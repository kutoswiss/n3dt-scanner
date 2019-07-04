/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2013-04-08
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace N3DTScanner
{
    public class N3DTController
    {
        #region Fields & Properties
        private N3DTView _view;
        private N3DTScan _scanner;
        private IFileFormat _fileFormat;
        private int _scanPercent;

        internal IFileFormat FileFormat
        {
            get { return _fileFormat; }
            set { _fileFormat = value; }
        }

        public int ScanPercent
        {
            get { return _scanPercent; }
            set { _scanPercent = value; }
        }

        public N3DTScan Scanner
        {
            get { return _scanner; }
            set { _scanner = value; }
        }

        public N3DTView View
        {
            get { return _view; }
            set { _view = value; }
        }
        #endregion

        #region Constructor
        public N3DTController(N3DTView v)
        {
            this.View = v;
            this.Scanner = new N3DTScan(this);
            this.FileFormat = new N3DTFileFormat(this);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to update the main view
        /// </summary>
        internal void UpdateMainView()
        {
            this.View.UpdateView();
        }

        /// <summary>
        /// Method to send an error. (MessageBox)
        /// </summary>
        /// <param name="msg">String message error</param>
        public void SendMsg(String msg, String title)
        {
            System.Windows.Forms.MessageBox.Show(msg, title);
        }

        #region N3DT getters & methods
        public System.Windows.Forms.PictureBox GetFramePictureBox()
        {
            return this.Scanner.Camera.PbCamFrame;
        }

        public System.Windows.Forms.PictureBox GetLaserFilteredPictureBox()
        {
            return this.Scanner.Camera.PbLaserFrame;
        }
        #endregion

        #region N3DTScan getters & methods
        /// <summary>
        /// Method to start the scan
        /// </summary>
        public void StartScan()
        {
            this.Scanner.Start();
        }

        /// <summary>
        /// Get the number of triangles from the mesh
        /// </summary>
        /// <returns>Integer value (number of triangles)</returns>
        public int GetNbTriangles()
        {
            return this.Scanner.Mesh.Triangles.Count;
        }

        /// <summary>
        /// Get the number of vertices
        /// </summary>
        /// <returns>Integer number of vertices</returns>
        public int GetNbVertices()
        {
            int nbVertices = 0;
            for (int i = 0; i < 200; i++)
                nbVertices += this.GetMesh().Vertices[i].Count;
            return nbVertices;
        }

        /// <summary>
        /// Method to get the current filter
        /// </summary>
        /// <returns>N3DTILaserFilter object</returns>
        public ILaserFilter GetFilter()
        {
            return this.Scanner.Camera.LaserFilter;
        }

        /// <summary>
        /// Method to get the Arduino object
        /// </summary>
        /// <returns>N3DTArduinoCommand object</returns>
        public N3DTArduinoCommand GetArduino()
        {
            return this.Scanner.Arduino;
        }

        /// <summary>
        /// Method to get the name of the current selected filter
        /// </summary>
        /// <returns>String value</returns>
        public string GetFilterMethodSelected()
        {
            return (this.Scanner.Camera.LaserFilter != null) ? this.Scanner.Camera.LaserFilter.Name : "Camera not connected";
        }

        /// <summary>
        /// Method to get the name of the current com port selected (for the Arduino)
        /// </summary>
        /// <returns>String value</returns>
        public string GetArduinoComPortSelected()
        {
            return this.Scanner.Arduino.PortCom;
        }

        /// <summary>
        /// Method to get the mesh
        /// </summary>
        /// <returns>N3DTMesh object</returns>
        public N3DTMesh GetMesh()
        {
            return this.Scanner.Mesh;
        }

        /// <summary>
        /// Method to get the camera object
        /// </summary>
        /// <returns>N3DTCamera object</returns>
        public N3DTCamera GetCamera()
        {
            return this.Scanner.Camera;
        }
        #endregion

        #region View Openner
        /// <summary>
        /// Method to open the Camera configuration view
        /// </summary>
        public void OpenCameraConfigurationView()
        {
            N3DTCamConfigView _cameraConfigView = new N3DTCamConfigView(this);
            _cameraConfigView.Show();
        }

        /// <summary>
        /// Method to open the Arduino configuration view
        /// </summary>
        public void OpenArduinoConfigurationView()
        {
            N3DTArduinoCommandView _arduinoConfigView = new N3DTArduinoCommandView(this);
            _arduinoConfigView.Show();
        }

        /// <summary>
        /// Method to open the 3D configuration view
        /// </summary>
        public void Open3dConfigurationView()
        {
            N3DT3dConfigurationView _3dConfigurationView = new N3DT3dConfigurationView(this);
            _3dConfigurationView.Show();
        }

        /// <summary>
        /// Method to open the scanning configuration view
        /// </summary>
        public void OpenScanningConfigurationView()
        {
            N3DTScanningConfigView _scanningConfigView = new N3DTScanningConfigView(this);
            _scanningConfigView.Show();
        }
        #endregion

        #region File Import/Export methods
        /// <summary>
        /// Method to export the mesh to a N3DT file format
        /// </summary>
        /// <param name="path">String value</param>
        public void ExportToN3dtFile(String path)
        {
            this.FileFormat = new N3DTFileFormat(this);
            this.FileFormat.Export(path);
            this.UpdateMainView();
        }

        /// <summary>
        /// Method to export the mesh to a N3DT file format
        /// </summary>
        /// <param name="path">String value</param>
        public void ExportToObjFile(String path)
        {
            this.FileFormat = new OBJFileFormat(this);
            this.FileFormat.Export(path);
            this.UpdateMainView();
        }

        /// <summary>
        /// Method to load a N3DT file (.n3dt)
        /// </summary>
        /// <param name="path">String value</param>
        private  void ImportN3dtFile(String path)
        {
            this.FileFormat = new N3DTFileFormat(this);
            this.FileFormat.Load(path);
            this.UpdateMainView();
        }

        /// <summary>
        /// Method to load a mesh from a file
        /// </summary>
        /// <param name="path">String value</param>
        public void LoadMesh(String path)
        {
            int indx = path.IndexOf(".");
            String extension = path.Substring(indx);

            switch(extension)
            {
                // N3DT file
                case ".n3dt": this.ImportN3dtFile(path);
                    break;

                // OBJ file
                case ".obj": 
                    break;
            }
            this.Scanner.Mesh.CreateTrianglesFromPointClouds();
        }
        #endregion

        #endregion
    }
}
