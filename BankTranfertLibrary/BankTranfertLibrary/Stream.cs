using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BankTranfertLibrary
{
   public class Stream
    {
        public void StreamWriter(uint transactionId, decimal amount, string fromBankIban, string toBankIban,string csvTitle)
        {

            var line = $"{transactionId};{amount};{fromBankIban};{toBankIban}";
            using (StreamWriter sw = File.AppendText(csvTitle))
            {
                sw.WriteLine(line);
            }

        }
        public void StreamWriter(string log,string path)
        {

          
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(log);
            }

        }
    }
}
