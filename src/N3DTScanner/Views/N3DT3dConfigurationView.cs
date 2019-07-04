/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System;
using System.Windows.Forms;

namespace N3DTScanner
{
    public partial class N3DT3dConfigurationView : Form
    {
        #region Fields & Properties
        private N3DTController _controller;

        public N3DTController Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }
        #endregion

        #region Constructor
        public N3DT3dConfigurationView(N3DTController controller)
        {
            InitializeComponent();
            this.Controller = controller;

            if(this.Controller.View.GlViewer.Rotation == N3DTGLViewer.ROTATION.DISABLE)
                this.rbRotationDisabled.Checked = true;
            else if (this.Controller.View.GlViewer.Rotation == N3DTGLViewer.ROTATION.COUNTERCLOCKWISE)
                this.rbCounterClockWise.Checked = true;
            else
                this.rbClockWise.Checked = true;

            this.nudRotateSpeed.Value = this.Controller.View.GlViewer.Timer.Interval;
        }
        #endregion

        #region Methods
        private void rbRotationChanged(object sender, EventArgs e)
        {
            if (this.rbClockWise.Checked)
                this.Controller.View.GlViewer.Rotation = N3DTGLViewer.ROTATION.CLOCKWISE;
            else if (this.rbCounterClockWise.Checked)
                this.Controller.View.GlViewer.Rotation = N3DTGLViewer.ROTATION.COUNTERCLOCKWISE;
            else if (this.rbRotationDisabled.Checked)
                this.Controller.View.GlViewer.Rotation = N3DTGLViewer.ROTATION.DISABLE;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Controller.View.GlViewer.Timer.Interval = (int)this.nudRotateSpeed.Value;
        }
        #endregion
    }
}
