namespace N3DTScanner
{
    partial class N3DTView
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBarScan = new System.Windows.Forms.ToolStripProgressBar();
            this.lblScanPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator0 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFilterSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblArduinoComPort = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStepResolutions = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNbVertices = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSeparator4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNbTriangles = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.n3DTFormatn3dtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBJFormatobjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dViewConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arduinoManualCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanningConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPictoCam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSpeedTimerRot = new System.Windows.Forms.NumericUpDown();
            this.rbRotationDisable = new System.Windows.Forms.RadioButton();
            this.rbRotationCounterClockwise = new System.Windows.Forms.RadioButton();
            this.rbRotationClockwise = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMeshLines = new System.Windows.Forms.Button();
            this.btnLight = new System.Windows.Forms.Button();
            this.btnMeshFacets = new System.Windows.Forms.Button();
            this.btnMeshLinesTriangles = new System.Windows.Forms.Button();
            this.btnMeshPoints = new System.Windows.Forms.Button();
            this.btnPictoSave = new System.Windows.Forms.Button();
            this.btnPictoImport = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedTimerRot)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarScan,
            this.lblScanPercent,
            this.lblSeparator0,
            this.lblFilterSelected,
            this.lblSeparator1,
            this.lblArduinoComPort,
            this.lblSeparator2,
            this.lblStepResolutions,
            this.lblSeparator3,
            this.lblNbVertices,
            this.lblSeparator4,
            this.lblNbTriangles});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1193, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBarScan
            // 
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(100, 16);
            // 
            // lblScanPercent
            // 
            this.lblScanPercent.Name = "lblScanPercent";
            this.lblScanPercent.Size = new System.Drawing.Size(85, 17);
            this.lblScanPercent.Text = "lblScanPercent";
            // 
            // lblSeparator0
            // 
            this.lblSeparator0.Name = "lblSeparator0";
            this.lblSeparator0.Size = new System.Drawing.Size(10, 17);
            this.lblSeparator0.Text = "|";
            // 
            // lblFilterSelected
            // 
            this.lblFilterSelected.Name = "lblFilterSelected";
            this.lblFilterSelected.Size = new System.Drawing.Size(90, 17);
            this.lblFilterSelected.Text = "lblFilterSelected";
            // 
            // lblSeparator1
            // 
            this.lblSeparator1.Name = "lblSeparator1";
            this.lblSeparator1.Size = new System.Drawing.Size(10, 17);
            this.lblSeparator1.Text = "|";
            // 
            // lblArduinoComPort
            // 
            this.lblArduinoComPort.Name = "lblArduinoComPort";
            this.lblArduinoComPort.Size = new System.Drawing.Size(111, 17);
            this.lblArduinoComPort.Text = "lblArduinoComPort";
            // 
            // lblSeparator2
            // 
            this.lblSeparator2.Name = "lblSeparator2";
            this.lblSeparator2.Size = new System.Drawing.Size(10, 17);
            this.lblSeparator2.Text = "|";
            // 
            // lblStepResolutions
            // 
            this.lblStepResolutions.Name = "lblStepResolutions";
            this.lblStepResolutions.Size = new System.Drawing.Size(104, 17);
            this.lblStepResolutions.Text = "lblStepResolutions";
            // 
            // lblSeparator3
            // 
            this.lblSeparator3.Name = "lblSeparator3";
            this.lblSeparator3.Size = new System.Drawing.Size(10, 17);
            this.lblSeparator3.Text = "|";
            // 
            // lblNbVertices
            // 
            this.lblNbVertices.Name = "lblNbVertices";
            this.lblNbVertices.Size = new System.Drawing.Size(77, 17);
            this.lblNbVertices.Text = "lblNbVertices";
            // 
            // lblSeparator4
            // 
            this.lblSeparator4.Name = "lblSeparator4";
            this.lblSeparator4.Size = new System.Drawing.Size(10, 17);
            this.lblSeparator4.Text = "|";
            // 
            // lblNbTriangles
            // 
            this.lblNbTriangles.Name = "lblNbTriangles";
            this.lblNbTriangles.Size = new System.Drawing.Size(84, 17);
            this.lblNbTriangles.Text = "lblNbTriangles";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.n3DTFormatn3dtToolStripMenuItem,
            this.oBJFormatobjToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportToolStripMenuItem.Text = "Export...";
            // 
            // n3DTFormatn3dtToolStripMenuItem
            // 
            this.n3DTFormatn3dtToolStripMenuItem.Name = "n3DTFormatn3dtToolStripMenuItem";
            this.n3DTFormatn3dtToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.n3DTFormatn3dtToolStripMenuItem.Text = "N3DT format (.n3dt)";
            this.n3DTFormatn3dtToolStripMenuItem.Click += new System.EventHandler(this.n3DTFormatn3dtToolStripMenuItem_Click);
            // 
            // oBJFormatobjToolStripMenuItem
            // 
            this.oBJFormatobjToolStripMenuItem.Name = "oBJFormatobjToolStripMenuItem";
            this.oBJFormatobjToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.oBJFormatobjToolStripMenuItem.Text = "OBJ format (.obj)";
            this.oBJFormatobjToolStripMenuItem.Click += new System.EventHandler(this.oBJFormatobjToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dViewConfigurationToolStripMenuItem,
            this.cameraConfigurationToolStripMenuItem,
            this.arduinoManualCommandToolStripMenuItem,
            this.scanningConfigurationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.editToolStripMenuItem.Text = "Tools";
            // 
            // dViewConfigurationToolStripMenuItem
            // 
            this.dViewConfigurationToolStripMenuItem.Name = "dViewConfigurationToolStripMenuItem";
            this.dViewConfigurationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.dViewConfigurationToolStripMenuItem.Text = "3D View configuration";
            this.dViewConfigurationToolStripMenuItem.Click += new System.EventHandler(this.dViewConfigurationToolStripMenuItem_Click);
            // 
            // cameraConfigurationToolStripMenuItem
            // 
            this.cameraConfigurationToolStripMenuItem.Name = "cameraConfigurationToolStripMenuItem";
            this.cameraConfigurationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cameraConfigurationToolStripMenuItem.Text = "Camera configuration";
            this.cameraConfigurationToolStripMenuItem.Click += new System.EventHandler(this.cameraConfigurationToolStripMenuItem_Click);
            // 
            // arduinoManualCommandToolStripMenuItem
            // 
            this.arduinoManualCommandToolStripMenuItem.Name = "arduinoManualCommandToolStripMenuItem";
            this.arduinoManualCommandToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.arduinoManualCommandToolStripMenuItem.Text = "Arduino configuration";
            this.arduinoManualCommandToolStripMenuItem.Click += new System.EventHandler(this.arduinoManualCommandToolStripMenuItem_Click);
            // 
            // scanningConfigurationToolStripMenuItem
            // 
            this.scanningConfigurationToolStripMenuItem.Name = "scanningConfigurationToolStripMenuItem";
            this.scanningConfigurationToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.scanningConfigurationToolStripMenuItem.Text = "Scanning configuration";
            this.scanningConfigurationToolStripMenuItem.Click += new System.EventHandler(this.scanningConfigurationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnStartScan
            // 
            this.btnStartScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartScan.BackColor = System.Drawing.Color.Transparent;
            this.btnStartScan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStartScan.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScan.Location = new System.Drawing.Point(801, 559);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(380, 32);
            this.btnStartScan.TabIndex = 7;
            this.btnStartScan.Text = "Start scanning";
            this.btnStartScan.UseVisualStyleBackColor = false;
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnPictoCam
            // 
            this.btnPictoCam.BackgroundImage = global::N3DTScanner.Properties.Resources.n3dt_picto_cam1;
            this.btnPictoCam.Location = new System.Drawing.Point(95, 27);
            this.btnPictoCam.Name = "btnPictoCam";
            this.btnPictoCam.Size = new System.Drawing.Size(30, 30);
            this.btnPictoCam.TabIndex = 11;
            this.btnPictoCam.UseVisualStyleBackColor = true;
            this.btnPictoCam.Click += new System.EventHandler(this.btnPictoCam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSpeedTimerRot);
            this.groupBox1.Controls.Add(this.rbRotationDisable);
            this.groupBox1.Controls.Add(this.rbRotationCounterClockwise);
            this.groupBox1.Controls.Add(this.rbRotationClockwise);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 118);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3DView";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ms/interval";
            // 
            // nudSpeedTimerRot
            // 
            this.nudSpeedTimerRot.Location = new System.Drawing.Point(11, 82);
            this.nudSpeedTimerRot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeedTimerRot.Name = "nudSpeedTimerRot";
            this.nudSpeedTimerRot.Size = new System.Drawing.Size(47, 20);
            this.nudSpeedTimerRot.TabIndex = 3;
            this.nudSpeedTimerRot.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSpeedTimerRot.ValueChanged += new System.EventHandler(this.nudSpeedTimerRot_ValueChanged);
            // 
            // rbRotationDisable
            // 
            this.rbRotationDisable.AutoSize = true;
            this.rbRotationDisable.Checked = true;
            this.rbRotationDisable.Location = new System.Drawing.Point(11, 59);
            this.rbRotationDisable.Name = "rbRotationDisable";
            this.rbRotationDisable.Size = new System.Drawing.Size(60, 17);
            this.rbRotationDisable.TabIndex = 2;
            this.rbRotationDisable.TabStop = true;
            this.rbRotationDisable.Text = "Disable";
            this.rbRotationDisable.UseVisualStyleBackColor = true;
            this.rbRotationDisable.CheckedChanged += new System.EventHandler(this.RotationGLControlChanged);
            // 
            // rbRotationCounterClockwise
            // 
            this.rbRotationCounterClockwise.AutoSize = true;
            this.rbRotationCounterClockwise.Location = new System.Drawing.Point(11, 39);
            this.rbRotationCounterClockwise.Name = "rbRotationCounterClockwise";
            this.rbRotationCounterClockwise.Size = new System.Drawing.Size(109, 17);
            this.rbRotationCounterClockwise.TabIndex = 1;
            this.rbRotationCounterClockwise.Text = "Counterclockwise";
            this.rbRotationCounterClockwise.UseVisualStyleBackColor = true;
            this.rbRotationCounterClockwise.CheckedChanged += new System.EventHandler(this.RotationGLControlChanged);
            // 
            // rbRotationClockwise
            // 
            this.rbRotationClockwise.AutoSize = true;
            this.rbRotationClockwise.Location = new System.Drawing.Point(11, 19);
            this.rbRotationClockwise.Name = "rbRotationClockwise";
            this.rbRotationClockwise.Size = new System.Drawing.Size(73, 17);
            this.rbRotationClockwise.TabIndex = 0;
            this.rbRotationClockwise.Text = "Clockwise";
            this.rbRotationClockwise.UseVisualStyleBackColor = true;
            this.rbRotationClockwise.CheckedChanged += new System.EventHandler(this.RotationGLControlChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMeshLines);
            this.groupBox2.Controls.Add(this.btnLight);
            this.groupBox2.Controls.Add(this.btnMeshFacets);
            this.groupBox2.Controls.Add(this.btnMeshLinesTriangles);
            this.groupBox2.Controls.Add(this.btnMeshPoints);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 145);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mesh renderer";
            // 
            // btnMeshLines
            // 
            this.btnMeshLines.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_lines;
            this.btnMeshLines.Location = new System.Drawing.Point(11, 67);
            this.btnMeshLines.Name = "btnMeshLines";
            this.btnMeshLines.Size = new System.Drawing.Size(30, 30);
            this.btnMeshLines.TabIndex = 19;
            this.btnMeshLines.UseVisualStyleBackColor = true;
            this.btnMeshLines.Click += new System.EventHandler(this.btnMeshLines_Click_1);
            // 
            // btnLight
            // 
            this.btnLight.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_light_off;
            this.btnLight.Location = new System.Drawing.Point(11, 103);
            this.btnLight.Name = "btnLight";
            this.btnLight.Size = new System.Drawing.Size(102, 30);
            this.btnLight.TabIndex = 18;
            this.btnLight.UseVisualStyleBackColor = true;
            this.btnLight.Click += new System.EventHandler(this.btnLight_Click);
            // 
            // btnMeshFacets
            // 
            this.btnMeshFacets.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_full_triangles;
            this.btnMeshFacets.Location = new System.Drawing.Point(83, 31);
            this.btnMeshFacets.Name = "btnMeshFacets";
            this.btnMeshFacets.Size = new System.Drawing.Size(30, 30);
            this.btnMeshFacets.TabIndex = 16;
            this.btnMeshFacets.UseVisualStyleBackColor = true;
            this.btnMeshFacets.Click += new System.EventHandler(this.btnMeshFacets_Click);
            // 
            // btnMeshLinesTriangles
            // 
            this.btnMeshLinesTriangles.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_lines_triangles;
            this.btnMeshLinesTriangles.Location = new System.Drawing.Point(47, 31);
            this.btnMeshLinesTriangles.Name = "btnMeshLinesTriangles";
            this.btnMeshLinesTriangles.Size = new System.Drawing.Size(30, 30);
            this.btnMeshLinesTriangles.TabIndex = 15;
            this.btnMeshLinesTriangles.UseVisualStyleBackColor = true;
            this.btnMeshLinesTriangles.Click += new System.EventHandler(this.btnMeshLines_Click);
            // 
            // btnMeshPoints
            // 
            this.btnMeshPoints.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_points;
            this.btnMeshPoints.Location = new System.Drawing.Point(11, 31);
            this.btnMeshPoints.Name = "btnMeshPoints";
            this.btnMeshPoints.Size = new System.Drawing.Size(30, 30);
            this.btnMeshPoints.TabIndex = 14;
            this.btnMeshPoints.UseVisualStyleBackColor = true;
            this.btnMeshPoints.Click += new System.EventHandler(this.btnMeshPoints_Click);
            // 
            // btnPictoSave
            // 
            this.btnPictoSave.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_save;
            this.btnPictoSave.Location = new System.Drawing.Point(59, 27);
            this.btnPictoSave.Name = "btnPictoSave";
            this.btnPictoSave.Size = new System.Drawing.Size(30, 30);
            this.btnPictoSave.TabIndex = 10;
            this.btnPictoSave.UseVisualStyleBackColor = true;
            this.btnPictoSave.Click += new System.EventHandler(this.btnPictoSave_Click);
            // 
            // btnPictoImport
            // 
            this.btnPictoImport.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_import;
            this.btnPictoImport.Location = new System.Drawing.Point(23, 27);
            this.btnPictoImport.Name = "btnPictoImport";
            this.btnPictoImport.Size = new System.Drawing.Size(30, 30);
            this.btnPictoImport.TabIndex = 9;
            this.btnPictoImport.UseVisualStyleBackColor = true;
            this.btnPictoImport.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // N3DTView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1193, 627);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPictoCam);
            this.Controls.Add(this.btnPictoSave);
            this.Controls.Add(this.btnPictoImport);
            this.Controls.Add(this.btnStartScan);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1077, 616);
            this.Name = "N3DTView";
            this.Text = "N3DT Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.N3DTView_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeedTimerRot)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnStartScan;
        private System.Windows.Forms.ToolStripMenuItem cameraConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arduinoManualCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dViewConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanningConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar progressBarScan;
        private System.Windows.Forms.ToolStripStatusLabel lblScanPercent;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator0;
        private System.Windows.Forms.ToolStripStatusLabel lblFilterSelected;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel lblArduinoComPort;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel lblStepResolutions;
        private System.Windows.Forms.ToolStripMenuItem n3DTFormatn3dtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oBJFormatobjToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel lblNbVertices;
        private System.Windows.Forms.Button btnPictoImport;
        private System.Windows.Forms.Button btnPictoCam;
        private System.Windows.Forms.Button btnPictoSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRotationDisable;
        private System.Windows.Forms.RadioButton rbRotationCounterClockwise;
        private System.Windows.Forms.RadioButton rbRotationClockwise;
        private System.Windows.Forms.NumericUpDown nudSpeedTimerRot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel lblSeparator4;
        private System.Windows.Forms.ToolStripStatusLabel lblNbTriangles;
        private System.Windows.Forms.Button btnLight;
        private System.Windows.Forms.Button btnMeshFacets;
        private System.Windows.Forms.Button btnMeshLinesTriangles;
        private System.Windows.Forms.Button btnMeshPoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMeshLines;
    }
}

