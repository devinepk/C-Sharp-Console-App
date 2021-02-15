using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningOffer
{
    public class EMD
    {


        bool Cash;
        bool EquityLine;
        bool Gift;
        bool Other;


        public static EMD AddErnestMoneyInfo()
        {

            ConsoleKey consoleKey = Console.ReadKey().Key;
           
            EMD emd = new EMD();

            Console.WriteLine("Where is the money coming from?");//Source of EMD
            Console.WriteLine("1) Cash");
            Console.WriteLine("2) Equity Line");
            Console.WriteLine("3) Gift");
            Console.WriteLine("4) Other");

            
            if (consoleKey == ConsoleKey.D1)
            {

                emd.Cash = true;

            } else if (consoleKey == ConsoleKey.D2)
            {

                emd.EquityLine = true;

            } else if (consoleKey == ConsoleKey.D3)
            {

                emd.Gift = true;

            } else if (consoleKey == ConsoleKey.D4)
            {

                emd.Other = true;

            }

            if (emd.Cash == true || emd.EquityLine == true || emd.Gift == true)
            {

                Console.WriteLine("How much is the EMD (Earnest Money Deposit)?  Use numbers only (i.e. 235000)"); // EMD amount
                string input = Console.ReadLine();
                int amount = int.Parse(input);

            } else if (emd.Other == true)
            {

                Console.WriteLine("Where is the ernest money deposit coming from?"); // EMD amount
                string otherEMD = Console.ReadLine();
                

                Console.WriteLine("How much is the EMD (Earnest Money Deposit)?  Use numbers only (i.e. 235000)"); // EMD amount
                string input = Console.ReadLine();
                int amount = int.Parse(input);

            }


            return emd;

        }
    }

}
