/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2013-04-08
 */

using System;
using System.Drawing;
using System.Threading;

namespace N3DTScanner
{
    public class N3DTScan
    {
      
        #region Constants
        private const int NB_SCAN_STEP = 200;
        #endregion

        #region Fields & Properties
        private Thread _threadScan;
        private N3DTController _controller; 
        private N3DTCamera _camera;
        private N3DTArduinoCommand _arduino;
        private N3DTMesh _mesh;
        private Bitmap _laserOnBmp;
        private int _stepResolution;
        private double _stepDegree;
        private bool _isFinish;
        private int _scanInProgress;
        private int _camIndex;

        public int CamIndex
        {
            get { return _camIndex; }
            set { _camIndex = value;
            this.Camera = new N3DTCamera(_camIndex);
            }
        }

        public int StepResolution
        {
            get { return _stepResolution; }
            set {
                _stepResolution = value;
                if (_stepResolution <= 0)
                    _stepResolution = 1;
                else if (_stepResolution > 200)
                    _stepResolution = 200;
            }
        }

        public int ScanInProgress
        {
            get { return _scanInProgress; }
            set { _scanInProgress = value; }
        }

        public bool IsScanning
        {
            get { return _isFinish; }
            set { _isFinish = value; }
        }

        public Thread ThreadScan
        {
            get { return _threadScan; }
            set { _threadScan = value; }
        }

        public N3DTController Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }

        public N3DTCamera Camera
        {
            get { return _camera; }
            set { _camera = value; }
        }

        internal N3DTArduinoCommand Arduino
        {
            get { return _arduino; }
            set { _arduino = value; }
        }

        public double StepDegree
        {
            get { return _stepDegree; }
            set { _stepDegree = value; }
        }

        internal N3DTMesh Mesh
        {
            get { return _mesh; }
            set { _mesh = value; }
        }

        public Bitmap LaserOnBmp
        {
            get { return _laserOnBmp; }
            set { _laserOnBmp = value; }
        }
        #endregion

        #region Constructor
        public N3DTScan(N3DTController c)
        {
            this.Controller = c;
            this.Mesh = new N3DTMesh(NB_SCAN_STEP);
            this.StepDegree = 360.0 / NB_SCAN_STEP;

            this.CamIndex = 0;
            this.Camera = new N3DTCamera(this.CamIndex);
            this.Arduino = new N3DTArduinoCommand();
            

            this.ThreadScan = new Thread(new ThreadStart(this.Execute));
            this.IsScanning = false;
            this.StepResolution = 1; // Default value = 1
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to start the scanning process
        /// </summary>
        public void Start()
        {
            this.ThreadScan = new Thread(new ThreadStart(this.Execute));
            this.ThreadScan.Start();
            this.IsScanning = true;
        }

        /// <summary>
        /// Method to stop the scanning process
        /// </summary>
        public void Stop()
        {
            if(this.ThreadScan.IsAlive)
                this.ThreadScan.Abort();
            this.IsScanning = false; 
        }

        /// <summary>
        /// Method to execute the scan process
        /// </summary>
        private void Execute()
        {
            this.Mesh.ClearVertices();
            for (int step = 0; step < NB_SCAN_STEP; step+=this.StepResolution)
            {
                if (this.Camera.LaserFilter.SelectedFilter == LASER_FILTER.IMG_DIFF)
                {
                    this.Arduino.LaserState(false, false);
                    System.Threading.Thread.Sleep(50);
                    (this.Camera.LaserFilter as N3DTImageDifferencesFilter).BmpA = new Bitmap(this.Camera.mCapture.QueryFrame().ToBitmap());
                    System.Threading.Thread.Sleep(50);

                    this.Arduino.LaserState(true, false);
                    System.Threading.Thread.Sleep(50);
                    (this.Camera.LaserFilter as N3DTImageDifferencesFilter).BmpB = new Bitmap(this.Camera.mCapture.QueryFrame().ToBitmap());
                    System.Threading.Thread.Sleep(50);
                }


                this.Camera.LaserFilter.ApplyFilter(); // Apply the selected filter
                Bitmap laserBmp = this.Camera.LaserFilter.ToBitmap(); // Get the image where the laser is filtered

                this.CapturePointCloud(laserBmp, step);

                this.Arduino.RotateStepperMotorByStep(this.StepResolution);
                System.Threading.Thread.Sleep(200);

                this._scanInProgress = step * 100 / (NB_SCAN_STEP-1); // Get the value in percent, -1 because the index starts from 0
                this.Controller.ScanPercent = this._scanInProgress;
                this.Controller.UpdateMainView();
            }
            this.Stop(); // Stop the scanning process
        }

        /// <summary>
        /// Method to capture a point cloud from a bitmap image
        /// </summary>
        /// <param name="laserBmp">Bitmap image</param>
        /// <param name="step">Current step of the motor</param>
        private void CapturePointCloud(Bitmap laserBmp, int step)
        {
            int argb;
            byte r, g, b;
            float X3d, Y3d, Z3d;
            float radian;
            float distX, distZ;
            Size s = laserBmp.Size;

            for (int y = 0; y < s.Height; y++)
            {
                for (int x = 0; x < s.Width / 2; x++)
                {
                    argb = laserBmp.GetPixel(x, y).ToArgb();
                    r = laserBmp.GetPixel(x, y).R;
                    g = laserBmp.GetPixel(x, y).G;
                    b = laserBmp.GetPixel(x, y).B;

                    //if(argb) // Higher than 0, the color is white
                    if ((r != 0) && (g != 0) & (b != 0))
                    {
                        // get the angle in radian
                        radian = (float)((this.StepDegree * step) * (Math.PI / 180));

                        // get max distances values to calculate the deep of the object
                        distX = (float)Math.Cos(radian);
                        distZ = (float)Math.Sin(radian);

                        // get x, y and z values, multiply x and z by 1.1f to adjust distances
                        X3d = (((s.Width / 2) - x) * distX / (s.Width / 2)) * 1.0f;
                        Z3d = (((s.Width / 2) - x) * distZ / (s.Width / 2)) * 1.0f;
                        Y3d = 1.0f - (y * 1.0f / s.Height);

                        this.Mesh.Vertices[step].Add(new N3DTVertex(X3d, Y3d, Z3d));
                        break;
                    }
                }
            }
        }

        #endregion
    }
}
