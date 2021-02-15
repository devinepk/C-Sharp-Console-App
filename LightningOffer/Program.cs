using System;
using System.Collections;
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

            //PROPERTY SECTION
            Console.Clear();
            Console.WriteLine("Please enter the property street address below: (i.e. 123 Main Street)");
            string address = Console.ReadLine();
            Property property = Property.PropertyLookUp(address);
            Console.Clear();

            //BUYER SECTION
            Console.WriteLine("How many buyers are there? Enter a number.");
            string input = Console.ReadLine();
            int numberOfBuyers = int.Parse(input); //convert the input to a number
            ArrayList ListOfBuyers = new ArrayList(); //creates the list to add each buyer to
            Person Buyer = Person.AddPerson(ListOfBuyers, numberOfBuyers); // pass in the listofbuyers and numberofbuyers            
            Console.Clear();

            //ERNEST MONEY DEPOSIT
            EMD emd = EMD.AddErnestMoneyInfo();
            Console.Clear();

            //FINANCING INFORMATION
            Financing fiancingInfo = Financing.AddFinancing();
            Console.Clear();

            //APPRAISAL
            Appraisal appraisal = Appraisal.

            Contract.BeginOffer();// build the offer 
            
                 
        }
    }
}
 