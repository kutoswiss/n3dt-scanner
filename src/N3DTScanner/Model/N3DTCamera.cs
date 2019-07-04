/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;

namespace N3DTScanner
{
    enum CAMERA_MARKER
    {
        CENTER_MARKER,
        GRID_MAKER,
        NONE
    }

    public class N3DTCamera
    {
        #region Constants
        const string ERROR_001_CAM_NOT_FOUND = "Error : Camera device is not connected.";
        const double CAMERA_DEFAULT_CONFIG_VALUE = 128.0;
        #endregion

        #region Fields & Properties
        private Bitmap _bmpFrame;
        private N3DTArduinoCommand _arduino;
        private Capture _capture;

        private ILaserFilter _laserFilter;

        public ILaserFilter LaserFilter
        {
            get { return _laserFilter; }
            set { _laserFilter = value; }
        }
        //private LASER_FILTER _selectedFilter;
        private CAMERA_MARKER _marker;

        private double _brightness;
        private double _contrast;
        private double _saturation;
        private double _hue;
        private double _gain;
        private int _camIndex;
        public System.Windows.Forms.PictureBox _pbFrame;
        public System.Windows.Forms.PictureBox _pbLaserFrame;
        
        public double h_max;
        public double h_min;
        public double s_max;
        public double s_min;
        public double v_max;
        public double v_min;

        

        public Bitmap BmpFrame
        {
            get { return _bmpFrame; }
            set { _bmpFrame = value; }
        }

        internal N3DTArduinoCommand Arduino
        {
            get { return _arduino; }
            set { _arduino = value; }
        }

        internal CAMERA_MARKER Marker
        {
            get { return _marker; }
            set { _marker = value; }
        }


        /*internal N3DTILaserFilter LaserFilter
        {
            get { return _laserFilter; }
            set { _laserFilter = value; }
        }

        internal LASER_FILTER SelectedFilter
        {
            get { return _selectedFilter; }
            set
            {
                _selectedFilter = value;
                switch (_selectedFilter)
                {
                    case LASER_FILTER.HSV:
                        this.LaserFilter = new N3DTHsvFilter();
                        break;

                    case LASER_FILTER.IMG_DIFF:
                        this.LaserFilter = new N3DTImageDifferencesFilter(this.Arduino, this);
                        break;
                }
            }
        }*/

        public int CamIndex
        {
            get { return _camIndex; }
            set { _camIndex = value; }
        }

        public System.Windows.Forms.PictureBox PbLaserFrame
        {
            get { return _pbLaserFrame; }
            set { _pbLaserFrame = value; }
        }

        public System.Windows.Forms.PictureBox PbCamFrame
        {
            get { return _pbFrame; }
            set { _pbFrame = value; }
        }

        public Capture mCapture
        {
            get { return _capture; }
            set { _capture = value; }
        }
        
        public double Brightness
        {
            get { return _brightness; }
            set { _brightness = value; }
        }
        
        public double Contrast
        {
            get { return _contrast; }
            set { _contrast = value; }
        }

        public double Saturation
        {
            get { return _saturation; }
            set { _saturation = value; }
        }

        public double Hue
        {
            get { return _hue; }
            set { _hue = value; }
        }

        public double Gain
        {
            get { return _gain; }
            set { _gain = value; }
        }
        public Image<Bgr, Byte> bgrFrame { get; set; }
        #endregion

        #region Constructor
        public N3DTCamera(int camIndex)
        {  
            try
            {
                // Initialize picture boxes
                this.PbCamFrame = new PictureBox();
                this.PbCamFrame.SizeMode = PictureBoxSizeMode.Zoom;
                this.PbCamFrame.BackColor = Color.Black;

                this.PbLaserFrame = new PictureBox();
                this.PbLaserFrame.SizeMode = PictureBoxSizeMode.Zoom;
                this.PbLaserFrame.BackColor = Color.Black;

                this.mCapture = new Capture(camIndex);
                this.mCapture.ImageGrabbed += ProcessFrame; // Set the delegate for the image grabbed

                // Set actual capture properties to the camera
                this.Brightness = this.mCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_BRIGHTNESS);
                this.Saturation = this.mCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_SATURATION);
                this.Contrast = this.mCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_CONTRAST);
                this.Hue = this.mCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_HUE);
                this.Gain = this.mCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_GAIN);

                this.LaserFilter = new N3DTImageDifferencesFilter();
                this.Marker = CAMERA_MARKER.NONE;
                this.BmpFrame = new Bitmap(1, 1);

                this.mCapture.Start();
            }
            catch (NullReferenceException excpt)
            {
                System.Windows.Forms.MessageBox.Show(ERROR_001_CAM_NOT_FOUND);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// A method called by the camera capture thread.
        /// </summary>
        private void ProcessFrame(object sender, EventArgs arg)
        {
            lock (this.BmpFrame)
            {
                this.bgrFrame = this.mCapture.RetrieveBgrFrame(); // Get the actual image frame on BGR format
                this.BmpFrame = this.bgrFrame.ToBitmap();

                using (Graphics g = Graphics.FromImage(this.BmpFrame))
                    g.DrawRectangle(Pens.Red, this._laserFilter.CropArea);

                // Draw marker
                switch (this.Marker)
                {
                    case CAMERA_MARKER.CENTER_MARKER:
                        using (Graphics g = Graphics.FromImage(this.BmpFrame))
                            g.DrawLine(Pens.Yellow, this.bgrFrame.ToBitmap().Width / 2, 0,
                                this.bgrFrame.ToBitmap().Width / 2, this.bgrFrame.ToBitmap().Height);
                        break;
                    case CAMERA_MARKER.GRID_MAKER:
                        using (Graphics g = Graphics.FromImage(this.BmpFrame))
                        {
                            for (int i = 1; i <= 2; i++)
                            {
                                g.DrawLine(Pens.Yellow, this.bgrFrame.ToBitmap().Width / 3 * i, 0,
                                    this.bgrFrame.ToBitmap().Width / 3 * i, this.bgrFrame.ToBitmap().Height);

                                g.DrawLine(Pens.Yellow, 0, this.bgrFrame.ToBitmap().Height / 3 * i, 
                                    this.bgrFrame.ToBitmap().Width, this.bgrFrame.ToBitmap().Height / 3 * i);
                            }
                        }
                        break;
                    default: break;
                }
                this._pbFrame.Image = this.BmpFrame;
            }

            // Apply the filter to the preview picbox
            if (this.LaserFilter.SelectedFilter == LASER_FILTER.HSV)
            {
                (this.LaserFilter as N3DTHsvFilter).HsvFrame = (this.LaserFilter as N3DTHsvFilter).ConvertFromBgr(this.bgrFrame); // Convert a BGR image to a HSV image

                (this.LaserFilter as N3DTHsvFilter).HueMin = h_min;
                (this.LaserFilter as N3DTHsvFilter).HueMax = h_max;
                (this.LaserFilter as N3DTHsvFilter).SatMin = s_min;
                (this.LaserFilter as N3DTHsvFilter).SatMax = s_max;
                (this.LaserFilter as N3DTHsvFilter).ValMin = v_min;
                (this.LaserFilter as N3DTHsvFilter).ValMax = v_max;

                this.LaserFilter.ApplyFilter();
                this.PbLaserFrame.Image = this.LaserFilter.ToBitmap();
            }
        }

        /// <summary>
        /// Method the release all data about the camera capture.
        /// </summary>
        private void ReleaseData()
        {
            if (_capture != null) _capture.Dispose();
        }

        /// <summary>
        /// Method to set the capture properties
        /// </summary>
        public void SetCaptureProperty()
        {
            this.mCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_BRIGHTNESS, this.Brightness);
            this.mCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_SATURATION, this.Saturation);
            this.mCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_CONTRAST, this.Contrast);
            this.mCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_HUE, this.Hue);
            this.mCapture.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_GAIN, this.Gain);
        }
        #endregion
    }
}
