/*
 * Project : N3DT Scanner - TDD 2013/2014
 * Author  : Christopher Rejas
 * Date    : 2013-04-08
 */

using System;
using System.IO.Ports;

namespace N3DTScanner
{
    public enum ARDUINO_COMMANDS
    {
        MOTOR_STEP_1 = 0x01,
        MOTOR_STEP_10 = 0x02,
        MOTOR_STEP_50 = 0x03,
        MOTOR_STEP_100 = 0x04,
        MOTOR_STEP_200 = 0x05,
        LASER_LEFT_TOGGLE = 0x06,
        LASER_RIGHT_TOGGLE = 0x07,
        LASER_LEFT_ON = 0x08,
        LASER_LEFT_OFF = 0x09,
        LASER_RIGHT_ON = 0x0A,
        LASER_RIGHT_OFF = 0x0B,
    }

    public enum LASER
    {
        RIGHT, LEFT
    }

    public class N3DTArduinoCommand
    {
        #region Fields & Properties
        private SerialPort _serialPort;
        private String _portCom;
        private int _baudRate;

        public int BaudRate
        {
            get { return _baudRate; }
            set 
            { 
                _baudRate = value;
                this._serialPort = new SerialPort(this._portCom, this._baudRate);
            }
        }

        public String PortCom
        {
            get { return _portCom; }
            set 
            { 
                _portCom = value;
                this._serialPort = new SerialPort(this._portCom, 9600);
            }
        }

        public SerialPort mSerialPort
        {
            get { return _serialPort; }
            set { _serialPort = value; }
        }
        #endregion

        #region Constructor
        public N3DTArduinoCommand() : this("COM4", 9600)
        { } // No code

        public N3DTArduinoCommand(String portCom, int baudRate)
        {
            this.PortCom = portCom;
            this.BaudRate = baudRate;
            this.mSerialPort = new SerialPort(this.PortCom, this.BaudRate);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method the send a command to the Arduino board.
        /// </summary>
        /// <param name="cmd">Command information</param>
        private void SendCommand(ARDUINO_COMMANDS cmd)
        {
            if (!this.mSerialPort.IsOpen)
            {
                try
                {
                    this.mSerialPort.Open();
                    this.mSerialPort.Write(Convert.ToChar(cmd).ToString());
                    this.mSerialPort.Close();
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Arduino board cannot be found. \nPlease make sure that the correct COM port was selected and the Arduino device was plugged in.");
                }
            }
        }

        /// <summary>
        /// Method to rotate the stepper motor connected to the Arduino board.
        /// </summary>
        /// <param name="nbStep">Number of steps</param>
        public void RotateStepperMotorByStep(int nbStep)
        {
            for (int i = 0; i < nbStep; i++)
            {
                this.SendCommand(ARDUINO_COMMANDS.MOTOR_STEP_1);
                System.Threading.Thread.Sleep(10);
            }
        }

        /// <summary>
        /// Method to rotate a quarter the stepper motor
        /// </summary>
        public void RotateStepperMotor_Quarter()
        {
            this.SendCommand(ARDUINO_COMMANDS.MOTOR_STEP_50);
        }

        /// <summary>
        /// Method to rotate a half the stepper motor
        /// </summary>
        public void RotateStepperMotor_Half()
        {
            this.SendCommand(ARDUINO_COMMANDS.MOTOR_STEP_100);
        }

        /// <summary>
        /// Method to rotate the stepper motor fully
        /// </summary>
        public void RotateStepperMotor_Full()
        {
            this.SendCommand(ARDUINO_COMMANDS.MOTOR_STEP_200);
        }

        /// <summary>
        /// Method to command the left laser
        /// </summary>
        /// <param name="state">State of the laser. (True: Laser ON, False: Laser OFF)</param>
        /// <param name="leftLaser">Parameter to choose the left or the right laser. (True: Left Laser, False: Right Laser)</param>
        public void LaserState(LASER position, bool state)
        {
            switch (position)
            {
                case LASER.LEFT:
                    this.SendCommand(state ? ARDUINO_COMMANDS.LASER_LEFT_ON : ARDUINO_COMMANDS.LASER_LEFT_OFF);
                    break;

                case LASER.RIGHT:
                    this.SendCommand(state ? ARDUINO_COMMANDS.LASER_RIGHT_ON : ARDUINO_COMMANDS.LASER_RIGHT_OFF);
                    break;

                default: break;
            }
        }

        /// <summary>
        /// Method to command both lasers state
        /// </summary>
        /// <param name="leftLaserState">State of the left laser. (True: Laser ON, False: Laser OFF)</param>
        /// <param name="rightLaserState">State of the right laser. (True: Laser ON, False: Laser OFF)</param>
        public void LaserState(bool leftLaserState, bool rightLaserState)
        {
            this.SendCommand(leftLaserState ? ARDUINO_COMMANDS.LASER_LEFT_ON : ARDUINO_COMMANDS.LASER_LEFT_OFF);
            this.SendCommand(rightLaserState ? ARDUINO_COMMANDS.LASER_RIGHT_ON : ARDUINO_COMMANDS.LASER_RIGHT_OFF);
        }

        /// <summary>
        /// Method to toggle the laser state
        /// </summary>
        /// <param name="leftLaser">Parameter to choose the left or the right laser. (True: Left Laser, False: Right Laser)</param>
        public void LaserToggleState(LASER position)
        {
            switch (position)
            {
                case LASER.LEFT:  this.SendCommand(ARDUINO_COMMANDS.LASER_LEFT_TOGGLE); break;
                case LASER.RIGHT: this.SendCommand(ARDUINO_COMMANDS.LASER_RIGHT_TOGGLE); break;
                default: break;
            }
        }
        #endregion
    }
}
