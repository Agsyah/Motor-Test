using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace motor_test
{
    public partial class Form1 : Form
    {
        // Inisialisasi mavlink.
        MAVLink.MavlinkParse mavlink = new MAVLink.MavlinkParse();
        // byte sysid;
        // byte compid;

        public Form1()
        {
            InitializeComponent();

            portsCom.Items.Clear();

            foreach (string items in SerialPort.GetPortNames())
            {
                portsCom.Items.Add(items);
            }

            panel1.Height = 131;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    conBtn.Text         = "CONNECT";
                    baudCom.Enabled     = true;
                    portsCom.Enabled    = true;

                    for (int i = 10; i <= 131; i++)
                    {
                        panel1.Height = i;
                        System.Threading.Thread.Sleep(1);
                    }
                    panel1.BackColor    = Color.DarkRed;
                    return;
                }
                conBtn.Text             = "DISCONNECT";
                baudCom.Enabled         = false;
                portsCom.Enabled        = false;

                for(int i = 131; i >= 10; i--)
                {
                    panel1.Height = i;
                    System.Threading.Thread.Sleep(1);
                }
                panel1.BackColor        = Color.DarkGreen;

                serialPort1.BaudRate    = int.Parse(baudCom.Text);
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void portsCom_MouseClick(object sender, MouseEventArgs e)
        {
            portsCom.Items.Clear();

            foreach (string items in SerialPort.GetPortNames())
            {
                portsCom.Items.Add(items);
            }
        }

        public void doMotorTest(int motor, int throttle = 0, int duration = 0)
        {
            // deklarasi untuk pengiriman data paket.
            MAVLink.mavlink_command_long_t request = new MAVLink.mavlink_command_long_t();

            // mengarahkan dari aplikasi ke apm, tidak ke perangkat lain.
            request.target_system       = 1;
            request.target_component    = 1;

            // menentukan target command dari indeks DO_MOTOR_TEST (209).
            request.command = (ushort) MAVLink.MAV_CMD.DO_MOTOR_TEST;

            request.param1 = motor;
            request.param2 = (byte) MAVLink.MOTOR_TEST_THROTTLE_TYPE.MOTOR_TEST_THROTTLE_PERCENT;
            request.param3 = throttle;
            request.param4 = duration;

            byte[] packet = mavlink.GenerateMAVLinkPacket10(MAVLink.MAVLINK_MSG_ID.COMMAND_LONG, request);
            serialPort1.Write(packet, 0, packet.Length);
        }

        private void motorABtn_Click(object sender, EventArgs e)
        {
            int throttle = (int)throttleNum.Value;
            int duration = (int)durationNum.Value;

            doMotorTest(1, throttle, duration);
        }

        private void motorBBtn_Click(object sender, EventArgs e)
        {
            int throttle = (int)throttleNum.Value;
            int duration = (int)durationNum.Value;

            doMotorTest(2, throttle, duration);
        }

        private void motorCBtn_Click(object sender, EventArgs e)
        {
            int throttle = (int)throttleNum.Value;
            int duration = (int)durationNum.Value;

            doMotorTest(3, throttle, duration);
        }

        private void motorDBtn_Click(object sender, EventArgs e)
        {
            int throttle = (int)throttleNum.Value;
            int duration = (int)durationNum.Value;

            doMotorTest(4, throttle, duration);
        }

        private void motorStartBtn_Click(object sender, EventArgs e)
        {
            int throttle = (int)throttleNum.Value;
            int duration = (int)durationNum.Value;

            for (int i = 1; i <= 4; i++)
            {
                doMotorTest(i, throttle, duration);
            }
        }

        private void motorStopBtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                doMotorTest(i, 0, 0);
            }
        }
    }
}
