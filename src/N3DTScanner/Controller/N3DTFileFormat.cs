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
    class N3DTFileFormat : IFileFormat
    {
        #region Fields
        private List<String> _fileLines;
        private N3DTController _controller;
        private StreamReader _streamReader;
        #endregion

        #region Constructor
        public N3DTFileFormat(N3DTController c)
        {
            this._controller = c;
            this._fileLines = new List<String>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method to load a mesh from a file
        /// </summary>
        /// <param name="path">String value (filename path)</param>
        public void Load(String path)
        {
            String line;
            this._streamReader = new StreamReader(path);
            this._controller.Scanner.Mesh.ClearVertices();

            while ((line = _streamReader.ReadLine()) != null)
            {
                if (line[0] == 'D')
                {
                    int a = int.Parse(line.Substring(3));
                    line = _streamReader.ReadLine();

                    while (line.CompareTo("End") != 0)
                    {
                        String[] vertices = line.Split(',');

                        double vX = double.Parse(vertices[0].Substring(3));
                        double vY = double.Parse(vertices[1].Substring(3));
                        double vZ = double.Parse(vertices[2].Substring(3));

                        this._controller.Scanner.Mesh.Vertices[a].Add(new N3DTVertex(vX, vY, vZ));
                        line = _streamReader.ReadLine();
                    }
                }
            }
            _streamReader.Close();
        }

        /// <summary>
        /// Method to export the mesh to n3dt file (.n3dt)
        /// </summary>
        /// <param name="path">String value (filename path)</param>
        public void Export(String path)
        {
            for (int i = 0; i < 200; i++)
            {
                this._fileLines.Add(String.Format("Deg{0:000}", i));
                foreach (N3DTVertex v in this._controller.Scanner.Mesh.Vertices[i])
                    this._fileLines.Add(String.Format("vX={0:0.000},vY={1:0.000},vZ={2:0.000}", v.X, v.Y, v.Z));
                this._fileLines.Add("End");
            }
            File.WriteAllLines(path, this._fileLines.ToArray());
            this._controller.SendMsg(String.Format("The mesh is exported on path {0}", path), "Export finished");
        }
        #endregion
    }
}
