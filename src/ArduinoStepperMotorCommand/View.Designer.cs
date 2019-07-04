namespace ArduinoStepperMotorAndLasersCommand
{
    partial class View
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnSend = new System.Windows.Forms.Button();
            this.nudNbStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMoveQuarter = new System.Windows.Forms.Button();
            this.btnMoveHalf = new System.Windows.Forms.Button();
            this.btnMoveFull = new System.Windows.Forms.Button();
            this.btnToggleLaserA = new System.Windows.Forms.Button();
            this.btnToggleLaserB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudNbStep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(100, 39);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // nudNbStep
            // 
            this.nudNbStep.Location = new System.Drawing.Point(100, 13);
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
            this.nudNbStep.Size = new System.Drawing.Size(75, 20);
            this.nudNbStep.TabIndex = 1;
            this.nudNbStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of step :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(192, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 3;
            // 
            // btnMoveQuarter
            // 
            this.btnMoveQuarter.Location = new System.Drawing.Point(100, 80);
            this.btnMoveQuarter.Name = "btnMoveQuarter";
            this.btnMoveQuarter.Size = new System.Drawing.Size(75, 23);
            this.btnMoveQuarter.TabIndex = 4;
            this.btnMoveQuarter.Text = "Quarter";
            this.btnMoveQuarter.UseVisualStyleBackColor = true;
            this.btnMoveQuarter.Click += new System.EventHandler(this.btnMoveQuarter_Click);
            // 
            // btnMoveHalf
            // 
            this.btnMoveHalf.Location = new System.Drawing.Point(100, 109);
            this.btnMoveHalf.Name = "btnMoveHalf";
            this.btnMoveHalf.Size = new System.Drawing.Size(75, 23);
            this.btnMoveHalf.TabIndex = 5;
            this.btnMoveHalf.Text = "Half";
            this.btnMoveHalf.UseVisualStyleBackColor = true;
            this.btnMoveHalf.Click += new System.EventHandler(this.btnMoveHalf_Click);
            // 
            // btnMoveFull
            // 
            this.btnMoveFull.Location = new System.Drawing.Point(100, 138);
            this.btnMoveFull.Name = "btnMoveFull";
            this.btnMoveFull.Size = new System.Drawing.Size(75, 23);
            this.btnMoveFull.TabIndex = 6;
            this.btnMoveFull.Text = "Full";
            this.btnMoveFull.UseVisualStyleBackColor = true;
            this.btnMoveFull.Click += new System.EventHandler(this.btnMoveFull_Click);
            // 
            // btnToggleLaserA
            // 
            this.btnToggleLaserA.Location = new System.Drawing.Point(12, 80);
            this.btnToggleLaserA.Name = "btnToggleLaserA";
            this.btnToggleLaserA.Size = new System.Drawing.Size(75, 23);
            this.btnToggleLaserA.TabIndex = 7;
            this.btnToggleLaserA.Text = "Laser A";
            this.btnToggleLaserA.UseVisualStyleBackColor = false;
            this.btnToggleLaserA.Click += new System.EventHandler(this.btnToggleLaserA_Click);
            // 
            // btnToggleLaserB
            // 
            this.btnToggleLaserB.Location = new System.Drawing.Point(12, 109);
            this.btnToggleLaserB.Name = "btnToggleLaserB";
            this.btnToggleLaserB.Size = new System.Drawing.Size(75, 23);
            this.btnToggleLaserB.TabIndex = 8;
            this.btnToggleLaserB.Text = "Laser B";
            this.btnToggleLaserB.UseVisualStyleBackColor = false;
            this.btnToggleLaserB.Click += new System.EventHandler(this.btnToggleLaserB_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 171);
            this.Controls.Add(this.btnToggleLaserB);
            this.Controls.Add(this.btnToggleLaserA);
            this.Controls.Add(this.btnMoveFull);
            this.Controls.Add(this.btnMoveHalf);
            this.Controls.Add(this.btnMoveQuarter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNbStep);
            this.Controls.Add(this.btnSend);
            this.Name = "View";
            this.Text = "Arduino Stepper Motor and Lasers Command";
            ((System.ComponentModel.ISupportInitialize)(this.nudNbStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.NumericUpDown nudNbStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMoveQuarter;
        private System.Windows.Forms.Button btnMoveHalf;
        private System.Windows.Forms.Button btnMoveFull;
        private System.Windows.Forms.Button btnToggleLaserA;
        private System.Windows.Forms.Button btnToggleLaserB;
    }
}

