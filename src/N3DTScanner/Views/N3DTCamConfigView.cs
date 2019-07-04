/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DirectShowLib;


namespace N3DTScanner
{
    public partial class N3DTCamConfigView : Form
    {
        #region Fields & Properties
        private sRectangle _cropArea;

        private struct sRectangle
        {
            public int X, Y;
            public int Width, Height;
        }

        private PictureBox _pbCameraFrame;
        private PictureBox _pbLaserFrame;
        private N3DTCamera Camera { get; set; }
        private N3DTController Controller { get; set; }
        private Rectangle CropArea { get; set; }
        #endregion

        #region Constructors
        public N3DTCamConfigView(N3DTController controller)
        {
            InitializeComponent();
            this.Controller = controller;
            this.Camera = this.Controller.GetCamera();
            this.InitPictureBoxes();
            this.CropArea = new Rectangle(0, 0, this.Controller.GetFramePictureBox().Width, this.Controller.GetFramePictureBox().Height);
            
            this.tbBrightness.Value = (this.Camera.Brightness > 0) ? (int)this.Camera.Brightness : 0;
            this.tbContrast.Value = (this.Camera.Contrast > 0) ? (int)this.Camera.Contrast : 0;
            this.tbGain.Value = (this.Camera.Gain > 0) ? (int)this.Camera.Gain : 0;
            this.tbHue.Value = (this.Camera.Hue > 0) ? (int)this.Camera.Hue : 0;
            this.tbSaturation.Value = (this.Camera.Saturation > 0) ? (int)this.Camera.Saturation : 0;

            switch (this.Camera.Marker)
            {
                case CAMERA_MARKER.CENTER_MARKER:
                    this.rbCenterMarker.Checked = true;
                    break;
                case CAMERA_MARKER.GRID_MAKER:
                    this.rbGrid.Checked = true;
                    break;
                case CAMERA_MARKER.NONE:
                    this.rbNone.Checked = true;
                    break;
            }


            this.Camera.s_max = 255;
            this.Camera.v_max = 255;
            this.tbHueMin.Value = Convert.ToInt16(this.Camera.h_min);
            this.tbHueMax.Value = Convert.ToInt16(this.Camera.h_max);
            this.tbSatMin.Value = Convert.ToInt16(this.Camera.s_min);
            this.tbSatMax.Value = Convert.ToInt16(this.Camera.s_max);
            this.tbBriMin.Value = Convert.ToInt16(this.Camera.v_min);
            this.tbBriMax.Value = Convert.ToInt16(this.Camera.v_max);
            this.lblTips.Text = "Definissez la zone où se trouve l'objet.";

            if (this.Controller.GetFilter() is N3DTImageDifferencesFilter)
            {
                this.tbThreshold.Value = (this.Controller.GetFilter() as N3DTImageDifferencesFilter).Threshold;
                this.lblThresholdPercent.Text = this.tbThreshold.Value.ToString() + "%";
            }

            // Filter method selected
            this.gbHsvFilter.Enabled = (this.Controller.GetFilter().SelectedFilter == LASER_FILTER.HSV) ? true : false;
            this.gbImgDiff.Enabled = (this.Controller.GetFilter().SelectedFilter == LASER_FILTER.IMG_DIFF) ? true : false;
            this.rbHsvFilter.Checked = (this.Controller.GetFilter().SelectedFilter == LASER_FILTER.HSV) ? true : false;
            this.rbImgDiff.Checked = (this.Controller.GetFilter().SelectedFilter == LASER_FILTER.IMG_DIFF) ? true : false;

            // Show all cameras devices connected
            // Thanks to kerboo -> http://www.emgu.com/forum/viewtopic.php?f=7&t=3095
            List<KeyValuePair<int, string>> ListCamerasData = new List<KeyValuePair<int, string>>();
            DsDevice[] _SystemCamereas = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            int _DeviceIndex = 0;
            foreach (DirectShowLib.DsDevice _Camera in _SystemCamereas)
            {
                ListCamerasData.Add(new KeyValuePair<int, string>(_DeviceIndex, _Camera.Name));
                _DeviceIndex++;
            }

            //-> clear the combobox
            this.cbCameraDevices.DataSource = null;
            this.cbCameraDevices.Items.Clear();

            //-> bind the combobox
            this.cbCameraDevices.DataSource = new BindingSource(ListCamerasData, null);
            this.cbCameraDevices.DisplayMember = "Value";
            this.cbCameraDevices.ValueMember = "Key";

            this.cbCameraDevices.SelectedIndex = this.Controller.Scanner.CamIndex;
        }
        #endregion

        #region Methods
        private void InitPictureBoxes()
        {
            this._pbCameraFrame = this.Controller.GetFramePictureBox();
            this._pbCameraFrame.Location = new Point(6, 19);
            this._pbCameraFrame.Size = new Size(320, 240);
            this._pbCameraFrame.MouseDown += this.pbCamView_MouseDown;
            this._pbCameraFrame.MouseUp += this.pbCamView_MouseUp;

            this._pbLaserFrame = this.Controller.GetLaserFilteredPictureBox();
            this._pbLaserFrame.Location = new Point(6, 19);
            this._pbLaserFrame.Size = new Size(320, 240);

            this.tabPageCamera.Controls.Add(this._pbCameraFrame);
            this.tabPageLaser.Controls.Add(this._pbLaserFrame);
        }

        private void btnSetConfig_Click(object sender, EventArgs e)
        {
            this.UpdateCameraConfigurations();
            this.Controller.UpdateMainView();
            this.Close();
        }

        private void TrackBarsValueChanged(object sender, EventArgs e)
        {
            this.Camera.Brightness = Convert.ToDouble(this.tbBrightness.Value);
            this.Camera.Contrast = Convert.ToDouble(this.tbContrast.Value);
            this.Camera.Gain = Convert.ToDouble(this.tbGain.Value);
            this.Camera.Hue = Convert.ToDouble(this.tbHue.Value);
            this.Camera.Saturation = Convert.ToDouble(this.tbSaturation.Value);
            this.Camera.SetCaptureProperty();
        }

        private void N3DTCamConfigView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controller.View.InitPicturesBoxes();
        }

        private void pbCamView_MouseDown(object sender, MouseEventArgs e)
        {
            this._cropArea.X = e.X*2;
            this._cropArea.Y = e.Y*2;
        }

        private void pbCamView_MouseUp(object sender, MouseEventArgs e)
        {
            this._cropArea.Height = e.Y*2 - _cropArea.Y;
            this._cropArea.Width = e.X*2 - _cropArea.X;
            this.Controller.GetFilter().CropArea = new Rectangle(_cropArea.X, _cropArea.Y, _cropArea.Width, _cropArea.Height);
        }

        private void HsvValuesChanged(object sender, EventArgs e)
        {
            this.Camera.h_min = this.tbHueMin.Value;
            this.Camera.h_max = this.tbHueMax.Value;
            this.Camera.s_min = this.tbSatMin.Value;
            this.Camera.s_max = this.tbSatMax.Value;
            this.Camera.v_min = this.tbBriMin.Value;
            this.Camera.v_max = this.tbBriMax.Value;
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            this.Controller.Scanner.Arduino.LaserState(false, false);
            System.Threading.Thread.Sleep(100);
            (this.Controller.GetFilter() as N3DTImageDifferencesFilter).BmpA = new Bitmap(this._pbCameraFrame.Image);
            System.Threading.Thread.Sleep(100);


            this.Controller.Scanner.Arduino.LaserState(true, false);
            System.Threading.Thread.Sleep(100);
            (this.Controller.GetFilter() as N3DTImageDifferencesFilter).BmpB = new Bitmap(this._pbCameraFrame.Image);
            System.Threading.Thread.Sleep(100);

            this.Controller.GetFilter().ApplyFilter();
            this._pbLaserFrame.Image = this.Controller.GetFilter().ToBitmap();
        }

        private void radioButtonChanged(object sender, EventArgs e)
        {          
            this.gbHsvFilter.Enabled = this.rbHsvFilter.Checked;
            this.gbImgDiff.Enabled = this.rbImgDiff.Checked;

            if(this.rbHsvFilter.Checked == true)
            {
                this.Controller.Scanner.Camera.LaserFilter = new N3DTHsvFilter();
                System.Threading.Thread.Sleep(20);
                this.tbThreshold.Enabled = false;
            }
            else if (this.rbImgDiff.Checked == true)
            {
                this.Controller.Scanner.Camera.LaserFilter = new N3DTImageDifferencesFilter();
                System.Threading.Thread.Sleep(20);
                this.tbThreshold.Enabled = true;
                (this.Controller.GetFilter() as N3DTImageDifferencesFilter).Threshold = Convert.ToInt16(this.tbThreshold.Value);
            }
        }

        private void tbThreshold_Scroll(object sender, EventArgs e)
        {
            (this.Controller.GetFilter() as N3DTImageDifferencesFilter).Threshold = Convert.ToInt16(this.tbThreshold.Value);
            this.lblThresholdPercent.Text = this.tbThreshold.Value.ToString();
        }

        private void RadioButtonChanged(object sender, EventArgs e)
        {
            if (this.rbCenterMarker.Checked)
                this.Camera.Marker = CAMERA_MARKER.CENTER_MARKER;
            else if (this.rbGrid.Checked)
                this.Camera.Marker = CAMERA_MARKER.GRID_MAKER;
            else
                this.Camera.Marker = CAMERA_MARKER.NONE;
        }

        private void btnDiff_Click_1(object sender, EventArgs e)
        {
            this.Controller.GetArduino().LaserState(false, false);
            System.Threading.Thread.Sleep(50);
            (this.Controller.GetFilter() as N3DTImageDifferencesFilter).BmpA = new Bitmap(this.Controller.GetCamera().mCapture.RetrieveBgrFrame().ToBitmap());
            System.Threading.Thread.Sleep(50);

            this.Controller.GetArduino().LaserState(true, false);
            System.Threading.Thread.Sleep(50);
            (this.Controller.GetFilter() as N3DTImageDifferencesFilter).BmpB = new Bitmap(this.Controller.GetCamera().mCapture.RetrieveBgrFrame().ToBitmap());
            System.Threading.Thread.Sleep(50);


            this.Controller.GetFilter().ApplyFilter();
            this._pbLaserFrame.Image = this.Controller.GetFilter().ToBitmap();
        }

        private void UpdateCameraConfigurations()
        {
            this.Controller.Scanner.CamIndex = this.cbCameraDevices.SelectedIndex;
            this.Camera = this.Controller.GetCamera();
            this.InitPictureBoxes();

            if (this.rbCenterMarker.Checked)
                this.Camera.Marker = CAMERA_MARKER.CENTER_MARKER;
            else if (this.rbGrid.Checked)
                this.Camera.Marker = CAMERA_MARKER.GRID_MAKER;
            else
                this.Camera.Marker = CAMERA_MARKER.NONE;

            this.Camera.Brightness = Convert.ToDouble(this.tbBrightness.Value);
            this.Camera.Contrast = Convert.ToDouble(this.tbContrast.Value);
            this.Camera.Gain = Convert.ToDouble(this.tbGain.Value);
            this.Camera.Hue = Convert.ToDouble(this.tbHue.Value);
            this.Camera.Saturation = Convert.ToDouble(this.tbSaturation.Value);
            this.Camera.SetCaptureProperty();

            if (this.rbHsvFilter.Checked == true)
            {
                this.Controller.Scanner.Camera.LaserFilter = new N3DTHsvFilter();
                System.Threading.Thread.Sleep(20);
                this.tbThreshold.Enabled = false;

                this.Camera.h_min = this.tbHueMin.Value;
                this.Camera.h_max = this.tbHueMax.Value;
                this.Camera.s_min = this.tbSatMin.Value;
                this.Camera.s_max = this.tbSatMax.Value;
                this.Camera.v_min = this.tbBriMin.Value;
                this.Camera.v_max = this.tbBriMax.Value;

                (this.Camera.LaserFilter as N3DTHsvFilter).Erode = this.tbErode.Value;
            }
            else if (this.rbImgDiff.Checked == true)
            {
                this.Controller.Scanner.Camera.LaserFilter = new N3DTImageDifferencesFilter();
                System.Threading.Thread.Sleep(20);
                this.tbThreshold.Enabled = true;
                (this.Controller.GetFilter() as N3DTImageDifferencesFilter).Threshold = Convert.ToInt16(this.tbThreshold.Value);
            }

            this.Controller.GetFilter().CropArea = new Rectangle(_cropArea.X, _cropArea.Y, _cropArea.Width, _cropArea.Height);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            (this.Camera.LaserFilter as N3DTHsvFilter).Erode = this.tbErode.Value;
        }
        #endregion
    }
}
