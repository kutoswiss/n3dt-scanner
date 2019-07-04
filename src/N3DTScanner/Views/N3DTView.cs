/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System;
using System.Windows.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Drawing;
using System.Collections.Generic;

namespace N3DTScanner
{
    public partial class N3DTView : Form
    {
        #region Fields & Properties
        private PictureBox _pbCameraFrame;
        private PictureBox _pbLaserFrame;
        private N3DTController _controller;
        private N3DTGLViewer _glViewer;
        private int _meshShowType;

        internal N3DTGLViewer GlViewer
        {
            get { return _glViewer; }
            set { _glViewer = value; }
        }

        public int MeshShowType
        {
            get { return _meshShowType; }
            set { _meshShowType = value; }
        }

        internal N3DTController Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }
        #endregion

        #region Constructor
        public N3DTView()
        {
            InitializeComponent();
            this.Controller = new N3DTController(this);

            this.InitPicturesBoxes();

            this.GlViewer = new N3DTGLViewer(this.Controller); // Create the GL viewer
            this.Controls.Add(this.GlViewer.GlControl); // Add to the main view
            this.UpdateView();
           
        }
        #endregion

        #region Methods
        /// <summary>
        /// To initializes picture boxes from the camera
        /// </summary>
        public void InitPicturesBoxes()
        {
            this._pbCameraFrame = this.Controller.GetFramePictureBox();
            this._pbLaserFrame = this.Controller.GetLaserFilteredPictureBox();

            this._pbCameraFrame.Size = new Size(380, 240);
            this._pbCameraFrame.Location = new Point(801, 69);
            this._pbLaserFrame.Size = new Size(380, 240);
            this._pbLaserFrame.Location = new Point(801, 313);

            this.Controls.Add(_pbCameraFrame);
            this.Controls.Add(_pbLaserFrame);
        }

        /// <summary>
        /// Method to Update the main view
        /// </summary>
        public void UpdateView()
        {
            // Update all labels on the Status strip menu
            this.lblScanPercent.Text = String.Format("{0} %", this.Controller.ScanPercent);
            this.lblFilterSelected.Text = String.Format("Filter selected: {0}", this.Controller.GetFilterMethodSelected());
            this.lblArduinoComPort.Text = String.Format("Arduino port: {0}", this.Controller.GetArduinoComPortSelected());
            this.lblStepResolutions.Text = String.Format("Step resolution: {0}", this.Controller.Scanner.StepResolution);
            this.lblNbVertices.Text = String.Format("Number of vertices: {0}", this.Controller.GetNbVertices());
            this.lblNbTriangles.Text = String.Format("Number of triangles (facets): {0}", this.Controller.GetNbTriangles());

            this.nudSpeedTimerRot.Value = this.GlViewer.Timer.Interval;
            //this.progressBarScan.Value = this.Controller.ScanPercent;

            //this.GlViewer.Update(); // Update the 3D GL view
            this.GlViewer.GlControl.Invalidate();
        }

        /// <summary>
        /// Button click to start the scanning process
        /// </summary>
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            this.Controller.StartScan();
            this.GlViewer.Update();
        }

        /// <summary>
        /// Method to open the camera configuration view
        /// </summary>
        private void cameraConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controller.OpenCameraConfigurationView();
        }

        /// <summary>
        /// Method to open the arduino configuration view
        /// </summary>
        private void arduinoManualCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controller.OpenArduinoConfigurationView();
        }

        private void RotationGLControlChanged(object sender, EventArgs e)
        {
            if (this.rbRotationClockwise.Checked)
                this.GlViewer.Rotation = N3DTGLViewer.ROTATION.CLOCKWISE;
            else if (this.rbRotationCounterClockwise.Checked)
                this.GlViewer.Rotation = N3DTGLViewer.ROTATION.COUNTERCLOCKWISE;
            else
                this.GlViewer.Rotation = N3DTGLViewer.ROTATION.DISABLE;
        }
        
        /// <summary>
        /// Method to open the 3d view configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dViewConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controller.Open3dConfigurationView();
        }

        /// <summary>
        /// Show some informations about the software
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String short_title = "N3DT Scanner";
            String long_title = "Numérisation 3D par principe de triangulation";
            String author = "Christopher Rejas";
            String year = "Session 2013/2014";
            String school = "CFPTI - Diplôme de Technicien ES en informatique";
            String email = "rejas.c@gmail.com";

            MessageBox.Show(String.Format("{0}\n{1}\n\n{2} - {3}\n{4} - {5}",
                short_title, long_title, school, year, author, email), "About");
        }

        /// <summary>
        /// Method executed when the form closing
        /// </summary>
        private void N3DTView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.Controller.Scanner.ThreadScan.IsAlive)
                this.Controller.Scanner.ThreadScan.Abort(); // We must abort the process
        }

        /// <summary>
        /// Method to open the scanning configuration view
        /// </summary>
        private void scanningConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controller.OpenScanningConfigurationView();
        }

        /// <summary>
        /// Method to export the mesh to .n3dt file format
        /// </summary>
        private void n3DTFormatn3dtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "mesh001.n3dt";
            this.saveFileDialog1.Filter = "N3DT files (*.n3dt)|*.n3dt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                this.Controller.ExportToN3dtFile(this.saveFileDialog1.FileName);
        }

        /// <summary>
        /// Method to load a mesh
        /// </summary>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.FileName = "*.n3dt";
            this.openFileDialog1.Filter = "N3DT files (*.n3dt)|*.n3dt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                this.Controller.LoadMesh(this.openFileDialog1.FileName);
        }

        /// <summary>
        /// Save mesh to OBJ format
        /// </summary>
        private void oBJFormatobjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "mesh001.obj";
            this.saveFileDialog1.Filter = "OBJ files (*.obj)|*.obj";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                this.Controller.ExportToObjFile(this.saveFileDialog1.FileName);
        }
        #endregion

        #region Pictogram buttons
        private void btnPictoCam_Click(object sender, EventArgs e)
        {
            this.Controller.OpenCameraConfigurationView();
        }

        private void btnPictoSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "mesh001.obj";
            this.saveFileDialog1.Filter = "OBJ files (*.obj)|*.obj";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                this.Controller.ExportToObjFile(this.saveFileDialog1.FileName);
        }
        #endregion

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLight_Click(object sender, EventArgs e)
        {
            this.GlViewer.LightOn = !this.GlViewer.LightOn; // Switch the light source
            if (this.GlViewer.LightOn)
                this.btnLight.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_light_on;
            else
                this.btnLight.Image = global::N3DTScanner.Properties.Resources.n3dt_picto_light_off;
            this.GlViewer.Update();
        }

        #region Mesh renderer
        private void btnMeshPoints_Click(object sender, EventArgs e)
        {
            this.GlViewer.MeshType = N3DTGLViewer.MESH_VIEWER_TYPE.POINTS;
            this.UpdateView();
        }

        private void btnMeshLines_Click(object sender, EventArgs e)
        {
            this.GlViewer.MeshType = N3DTGLViewer.MESH_VIEWER_TYPE.FACETS_EMPTY;
            this.UpdateView();
        }

        private void btnMeshFacets_Click(object sender, EventArgs e)
        {
            this.GlViewer.MeshType = N3DTGLViewer.MESH_VIEWER_TYPE.FACETS;
            this.UpdateView();
        }

        private void nudSpeedTimerRot_ValueChanged(object sender, EventArgs e)
        {
            this.GlViewer.Timer.Interval = (int)this.nudSpeedTimerRot.Value;
        }

        private void btnMeshLines_Click_1(object sender, EventArgs e)
        {
            this.GlViewer.MeshType = N3DTGLViewer.MESH_VIEWER_TYPE.LINES;
            this.UpdateView();
        }
        #endregion
        
    }
}
