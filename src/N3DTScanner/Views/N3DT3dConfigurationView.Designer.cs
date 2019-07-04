namespace N3DTScanner
{
    partial class N3DT3dConfigurationView
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbRotationDisabled = new System.Windows.Forms.RadioButton();
            this.nudRotateSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCounterClockWise = new System.Windows.Forms.RadioButton();
            this.rbClockWise = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbRotationDisabled);
            this.groupBox2.Controls.Add(this.nudRotateSpeed);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rbCounterClockWise);
            this.groupBox2.Controls.Add(this.rbClockWise);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotation";
            // 
            // rbRotationDisabled
            // 
            this.rbRotationDisabled.AutoSize = true;
            this.rbRotationDisabled.Location = new System.Drawing.Point(203, 47);
            this.rbRotationDisabled.Name = "rbRotationDisabled";
            this.rbRotationDisabled.Size = new System.Drawing.Size(60, 17);
            this.rbRotationDisabled.TabIndex = 4;
            this.rbRotationDisabled.TabStop = true;
            this.rbRotationDisabled.Text = "Disable";
            this.rbRotationDisabled.UseVisualStyleBackColor = true;
            // 
            // nudRotateSpeed
            // 
            this.nudRotateSpeed.Location = new System.Drawing.Point(53, 21);
            this.nudRotateSpeed.Name = "nudRotateSpeed";
            this.nudRotateSpeed.Size = new System.Drawing.Size(80, 20);
            this.nudRotateSpeed.TabIndex = 3;
            this.nudRotateSpeed.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed:";
            // 
            // rbCounterClockWise
            // 
            this.rbCounterClockWise.AutoSize = true;
            this.rbCounterClockWise.Location = new System.Drawing.Point(88, 48);
            this.rbCounterClockWise.Name = "rbCounterClockWise";
            this.rbCounterClockWise.Size = new System.Drawing.Size(109, 17);
            this.rbCounterClockWise.TabIndex = 1;
            this.rbCounterClockWise.TabStop = true;
            this.rbCounterClockWise.Text = "Counterclockwise";
            this.rbCounterClockWise.UseVisualStyleBackColor = true;
            this.rbCounterClockWise.CheckedChanged += new System.EventHandler(this.rbRotationChanged);
            // 
            // rbClockWise
            // 
            this.rbClockWise.AutoSize = true;
            this.rbClockWise.Location = new System.Drawing.Point(9, 47);
            this.rbClockWise.Name = "rbClockWise";
            this.rbClockWise.Size = new System.Drawing.Size(73, 17);
            this.rbClockWise.TabIndex = 0;
            this.rbClockWise.TabStop = true;
            this.rbClockWise.Text = "Clockwise";
            this.rbClockWise.UseVisualStyleBackColor = true;
            this.rbClockWise.CheckedChanged += new System.EventHandler(this.rbRotationChanged);
            // 
            // N3DT3dConfigurationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 90);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "N3DT3dConfigurationView";
            this.Text = "N3DT - 3d configuration";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudRotateSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCounterClockWise;
        private System.Windows.Forms.RadioButton rbClockWise;
        private System.Windows.Forms.RadioButton rbRotationDisabled;
    }
}