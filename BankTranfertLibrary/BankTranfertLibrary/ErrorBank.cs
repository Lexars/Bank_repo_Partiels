using System;
using System.Collections.Generic;
using System.Text;

namespace BankTranfertLibrary
{
    class ErrorBank
    {
        Logger log = new Logger();
        public void handle(string fromBankIban, string toBankIban)
        {
            if (string.IsNullOrEmpty(fromBankIban) || string.IsNullOrEmpty(toBankIban))
            {
                log.Log(Severity.Error, "Both IBAN should have a value");
                throw new ArgumentNullException();
            }
        }
    }
}
