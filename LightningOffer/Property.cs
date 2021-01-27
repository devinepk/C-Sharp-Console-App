using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.Configuration;
using System.Collections.Specialized;

namespace LightningOffer
{
    public class Property
    {

        public static void PropertyLookUp()
        {
            Console.WriteLine("Please enter the property street address below: (i.e. 123 Main Street)");
            string address = Console.ReadLine();

            //append the entered address to the request
            var addressentered = "https://api.datafiniti.co/v4/properties/search?address=" + address;

            //access the api key from the app.config file
            string bearertoken = string.Empty;
            var apikeys = ConfigurationManager.GetSection("ApiKeys") as NameValueCollection;
            if(apikeys != null)
            {
                bearertoken = apikeys["datafiniti"].ToString();
            }

            var client = new RestClient(addressentered);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", bearertoken);
            request.AddParameter("application/json", "{\r\n    \"query\": \"address:\\\"" + address + "\\\" AND mlsNumber:* AND statuses.type:\\\"For Sale\\\" AND postalCode:(40067 OR 40022 OR 40065 OR 40003 OR 40076 OR 40057 OR 40019 OR 40601) AND country:(US)\",\r\n    \"num_records\": 1\r\n}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            string json = response.Content;

            try
            {
                
                if (response.Content.Length > 43)
                {


                    //Record newProperty = new Property.Record(); // create property object and attributes

                    object newProperty = JsonConvert.DeserializeObject(json);

                    Broker listingBroker = new Property.Broker(); // create broker object and attributes


                    Console.WriteLine(response.Content);
                  ///  string propertyAddress = newProperty.address;
                  ///  string mlsNumber = newProperty.mlsNumber;
                  ///  string[] propertyImage = newProperty.imageURLs;

                    string listAgent = listingBroker.agent;
                    string listCompany = listingBroker.company;
                    string[] listPhone = listingBroker.phones;

                    Console.WriteLine("We've successfully located the mls listing of " + address + ". Please press any key to continue with your offer."); //confirm the listing was found  -- Console.WriteLine(response.Content)
                  //  CreateOfferFile( address,  propertyAddress,  mlsNumber,  listCompany,  listAgent, listPhone);                
                }
                else
                {
                    Console.WriteLine(address + " is not listed as active in the MLS. Please enter another address:");
                    PropertyLookUp();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static void CreateOfferFile(string address, string propertyAddress, string mlsNumber, string listCompany, string listAgent, string[] listPhone)
        {
            try
            {
                string path = @"C:\Users\pdevine\OneDrive - Bastian Solutions\Desktop\Personal Projects\LightningOffer\Offers\";
                string fileName = address + ".txt";
                string fullpath = path + fileName;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fullpath))
                {
                    file.WriteLine("An offer for " + propertyAddress + "(MLS Number: " + mlsNumber + ") was created at " + DateTime.Now.ToShortDateString() + ".");
                    file.WriteLine("It is listed by " + listAgent + ", with " + listCompany + ".");
                    
                }
            } catch (Exception e)
            {
                Console.WriteLine("Sorry, we were unable to create the file.");
                Console.WriteLine(e.Message);
            }
        }

        public class Rootobject
        {
            public int num_found { get; set; }
            public int total_cost { get; set; }
            public Record[] records { get; set; }
        }

        public class Record
        {
            public string address { get; set; }
            public Broker[] brokers { get; set; }
            public string city { get; set; }
            public string country { get; set; }
            public DateTime dateAdded { get; set; }
            public DateTime dateUpdated { get; set; }
            public Description[] descriptions { get; set; }
            public string[] domains { get; set; }
            public Feature[] features { get; set; }
            public Fee[] fees { get; set; }
            public int floorSizeValue { get; set; }
            public string floorSizeUnit { get; set; }
            public string geoLocation { get; set; }
            public string[] imageURLs { get; set; }
            public string[] keys { get; set; }
            public string latitude { get; set; }
            public string listingName { get; set; }
            public string longitude { get; set; }
            public float lotSizeValue { get; set; }
            public string lotSizeUnit { get; set; }
            public string mostRecentStatus { get; set; }
            public string mlsNumber { get; set; }
            public Nearbyschool[] nearbySchools { get; set; }
            public string[] neighborhoods { get; set; }
            public int numBathroom { get; set; }
            public int numBedroom { get; set; }
            public int numFloor { get; set; }
            public string[] parking { get; set; }
            public Person[] people { get; set; }
            public string[] phones { get; set; }
            public string postalCode { get; set; }
            public Price[] prices { get; set; }
            public Propertytax[] propertyTaxes { get; set; }
            public string propertyType { get; set; }
            public string province { get; set; }
            public string[] sourceURLs { get; set; }
            public Status[] statuses { get; set; }
            public string[] websiteIDs { get; set; }
            public string id { get; set; }
        }

        public class Broker
        {
            public string[] sourceURLs { get; set; }
            public DateTime dateSeen { get; set; }
            public string agent { get; set; }
            public string company { get; set; }
            public string[] phones { get; set; }
        }

        public class Description
        {
            public string value { get; set; }
            public string[] sourceURLs { get; set; }
            public DateTime dateSeen { get; set; }
        }

        public class Feature
        {
            public string key { get; set; }
            public string[] value { get; set; }
        }

        public class Fee
        {
            public string type { get; set; }
            public string[] sourceURLs { get; set; }
            public DateTime[] dateSeen { get; set; }
            public string currency { get; set; }
            public int amountMin { get; set; }
            public int amountMax { get; set; }
        }

        public class Nearbyschool
        {
            public DateTime dateSeen { get; set; }
            public string name { get; set; }
            public string[] sourceURLs { get; set; }
            public string[] gradeLevels { get; set; }
            public string country { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string postalCode { get; set; }
            public string province { get; set; }
            public string assigned { get; set; }
            public string distanceUnit { get; set; }
            public float distanceValue { get; set; }
        }

        public class Person
        {
            public DateTime dateSeen { get; set; }
            public string name { get; set; }
            public string title { get; set; }
        }

        public class Price
        {
            public int amountMax { get; set; }
            public int amountMin { get; set; }
            public string availability { get; set; }
            public string currency { get; set; }
            public DateTime[] dateSeen { get; set; }
            public string isSale { get; set; }
            public string isSold { get; set; }
            public float pricePerSquareFoot { get; set; }
            public string[] sourceURLs { get; set; }
            public string comment { get; set; }
            public DateTime date { get; set; }
        }

        public class Propertytax
        {
            public int amount { get; set; }
            public string currency { get; set; }
            public string[] sourceURLs { get; set; }
            public DateTime[] dateSeen { get; set; }
        }

        public class Status
        {
            public string type { get; set; }
            public string[] sourceURLs { get; set; }
            public DateTime[] dateSeen { get; set; }
            public DateTime date { get; set; }
        }


    }
}
