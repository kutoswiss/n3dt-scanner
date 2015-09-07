namespace LifeCamCapture
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
            this.picBoxCam = new System.Windows.Forms.PictureBox();
            this.captureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxCam
            // 
            this.picBoxCam.BackColor = System.Drawing.Color.White;
            this.picBoxCam.Location = new System.Drawing.Point(13, 13);
            this.picBoxCam.Name = "picBoxCam";
            this.picBoxCam.Size = new System.Drawing.Size(640, 380);
            this.picBoxCam.TabIndex = 0;
            this.picBoxCam.TabStop = false;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(13, 400);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 1;
            this.captureButton.Text = "button1";
            this.captureButton.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 464);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.picBoxCam);
            this.Name = "View";
            this.Text = "LifeCamCapture";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxCam;
        private System.Windows.Forms.Button captureButton;
    }
}

