using System;
using System.IO.Ports;
using System.Windows.Forms;
namespace SerialPortCommunication
{
    public partial class Form1 : Form
    {
        static SerialPort serialPort1 = new SerialPort();
        public Form1()
        {
            InitializeComponent();
            GetPorts();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Text = "Serial Port Com";
            this.Icon = new System.Drawing.Icon("usblogo.ico");
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {

            try
            {
                ConnectPort();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConnectPort()
        {
            try
            {
                //conn.Open();
                serialPort1 = new SerialPort();
                if (cmbPorts.Text == "" || cmbBaudRates.Text == "" || cmbDataBits.Text == "" || cmbStopBit.Text == "" || cmbParity.Text == "")
                {
                    MessageBox.Show("Please select port settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    serialPort1.PortName = cmbPorts.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmbBaudRates.Text);
                    serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cmbParity.Text);
                    serialPort1.DataBits = int.Parse(cmbDataBits.Text);
                    serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmbStopBit.Text);
                    serialPort1.Open();
                    serialPort1.DataReceived += SerialPortDataReceived;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    btnSend.Enabled = true;
                    groupBox1.Enabled = false;
                    lblConnect.Visible = true;
                    textBox1.ReadOnly = false;
                }

            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorised Access", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void GetPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.DataSource = ports;
        }

        delegate void SetTextCallBack(string text);
        private void WriteToRichBox(string text)
        {
            if (this.richTextBox1.InvokeRequired)
            {
                SetTextCallBack del = new SetTextCallBack(WriteToRichBox);
                this.Invoke(del, new object[] { text });
            }
            else
            {
                this.richTextBox1.AppendText(text);
            }
        }
        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialPort = (SerialPort)sender;
            var data = serialPort.ReadExisting();
            WriteToRichBox(data);
        }


        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnConnect.Enabled = true;
                btnSend.Enabled = false;
                btnDisconnect.Enabled = false;
                groupBox1.Enabled = true;
                lblConnect.Visible = false;
                textBox1.Clear();
                textBox1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rdString.Checked == true)
            {
                try
                {
                    serialPort1.Write(textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                try
                {
                    byte[] data = HexToByte(textBox1.Text);
                    serialPort1.Write(data,0,data.Length);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private byte[] HexToByte(string text)
        {
            text = text.Replace(" ", " ");
            byte[] buffer = new byte[text.Length / 2];
            for(int i = 0; i < text.Length; i+=2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(text.Substring(i, 2), 16);
            }
            return buffer;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetPorts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
                serialPort1.Close();
        }

        
            
    }
}
