using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningOffer
{
    public class Financing
    {

        bool Conventional = false;
        bool Fha = false;
        bool Va = false;
        bool ARM = false;
        bool Cash = false;
        bool EquityLine = false;
        int EquityAmount = 0;
        bool ListingHoldingEscrow = false;
        bool SellingHoldingEscrow = false;

        bool Gift = false;
        int GiftAmount = 0;

        bool OtherPayment = false;
        string OtherPaymentDescription = "";
        int OtherPaymentAmount = 0;

        int downPaymentAmount = 0;
        double downPaymentPercent = 0.0;



        public static void FinancingInfo()
        {
            Financing finance = new Financing();

            Console.WriteLine("Enter the offer amount using numbers only (i.e. 235000)"); // amount the buyer wants to offer
            int purchasePrice = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            ConsoleKey consoleKey = Console.ReadKey().Key;
         

            Console.WriteLine("How are they paying for the house? Choose an option below:"); // list the financing options
            Console.WriteLine("1) Cash");
            Console.WriteLine("2) Financing, Equity Line, Gift, Other");
            Console.ReadKey();


            if (consoleKey == ConsoleKey.D1) //cash
            {
                finance.Cash = true;
            }
            else if (consoleKey == ConsoleKey.D2)//financing
            {
                Console.Clear();
                Console.WriteLine("Select the type of financing below:");
                Console.WriteLine("1) Conventional Loan");
                Console.WriteLine("2) FHA Finacing");
                Console.WriteLine("3) VA Financing");
                Console.WriteLine("4) Adjustable Rate Mortgage");
                Console.WriteLine("5) Equity Line");
                Console.WriteLine("6) Gift");
                Console.WriteLine("7) Other Payment Method");
            }
            if (consoleKey == ConsoleKey.D1)//Conventional financing
            {
                finance.Conventional = true;
                finance.downPaymentPercent = 0.20;
                finance.downPaymentPercent = (purchasePrice * finance.downPaymentAmount);
            }
            else if (consoleKey == ConsoleKey.D2)//FHA
            {
                finance.Fha = true;
                finance.downPaymentPercent = 0.03;
                finance.downPaymentPercent = (purchasePrice * finance.downPaymentAmount);
            }
            else if (consoleKey == ConsoleKey.D3)//VA
            {
                finance.Va = true;
                finance.downPaymentPercent = 0.00;
                finance.downPaymentPercent = (purchasePrice * finance.downPaymentAmount);
            }
            else if (consoleKey == ConsoleKey.D4)//ARM
            {
                finance.ARM = true;
                finance.downPaymentPercent = 0.03;
                finance.downPaymentPercent = (purchasePrice * finance.downPaymentAmount);
            }
            else if (consoleKey == ConsoleKey.D5)//Equity Line
            {
                Console.WriteLine("How much is the buyer using from their equity? Enter numbers only (i.e. 235000)"); 
                finance.EquityAmount = Convert.ToInt32(Console.ReadLine());
                finance.EquityLine = true;
            }
            else if (consoleKey == ConsoleKey.D6)//Gift
            {
                Console.WriteLine("How much is the gift the buyer is using? Enter numbers only (i.e. 235000)"); 
                finance.GiftAmount = Convert.ToInt32(Console.ReadLine());
                finance.Gift = true;
            }
            else if (consoleKey == ConsoleKey.D7)//Other
            {
                Console.WriteLine("Please write a short description of the financing below:");
                finance.OtherPaymentDescription = Console.ReadLine();

                Console.WriteLine("How much is the amount of this other financing? Enter numbers only (i.e. 235000)");
                finance.OtherPaymentAmount = Convert.ToInt32(Console.ReadLine());
                finance.OtherPayment = true;
            }

            Console.WriteLine("Which company will be holding the Earnest Money Desposit"); // END holding company
            Console.WriteLine("1) Listing Broker (seller's agent)");
            Console.WriteLine("2) Selling Broker (buyer's agent)");
            Console.ReadKey();

            if (consoleKey == ConsoleKey.D1)
            {
                finance.ListingHoldingEscrow = true;
            } else if (consoleKey == ConsoleKey.D2)
            {
                finance.SellingHoldingEscrow = true;
            }

        }

    }

}
