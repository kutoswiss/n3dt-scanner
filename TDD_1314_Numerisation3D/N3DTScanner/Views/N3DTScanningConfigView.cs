/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System;
using System.Windows.Forms;

namespace N3DTScanner
{
    public partial class N3DTScanningConfigView : Form
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
        public N3DTScanningConfigView(N3DTController controller)
        {
            InitializeComponent();
            this.Controller = controller;
        }
        #endregion

        #region Methods
        private void nudStepRes_ValueChanged(object sender, EventArgs e)
        {
            this.Controller.Scanner.StepResolution = (int)this.nudStepRes.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controller.UpdateMainView();
            this.Close();
        }

        private void MeshRenderingChanged(object sender, EventArgs e)
        {
            if (this.rbMeshPoints.Checked)
                this.Controller.View.GlViewer.MeshType = N3DTGLViewer.MESH_VIEWER_TYPE.POINTS;
            else if (this.rbMeshLines.Checked)
                this.Controller.View.GlViewer.MeshType = N3DTGLViewer.MESH_VIEWER_TYPE.LINES;
            else
                this.Controller.View.GlViewer.MeshType = N3DTGLViewer.MESH_VIEWER_TYPE.FACETS;

            this.Controller.UpdateMainView();
        }
        #endregion
    }
}
