namespace ModbusObserverTool
{
    partial class MainControlPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelRunning = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxReg2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelReg2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxWrite2 = new System.Windows.Forms.TextBox();
            this.buttonWrite2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxReg1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelReg1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWrite1 = new System.Windows.Forms.TextBox();
            this.buttonWrite1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.ForeColor = System.Drawing.Color.Gray;
            this.buttonStop.Location = new System.Drawing.Point(84, 8);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(70, 30);
            this.buttonStop.TabIndex = 25;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.EnabledChanged += new System.EventHandler(this.buttonStartDebug_EnabledChanged);
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(8, 8);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(70, 30);
            this.buttonStart.TabIndex = 24;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.EnabledChanged += new System.EventHandler(this.buttonStartDebug_EnabledChanged);
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelRunning
            // 
            this.labelRunning.BackColor = System.Drawing.Color.Transparent;
            this.labelRunning.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRunning.ForeColor = System.Drawing.Color.Red;
            this.labelRunning.Location = new System.Drawing.Point(160, 8);
            this.labelRunning.Margin = new System.Windows.Forms.Padding(3);
            this.labelRunning.Name = "labelRunning";
            this.labelRunning.Size = new System.Drawing.Size(435, 30);
            this.labelRunning.TabIndex = 36;
            this.labelRunning.Text = "Not Connected";
            this.labelRunning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.buttonStart);
            this.flowLayoutPanel1.Controls.Add(this.buttonStop);
            this.flowLayoutPanel1.Controls.Add(this.labelRunning);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 50);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelMessage, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 510);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // labelMessage
            // 
            this.labelMessage.BackColor = System.Drawing.Color.Transparent;
            this.labelMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMessage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.LightSalmon;
            this.labelMessage.Location = new System.Drawing.Point(3, 483);
            this.labelMessage.Margin = new System.Windows.Forms.Padding(3);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(794, 24);
            this.labelMessage.TabIndex = 37;
            this.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Controls.Add(this.label12);
            this.flowLayoutPanel4.Controls.Add(this.textBoxReg2);
            this.flowLayoutPanel4.Controls.Add(this.label13);
            this.flowLayoutPanel4.Controls.Add(this.labelReg2);
            this.flowLayoutPanel4.Controls.Add(this.label15);
            this.flowLayoutPanel4.Controls.Add(this.textBoxWrite2);
            this.flowLayoutPanel4.Controls.Add(this.buttonWrite2);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 440);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel4.Size = new System.Drawing.Size(800, 40);
            this.flowLayoutPanel4.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 30);
            this.label12.TabIndex = 42;
            this.label12.Text = "Register ID:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReg2
            // 
            this.textBoxReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxReg2.Location = new System.Drawing.Point(105, 8);
            this.textBoxReg2.Name = "textBoxReg2";
            this.textBoxReg2.Size = new System.Drawing.Size(46, 22);
            this.textBoxReg2.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(157, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 30);
            this.label13.TabIndex = 47;
            this.label13.Text = "Value:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReg2
            // 
            this.labelReg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReg2.BackColor = System.Drawing.Color.Transparent;
            this.labelReg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelReg2.ForeColor = System.Drawing.Color.Lime;
            this.labelReg2.Location = new System.Drawing.Point(217, 6);
            this.labelReg2.Name = "labelReg2";
            this.labelReg2.Size = new System.Drawing.Size(58, 30);
            this.labelReg2.TabIndex = 43;
            this.labelReg2.Text = "-";
            this.labelReg2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(281, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 30);
            this.label15.TabIndex = 45;
            this.label15.Text = "Write Value:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWrite2
            // 
            this.textBoxWrite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxWrite2.Location = new System.Drawing.Point(378, 8);
            this.textBoxWrite2.Name = "textBoxWrite2";
            this.textBoxWrite2.Size = new System.Drawing.Size(46, 22);
            this.textBoxWrite2.TabIndex = 46;
            // 
            // buttonWrite2
            // 
            this.buttonWrite2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWrite2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWrite2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite2.ForeColor = System.Drawing.Color.White;
            this.buttonWrite2.Location = new System.Drawing.Point(430, 8);
            this.buttonWrite2.Name = "buttonWrite2";
            this.buttonWrite2.Size = new System.Drawing.Size(51, 27);
            this.buttonWrite2.TabIndex = 23;
            this.buttonWrite2.Text = "Write";
            this.buttonWrite2.UseVisualStyleBackColor = true;
            this.buttonWrite2.Click += new System.EventHandler(this.buttonWrite2_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.textBoxReg1);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.labelReg1);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.textBoxWrite1);
            this.flowLayoutPanel3.Controls.Add(this.buttonWrite1);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 400);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(800, 40);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 30);
            this.label3.TabIndex = 42;
            this.label3.Text = "Register ID:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReg1
            // 
            this.textBoxReg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxReg1.Location = new System.Drawing.Point(105, 8);
            this.textBoxReg1.Name = "textBoxReg1";
            this.textBoxReg1.Size = new System.Drawing.Size(46, 22);
            this.textBoxReg1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(157, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 30);
            this.label6.TabIndex = 47;
            this.label6.Text = "Value:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReg1
            // 
            this.labelReg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReg1.BackColor = System.Drawing.Color.Transparent;
            this.labelReg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelReg1.ForeColor = System.Drawing.Color.Lime;
            this.labelReg1.Location = new System.Drawing.Point(217, 6);
            this.labelReg1.Name = "labelReg1";
            this.labelReg1.Size = new System.Drawing.Size(58, 30);
            this.labelReg1.TabIndex = 43;
            this.labelReg1.Text = "-";
            this.labelReg1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(281, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 30);
            this.label4.TabIndex = 45;
            this.label4.Text = "Write Value:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWrite1
            // 
            this.textBoxWrite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxWrite1.Location = new System.Drawing.Point(378, 8);
            this.textBoxWrite1.Name = "textBoxWrite1";
            this.textBoxWrite1.Size = new System.Drawing.Size(46, 22);
            this.textBoxWrite1.TabIndex = 46;
            // 
            // buttonWrite1
            // 
            this.buttonWrite1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonWrite1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWrite1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWrite1.ForeColor = System.Drawing.Color.White;
            this.buttonWrite1.Location = new System.Drawing.Point(430, 8);
            this.buttonWrite1.Name = "buttonWrite1";
            this.buttonWrite1.Size = new System.Drawing.Size(51, 27);
            this.buttonWrite1.TabIndex = 23;
            this.buttonWrite1.Text = "Write";
            this.buttonWrite1.UseVisualStyleBackColor = true;
            this.buttonWrite1.Click += new System.EventHandler(this.buttonWrite1_Click);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(794, 344);
            this.flowLayoutPanelMain.TabIndex = 21;
            // 
            // MainControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainControlPanel";
            this.Size = new System.Drawing.Size(800, 510);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelRunning;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxReg2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelReg2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxWrite2;
        private System.Windows.Forms.Button buttonWrite2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxReg1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelReg1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWrite1;
        private System.Windows.Forms.Button buttonWrite1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.Label labelMessage;
    }
}
