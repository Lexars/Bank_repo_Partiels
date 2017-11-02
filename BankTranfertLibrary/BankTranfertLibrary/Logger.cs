using System;
using System.Collections.Generic;
using System.Text;

namespace BankTranfertLibrary
{
    public enum Severity
    {
        Info, 
        Warning,
        Error,
    }
    public class Logger
    {
        public void Log(Severity severity, string message)
        {
            var log = new Stream();
          // Console.WriteLine($"{severity.ToString()} - {message}");
            log.StreamWriter(Console.WriteLine($"{severity.ToString()} - {message}"), "BankTranfertLibrary\BankTransfertLibraryTest\bin\Debug\netcoreapp2.0");
        }
    }
}
