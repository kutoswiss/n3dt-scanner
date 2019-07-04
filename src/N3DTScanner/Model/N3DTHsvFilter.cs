/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;

namespace N3DTScanner
{
    class N3DTHsvFilter : ILaserFilter
    {
        #region Fields & Properties
        private Image<Hsv, byte> _hsvFrame;
        private Image<Gray, byte> _grayFrame;
        private Rectangle _cropArea;
        private Hsv _hsvMin;
        private Hsv _hsvMax;
        private int _erode;

        private double _hueMin;
        private double _hueMax;
        private double _satMin;
        private double _satMax;
        private double _valMin;
        private double _valMax;

        public LASER_FILTER SelectedFilter { get; set; }

        public int Erode
        {
            get { return _erode; }
            set { _erode = value; }
        }

        public double ValMin
        {
            get { return _valMin; }
            set { _valMin = value; }
        }
        
        public double ValMax
        {
            get { return _valMax; }
            set { _valMax = value; }
        }

        public double SatMin
        {
            get { return _satMin; }
            set { _satMin = value; }
        }

        public double SatMax
        {
            get { return _satMax; }
            set { _satMax = value; }
        }

        public double HueMax
        {
            get { return _hueMax; }
            set { _hueMax = value; }
        }
        
        public double HueMin
        {
            get { return _hueMin; }
            set { _hueMin = value; }
        }

        public Hsv HsvMin
        {
            get { return _hsvMin; }
            set { _hsvMin = value; }
        }

        public Hsv HsvMax
        {
            get { return _hsvMax; }
            set { _hsvMax = value; }
        }

        public Image<Hsv, byte> HsvFrame
        {
            get { return _hsvFrame; }
            set { _hsvFrame = value; }
        }

        public Image<Gray, byte> GrayFrame
        {
            get { return _grayFrame; }
            set { _grayFrame = value; }
        }
        public string Name
        {
            get { return "HSV filter"; }
        }

        public Rectangle CropArea
        {
            get { return _cropArea; }
            set { _cropArea = value; }
        }
        #endregion

        #region Contructor
        public N3DTHsvFilter()
        {
            this.CropArea = new Rectangle();
            this.SelectedFilter = LASER_FILTER.HSV;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to convert an image bgr type to an image hsv type
        /// </summary>
        /// <param name="bgrFrame">Image Bgr type</param>
        /// <returns>Image HsvType</returns>
        public Image<Hsv, byte> ConvertFromBgr(Image<Bgr, byte> bgrFrame)
        {
            Image<Hsv, byte> _hsvImg = bgrFrame.Convert<Hsv, byte>(); // Convert it to HSV format
            
            //CvInvoke.cvCvtColor(bgrFrame.Ptr, bgrFrame.Ptr, Emgu.CV.CvEnum.COLOR_CONVERSION.BGR2HSV);
            return _hsvImg;
        }

        /// <summary>
        /// Method to apply the HSV filter to an image
        /// </summary>
        public void ApplyFilter()
        {
            this.HsvMin = new Hsv((HueMin > HueMax) ? HueMax : HueMin, SatMin, ValMin);
            this.HsvMax = new Hsv((HueMin > HueMax) ? HueMin : HueMax, SatMax, ValMax);
            if (this.HsvFrame != null)
            {
                this.GrayFrame = this.HsvFrame.InRange(HsvMin, HsvMax).Erode(this.Erode); // Apply the HSV laser filter to the image
            }
        }

        /// <summary>
        /// Method that return a bitmap where the laser is filtered
        /// </summary>
        /// <returns>Bitmap image</returns>
        public Bitmap ToBitmap()
        {
            return (this.GrayFrame != null) ? this.GrayFrame.ToBitmap() : new Bitmap(1,1);
        }

        /// <summary>
        /// Method that return a bitmap where the laser is filtered
        /// </summary>
        /// <param name="cropArea">Rectangle crop area</param>
        /// <returns></returns>
        public Bitmap ToBitmap(Rectangle cropArea)
        {
            return this.GrayFrame.ToBitmap().Clone(cropArea, this.GrayFrame.ToBitmap().PixelFormat);
        }
        #endregion
    }
}
