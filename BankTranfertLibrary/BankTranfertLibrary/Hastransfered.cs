using System;
using System.Collections.Generic;
using System.Text;

namespace BankTranfertLibrary
{
    class Hastransfered
    {
        public void Transfert(decimal amount, string fromBankIban, string toBankIban)
        {
            Logger log = new Logger();
            BankTransfert bank = new BankTransfert();
            var hasTransfered = bank.EmulateTransfert(amount, fromBankIban, toBankIban);

            if (!hasTransfered)
            {
                log.Log(Severity.Error, "Transfert interrupted");
                throw new InvalidOperationException();
            }
        }
    }
}
