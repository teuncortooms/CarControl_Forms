using System;
using System.IO.Ports;

namespace CarControl
{
    class Messenger
    {
        private readonly SerialPort _port;
        private readonly MessageBuilder _messageBuilder;
        public int BaudRate { get { return _port.BaudRate; } }
        public string PortName { get { return _port.PortName; } }

        public Messenger(string portName, int baudRate, MessageBuilder messageBuilder)
        {
            if (portName == null)
            {
                throw new ArgumentNullException("portName");
            }
            if (baudRate < 9600)
            {
                throw new ArgumentOutOfRangeException("baudRate");
            }
            if (messageBuilder == null)
            {
                throw new ArgumentNullException("messageBuilder");
            }
            _port = new SerialPort(portName, baudRate);
            _messageBuilder = messageBuilder;
        }

        public void Connect()
        {
            if (!_port.IsOpen)
            {
                _port.Open();
                if (_port.IsOpen)
                {
                    _port.DiscardInBuffer();
                    _port.DiscardOutBuffer();
                }
            }
        }

        public void Disconnect()
        {
            if (_port.IsOpen)
            {
                _port.Close();
            }
        }

        public string[] GetAvailablePortNames()
        {
            return SerialPort.GetPortNames();
        }

        public bool IsConnected()
        {
            return _port.IsOpen;
        }

        public bool SendMessage(string message)
        {
            if (_port.IsOpen)
            {
                _port.Write(message + _messageBuilder.EndMarker);
                return true;
            }
            return false;
        }

        public string ReadMessages()
        {
            if (_port.IsOpen && _port.BytesToRead > 0)
            {
                string data = _port.ReadExisting();
                return _messageBuilder.Add(data);
            }
            return null;
        }
    }
}

