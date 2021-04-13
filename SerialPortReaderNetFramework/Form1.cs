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
        private SerialPort port = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
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
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            port.DataReceived -= Port_DataReceived;
            port.Close();
            logTextBox.Text += $"{DateTimeOffset.Now} - Stop reading on port {port.PortName}\r\n";
            startButton.Enabled = true;
            stopButton.Enabled = false;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            this.readTextBox.Text += port.ReadExisting();
        }
    }
}
