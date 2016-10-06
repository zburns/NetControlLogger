using System;
using System.Collections.Generic;
using System.Text;

namespace NetControlLogger
{
    class Log
    {
        static public void LogError(string Error, System.Exception Exception)
        {
            try
            {
                System.IO.TextWriter output = System.IO.File.AppendText("ErrorLog.log");
                output.WriteLine(Error + " Exception" + Exception.StackTrace);
                output.Flush();
                output.Close();
                output.Dispose();
                output = null;
            }
            catch (System.Exception SeriousException)
            {
                throw new System.Exception("An serious error occurred and could not be logged...." + SeriousException.Message);
            }
        }

        static public void LogMessage(string NetName, string TextToLog)
        {
            try
            {
                System.IO.TextWriter output = System.IO.File.AppendText((NetName == null ? "Generic Net" : NetName)+ "-" + System.DateTime.Now.ToString("MM-dd-yyyy") + ".log");
                output.WriteLine((NetName==null ? "Generic Net" : NetName) + ":" + System.DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss") + ":" + TextToLog);
                output.Flush();
                output.Close();
                output.Dispose();
                output = null;
            }
            catch (System.Exception SeriousException)
            {
                try
                {
                    LogError("Unable to log event.", SeriousException);
                }
                catch
                {

                }
            }
        }
    }
}
