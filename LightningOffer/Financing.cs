using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningOffer
{
    public class Financing
    {

        private bool Conventional { get; set; }
        private bool Fha { get; set; }
        private bool Va { get; set; }
        private bool ARM { get; set; }
        private bool Cash { get; set; }
        private bool EquityLine { get; set; }
        private int EquityAmount { get; set; }
        private bool ListingHoldingEscrow { get; set; }
        private bool SellingHoldingEscrow { get; set; }

        private bool Gift { get; set; }
        private int GiftAmount { get; set; }

        private bool OtherPayment { get; set; }
        private string OtherPaymentDescription { get; set; }
        private int OtherPaymentAmount { get; set; }

        private int downPaymentAmount { get; set; }
        private double downPaymentPercent { get; set; }


        public Financing()
        {
            Conventional = false;
            Fha = false;
            Va = false;
            ARM = false;
            Cash = false;
            EquityLine = false;
            EquityAmount = 0;
            ListingHoldingEscrow = false;
            SellingHoldingEscrow = false;

            Gift = false;
            GiftAmount = 0;

            OtherPayment = false;
            OtherPaymentDescription = "";
             OtherPaymentAmount = 0;

            downPaymentAmount = 0;
            downPaymentPercent = 0.0;
        }

        public static Financing AddFinancing()
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

            return finance;
        }

    }

}
