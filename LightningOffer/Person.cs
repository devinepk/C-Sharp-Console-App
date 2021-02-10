using System;
using System.Collections.Generic;
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

        public static void AddPerson()
        {
            Console.WriteLine("How many buyers are there?");
            Console.WriteLine("A) One buyer");
            Console.WriteLine("B) Two buyers");
            ConsoleKey consoleKey = Console.ReadKey().Key;
       

            try
            {
                if (consoleKey == ConsoleKey.A) //one buyer
                {
                    Console.Clear();
                    Person buyerOne = new Person(); //create the person

                    Console.WriteLine("What's the buyer's first name?"); //first name
                    buyerOne.FirstName = Console.ReadLine();
                    // TODO: capitalize the first name

                    Console.WriteLine("What's " + buyerOne.FirstName + "'s last name?"); //last name
                    buyerOne.LastName = Console.ReadLine();
                    // TODO: capitalize the first name

                    Console.WriteLine("What's " + buyerOne.FirstName + "'s email address?"); //email address
                    buyerOne.EmailAddress = Console.ReadLine();
                    // TODO: format the email address

                    Console.WriteLine("What's " + buyerOne.FirstName + "'s phone number? (enter it without any dashes or characters)"); //phone number
                    buyerOne.CellPhone = Console.ReadLine();
                    // TODO: format the cell phone number
                    return;
                }
                else if (consoleKey == ConsoleKey.B)//two buyers
                {
                    Console.Clear();
                    // first buyer
                    Person buyerOne = new Person(); //create the person

                    Console.WriteLine("What's the first buyer's first name?"); //first name
                    buyerOne.FirstName = Console.ReadLine();
                    // TODO: capitalize the first name

                    Console.WriteLine("What's the first buyer's last name?"); //last name
                    buyerOne.LastName = Console.ReadLine();
                    // TODO: capitalize the first name

                    Console.WriteLine("What's the first buyer's email address?"); //email address
                    buyerOne.EmailAddress = Console.ReadLine();
                    // TODO: format the email address

                    Console.WriteLine("What's the first buyer's phone number? (enter it without any dashes or characters)"); //phone number
                    buyerOne.CellPhone = Console.ReadLine();
                    // TODO: format the cell phone number

                    // second buyer
                    Person buyerTwo = new Person(); //create the person

                    Console.WriteLine("What's the second buyer's first name?"); //first name
                    buyerTwo.FirstName = Console.ReadLine();
                    // TODO: capitalize the first name

                    Console.WriteLine("What's the second buyer's last name?"); //last name
                    buyerTwo.LastName = Console.ReadLine();
                    // TODO: capitalize the first name

                    Console.WriteLine("What's the second buyer's email address?"); //email address
                    buyerTwo.EmailAddress = Console.ReadLine();
                    // TODO: format the email address

                    Console.WriteLine("What's the second buyer's phone number? (enter it without any dashes or characters)"); //phone number
                    buyerTwo.CellPhone = Console.ReadLine();
                    // TODO: format the cell phone number
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong with the add person method.");
                Console.WriteLine(e.Message);
            }

            
        }


    }
}
