using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class LogFileServises : ILogFileServises
    {
        public string FileName { get; set; }

        public LogFileServises()
        {
            FileName = $"{Directory.GetCurrentDirectory()}//log.txt";

        }

        public bool WriteLog(string msg)
        {
            try
            {
                if (!File.Exists(FileName))
                    File.Create(FileName);
                System.IO.File.WriteAllText(FileName, $"{DateTime.Now} => {msg}");
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


        }

        public string ReadLog()
        {
            try
            {
                return System.IO.File.ReadAllText(FileName);
            }
            catch (Exception ex)
            {

           
                throw   new System.ArgumentException("error when read file", ex); ;
            }
      
        }
    }
}
