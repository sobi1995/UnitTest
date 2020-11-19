using Core.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiXUnit.Services
{
  public  class LogFileServisesTest
    {
        public LogFileServisesTest()
        {
        
        }
        [Fact]
        public void WriteLog_Test_By_Moq() {

            var paymentServiceMock = new Mock<ILogFileServises>();

        }
    }
}
