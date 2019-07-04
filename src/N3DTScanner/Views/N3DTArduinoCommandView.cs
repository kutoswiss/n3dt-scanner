/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2013-04-08
 */

using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace N3DTScanner
{
    public partial class N3DTArduinoCommandView : Form
    {
        #region Fields & Properties
        private N3DTController _controller;
        private N3DTArduinoCommand _arduino;

        internal N3DTArduinoCommand Arduino
        {
            get { return _arduino; }
            set { _arduino = value; }
        }
        public N3DTController Controller
        {
            get { return _controller; }
            set { _controller = value; }
        }
        #endregion

        #region Constructor
        public N3DTArduinoCommandView(N3DTController controller)
        {
            InitializeComponent();
            this.Controller = controller;
            this.Arduino = this.Controller.Scanner.Arduino;

            this.cbPortCom.Items.Clear();
            foreach (string p in SerialPort.GetPortNames())
                this.cbPortCom.Items.Add(p);

            this.cbPortCom.SelectedIndex = 0;  // first Com port by default
            this.cbBaudrate.SelectedIndex = 5; // Baudrate 9600 by default
        }
        #endregion

        #region Methods
        private void btnToggleLaserA_Click(object sender, EventArgs e)
        {
            this.Arduino.LaserToggleState(LASER.LEFT);
        }

        private void btnToggleLaserB_Click(object sender, EventArgs e)
        {
            this.Arduino.LaserToggleState(LASER.RIGHT);
        }
        
        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Arduino.RotateStepperMotorByStep(Convert.ToInt16(this.nudNbStep.Value));
        }

        private void btnMoveQuarter_Click(object sender, EventArgs e)
        {
            this.Arduino.RotateStepperMotor_Quarter();
        }

        private void btnMoveHalf_Click(object sender, EventArgs e)
        {
            this.Arduino.RotateStepperMotor_Half();
        }

        private void btnMoveFull_Click(object sender, EventArgs e)
        {
            this.Arduino.RotateStepperMotor_Full();
        }

        private void btnLeftLaserOn_Click(object sender, EventArgs e)
        {
            this.Arduino.LaserState(LASER.LEFT, true);
        }
        private void btnLeftLaserOff_Click(object sender, EventArgs e)
        {
            this.Arduino.LaserState(LASER.LEFT, false);
        }

        private void btnRightLaserOn_Click(object sender, EventArgs e)
        {
            this.Arduino.LaserState(LASER.RIGHT, true);
        }

        private void btnRightLaserOff_Click(object sender, EventArgs e)
        {
            this.Arduino.LaserState(LASER.RIGHT, false);
        }

        private void btnSetOptions_Click(object sender, EventArgs e)
        {
            this.Arduino.PortCom = this.cbPortCom.SelectedItem.ToString();
            this.Arduino.BaudRate = Convert.ToInt16(this.cbBaudrate.SelectedItem.ToString());
            this.Controller.UpdateMainView();
        }
        #endregion
    }
}
