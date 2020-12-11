
using Core.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ApiXUnit.Controllers
{
    public class StudentControllerTest
    {

        [Fact]
        public void Student_Test_add_Mock()
        {
            var logFileServises = new Mock<ILogFileServises>();
            logFileServises.Setup(p => p.WriteLog(It.IsAny<string>())).Returns(true);
        var a= logFileServises.Object.WriteLog("Fuck");
       

        }
    }
}