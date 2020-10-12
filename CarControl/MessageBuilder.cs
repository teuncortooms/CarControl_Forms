using System;

namespace CarControl
{
    class MessageBuilder
    {
        private string _incompleteMessage;
        public char EndMarker { get; private set; }

        public MessageBuilder()
        {
            EndMarker = '#';
            _incompleteMessage = null;
        }

        public string Add(string data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            string message;
            if (_incompleteMessage != null)
            {
                message = _incompleteMessage;
            }
            else
            {
                message = "";
            }

            Console.WriteLine(message);

            foreach (char character in data)
            {
                if (character == EndMarker)
                {
                    return message;
                }
                else
                {
                    message += character;
                }
            }
            _incompleteMessage = message;
            return "";
        }

        public void Clear()
        {
            _incompleteMessage = null;
        }
    }
}
