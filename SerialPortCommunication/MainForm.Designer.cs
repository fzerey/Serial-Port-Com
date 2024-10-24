using System.Windows.Forms;

namespace SerialPortCommunication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connectButton = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.stopBitLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.receivedMessagesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.portSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.stringRadioButton = new System.Windows.Forms.RadioButton();
            this.hexRadioButton = new System.Windows.Forms.RadioButton();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.portSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(189, 274);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(92, 29);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(97, 22);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(121, 24);
            this.portComboBox.TabIndex = 1;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(28, 25);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 17);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "Port";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(28, 61);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(66, 17);
            this.baudRateLabel.TabIndex = 3;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(28, 98);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(65, 17);
            this.dataBitsLabel.TabIndex = 4;
            this.dataBitsLabel.Text = "Data Bits";
            // 
            // stopBitsLabel
            // 
            this.stopBitLabel.AutoSize = true;
            this.stopBitLabel.Location = new System.Drawing.Point(28, 137);
            this.stopBitLabel.Name = "stopBitsLabel";
            this.stopBitLabel.Size = new System.Drawing.Size(64, 17);
            this.stopBitLabel.TabIndex = 5;
            this.stopBitLabel.Text = "Stop Bits";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(28, 175);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(44, 17);
            this.parityLabel.TabIndex = 6;
            this.parityLabel.Text = "Parity";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "50",
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600"});
            this.baudRateComboBox.Location = new System.Drawing.Point(97, 58);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 24);
            this.baudRateComboBox.TabIndex = 7;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Items.AddRange(new object[] {
            "7",
            "8"});
            this.dataBitsComboBox.Location = new System.Drawing.Point(97, 98);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(121, 24);
            this.dataBitsComboBox.TabIndex = 8;
            // 
            // stopBitsComboBox
            // 
            this.stopBitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitComboBox.FormattingEnabled = true;
            this.stopBitComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.stopBitComboBox.Location = new System.Drawing.Point(97, 137);
            this.stopBitComboBox.Name = "stopBitsComboBox";
            this.stopBitComboBox.Size = new System.Drawing.Size(121, 24);
            this.stopBitComboBox.TabIndex = 9;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.parityComboBox.Location = new System.Drawing.Point(97, 175);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 24);
            this.parityComboBox.TabIndex = 10;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(91, 274);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(92, 29);
            this.disconnectButton.TabIndex = 13;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(296, 195);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(170, 22);
            this.messageTextBox.TabIndex = 15;
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Location = new System.Drawing.Point(472, 194);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 16;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // receivedMessagesRichTextBox
            // 
            this.receivedMessagesRichTextBox.Location = new System.Drawing.Point(296, 12);
            this.receivedMessagesRichTextBox.Name = "receivedMessagesRichTextBox";
            this.receivedMessagesRichTextBox.ReadOnly = true;
            this.receivedMessagesRichTextBox.Size = new System.Drawing.Size(251, 177);
            this.receivedMessagesRichTextBox.TabIndex = 17;
            this.receivedMessagesRichTextBox.Text = "";
            // 
            // portSettingsGroupBox
            // 
            this.portSettingsGroupBox.Controls.Add(this.refreshButton);
            this.portSettingsGroupBox.Controls.Add(this.stopBitComboBox);
            this.portSettingsGroupBox.Controls.Add(this.portComboBox);
            this.portSettingsGroupBox.Controls.Add(this.portLabel);
            this.portSettingsGroupBox.Controls.Add(this.baudRateLabel);
            this.portSettingsGroupBox.Controls.Add(this.dataBitsLabel);
            this.portSettingsGroupBox.Controls.Add(this.parityComboBox);
            this.portSettingsGroupBox.Controls.Add(this.stopBitLabel);
            this.portSettingsGroupBox.Controls.Add(this.parityLabel);
            this.portSettingsGroupBox.Controls.Add(this.dataBitsComboBox);
            this.portSettingsGroupBox.Controls.Add(this.baudRateComboBox);
            this.portSettingsGroupBox.Location = new System.Drawing.Point(12, 6);
            this.portSettingsGroupBox.Name = "portSettingsGroupBox";
            this.portSettingsGroupBox.Size = new System.Drawing.Size(269, 262);
            this.portSettingsGroupBox.TabIndex = 18;
            this.portSettingsGroupBox.TabStop = false;
            this.portSettingsGroupBox.Text = "Port Settings";
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.BackgroundImage")));
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.refreshButton.Location = new System.Drawing.Point(31, 201);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(57, 46);
            this.refreshButton.TabIndex = 21;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // stringRadioButton
            // 
            this.stringRadioButton.AutoSize = true;
            this.stringRadioButton.Checked = true;
            this.stringRadioButton.Location = new System.Drawing.Point(296, 223);
            this.stringRadioButton.Name = "stringRadioButton";
            this.stringRadioButton.Size = new System.Drawing.Size(66, 21);
            this.stringRadioButton.TabIndex = 19;
            this.stringRadioButton.TabStop = true;
            this.stringRadioButton.Text = "String";
            this.stringRadioButton.UseVisualStyleBackColor = true;
            // 
            // hexRadioButton
            // 
            this.hexRadioButton.AutoSize = true;
            this.hexRadioButton.Location = new System.Drawing.Point(296, 247);
            this.hexRadioButton.Name = "hexRadioButton";
            this.hexRadioButton.Size = new System.Drawing.Size(53, 21);
            this.hexRadioButton.TabIndex = 20;
            this.hexRadioButton.Text = "Hex";
            this.hexRadioButton.UseVisualStyleBackColor = true;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.connectionStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.connectionStatusLabel.Location = new System.Drawing.Point(205, 306);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(76, 17);
            this.connectionStatusLabel.TabIndex = 22;
            this.connectionStatusLabel.Text = "Connected";
            this.connectionStatusLabel.Visible = false;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(472, 223);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 336);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.hexRadioButton);
            this.Controls.Add(this.stringRadioButton);
            this.Controls.Add(this.portSettingsGroupBox);
            this.Controls.Add(this.receivedMessagesRichTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Serial Port Communication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.portSettingsGroupBox.ResumeLayout(false);
            this.portSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button connectButton;
        private ComboBox portComboBox;
        private Label portLabel;
        private Label baudRateLabel;
        private Label dataBitsLabel;
        private Label stopBitLabel;
        private Label parityLabel;
        private ComboBox baudRateComboBox;
        private ComboBox dataBitsComboBox;
        private ComboBox stopBitComboBox;
        private ComboBox parityComboBox;
        private Button disconnectButton;
        private TextBox messageTextBox;
        private Button sendButton;
        private RichTextBox receivedMessagesRichTextBox;
        private GroupBox portSettingsGroupBox;
        private RadioButton stringRadioButton;
        private RadioButton hexRadioButton;
        private Button refreshButton;
        private Label connectionStatusLabel;
        private Button clearButton;
    }
}
