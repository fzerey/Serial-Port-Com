using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialPortCommunication
{
    public partial class MainForm : Form
    {
        private SerialPort _serialPort;

        public MainForm()
        {
            InitializeComponent();
            InitializeSerialPort();
            PopulateAvailablePorts();
            ConfigureFormSettings();
        }

        private void InitializeSerialPort()
        {
            _serialPort = new SerialPort();
            _serialPort.DataReceived += SerialPortDataReceived;
        }

        private void ConfigureFormSettings()
        {
            CheckForIllegalCrossThreadCalls = false;
            Text = "Serial Port Communication";
            Icon = new System.Drawing.Icon("usblogo.ico");
        }

        private void PopulateAvailablePorts()
        {
            portComboBox.DataSource = SerialPort.GetPortNames();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectToSerialPort();
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void ConnectToSerialPort()
        {
            if (IsPortSettingsValid())
            {
                ConfigureSerialPortSettings();
                _serialPort.Open();
                UpdateUiForConnectionState(true);
            }
            else
            {
                ShowErrorMessage("Please select valid port settings.");
            }
        }

        private bool IsPortSettingsValid()
        {
            return !string.IsNullOrWhiteSpace(portComboBox.Text) &&
                   !string.IsNullOrWhiteSpace(baudRateComboBox.Text) &&
                   !string.IsNullOrWhiteSpace(dataBitsComboBox.Text) &&
                   !string.IsNullOrWhiteSpace(stopBitComboBox.Text) &&
                   !string.IsNullOrWhiteSpace(parityComboBox.Text);
        }

        private void ConfigureSerialPortSettings()
        {
            _serialPort.PortName = portComboBox.Text;
            _serialPort.BaudRate = int.Parse(baudRateComboBox.Text);
            _serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), parityComboBox.Text);
            _serialPort.DataBits = int.Parse(dataBitsComboBox.Text);
            _serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitComboBox.Text);
        }

        private void UpdateUiForConnectionState(bool isConnected)
        {
            connectButton.Enabled = !isConnected;
            disconnectButton.Enabled = isConnected;
            sendButton.Enabled = isConnected;
            portSettingsGroupBox.Enabled = !isConnected;
            connectionStatusLabel.Visible = isConnected;
            messageTextBox.ReadOnly = !isConnected;

            if (!isConnected)
            {
                messageTextBox.Clear();
            }
        }

        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var receivedData = _serialPort.ReadExisting();
            WriteToRichTextBox(receivedData);
        }

        private void WriteToRichTextBox(string text)
        {
            if (receivedMessagesRichTextBox.InvokeRequired)
            {
                Invoke(new Action<string>(WriteToRichTextBox), text);
            }
            else
            {
                receivedMessagesRichTextBox.AppendText(text);
            }
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.Close();
                UpdateUiForConnectionState(false);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (stringRadioButton.Checked)
                {
                    _serialPort.Write(messageTextBox.Text);
                }
                else
                {
                    var hexData = ConvertHexToByteArray(messageTextBox.Text);
                    _serialPort.Write(hexData, 0, hexData.Length);
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private byte[] ConvertHexToByteArray(string hexText)
        {
            hexText = hexText.Replace(" ", "");
            var byteArray = new byte[hexText.Length / 2];

            for (int i = 0; i < hexText.Length; i += 2)
            {
                byteArray[i / 2] = Convert.ToByte(hexText.Substring(i, 2), 16);
            }

            return byteArray;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            PopulateAvailablePorts();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            receivedMessagesRichTextBox.Clear();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
