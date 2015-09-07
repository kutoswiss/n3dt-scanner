/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System;
using System.Collections.Generic;
using System.IO;

namespace N3DTScanner
{
    class OBJFileFormat : IFileFormat
    {
        #region Fields
        private List<String> _verticesList;
        private List<String> _normalsList;
        private List<String> _facesList;
        private N3DTController _controller;
        private StreamReader _streamReader;
        #endregion

        #region Constructor
        public OBJFileFormat(N3DTController c)
        {
            this._controller = c;
            this._verticesList = new List<String>();
            this._normalsList = new List<String>();
            this._facesList = new List<String>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to load a mesh from a OBJ file format
        /// </summary>
        /// <param name="path">String value (filename path)</param>
        public void Load(string path)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Method to export a mesh to OBJ file format
        /// </summary>
        /// <param name="path">String value (filename path)</param>
        public void Export(string path)
        {
            long nbv = 1;
            foreach (N3DTMesh.Triangle t in this._controller.Scanner.Mesh.Triangles)
            {
                _verticesList.Add(String.Format(t.p1.ToObjFormat()));
                _verticesList.Add(String.Format(t.p2.ToObjFormat()));
                _verticesList.Add(String.Format(t.p3.ToObjFormat()));

                _normalsList.Add(String.Format("vn {0:0.000} {1:0.000} {2:0.000}", t.normal.X, t.normal.Y, t.normal.Z));
                _facesList.Add(String.Format("f {0} {1} {2}", nbv, nbv + 1, nbv + 2));
                nbv += 3;
            }
            File.WriteAllLines(path, _verticesList.ToArray());
            File.AppendAllLines(path, _normalsList.ToArray());
            File.AppendAllLines(path, _facesList.ToArray());
            this._controller.SendMsg(String.Format("The mesh is exported on path {0}", path), "Export finished");
        }
        #endregion
    }
}
