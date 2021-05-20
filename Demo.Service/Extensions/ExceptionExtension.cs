using Demo.Service.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public static class ExceptionExtension
    {
        public static void Log(this Exception exception)
        {
            new ErrorLogService().Log(exception);
        }
    }
}
