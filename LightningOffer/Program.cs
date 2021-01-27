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

            EMD.EarnestMoneyInfo(); // collect info on earnest money deposit

            //Financing.FinancingInfo();// collect info on financing

            Contract.BeginOffer();// build the offer 
            
                 
        }
    }
}
