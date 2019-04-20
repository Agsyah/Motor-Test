namespace motor_test
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.motorABtn = new System.Windows.Forms.Button();
            this.motorBBtn = new System.Windows.Forms.Button();
            this.motorDBtn = new System.Windows.Forms.Button();
            this.motorCBtn = new System.Windows.Forms.Button();
            this.motorStartBtn = new System.Windows.Forms.Button();
            this.motorStopBtn = new System.Windows.Forms.Button();
            this.throttleNum = new System.Windows.Forms.NumericUpDown();
            this.durationNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portsCom = new System.Windows.Forms.ComboBox();
            this.conBtn = new System.Windows.Forms.Button();
            this.baudCom = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.throttleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNum)).BeginInit();
            this.SuspendLayout();
            // 
            // motorABtn
            // 
            this.motorABtn.Location = new System.Drawing.Point(146, 67);
            this.motorABtn.Name = "motorABtn";
            this.motorABtn.Size = new System.Drawing.Size(75, 23);
            this.motorABtn.TabIndex = 0;
            this.motorABtn.Text = "Motor A";
            this.motorABtn.UseVisualStyleBackColor = true;
            this.motorABtn.Click += new System.EventHandler(this.motorABtn_Click);
            // 
            // motorBBtn
            // 
            this.motorBBtn.Location = new System.Drawing.Point(146, 96);
            this.motorBBtn.Name = "motorBBtn";
            this.motorBBtn.Size = new System.Drawing.Size(75, 23);
            this.motorBBtn.TabIndex = 1;
            this.motorBBtn.Text = "Motor B";
            this.motorBBtn.UseVisualStyleBackColor = true;
            this.motorBBtn.Click += new System.EventHandler(this.motorBBtn_Click);
            // 
            // motorDBtn
            // 
            this.motorDBtn.Location = new System.Drawing.Point(233, 96);
            this.motorDBtn.Name = "motorDBtn";
            this.motorDBtn.Size = new System.Drawing.Size(75, 23);
            this.motorDBtn.TabIndex = 2;
            this.motorDBtn.Text = "Motor D";
            this.motorDBtn.UseVisualStyleBackColor = true;
            this.motorDBtn.Click += new System.EventHandler(this.motorDBtn_Click);
            // 
            // motorCBtn
            // 
            this.motorCBtn.Location = new System.Drawing.Point(233, 67);
            this.motorCBtn.Name = "motorCBtn";
            this.motorCBtn.Size = new System.Drawing.Size(75, 23);
            this.motorCBtn.TabIndex = 3;
            this.motorCBtn.Text = "Motor C";
            this.motorCBtn.UseVisualStyleBackColor = true;
            this.motorCBtn.Click += new System.EventHandler(this.motorCBtn_Click);
            // 
            // motorStartBtn
            // 
            this.motorStartBtn.Location = new System.Drawing.Point(13, 125);
            this.motorStartBtn.Name = "motorStartBtn";
            this.motorStartBtn.Size = new System.Drawing.Size(295, 23);
            this.motorStartBtn.TabIndex = 4;
            this.motorStartBtn.Text = "START ALL";
            this.motorStartBtn.UseVisualStyleBackColor = true;
            this.motorStartBtn.Click += new System.EventHandler(this.motorStartBtn_Click);
            // 
            // motorStopBtn
            // 
            this.motorStopBtn.Location = new System.Drawing.Point(13, 154);
            this.motorStopBtn.Name = "motorStopBtn";
            this.motorStopBtn.Size = new System.Drawing.Size(295, 23);
            this.motorStopBtn.TabIndex = 5;
            this.motorStopBtn.Text = "STOP ALL";
            this.motorStopBtn.UseVisualStyleBackColor = true;
            this.motorStopBtn.Click += new System.EventHandler(this.motorStopBtn_Click);
            // 
            // throttleNum
            // 
            this.throttleNum.Location = new System.Drawing.Point(62, 70);
            this.throttleNum.Name = "throttleNum";
            this.throttleNum.Size = new System.Drawing.Size(78, 20);
            this.throttleNum.TabIndex = 6;
            // 
            // durationNum
            // 
            this.durationNum.Location = new System.Drawing.Point(62, 99);
            this.durationNum.Name = "durationNum";
            this.durationNum.Size = new System.Drawing.Size(78, 20);
            this.durationNum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Throttle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Duration:";
            // 
            // portsCom
            // 
            this.portsCom.FormattingEnabled = true;
            this.portsCom.Location = new System.Drawing.Point(12, 12);
            this.portsCom.Name = "portsCom";
            this.portsCom.Size = new System.Drawing.Size(121, 21);
            this.portsCom.TabIndex = 10;
            this.portsCom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.portsCom_MouseClick);
            // 
            // conBtn
            // 
            this.conBtn.Location = new System.Drawing.Point(220, 12);
            this.conBtn.Name = "conBtn";
            this.conBtn.Size = new System.Drawing.Size(88, 23);
            this.conBtn.TabIndex = 11;
            this.conBtn.Text = "CONNECT";
            this.conBtn.UseVisualStyleBackColor = true;
            this.conBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // baudCom
            // 
            this.baudCom.FormattingEnabled = true;
            this.baudCom.Items.AddRange(new object[] {
            "57600",
            "115200"});
            this.baudCom.Location = new System.Drawing.Point(139, 12);
            this.baudCom.Name = "baudCom";
            this.baudCom.Size = new System.Drawing.Size(75, 21);
            this.baudCom.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 10);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 187);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.baudCom);
            this.Controls.Add(this.conBtn);
            this.Controls.Add(this.portsCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.durationNum);
            this.Controls.Add(this.throttleNum);
            this.Controls.Add(this.motorStopBtn);
            this.Controls.Add(this.motorStartBtn);
            this.Controls.Add(this.motorCBtn);
            this.Controls.Add(this.motorDBtn);
            this.Controls.Add(this.motorBBtn);
            this.Controls.Add(this.motorABtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motor Control";
            ((System.ComponentModel.ISupportInitialize)(this.throttleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.durationNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button motorABtn;
        private System.Windows.Forms.Button motorBBtn;
        private System.Windows.Forms.Button motorDBtn;
        private System.Windows.Forms.Button motorCBtn;
        private System.Windows.Forms.Button motorStartBtn;
        private System.Windows.Forms.Button motorStopBtn;
        private System.Windows.Forms.NumericUpDown throttleNum;
        private System.Windows.Forms.NumericUpDown durationNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox portsCom;
        private System.Windows.Forms.Button conBtn;
        private System.Windows.Forms.ComboBox baudCom;
        private System.Windows.Forms.Panel panel1;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

