/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using System;

namespace N3DTScanner
{
    class N3DTImageDifferencesFilter : ILaserFilter
    {
        #region Fields & Properties
        private Rectangle _cropArea;
        private Image<Gray, byte> _grayFrame;
        private Bitmap _bmpA;
        private Bitmap _bmpB;
        private int _threshold;

        public LASER_FILTER SelectedFilter { get; set; }
        public N3DTArduinoCommand Arduino { get; set; }
        public N3DTCamera Camera { get; set; }

        public Bitmap BmpB
        {
            get { return _bmpB; }
            set { _bmpB = value; }
        }

        public Bitmap BmpA
        {
            get { return _bmpA; }
            set { _bmpA = value; }
        }

        public int Threshold
        {
            get { return _threshold; }
            set
            {
                _threshold = value;
                if (_threshold > 255)
                    _threshold = 255;
                else if (_threshold < 0)
                    _threshold = 0;
            }
        }

        public string Name
        {
            get { return "Comparing images"; }
        }

        public Rectangle CropArea
        {
            get{ return _cropArea; }
            set{ _cropArea = value; }
        }

        public Image<Gray, byte> GrayFrame
        {
            get { return _grayFrame; }
            set { _grayFrame = value; }
        }
        #endregion

        #region Constructor

        public N3DTImageDifferencesFilter() : this(new Bitmap(1,1), new Bitmap(1,1))
        { }  // No code

        public N3DTImageDifferencesFilter(Bitmap bmpA, Bitmap bmpB)
        {
            this.CropArea = new Rectangle(0, 0, bmpA.Width, bmpA.Height);
            this.BmpA = bmpA;
            this.BmpB = bmpB;
            this.Threshold = 20; // Default threshold is 20%
            this.SelectedFilter = LASER_FILTER.IMG_DIFF;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Method to extract the difference between two bitmaps.
        /// The difference will be shown in black and white.
        /// </summary>
        public void ApplyFilter()
        {
            /*this.Arduino.LaserState(false, false);
            System.Threading.Thread.Sleep(50);
            this.BmpA = new Bitmap(this.Camera.mCapture.RetrieveBgrFrame().ToBitmap());
            System.Threading.Thread.Sleep(50);

            this.Arduino.LaserState(true, false);
            System.Threading.Thread.Sleep(50);
            this.BmpB = new Bitmap(this.Camera.mCapture.RetrieveBgrFrame().ToBitmap());
            System.Threading.Thread.Sleep(50);*/

            Bitmap bmp = new Bitmap(BmpA.Width, BmpA.Height);
            Color cBmpA, cBmpB;

            // Apply filter only on the crop area
            for (int y = this.CropArea.Y; y < this.CropArea.Y + this.CropArea.Height; y++)
            {
                for (int x = this.CropArea.X; x < this.CropArea.X + this.CropArea.Width; x++)
                {
                    cBmpA = BmpA.GetPixel(x, y);
                    cBmpB = BmpB.GetPixel(x, y);
                    bmp.SetPixel(x, y, (Math.Abs(cBmpA.R - cBmpB.R) < Threshold) ? Color.Black : Color.White);
                }
            }
            this.GrayFrame = new Image<Gray, byte>(bmp);
        }

        /// <summary>
        /// Method that return a bitmap where the laser is filtered
        /// </summary>
        /// <returns>Bitmap image</returns>
        public Bitmap ToBitmap()
        {
            return (this.GrayFrame != null) ? this.GrayFrame.ToBitmap() : new Bitmap(1, 1);
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
