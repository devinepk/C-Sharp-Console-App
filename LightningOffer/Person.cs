using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightningOffer
{
    public class Person
    {
        public int Id { get; set; }
        public string CellPhone { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private Person()
        {
            CellPhone = "555-555-5555";
            EmailAddress = "blank@noemail.com";
            FirstName = "NoFirstName";
            LastName = "NoLastName";
        }

        public static Person AddPerson(ArrayList listOfBuyers, int numberOfBuyers)
        {
          
            Person buyer = new Person(); //creates the person object

            try
            {
                for (int i = 0; i < numberOfBuyers; i++)
                {
                    
                    Console.WriteLine("What's the buyer's first name?"); //first name
                    buyer.FirstName = Console.ReadLine(); // TODO: capitalize the first name
                    

                    Console.WriteLine("What's " + buyer.FirstName + "'s last name?"); //last name
                    buyer.LastName = Console.ReadLine();  // TODO: capitalize the first name
                    

                    Console.WriteLine("What's " + buyer.FirstName + "'s email address?"); //email address
                    buyer.EmailAddress = Console.ReadLine();  // TODO: format the email address
                   

                    Console.WriteLine("What's " + buyer.FirstName + "'s phone number? (enter it without any dashes or characters)"); //phone number
                    buyer.CellPhone = Console.ReadLine();   // TODO: format the cell phone number

                    listOfBuyers.Add(buyer);
                    Console.Clear();
                }

                

                return buyer;
    

            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong with the add person method.");
                Console.WriteLine(e.Message);
                return buyer;
            }


        }


    }
}
