/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2014-04-08
 */

using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace N3DTScanner
{
    class N3DTGLViewer
    {
        #region Enum
        public enum ROTATION
        {
            CLOCKWISE,
            COUNTERCLOCKWISE,
            DISABLE
        }

        public enum MESH_VIEWER_TYPE
        {
            POINTS,
            LINES,
            FACETS,
            FACETS_EMPTY
        }
        #endregion

        #region Constants
        const int LOCATION_X = 144;
        const int LOCATION_Y = 69;
        const int SIZE_WIDTH = 651;
        const int SIZE_HEIGHT = 522;

        const int COLOR_FORMAT = 32;
        const int DEPTH = 24;
        const int STENCIL = 0;
        const int SAMPLES = 8;
        #endregion

        #region Fields & Properties
        private N3DTController _controller;
        private GLControl _glControl;
        private Timer _timer;
        private bool _glLoaded;
        private MESH_VIEWER_TYPE _meshType;
        private ROTATION _rotation;
        private int _mouseStartX, _mouseStartY;
        private float _angleX, _angleY;
        private bool _lightOn;

        public bool LightOn
        {
            get { return _lightOn; }
            set { _lightOn = value; }
        }
        public Timer Timer
        {
            get { return _timer; }
            set { _timer = value; }
        }

        internal ROTATION Rotation
        {
            get { return _rotation; }
            set { 
                _rotation = value;
                if(this.Timer != null)
                    this.Timer.Enabled = (_rotation != ROTATION.DISABLE); // Disable the timer if rotation is disable
            }
        }

        internal MESH_VIEWER_TYPE MeshType
        {
            get { return _meshType; }
            set { _meshType = value; }
        }

        public N3DTController Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }

        public bool GlLoaded
        {
            get { return _glLoaded; }
            set { _glLoaded = value; }
        }

        public GLControl GlControl
        {
            get { return _glControl; }
            set { _glControl = value; }
        }
        #endregion

        #region Constructor
        public N3DTGLViewer(N3DTController c)
        {
            this.LightOn = false;
            this.MeshType = MESH_VIEWER_TYPE.POINTS;
            this.Rotation = ROTATION.DISABLE;
            this.Controller = c;

            this.Timer = new Timer();
            this.Timer.Interval = 50; // 50 is the default value
            this.Timer.Tick += Timer_Tick;

            this.GlLoaded = false;
            this.GlControl = new OpenTK.GLControl(new OpenTK.Graphics.GraphicsMode(COLOR_FORMAT, DEPTH, STENCIL, SAMPLES));
            this.GlControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.GlControl.Location = new Point(LOCATION_X, LOCATION_Y);
            this.GlControl.Size = new Size(SIZE_WIDTH, SIZE_HEIGHT);
            this.GlControl.Load += new EventHandler(this.glControl_Load);
            this.GlControl.MouseWheel += new MouseEventHandler(this.glControl_mouseWheel);
            this.GlControl.Resize += new EventHandler(this.glControl_Resize);
            this.GlControl.MouseDown += new MouseEventHandler(this.glControl_mouseDown);
            this.GlControl.MouseMove += new MouseEventHandler(this.glControl_mouseMove);
            this.GlControl.Paint += new PaintEventHandler(this.glControl_paint);
            this._angleX = this._angleY = 0;
            this._mouseStartX = this._mouseStartY = 0;
        }

        private void glControl_paint(object sender, PaintEventArgs e)
        {
            this.Update();
        }

        #endregion

        #region Methods

        #region GLControl translations
        private void glControl_mouseMove(object sender, MouseEventArgs e)
        {
            bool mouseCliked = false;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _angleX = (e.X - _mouseStartX) * 1f;
                    GL.Rotate(_angleX, Vector3d.UnitY);
                    mouseCliked = true;
                    break;

                case MouseButtons.Right:
                    _angleY = (e.Y - _mouseStartY) * 0.002f;
                    GL.Translate(0, _angleY * -1.0f, 0);
                    mouseCliked = true;
                    break;

                default: break;
            }

            if (mouseCliked)
            {
                this.Update();
                this._mouseStartX = e.X;
                this._mouseStartY = e.Y;
                mouseCliked = false;
            }  
        }

        private void glControl_mouseDown(object sender, MouseEventArgs e)
        {
            this._mouseStartX = e.X;
            this._mouseStartY = e.Y;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            GL.Rotate((this.Rotation == ROTATION.CLOCKWISE) ? -1 : 1, OpenTK.Vector3d.UnitY);
            this.Update();
        }
        #endregion

        #region Drawing primitive geometry
        /// <summary>
        /// Method to draw a line on a GLControl
        /// </summary>
        /// <param name="v1">OpenTK.Vector3 vector1</param>
        /// <param name="v2">OpenTK.Vector3 vector2</param>
        private void DrawLine(Vector3 v1, Vector3 v2)
        {
            GL.Begin(BeginMode.Lines);
            GL.Vertex3(v1.X, v1.Y, v1.Z);
            GL.Vertex3(v2.X, v2.Y, v2.Z);
            GL.End();
        }

        /// <summary>
        /// Method to draw a point on a GLControl
        /// </summary>
        /// <param name="v1">OpenTK.Vector3 vector1</param>
        private void DrawPoint(Vector3 v1)
        {
            GL.Begin(BeginMode.Points);
            GL.Vertex3(v1.X, v1.Y, v1.Z);
            GL.End();
        }

        /// <summary>
        /// Method to draw a triangle on a GLControl
        /// </summary>
        /// <param name="v1">OpenTK.Vector3 vector1</param>
        /// <param name="v2">OpenTK.Vector3 vector2</param>
        /// <param name="v3">OpenTK.Vector3 vector3</param>
        private void DrawTriangle(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            GL.Begin(BeginMode.Triangles);
            GL.Vertex3(v1.X, v1.Y, v1.Z);
            GL.Vertex3(v2.X, v2.Y, v2.Z);
            GL.Vertex3(v3.X, v3.Y, v3.Z);
            GL.End();
        }
        #endregion

        /// <summary>
        /// Method to update the GLControl view
        /// </summary>
        public void Update()
        {
            if (this._glLoaded)
            {
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                GL.ClearColor(Color.LightGray);
                GL.ShadeModel(ShadingModel.Smooth);

                if (this.LightOn)
                {
                    float[] mat_specular = { 1.0f, 1.0f, 1.0f, 1.0f };
                    float[] mat_shininess = { 50.0f };
                    float[] light_position = { 1.0f, 1.0f, 1.0f, 0.0f };
                    float[] light_ambient = { 0.5f, 0.5f, 0.5f, 1.0f };

                    GL.Material(MaterialFace.Front, MaterialParameter.Specular, mat_specular);
                    GL.Material(MaterialFace.Front, MaterialParameter.Shininess, mat_shininess);
                    GL.Light(LightName.Light0, LightParameter.Position, light_position);
                    GL.Light(LightName.Light0, LightParameter.Ambient, light_ambient);
                    GL.Light(LightName.Light0, LightParameter.Diffuse, mat_specular);

                    GL.Enable(EnableCap.Lighting);
                    GL.Enable(EnableCap.Light0);
                    GL.Enable(EnableCap.DepthTest);
                    GL.Enable(EnableCap.ColorMaterial);
                    GL.Enable(EnableCap.CullFace);
                }
                else
                {
                    GL.Disable(EnableCap.Lighting);
                    GL.Disable(EnableCap.Light0);
                    GL.Disable(EnableCap.DepthTest);
                    GL.Disable(EnableCap.ColorMaterial);
                    GL.Disable(EnableCap.CullFace);
                }

                GL.Color3(Color.Black);
                switch (this.MeshType)
                {
                    // Draw points
                    case MESH_VIEWER_TYPE.POINTS:
                        for (int i = 0; i < 200; i++)
                            foreach (N3DTVertex v in this.Controller.GetMesh().Vertices[i])
                                DrawPoint(v.ToVector3());
                        break;

                    // Draw lines
                    case MESH_VIEWER_TYPE.LINES:
                        for (int i = 0; i < 200; i++)
                            for (int j = 0; j < this.Controller.GetMesh().Vertices[i].Count - 1; j++)
                                DrawLine(this.Controller.GetMesh().Vertices[i][j].ToVector3(), this.Controller.GetMesh().Vertices[i][j + 1].ToVector3());
                        break;

                    // Draw facets (with triangles)
                    case MESH_VIEWER_TYPE.FACETS:
                        if (this.Controller.Scanner.Mesh.Triangles != null)
                        {
                            foreach (N3DTMesh.Triangle t in this.Controller.Scanner.Mesh.Triangles)
                            {
                                GL.Begin(BeginMode.Triangles);
                                GL.Normal3(t.normal.ToVector3());
                                GL.Vertex3(t.p1.X, t.p1.Y, t.p1.Z);
                                GL.Vertex3(t.p2.X, t.p2.Y, t.p2.Z);
                                GL.Vertex3(t.p3.X, t.p3.Y, t.p3.Z);
                                GL.End();
                            }
                        }
                        break;

                    // Draw empty facets (with triangles)
                    case MESH_VIEWER_TYPE.FACETS_EMPTY:
                        if (this.Controller.Scanner.Mesh.Triangles != null)
                        {
                            foreach (N3DTMesh.Triangle t in this.Controller.Scanner.Mesh.Triangles)
                            {
                                GL.Begin(BeginMode.LineLoop);
                                GL.Normal3(t.normal.ToVector3());
                                GL.Vertex3(t.p1.X, t.p1.Y, t.p1.Z);
                                GL.Vertex3(t.p2.X, t.p2.Y, t.p2.Z);
                                GL.Vertex3(t.p3.X, t.p3.Y, t.p3.Z);
                                GL.End();
                            }
                        }
                        break;
                }
                _glControl.SwapBuffers();
            }
        }

        /// <summary>
        /// Method called when the GLControl is resized
        /// </summary>
        private void glControl_Resize(object sender, EventArgs e)
        {
            GL.Viewport(this.GlControl.Size);
            //this.Update();
            this.GlControl.Invalidate();
        }


        /// <summary>
        /// Method called when the mouse wheel value is changed on the GLControl
        /// </summary>
        private void glControl_mouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0) GL.Scale(1.1, 1.1, 1.1);
            else GL.Scale(0.9, 0.9, 0.9);
            this.Update();
        }

        /// <summary>
        /// Method called on load of GLControl
        /// </summary>
        private void glControl_Load(object sender, EventArgs e)
        {
            this.GlLoaded = true;
            GL.Rotate(15.0, OpenTK.Vector3d.UnitX);
            GL.ClearColor(Color.Silver);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ShadeModel(ShadingModel.Smooth);
            _glControl.SwapBuffers();
        }
        #endregion
    }
}
