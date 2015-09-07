/*
 *  Project : Arduino Stepper Motor and Lasers Command 
 *  Author  : RC
 *  Date    : 2014-04-01
 */

using System;
using System.Windows.Forms;

namespace ArduinoStepperMotorAndLasersCommand
{
    public partial class View : Form
    {
        const int MOTOR_STEP_1   = 0x01;
        const int MOTOR_STEP_10  = 0x02;
        const int MOTOR_STEP_50  = 0x03;
        const int MOTOR_STEP_100 = 0x04;
        const int MOTOR_STEP_200 = 0x05;
        const int LASER_A_TOGGLE = 0x06;
        const int LASER_B_TOGGLE = 0x07;

        public void SendCmd(int cmd)
        {
            if (!this.serialPort1.IsOpen)
            {
                try
                {
                    this.serialPort1.Open();
                    this.serialPort1.Write(Convert.ToChar(cmd).ToString());
                    this.serialPort1.Close();
                }
                catch
                {
                    MessageBox.Show("There was an error. Please make sure that the correct port was selected and the device was plugged in.");
                }
            }
        }

        public void MoveStepperMotorByStep(int nbStep, int stepResolution)
        {
            for (int i = 0; i < nbStep; i++)
            {
                this.SendCmd(stepResolution);
                System.Threading.Thread.Sleep(10);
            }
        }

        public void ToggleLaser(int cmd)
        {
            this.SendCmd(cmd);
        }

        public View()
        {
            InitializeComponent();
            this.serialPort1.PortName = "COM4";
            this.serialPort1.BaudRate = 9600;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.MoveStepperMotorByStep(Convert.ToInt16(this.nudNbStep.Value), MOTOR_STEP_1);
        }

        private void btnMoveQuarter_Click(object sender, EventArgs e)
        {
            this.MoveStepperMotorByStep(1, MOTOR_STEP_50);
        }

        private void btnMoveHalf_Click(object sender, EventArgs e)
        {
            this.MoveStepperMotorByStep(1, MOTOR_STEP_100);
        }

        private void btnMoveFull_Click(object sender, EventArgs e)
        {
            this.MoveStepperMotorByStep(1, MOTOR_STEP_200);
        }

        private void btnToggleLaserA_Click(object sender, EventArgs e)
        {
            this.ToggleLaser(LASER_A_TOGGLE);
        }

        private void btnToggleLaserB_Click(object sender, EventArgs e)
        {
            this.ToggleLaser(LASER_B_TOGGLE);
        }
    }
}
