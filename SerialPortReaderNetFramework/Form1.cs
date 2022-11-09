using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortReaderNetFramework
{
    public partial class Form1 : Form
    {
        // Create the serial port with basic settings 
        private SerialPort port = new SerialPort("COM6", 9600, Parity.None, 8, StopBits.One);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startReadButton_Click(object sender, EventArgs e)
        {
            // Attach a method to be called when there
            // is data waiting in the port's buffer 
            port.DataReceived += Port_DataReceived;
            try
            {
                // Begin communications 
                port.Open();
                logTextBox.Text += $"{DateTimeOffset.Now} - Start reading on port {port.PortName}\r\n";
            }
            catch (Exception ex)
            {
                logTextBox.Text += $"{DateTimeOffset.Now} - Error: {ex.Message}\r\n";
                port.DataReceived -= Port_DataReceived;
                return;
            }

            // Enter an application loop to keep this thread alive 
            startReadButton.Enabled = false;
            stopReadButton.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopReadButton_Click(object sender, EventArgs e)
        {
            port.DataReceived -= Port_DataReceived;
            port.Close();
            logTextBox.Text += $"{DateTimeOffset.Now} - Stop reading on port {port.PortName}\r\n";
            startReadButton.Enabled = true;
            stopReadButton.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text)) {
                writeButton.Enabled = true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Begin communications 
                port.Open();
                logTextBox.Text += $"{DateTimeOffset.Now} - Start writing on port {port.PortName}\r\n";
                port.Write(writeTextBox.Text);
                logTextBox.Text += $"{DateTimeOffset.Now} - Written on port {port.PortName}\r\n";
                port.Close();
                writeTextBox.Text = "";
                writeButton.Enabled = false;
            }
            catch (Exception ex)
            {
                logTextBox.Text += $"{DateTimeOffset.Now} - Error: {ex.Message}\r\n";
                port.DataReceived -= Port_DataReceived;
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            this.readTextBox.Text += port.ReadExisting();
        }

    }
}
