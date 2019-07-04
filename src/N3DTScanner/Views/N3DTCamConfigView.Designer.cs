namespace N3DTScanner
{
    partial class N3DTCamConfigView
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
            this.tbBrightness = new System.Windows.Forms.TrackBar();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.lbContrast = new System.Windows.Forms.Label();
            this.lbSaturation = new System.Windows.Forms.Label();
            this.lbHue = new System.Windows.Forms.Label();
            this.lbGain = new System.Windows.Forms.Label();
            this.btnSetConfig = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbHueMin = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbHsvFilter = new System.Windows.Forms.GroupBox();
            this.tbBriMax = new System.Windows.Forms.TrackBar();
            this.tbBriMin = new System.Windows.Forms.TrackBar();
            this.tbSatMax = new System.Windows.Forms.TrackBar();
            this.tbSatMin = new System.Windows.Forms.TrackBar();
            this.tbHueMax = new System.Windows.Forms.TrackBar();
            this.gbCamConfig = new System.Windows.Forms.GroupBox();
            this.cbCameraDevices = new System.Windows.Forms.ComboBox();
            this.lblDevices = new System.Windows.Forms.Label();
            this.tbGain = new System.Windows.Forms.TrackBar();
            this.tbHue = new System.Windows.Forms.TrackBar();
            this.tbSaturation = new System.Windows.Forms.TrackBar();
            this.tbContrast = new System.Windows.Forms.TrackBar();
            this.lblTips = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbImgDiff = new System.Windows.Forms.RadioButton();
            this.rbHsvFilter = new System.Windows.Forms.RadioButton();
            this.tbThreshold = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.lblThresholdPercent = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCamera = new System.Windows.Forms.TabPage();
            this.gbMarkers = new System.Windows.Forms.GroupBox();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbCenterMarker = new System.Windows.Forms.RadioButton();
            this.rbGrid = new System.Windows.Forms.RadioButton();
            this.tabPageLaser = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbImgDiff = new System.Windows.Forms.GroupBox();
            this.btnDiff = new System.Windows.Forms.Button();
            this.tbErode = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueMin)).BeginInit();
            this.gbHsvFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBriMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBriMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueMax)).BeginInit();
            this.gbCamConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageCamera.SuspendLayout();
            this.gbMarkers.SuspendLayout();
            this.tabPageLaser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbImgDiff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbErode)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBrightness
            // 
            this.tbBrightness.BackColor = System.Drawing.Color.White;
            this.tbBrightness.Location = new System.Drawing.Point(116, 60);
            this.tbBrightness.Maximum = 255;
            this.tbBrightness.Name = "tbBrightness";
            this.tbBrightness.Size = new System.Drawing.Size(255, 45);
            this.tbBrightness.TabIndex = 0;
            this.tbBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBrightness.Scroll += new System.EventHandler(this.TrackBarsValueChanged);
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Location = new System.Drawing.Point(21, 64);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(56, 13);
            this.lbBrightness.TabIndex = 2;
            this.lbBrightness.Text = "Brightness";
            // 
            // lbContrast
            // 
            this.lbContrast.AutoSize = true;
            this.lbContrast.Location = new System.Drawing.Point(21, 92);
            this.lbContrast.Name = "lbContrast";
            this.lbContrast.Size = new System.Drawing.Size(46, 13);
            this.lbContrast.TabIndex = 4;
            this.lbContrast.Text = "Contrast";
            // 
            // lbSaturation
            // 
            this.lbSaturation.AutoSize = true;
            this.lbSaturation.Location = new System.Drawing.Point(21, 124);
            this.lbSaturation.Name = "lbSaturation";
            this.lbSaturation.Size = new System.Drawing.Size(55, 13);
            this.lbSaturation.TabIndex = 6;
            this.lbSaturation.Text = "Saturation";
            // 
            // lbHue
            // 
            this.lbHue.AutoSize = true;
            this.lbHue.Location = new System.Drawing.Point(21, 156);
            this.lbHue.Name = "lbHue";
            this.lbHue.Size = new System.Drawing.Size(27, 13);
            this.lbHue.TabIndex = 8;
            this.lbHue.Text = "Hue";
            // 
            // lbGain
            // 
            this.lbGain.AutoSize = true;
            this.lbGain.Location = new System.Drawing.Point(21, 188);
            this.lbGain.Name = "lbGain";
            this.lbGain.Size = new System.Drawing.Size(29, 13);
            this.lbGain.TabIndex = 10;
            this.lbGain.Text = "Gain";
            // 
            // btnSetConfig
            // 
            this.btnSetConfig.Location = new System.Drawing.Point(515, 414);
            this.btnSetConfig.Name = "btnSetConfig";
            this.btnSetConfig.Size = new System.Drawing.Size(127, 33);
            this.btnSetConfig.TabIndex = 11;
            this.btnSetConfig.Text = "Set configurations";
            this.btnSetConfig.UseVisualStyleBackColor = true;
            this.btnSetConfig.Click += new System.EventHandler(this.btnSetConfig_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(648, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 33);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbHueMin
            // 
            this.tbHueMin.BackColor = System.Drawing.Color.White;
            this.tbHueMin.Location = new System.Drawing.Point(116, 32);
            this.tbHueMin.Maximum = 180;
            this.tbHueMin.Name = "tbHueMin";
            this.tbHueMin.Size = new System.Drawing.Size(255, 45);
            this.tbHueMin.TabIndex = 19;
            this.tbHueMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbHueMin.Scroll += new System.EventHandler(this.HsvValuesChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Hue Min.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hue Max.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sat Max.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sat Min.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Bri Max.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Bri Min.";
            // 
            // gbHsvFilter
            // 
            this.gbHsvFilter.Controls.Add(this.label8);
            this.gbHsvFilter.Controls.Add(this.tbErode);
            this.gbHsvFilter.Controls.Add(this.tbBriMax);
            this.gbHsvFilter.Controls.Add(this.tbBriMin);
            this.gbHsvFilter.Controls.Add(this.tbSatMax);
            this.gbHsvFilter.Controls.Add(this.tbSatMin);
            this.gbHsvFilter.Controls.Add(this.tbHueMax);
            this.gbHsvFilter.Controls.Add(this.label1);
            this.gbHsvFilter.Controls.Add(this.label5);
            this.gbHsvFilter.Controls.Add(this.label6);
            this.gbHsvFilter.Controls.Add(this.tbHueMin);
            this.gbHsvFilter.Controls.Add(this.label2);
            this.gbHsvFilter.Controls.Add(this.label3);
            this.gbHsvFilter.Controls.Add(this.label4);
            this.gbHsvFilter.Location = new System.Drawing.Point(335, 19);
            this.gbHsvFilter.Name = "gbHsvFilter";
            this.gbHsvFilter.Size = new System.Drawing.Size(413, 240);
            this.gbHsvFilter.TabIndex = 34;
            this.gbHsvFilter.TabStop = false;
            this.gbHsvFilter.Text = "HSV Filter";
            // 
            // tbBriMax
            // 
            this.tbBriMax.BackColor = System.Drawing.Color.White;
            this.tbBriMax.Location = new System.Drawing.Point(116, 157);
            this.tbBriMax.Maximum = 255;
            this.tbBriMax.Name = "tbBriMax";
            this.tbBriMax.Size = new System.Drawing.Size(255, 45);
            this.tbBriMax.TabIndex = 35;
            this.tbBriMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBriMax.Value = 255;
            this.tbBriMax.Scroll += new System.EventHandler(this.HsvValuesChanged);
            // 
            // tbBriMin
            // 
            this.tbBriMin.BackColor = System.Drawing.Color.White;
            this.tbBriMin.Location = new System.Drawing.Point(116, 136);
            this.tbBriMin.Maximum = 255;
            this.tbBriMin.Name = "tbBriMin";
            this.tbBriMin.Size = new System.Drawing.Size(255, 45);
            this.tbBriMin.TabIndex = 37;
            this.tbBriMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbBriMin.Scroll += new System.EventHandler(this.HsvValuesChanged);
            // 
            // tbSatMax
            // 
            this.tbSatMax.BackColor = System.Drawing.Color.White;
            this.tbSatMax.Location = new System.Drawing.Point(116, 104);
            this.tbSatMax.Maximum = 255;
            this.tbSatMax.Name = "tbSatMax";
            this.tbSatMax.Size = new System.Drawing.Size(255, 45);
            this.tbSatMax.TabIndex = 36;
            this.tbSatMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSatMax.Value = 255;
            this.tbSatMax.Scroll += new System.EventHandler(this.HsvValuesChanged);
            // 
            // tbSatMin
            // 
            this.tbSatMin.BackColor = System.Drawing.Color.White;
            this.tbSatMin.Location = new System.Drawing.Point(116, 84);
            this.tbSatMin.Maximum = 255;
            this.tbSatMin.Name = "tbSatMin";
            this.tbSatMin.Size = new System.Drawing.Size(255, 45);
            this.tbSatMin.TabIndex = 35;
            this.tbSatMin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSatMin.Scroll += new System.EventHandler(this.HsvValuesChanged);
            // 
            // tbHueMax
            // 
            this.tbHueMax.BackColor = System.Drawing.Color.White;
            this.tbHueMax.Location = new System.Drawing.Point(116, 52);
            this.tbHueMax.Maximum = 180;
            this.tbHueMax.Name = "tbHueMax";
            this.tbHueMax.Size = new System.Drawing.Size(255, 45);
            this.tbHueMax.TabIndex = 34;
            this.tbHueMax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbHueMax.Scroll += new System.EventHandler(this.HsvValuesChanged);
            // 
            // gbCamConfig
            // 
            this.gbCamConfig.Controls.Add(this.cbCameraDevices);
            this.gbCamConfig.Controls.Add(this.lblDevices);
            this.gbCamConfig.Controls.Add(this.tbGain);
            this.gbCamConfig.Controls.Add(this.tbHue);
            this.gbCamConfig.Controls.Add(this.tbSaturation);
            this.gbCamConfig.Controls.Add(this.tbContrast);
            this.gbCamConfig.Controls.Add(this.tbBrightness);
            this.gbCamConfig.Controls.Add(this.lbBrightness);
            this.gbCamConfig.Controls.Add(this.lbContrast);
            this.gbCamConfig.Controls.Add(this.lbGain);
            this.gbCamConfig.Controls.Add(this.lbSaturation);
            this.gbCamConfig.Controls.Add(this.lbHue);
            this.gbCamConfig.Location = new System.Drawing.Point(332, 22);
            this.gbCamConfig.Name = "gbCamConfig";
            this.gbCamConfig.Size = new System.Drawing.Size(413, 240);
            this.gbCamConfig.TabIndex = 36;
            this.gbCamConfig.TabStop = false;
            this.gbCamConfig.Text = "Camera configurations";
            // 
            // cbCameraDevices
            // 
            this.cbCameraDevices.FormattingEnabled = true;
            this.cbCameraDevices.Location = new System.Drawing.Point(124, 19);
            this.cbCameraDevices.Name = "cbCameraDevices";
            this.cbCameraDevices.Size = new System.Drawing.Size(247, 21);
            this.cbCameraDevices.TabIndex = 16;
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(21, 22);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(86, 13);
            this.lblDevices.TabIndex = 15;
            this.lblDevices.Text = "Camera devices:";
            // 
            // tbGain
            // 
            this.tbGain.BackColor = System.Drawing.Color.White;
            this.tbGain.Location = new System.Drawing.Point(116, 190);
            this.tbGain.Maximum = 255;
            this.tbGain.Name = "tbGain";
            this.tbGain.Size = new System.Drawing.Size(255, 45);
            this.tbGain.TabIndex = 14;
            this.tbGain.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbGain.Scroll += new System.EventHandler(this.TrackBarsValueChanged);
            // 
            // tbHue
            // 
            this.tbHue.BackColor = System.Drawing.Color.White;
            this.tbHue.Location = new System.Drawing.Point(116, 158);
            this.tbHue.Maximum = 255;
            this.tbHue.Name = "tbHue";
            this.tbHue.Size = new System.Drawing.Size(255, 45);
            this.tbHue.TabIndex = 13;
            this.tbHue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbHue.Scroll += new System.EventHandler(this.TrackBarsValueChanged);
            // 
            // tbSaturation
            // 
            this.tbSaturation.BackColor = System.Drawing.Color.White;
            this.tbSaturation.Location = new System.Drawing.Point(116, 126);
            this.tbSaturation.Maximum = 255;
            this.tbSaturation.Name = "tbSaturation";
            this.tbSaturation.Size = new System.Drawing.Size(255, 45);
            this.tbSaturation.TabIndex = 12;
            this.tbSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbSaturation.Scroll += new System.EventHandler(this.TrackBarsValueChanged);
            // 
            // tbContrast
            // 
            this.tbContrast.BackColor = System.Drawing.Color.White;
            this.tbContrast.Location = new System.Drawing.Point(116, 94);
            this.tbContrast.Maximum = 255;
            this.tbContrast.Name = "tbContrast";
            this.tbContrast.Size = new System.Drawing.Size(255, 45);
            this.tbContrast.TabIndex = 11;
            this.tbContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbContrast.Scroll += new System.EventHandler(this.TrackBarsValueChanged);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(3, 265);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(37, 13);
            this.lblTips.TabIndex = 15;
            this.lblTips.Text = "lblTips";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Camera view";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Laser filter view";
            // 
            // rbImgDiff
            // 
            this.rbImgDiff.AutoSize = true;
            this.rbImgDiff.Checked = true;
            this.rbImgDiff.Location = new System.Drawing.Point(29, 19);
            this.rbImgDiff.Name = "rbImgDiff";
            this.rbImgDiff.Size = new System.Drawing.Size(109, 17);
            this.rbImgDiff.TabIndex = 40;
            this.rbImgDiff.TabStop = true;
            this.rbImgDiff.Text = "Image differences";
            this.rbImgDiff.UseVisualStyleBackColor = true;
            this.rbImgDiff.CheckedChanged += new System.EventHandler(this.radioButtonChanged);
            // 
            // rbHsvFilter
            // 
            this.rbHsvFilter.AutoSize = true;
            this.rbHsvFilter.Location = new System.Drawing.Point(155, 19);
            this.rbHsvFilter.Name = "rbHsvFilter";
            this.rbHsvFilter.Size = new System.Drawing.Size(72, 17);
            this.rbHsvFilter.TabIndex = 41;
            this.rbHsvFilter.Text = "HSV Filter";
            this.rbHsvFilter.UseVisualStyleBackColor = true;
            this.rbHsvFilter.CheckedChanged += new System.EventHandler(this.radioButtonChanged);
            // 
            // tbThreshold
            // 
            this.tbThreshold.BackColor = System.Drawing.Color.White;
            this.tbThreshold.Location = new System.Drawing.Point(116, 19);
            this.tbThreshold.Maximum = 255;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(255, 45);
            this.tbThreshold.TabIndex = 43;
            this.tbThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbThreshold.Scroll += new System.EventHandler(this.tbThreshold_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Threshold:";
            // 
            // lblThresholdPercent
            // 
            this.lblThresholdPercent.AutoSize = true;
            this.lblThresholdPercent.Location = new System.Drawing.Point(377, 20);
            this.lblThresholdPercent.Name = "lblThresholdPercent";
            this.lblThresholdPercent.Size = new System.Drawing.Size(21, 13);
            this.lblThresholdPercent.TabIndex = 45;
            this.lblThresholdPercent.Text = "0%";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCamera);
            this.tabControl1.Controls.Add(this.tabPageLaser);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 396);
            this.tabControl1.TabIndex = 46;
            // 
            // tabPageCamera
            // 
            this.tabPageCamera.Controls.Add(this.gbMarkers);
            this.tabPageCamera.Controls.Add(this.label10);
            this.tabPageCamera.Controls.Add(this.gbCamConfig);
            this.tabPageCamera.Controls.Add(this.lblTips);
            this.tabPageCamera.Location = new System.Drawing.Point(4, 22);
            this.tabPageCamera.Name = "tabPageCamera";
            this.tabPageCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCamera.Size = new System.Drawing.Size(759, 370);
            this.tabPageCamera.TabIndex = 0;
            this.tabPageCamera.Text = "Camera view";
            this.tabPageCamera.UseVisualStyleBackColor = true;
            // 
            // gbMarkers
            // 
            this.gbMarkers.Controls.Add(this.rbNone);
            this.gbMarkers.Controls.Add(this.rbCenterMarker);
            this.gbMarkers.Controls.Add(this.rbGrid);
            this.gbMarkers.Location = new System.Drawing.Point(332, 265);
            this.gbMarkers.Name = "gbMarkers";
            this.gbMarkers.Size = new System.Drawing.Size(127, 99);
            this.gbMarkers.TabIndex = 39;
            this.gbMarkers.TabStop = false;
            this.gbMarkers.Text = "Markers";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Checked = true;
            this.rbNone.Location = new System.Drawing.Point(24, 67);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 42;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
            // 
            // rbCenterMarker
            // 
            this.rbCenterMarker.AutoSize = true;
            this.rbCenterMarker.Location = new System.Drawing.Point(24, 19);
            this.rbCenterMarker.Name = "rbCenterMarker";
            this.rbCenterMarker.Size = new System.Drawing.Size(91, 17);
            this.rbCenterMarker.TabIndex = 40;
            this.rbCenterMarker.TabStop = true;
            this.rbCenterMarker.Text = "Center marker";
            this.rbCenterMarker.UseVisualStyleBackColor = true;
            this.rbCenterMarker.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
            // 
            // rbGrid
            // 
            this.rbGrid.AutoSize = true;
            this.rbGrid.Location = new System.Drawing.Point(24, 42);
            this.rbGrid.Name = "rbGrid";
            this.rbGrid.Size = new System.Drawing.Size(44, 17);
            this.rbGrid.TabIndex = 41;
            this.rbGrid.TabStop = true;
            this.rbGrid.Text = "Grid";
            this.rbGrid.UseVisualStyleBackColor = true;
            this.rbGrid.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
            // 
            // tabPageLaser
            // 
            this.tabPageLaser.Controls.Add(this.groupBox1);
            this.tabPageLaser.Controls.Add(this.gbImgDiff);
            this.tabPageLaser.Controls.Add(this.label11);
            this.tabPageLaser.Controls.Add(this.gbHsvFilter);
            this.tabPageLaser.Location = new System.Drawing.Point(4, 22);
            this.tabPageLaser.Name = "tabPageLaser";
            this.tabPageLaser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLaser.Size = new System.Drawing.Size(759, 370);
            this.tabPageLaser.TabIndex = 1;
            this.tabPageLaser.Text = "Laser filter";
            this.tabPageLaser.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbImgDiff);
            this.groupBox1.Controls.Add(this.rbHsvFilter);
            this.groupBox1.Location = new System.Drawing.Point(9, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 48);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter method:";
            // 
            // gbImgDiff
            // 
            this.gbImgDiff.Controls.Add(this.btnDiff);
            this.gbImgDiff.Controls.Add(this.label7);
            this.gbImgDiff.Controls.Add(this.tbThreshold);
            this.gbImgDiff.Controls.Add(this.lblThresholdPercent);
            this.gbImgDiff.Location = new System.Drawing.Point(335, 264);
            this.gbImgDiff.Name = "gbImgDiff";
            this.gbImgDiff.Size = new System.Drawing.Size(413, 94);
            this.gbImgDiff.TabIndex = 46;
            this.gbImgDiff.TabStop = false;
            this.gbImgDiff.Text = "Image differences";
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(260, 55);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(147, 33);
            this.btnDiff.TabIndex = 46;
            this.btnDiff.Text = "Calculate differences";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.btnDiff_Click_1);
            // 
            // tbErode
            // 
            this.tbErode.BackColor = System.Drawing.Color.White;
            this.tbErode.Location = new System.Drawing.Point(116, 187);
            this.tbErode.Name = "tbErode";
            this.tbErode.Size = new System.Drawing.Size(98, 45);
            this.tbErode.TabIndex = 48;
            this.tbErode.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Erode value:";
            // 
            // N3DTCamConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 455);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSetConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "N3DTCamConfigView";
            this.Text = "N3DT - Camera configurations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.N3DTCamConfigView_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tbBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueMin)).EndInit();
            this.gbHsvFilter.ResumeLayout(false);
            this.gbHsvFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBriMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBriMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHueMax)).EndInit();
            this.gbCamConfig.ResumeLayout(false);
            this.gbCamConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCamera.ResumeLayout(false);
            this.tabPageCamera.PerformLayout();
            this.gbMarkers.ResumeLayout(false);
            this.gbMarkers.PerformLayout();
            this.tabPageLaser.ResumeLayout(false);
            this.tabPageLaser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbImgDiff.ResumeLayout(false);
            this.gbImgDiff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbErode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbBrightness;
        private System.Windows.Forms.Label lbBrightness;
        private System.Windows.Forms.Label lbContrast;
        private System.Windows.Forms.Label lbSaturation;
        private System.Windows.Forms.Label lbHue;
        private System.Windows.Forms.Label lbGain;
        private System.Windows.Forms.Button btnSetConfig;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TrackBar tbHueMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbHsvFilter;
        private System.Windows.Forms.TrackBar tbBriMax;
        private System.Windows.Forms.TrackBar tbBriMin;
        private System.Windows.Forms.TrackBar tbSatMax;
        private System.Windows.Forms.TrackBar tbSatMin;
        private System.Windows.Forms.TrackBar tbHueMax;
        private System.Windows.Forms.GroupBox gbCamConfig;
        private System.Windows.Forms.TrackBar tbSaturation;
        private System.Windows.Forms.TrackBar tbContrast;
        private System.Windows.Forms.TrackBar tbGain;
        private System.Windows.Forms.TrackBar tbHue;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbCameraDevices;
        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.RadioButton rbImgDiff;
        private System.Windows.Forms.RadioButton rbHsvFilter;
        private System.Windows.Forms.TrackBar tbThreshold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblThresholdPercent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageCamera;
        private System.Windows.Forms.TabPage tabPageLaser;
        private System.Windows.Forms.GroupBox gbImgDiff;
        private System.Windows.Forms.GroupBox gbMarkers;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbGrid;
        private System.Windows.Forms.RadioButton rbCenterMarker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbErode;
    }
}