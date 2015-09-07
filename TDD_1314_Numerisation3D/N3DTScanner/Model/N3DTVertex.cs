/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2013-04-08
 */

using System;
using OpenTK;

namespace N3DTScanner
{
    public class N3DTVertex
    {
        #region Fields & Properties
        private double _x;
        private double _y;
        private double _z;

        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        
        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }
        #endregion

        #region Constructor
        public N3DTVertex() : this(0.0, 0.0, 0.0)
        { } // No code

        public N3DTVertex(N3DTVertex v) : this(v.X, v.Y, v.Z)
        { } // No code

        public N3DTVertex(Vector3 v) : this(v.X, v.Y, v.Z)
        { } // No code

        public N3DTVertex(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Export vertex to OBJ format
        /// </summary>
        /// <returns>String value</returns>
        public String ToObjFormat()
        {
            return String.Format("v {0:0.000} {1:0.000} {2:0.000}", this.X, this.Y, this.Z);
        }

        /// <summary>
        /// Export vertex to N3DT format
        /// </summary>
        /// <returns>String value</returns>
        public String ToN3dtFormat()
        {
            return String.Format("vX={0:0.000},vY={1:0.000},vZ={2:0.000}", this.X, this.Y, this.Z);
        }

        /// <summary>
        /// Convert Vertex to OpenTK Vector3
        /// </summary>
        /// <returns>OpenTK.Vector3 value</returns>
        public OpenTK.Vector3 ToVector3()
        {
            return new OpenTK.Vector3((float)this.X, (float)this.Y, (float)this.Z);
        }
        #endregion
    }
}
