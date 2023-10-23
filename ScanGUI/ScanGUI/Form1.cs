using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
namespace ScanGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbComport.Items.Add(port);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbComport_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cbComport.Text;

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cbComport.Text == "")
            {
                MessageBox.Show("Slect COM Port", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show("COM Port is connetd and ready for use !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        serialPort1.Open();
                        tbStatus.BackColor = Color.Lime;
                        tbStatus.Text = "Connecting....";
                        cbComport.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("COM Port is not found Please Check your COM Port !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    tbStatus.BackColor = Color.Red;
                    tbStatus.Text = "Disconnted";
                    cbComport.Enabled = true;

                }
                else
                {
                    MessageBox.Show("COM Port is disconnetd and ready for use !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM Port is not found Please Check your COM Port !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
