using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningOffer
{
    public class EMD
    {
        int Amount = 0;

        public static void EarnestMoneyInfo()
        {
            EMD Emd1 = new EMD();

            Console.WriteLine("How much is the EMD (Earnest Money Deposit)?  Use numbers only (i.e. 235000)"); // EMD amount
            Emd1.Amount = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
    }

}
