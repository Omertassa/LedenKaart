using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ledenkaart_Verzender
{
    class Logger
    {

        public string GetTempPath()
        {


            string path = System.Windows.Forms.Application.StartupPath + "\\Logging";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                {
                    Directory.CreateDirectory(path);
                }
            }

            if (!path.EndsWith("\\")) path += "\\";
            return path;
        }

        public void LogMessageToFile(string msg)
        {
            System.IO.StreamWriter sw = System.IO.File.AppendText(
                GetTempPath() + "Log bestand.txt");
            try
            {
                string logLine = System.String.Format(
                    "{0:G}: {1}", System.DateTime.Now, msg);
                sw.WriteLine(logLine);
            }
            finally
            {
                sw.Close();
            }
        }
    }
}
