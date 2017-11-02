using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankTranfertLibrary
{
    class ExistFile
    {
        public void ErrorFile(string csvTitle)
        {
            if (!File.Exists(csvTitle))
            {
                using (StreamWriter sw = File.CreateText(csvTitle))
                {
                    sw.WriteLine("Transaction;Amount;From;To");
                }
            }
        }
    }
}
