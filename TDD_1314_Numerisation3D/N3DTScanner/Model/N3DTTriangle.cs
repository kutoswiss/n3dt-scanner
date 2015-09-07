/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using OpenTK;

namespace N3DTScanner
{
    class N3DTTriangle
    {
        #region Fields & Properties
        private N3DTVertex _p1;
        private N3DTVertex _p2;
        private N3DTVertex _p3;
        private N3DTVertex _normal;

        public N3DTVertex A
        {
            get { return _p1; }
            set { _p1 = value; }
        }
        
        public N3DTVertex B
        {
            get { return _p2; }
            set { _p2 = value; }
        }
        
        public N3DTVertex C
        {
            get { return _p3; }
            set { _p3 = value; }
        }
        

        public N3DTVertex Normal
        {
            get { return _normal; }
            private set { _normal = value; }
        }
        #endregion

        #region Constructors
        public N3DTTriangle() : this(new N3DTVertex(), new N3DTVertex(), new N3DTVertex())
        { }

        public N3DTTriangle(N3DTTriangle t) : this(t.A, t.B, t.C)
        { } // No code

        public N3DTTriangle(N3DTVertex p1, N3DTVertex p2, N3DTVertex p3)
        {
            this.A = p1;
            this.B = p2;
            this.C = p3;
            this.Normal = this.GetNormal(this.A, this.B, this.C);
        }
        #endregion

        #region Methods
        private N3DTVertex GetNormal(N3DTVertex a, N3DTVertex b, N3DTVertex c)
        {
            var s1 = b.ToVector3() - a.ToVector3();
            var s2 = c.ToVector3() - a.ToVector3();
            Vector3 v = Vector3.Cross(s1, s2);
            return new N3DTVertex(v.X, v.Y, v.Z);
        }
        #endregion
    }
}
