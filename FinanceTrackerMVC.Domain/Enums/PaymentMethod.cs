using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceTrackerMVC.Domain.Enums
{
    public enum PaymentMethod
    {
        Cash,
        CreditCard,
        QRCodePayment,
        EWallet,
        BankTransfer,
        DuitNow
    }
}
