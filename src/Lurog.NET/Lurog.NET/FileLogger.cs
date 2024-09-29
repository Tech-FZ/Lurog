using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lurog.NET
{
    public class FileLogger : ILogger
    {
        public void Log(object sender, ErrorRaisedEventArgs e, string[,] addargs)
        {
            try
            {
                string filePath = "";

                for (int i = 0; i < addargs.Length; i++)
                {
                    if (addargs[i,0] == "filepath")
                    {
                        filePath = addargs[i,1];
                    }
                }

                if (string.IsNullOrEmpty(filePath))
                {
                    FileStream logStream = File.Open(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                    logStream.Write(Encoding.UTF8.GetBytes(e.Severity.ToString() + "\n"));
                    logStream.Write(Encoding.UTF8.GetBytes(e.ErrorCode + "\n"));
                    logStream.Write(Encoding.UTF8.GetBytes(e.TimeOccurence.ToString() + "\n"));
                    logStream.Write(Encoding.UTF8.GetBytes(e.Message + "\n\n"));

                    logStream.Flush();
                }
                

            }

            catch (Exception ex)
            {
                // insert stuff here
            }
        }
    }
}
