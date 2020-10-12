using System.Collections.Generic;

namespace CarControl
{
    class Logger
    {
        static public List<string> logTexts = new List<string>();

        static public List<string> Log(string action)
        {
            logTexts.Add(action);
            return logTexts;
        }
    }
}

