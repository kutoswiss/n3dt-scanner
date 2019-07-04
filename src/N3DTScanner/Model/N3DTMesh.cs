/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using System.Collections.Generic;

namespace N3DTScanner
{
    public class N3DTMesh
    {
        public struct Triangle
        {
            public N3DTVertex p1, p2, p3;
            public N3DTVertex normal;
        }

        #region Fields & Properties
        private List<N3DTVertex>[] _vertices;
        private List<Triangle> _triangles;
        private int _nbScanStep;

        public List<Triangle> Triangles
        {
            get { return _triangles; }
            set { _triangles = value; }
        }

        public int NbScanStep
        {
            get { return _nbScanStep; }
            set { _nbScanStep = value; }
        }

        public List<N3DTVertex>[] Vertices
        {
            get { return _vertices; }
            set { _vertices = value; }
        }
        #endregion

        #region Constructor
        public N3DTMesh()
            : this(200)
        { }

        public N3DTMesh(int nbScanStep)
        {
            this.NbScanStep = nbScanStep;
            this.Vertices = new List<N3DTVertex>[this.NbScanStep];
            for (int i = 0; i < this.NbScanStep; i++)
                this.Vertices[i] = new List<N3DTVertex>();

            this.Triangles = new List<Triangle>();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Clear the array of vertices list
        /// </summary>
        public void ClearVertices()
        {
            for (int i = 0; i < this.NbScanStep; i++)
                this.Vertices[i].Clear();
        }

        /// <summary>
        /// Method to generate Triangles from the point clouds
        /// </summary>
        /// <returns>List of Triangle</returns>
        public List<Triangle> CreateTrianglesFromPointClouds()
        {
            this.Triangles.Clear();
            for (int i = 0; i < 200 - 1; i++)
            {
                for (int j = 0; j < this.Vertices[i].Count - 1; j++)
                {
                    // 1st triangle
                    Triangle t = new Triangle();
                    t.p1 = new N3DTVertex(this.Vertices[i][j]);
                    t.p2 = new N3DTVertex(this.Vertices[i][j+1]);

                    if (j < this.Vertices[i + 1].Count)
                        t.p3 = new N3DTVertex(this.Vertices[i + 1][j]);
                    else{
                        int last = this.Vertices[i+1].Count;
                        t.p3 = new N3DTVertex(this.Vertices[i + 1][last - 1]);
                    }
                    t.normal = new N3DTVertex(this.GetNormal(t.p1.ToVector3(), t.p2.ToVector3(), t.p3.ToVector3()));
                    this.Triangles.Add(t);

                    // 2nd triangle
                    Triangle t2 = new Triangle();
                    t2.p1 = new N3DTVertex(this.Vertices[i][j]);
                    t2.p2 = new N3DTVertex(this.Vertices[i][j + 1]);
                    if((i-1) < 0)
                    {
                        if((j+1) < this.Vertices[199].Count)
                            t2.p3 = new N3DTVertex(this.Vertices[199][j+1]);
                        else
                        {
                            int last = this.Vertices[199].Count;
                            t2.p3 = new N3DTVertex(this.Vertices[199][last - 1]);
                        }
                    }
                    else
                    {
                        if ((j+1) < this.Vertices[i-1].Count)
                            t2.p3 = new N3DTVertex(this.Vertices[i-1][j + 1]);
                        else
                        {
                            int last = this.Vertices[i - 1].Count;
                            t2.p3 = new N3DTVertex(this.Vertices[i - 1][last-1]);
                        }
                    }
                    t2.normal = new N3DTVertex(this.GetNormal(t2.p1.ToVector3(), t2.p2.ToVector3(), t2.p3.ToVector3()));
                    this.Triangles.Add(t2);
                }
            }
            return this.Triangles;
        }

        /// <summary>
        /// Method to calculate the normal of a triangle
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private OpenTK.Vector3 GetNormal(OpenTK.Vector3 a, OpenTK.Vector3 b, OpenTK.Vector3 c)
        {
            double x = ((b.Y - a.Y) * (c.Z - a.Z)) - ((b.Z - a.Z) * (c.Y - a.Y));
            double y = ((b.Z - a.Z) * (c.X - a.X)) - ((b.X - a.X) * (c.Z - a.Z));
            double z = ((b.X - a.X) * (c.Y - a.Y)) - ((b.Y - a.Y) * (c.X - a.X));

            return new N3DTVertex(x, y, z).ToVector3();
        }
        #endregion
    }
}
