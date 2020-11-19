using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
   public interface ILogFileServises
    {
        bool WriteLog(string msg);
        string ReadLog();


    }
}
