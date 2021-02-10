using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningOffer
{
    class Program
    {
        public static void Main(string[] args)
        {          

            Property.PropertyLookUp();
            Console.Clear();
            
            Person.AddPerson(); // add buyer(s)
            Console.Clear();

            EMD.EarnestMoneyInfo(); // collect info on earnest money deposit
            Console.Clear();

            //Financing.FinancingInfo();// collect info on financing

            Contract.BeginOffer();// build the offer 
            
                 
        }
    }
}
