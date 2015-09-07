namespace N3DTScanner
{
    partial class N3DTArduinoCommandView
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnToggleLaserB = new System.Windows.Forms.Button();
            this.btnToggleLaserA = new System.Windows.Forms.Button();
            this.btnMoveFull = new System.Windows.Forms.Button();
            this.btnMoveHalf = new System.Windows.Forms.Button();
            this.btnMoveQuarter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNbStep = new System.Windows.Forms.NumericUpDown();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRightLaserOn = new System.Windows.Forms.Button();
            this.btnRightLaserOff = new System.Windows.Forms.Button();
            this.btnLeftLaserOn = new System.Windows.Forms.Button();
            this.btnLeftLaserOff = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSetOptions = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbPortCom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbStep)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToggleLaserB
            // 
            this.btnToggleLaserB.Location = new System.Drawing.Point(137, 81);
            this.btnToggleLaserB.Name = "btnToggleLaserB";
            this.btnToggleLaserB.Size = new System.Drawing.Size(109, 25);
            this.btnToggleLaserB.TabIndex = 17;
            this.btnToggleLaserB.Text = "Right Laser Toggle";
            this.btnToggleLaserB.UseVisualStyleBackColor = false;
            this.btnToggleLaserB.Click += new System.EventHandler(this.btnToggleLaserB_Click);
            // 
            // btnToggleLaserA
            // 
            this.btnToggleLaserA.Location = new System.Drawing.Point(12, 81);
            this.btnToggleLaserA.Name = "btnToggleLaserA";
            this.btnToggleLaserA.Size = new System.Drawing.Size(109, 25);
            this.btnToggleLaserA.TabIndex = 16;
            this.btnToggleLaserA.Text = "Left Laser Toggle";
            this.btnToggleLaserA.UseVisualStyleBackColor = false;
            this.btnToggleLaserA.Click += new System.EventHandler(this.btnToggleLaserA_Click);
            // 
            // btnMoveFull
            // 
            this.btnMoveFull.Location = new System.Drawing.Point(171, 81);
            this.btnMoveFull.Name = "btnMoveFull";
            this.btnMoveFull.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFull.TabIndex = 15;
            this.btnMoveFull.Text = "Full";
            this.btnMoveFull.UseVisualStyleBackColor = true;
            this.btnMoveFull.Click += new System.EventHandler(this.btnMoveFull_Click);
            // 
            // btnMoveHalf
            // 
            this.btnMoveHalf.Location = new System.Drawing.Point(90, 81);
            this.btnMoveHalf.Name = "btnMoveHalf";
            this.btnMoveHalf.Size = new System.Drawing.Size(75, 23);
            this.btnMoveHalf.TabIndex = 14;
            this.btnMoveHalf.Text = "Half";
            this.btnMoveHalf.UseVisualStyleBackColor = true;
            this.btnMoveHalf.Click += new System.EventHandler(this.btnMoveHalf_Click);
            // 
            // btnMoveQuarter
            // 
            this.btnMoveQuarter.Location = new System.Drawing.Point(9, 81);
            this.btnMoveQuarter.Name = "btnMoveQuarter";
            this.btnMoveQuarter.Size = new System.Drawing.Size(75, 23);
            this.btnMoveQuarter.TabIndex = 13;
            this.btnMoveQuarter.Text = "Quarter";
            this.btnMoveQuarter.UseVisualStyleBackColor = true;
            this.btnMoveQuarter.Click += new System.EventHandler(this.btnMoveQuarter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of step :";
            // 
            // nudNbStep
            // 
            this.nudNbStep.Location = new System.Drawing.Point(97, 23);
            this.nudNbStep.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudNbStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNbStep.Name = "nudNbStep";
            this.nudNbStep.Size = new System.Drawing.Size(149, 20);
            this.nudNbStep.TabIndex = 10;
            this.nudNbStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(9, 52);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(237, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.nudNbStep);
            this.groupBox1.Controls.Add(this.btnMoveFull);
            this.groupBox1.Controls.Add(this.btnMoveQuarter);
            this.groupBox1.Controls.Add(this.btnMoveHalf);
            this.groupBox1.Location = new System.Drawing.Point(12, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 116);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor command";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRightLaserOn);
            this.groupBox2.Controls.Add(this.btnRightLaserOff);
            this.groupBox2.Controls.Add(this.btnLeftLaserOn);
            this.groupBox2.Controls.Add(this.btnLeftLaserOff);
            this.groupBox2.Controls.Add(this.btnToggleLaserA);
            this.groupBox2.Controls.Add(this.btnToggleLaserB);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 118);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lasers manual command";
            // 
            // btnRightLaserOn
            // 
            this.btnRightLaserOn.Location = new System.Drawing.Point(137, 19);
            this.btnRightLaserOn.Name = "btnRightLaserOn";
            this.btnRightLaserOn.Size = new System.Drawing.Size(109, 25);
            this.btnRightLaserOn.TabIndex = 21;
            this.btnRightLaserOn.Text = "Right Laser ON";
            this.btnRightLaserOn.UseVisualStyleBackColor = false;
            this.btnRightLaserOn.Click += new System.EventHandler(this.btnRightLaserOn_Click);
            // 
            // btnRightLaserOff
            // 
            this.btnRightLaserOff.Location = new System.Drawing.Point(137, 50);
            this.btnRightLaserOff.Name = "btnRightLaserOff";
            this.btnRightLaserOff.Size = new System.Drawing.Size(109, 25);
            this.btnRightLaserOff.TabIndex = 20;
            this.btnRightLaserOff.Text = "Right Laser OFF";
            this.btnRightLaserOff.UseVisualStyleBackColor = false;
            this.btnRightLaserOff.Click += new System.EventHandler(this.btnRightLaserOff_Click);
            // 
            // btnLeftLaserOn
            // 
            this.btnLeftLaserOn.Location = new System.Drawing.Point(12, 19);
            this.btnLeftLaserOn.Name = "btnLeftLaserOn";
            this.btnLeftLaserOn.Size = new System.Drawing.Size(109, 25);
            this.btnLeftLaserOn.TabIndex = 19;
            this.btnLeftLaserOn.Text = "Left Laser ON";
            this.btnLeftLaserOn.UseVisualStyleBackColor = false;
            this.btnLeftLaserOn.Click += new System.EventHandler(this.btnLeftLaserOn_Click);
            // 
            // btnLeftLaserOff
            // 
            this.btnLeftLaserOff.Location = new System.Drawing.Point(12, 50);
            this.btnLeftLaserOff.Name = "btnLeftLaserOff";
            this.btnLeftLaserOff.Size = new System.Drawing.Size(109, 25);
            this.btnLeftLaserOff.TabIndex = 18;
            this.btnLeftLaserOff.Text = "Left Laser OFF";
            this.btnLeftLaserOff.UseVisualStyleBackColor = false;
            this.btnLeftLaserOff.Click += new System.EventHandler(this.btnLeftLaserOff_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSetOptions);
            this.groupBox3.Controls.Add(this.cbBaudrate);
            this.groupBox3.Controls.Add(this.cbPortCom);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 110);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arduino configurations";
            // 
            // btnSetOptions
            // 
            this.btnSetOptions.Location = new System.Drawing.Point(96, 75);
            this.btnSetOptions.Name = "btnSetOptions";
            this.btnSetOptions.Size = new System.Drawing.Size(121, 23);
            this.btnSetOptions.TabIndex = 4;
            this.btnSetOptions.Text = "Set configurations";
            this.btnSetOptions.UseVisualStyleBackColor = true;
            this.btnSetOptions.Click += new System.EventHandler(this.btnSetOptions_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.Enabled = false;
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.cbBaudrate.Location = new System.Drawing.Point(96, 48);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudrate.TabIndex = 3;
            // 
            // cbPortCom
            // 
            this.cbPortCom.FormattingEnabled = true;
            this.cbPortCom.Location = new System.Drawing.Point(96, 21);
            this.cbPortCom.Name = "cbPortCom";
            this.cbPortCom.Size = new System.Drawing.Size(121, 21);
            this.cbPortCom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baudrate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port COM:";
            // 
            // N3DTArduinoCommandView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "N3DTArduinoCommandView";
            this.Text = "Arduino configurations";
            ((System.ComponentModel.ISupportInitialize)(this.nudNbStep)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnToggleLaserB;
        private System.Windows.Forms.Button btnToggleLaserA;
        private System.Windows.Forms.Button btnMoveFull;
        private System.Windows.Forms.Button btnMoveHalf;
        private System.Windows.Forms.Button btnMoveQuarter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNbStep;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSetOptions;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbPortCom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRightLaserOn;
        private System.Windows.Forms.Button btnRightLaserOff;
        private System.Windows.Forms.Button btnLeftLaserOn;
        private System.Windows.Forms.Button btnLeftLaserOff;
    }
}