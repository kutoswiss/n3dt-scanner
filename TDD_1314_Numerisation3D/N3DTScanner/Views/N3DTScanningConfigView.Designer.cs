namespace N3DTScanner
{
    partial class N3DTScanningConfigView
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudStepRes = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMeshFaces = new System.Windows.Forms.RadioButton();
            this.rbMeshLines = new System.Windows.Forms.RadioButton();
            this.rbMeshPoints = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStepRes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Step resolution:";
            // 
            // nudStepRes
            // 
            this.nudStepRes.Location = new System.Drawing.Point(98, 7);
            this.nudStepRes.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudStepRes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStepRes.Name = "nudStepRes";
            this.nudStepRes.Size = new System.Drawing.Size(108, 20);
            this.nudStepRes.TabIndex = 11;
            this.nudStepRes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStepRes.ValueChanged += new System.EventHandler(this.nudStepRes_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbMeshFaces);
            this.groupBox1.Controls.Add(this.rbMeshLines);
            this.groupBox1.Controls.Add(this.rbMeshPoints);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 128);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesh rendering";
            // 
            // rbMeshFaces
            // 
            this.rbMeshFaces.AutoSize = true;
            this.rbMeshFaces.Location = new System.Drawing.Point(23, 84);
            this.rbMeshFaces.Name = "rbMeshFaces";
            this.rbMeshFaces.Size = new System.Drawing.Size(54, 17);
            this.rbMeshFaces.TabIndex = 2;
            this.rbMeshFaces.TabStop = true;
            this.rbMeshFaces.Text = "Faces";
            this.rbMeshFaces.UseVisualStyleBackColor = true;
            this.rbMeshFaces.CheckedChanged += new System.EventHandler(this.MeshRenderingChanged);
            // 
            // rbMeshLines
            // 
            this.rbMeshLines.AutoSize = true;
            this.rbMeshLines.Location = new System.Drawing.Point(23, 61);
            this.rbMeshLines.Name = "rbMeshLines";
            this.rbMeshLines.Size = new System.Drawing.Size(50, 17);
            this.rbMeshLines.TabIndex = 1;
            this.rbMeshLines.TabStop = true;
            this.rbMeshLines.Text = "Lines";
            this.rbMeshLines.UseVisualStyleBackColor = true;
            this.rbMeshLines.CheckedChanged += new System.EventHandler(this.MeshRenderingChanged);
            // 
            // rbMeshPoints
            // 
            this.rbMeshPoints.AutoSize = true;
            this.rbMeshPoints.Location = new System.Drawing.Point(23, 38);
            this.rbMeshPoints.Name = "rbMeshPoints";
            this.rbMeshPoints.Size = new System.Drawing.Size(54, 17);
            this.rbMeshPoints.TabIndex = 0;
            this.rbMeshPoints.TabStop = true;
            this.rbMeshPoints.Text = "Points";
            this.rbMeshPoints.UseVisualStyleBackColor = true;
            this.rbMeshPoints.CheckedChanged += new System.EventHandler(this.MeshRenderingChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Set configurations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // N3DTScanningConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudStepRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "N3DTScanningConfigView";
            this.Text = "N3DT - Scanning configuration";
            ((System.ComponentModel.ISupportInitialize)(this.nudStepRes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStepRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMeshFaces;
        private System.Windows.Forms.RadioButton rbMeshLines;
        private System.Windows.Forms.RadioButton rbMeshPoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}