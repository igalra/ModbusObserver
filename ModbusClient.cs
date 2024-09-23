using NModbus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ModbusObserverTool
{
    public class ModbusClient
    {
        public string IpAddress { get; set; }
        public int Port { get; set;}
        private readonly int readTimeout;
        private readonly int writeTimeout;
        private readonly int retries;
        private TcpClient tcpClient;
        private IModbusMaster modbusMaster;

        const int MaxNumberOfRegistersToRead = 125;

        public event Action Disconnected;

        public ModbusClient(string ipAddress, int port, int readTimeout = 2000, int writeTimeout = 2000, int retries = 3)
        {
            this.IpAddress = ipAddress;
            this.Port = port;
            this.readTimeout = readTimeout;
            this.writeTimeout = writeTimeout;
            this.retries = retries;
        }

        public void Connect()
        {
            this.tcpClient = new TcpClient(IpAddress, Port);
            var factory = new ModbusFactory();
            this.modbusMaster = factory.CreateMaster(this.tcpClient);

            this.modbusMaster.Transport.ReadTimeout = readTimeout;
            this.modbusMaster.Transport.WriteTimeout = writeTimeout;
            //this.modbusMaster.Transport.Retries = retries;
        }

        public void Disconnect()
        {
            if (this.tcpClient != null)
            {
                this.tcpClient.Close();
                this.tcpClient.Dispose();
                this.tcpClient = null;
            }

            if (this.modbusMaster != null)
            {
                this.modbusMaster.Dispose();
                this.modbusMaster = null;
            }
        }

        public async Task<ICollection<ushort>> ReadHoldingRegistersSafeAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (numberOfPoints > MaxNumberOfRegistersToRead)
            {
                var readings = new List<ushort>();

                var registers = Enumerable.Range(startAddress, numberOfPoints).ToList();
                for (int i = 0; i < registers.Count; i += MaxNumberOfRegistersToRead)
                {
                    var chunk = registers.GetRange(i, Math.Min(MaxNumberOfRegistersToRead, registers.Count - i));
                    var start = (ushort)chunk[0];
                    var count = (ushort)chunk.Count;
                    var readChunk = await this.ReadHoldingRegistersAsync(slaveAddress, start, count);
                    readings.AddRange(readChunk);
                }

                return readings;
            }
            else
            {
                return await this.ReadHoldingRegistersAsync(slaveAddress, startAddress, numberOfPoints);
            }
        }

        private async Task<ushort[]> ReadHoldingRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            Exception exception = null;
            for (int i = 0; i < retries; i++)
            {
                if (this.tcpClient == null || !this.tcpClient.Connected || !this.tcpClient.Client.Connected)
                {
                    this.Disconnected?.Invoke();
                    throw new Exception("tcp client has disconnected");
                }
                try
                {
                    return await this.modbusMaster.ReadHoldingRegistersAsync(slaveAddress, startAddress, numberOfPoints);
                }
                catch (IOException ioException) when (ioException.InnerException is SocketException socketException)
                {
                    /*Logger.Error($"A socket exception has occured while reading holding registers. Slave address: {slaveAddress}, start address: {startAddress}, number of points: {numberOfPoints}. Socket exception error code: {socketException.ErrorCode}", socketException);*/

                    this.Disconnected?.Invoke();
                    throw;
                }
                catch (Exception e)
                {
                    bool reachedNumberofTries = i == retries - 1;
                    /*Logger.ConditionalLog(() => reachedNumberofTries, $"An exception has occured while reading holding registers. Try number: {i + 1}/{retries}, slave address: {slaveAddress}, start address: {startAddress}, number of points: {numberOfPoints}", e, LogLevel.Error, LogLevel.Warn);*/

                    if (reachedNumberofTries)
                        exception = e;
                    else
                        await Task.Delay(100);
                }
            }
            throw exception;
        }

        public async Task<ICollection<ushort>> ReadInputRegistersSafeAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            if (numberOfPoints > MaxNumberOfRegistersToRead)
            {
                var readings = new List<ushort>();

                var registers = Enumerable.Range(startAddress, numberOfPoints).ToList();
                for (int i = 0; i < registers.Count; i += MaxNumberOfRegistersToRead)
                {
                    var chunk = registers.GetRange(i, Math.Min(MaxNumberOfRegistersToRead, registers.Count - i));
                    var start = (ushort)chunk[0];
                    var count = (ushort)chunk.Count;
                    var readChunk = await this.ReadInputRegistersAsync(slaveAddress, start, count);
                    readings.AddRange(readChunk);
                }

                return readings;
            }
            else
            {
                return await this.ReadInputRegistersAsync(slaveAddress, startAddress, numberOfPoints);
            }
        }

        private async Task<ushort[]> ReadInputRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints)
        {
            Exception exception = null;
            for (int i = 0; i < retries; i++)
            {
                if (this.tcpClient == null || !this.tcpClient.Connected || !this.tcpClient.Client.Connected)
                {
                    this.Disconnected?.Invoke();
                    throw new Exception("tcp client has disconnected");
                }
                try
                {
                    return await this.modbusMaster.ReadInputRegistersAsync(slaveAddress, startAddress, numberOfPoints);
                }
                catch (IOException ioException) when (ioException.InnerException is SocketException socketException)
                {
                    /*Logger.Error($"A socket exception has occured while reading holding registers. Slave address: {slaveAddress}, start address: {startAddress}, number of points: {numberOfPoints}. Socket exception error code: {socketException.ErrorCode}", socketException);*/

                    this.Disconnected?.Invoke();
                    throw;
                }
                catch (Exception e)
                {
                    bool reachedNumberofTries = i == retries - 1;
                    /*Logger.ConditionalLog(() => reachedNumberofTries, $"An exception has occured while reading holding registers. Try number: {i + 1}/{retries}, slave address: {slaveAddress}, start address: {startAddress}, number of points: {numberOfPoints}", e, LogLevel.Error, LogLevel.Warn);*/

                    if (reachedNumberofTries)
                        exception = e;
                    else
                        await Task.Delay(100);
                }
            }
            throw exception;
        }

        public async Task WriteSingleRegisterAsync(byte slaveAddress, ushort registerAddress, ushort value)
        {
            Exception exception = null;
            for (int i = 0; i < retries; i++)
            {
                if (this.tcpClient == null || !this.tcpClient.Connected || !this.tcpClient.Client.Connected)
                {
                    this.Disconnected?.Invoke();
                    throw new Exception("tcp client has disconnected");
                }
                try
                {
                    await this.modbusMaster.WriteSingleRegisterAsync(slaveAddress, registerAddress, value);
                    return;
                }
                catch (IOException ioException) when (ioException.InnerException is SocketException socketException)
                {
                    /*Logger.Error($"A socket exception has occured while writing holding register. Slave address: {slaveAddress}, register address: {registerAddress}, value: {value}. Socket exception error code: {socketException.ErrorCode}", socketException);*/

                    this.Disconnected?.Invoke();
                    throw;
                }
                catch (Exception e)
                {
                    bool reachedNumberofTries = i == retries - 1;
                    /*Logger.ConditionalLog(() => reachedNumberofTries, $"An exception has occured while writing holding register. Try number: {i + 1}/{retries}, slave address: {slaveAddress}, register address: {registerAddress}, value: {value}", e, LogLevel.Error, LogLevel.Warn);*/

                    if (reachedNumberofTries)
                        exception = e;
                    else
                        await Task.Delay(100);
                }
            }
            throw exception;
        }
    }
}
