using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace LifeCamCaptureEmguCV
{
    public partial class Form1 : Form
    {
        private Capture _capture = null;
        private bool _captureInProgress;

        public Form1()
        {
            InitializeComponent();
            this.captureImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            try
            {
                _capture = new Capture();
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Image<Bgr, Byte> frame = _capture.RetrieveBgrFrame();
            captureImageBox.Image = frame.ToBitmap();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {  //stop the capture
                    btnCapture.Text = "Start Capture";
                    _capture.Pause();
                }
                else
                {
                    //start the capture
                    btnCapture.Text = "Stop";
                    _capture.Start();
                }

                _captureInProgress = !_captureInProgress;
            }
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }
    }
}
