using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningOffer
{
    class Appraisal
    {
        public bool Lender { get; set; }
        public bool Cash { get; set; }
        public bool NotContingent { get; set; }

        private Appraisal()
        {
            Lender = false;
            Cash = false;
            NotContingent = false;
        }

        public static Appraisal AddAppraisal()
        {

            ConsoleKey consoleKey = Console.ReadKey().Key;

            Appraisal propertyAppraisal = new Appraisal();

            Console.WriteLine("Is this contingent on an appraisal?");
            Console.WriteLine("1) No");
            Console.WriteLine("2) Yes");


            if (consoleKey == ConsoleKey.D1)
            {

                propertyAppraisal.NotContingent = true;
                Console.WriteLine("This contract is not contingent on an appraisal");

            }
            else if (consoleKey == ConsoleKey.D2)
            {

                Console.WriteLine("Is this transaction involving a lender or a cash transaction/private finance/contract for deed?");
                Console.WriteLine("1) Lender");
                Console.WriteLine("2) Cash transaction/private finance/contract for deed");

                if (consoleKey == ConsoleKey.D1)
                {

                    propertyAppraisal.Lender = true;

                }
                else
                if (consoleKey == ConsoleKey.D2)
                {

                    propertyAppraisal.Cash = true;

                }

            }

            return propertyAppraisal; ;
        }

    }
}
