using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System;

namespace CarControl
{
    public partial class CarControlForm : Form
    {
        readonly Messenger _messenger;
        readonly MessageBuilder _messageBuilder;

        public CarControlForm()
        {
            InitializeComponent();

            _messageBuilder = new MessageBuilder();
            _messenger = new Messenger("COM4", 115200, _messageBuilder);
            ConnectToPort();

            Timer myTimer = new Timer();
            myTimer.Tick += new EventHandler(Timer_Tick);
            myTimer.Interval = 10;
            myTimer.Enabled = true;
        }

        private void ConnectToPort()
        {
            try
            {
                _messenger.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                tb_Received.AppendText("\r\n" + "No connection");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string message = _messenger.ReadMessages();
            if (message != null && message != "")
            {
                ProcessReceivedMessage(message);
            }
        }

        private void ProcessReceivedMessage(string message)
        {
            message = message.Trim();
            tb_Received.AppendText("\r\n" + message);
            // TODO: Fill in message handling below
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            ConnectToPort();
        }
    }
}
