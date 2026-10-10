using Country_Business_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Country_Presentation_Layer
{
    internal class CountryPresentationLayer
    {
       static void testFindCountrybyID(int ID)
        {
            clsCountry contact = clsCountry.Find(ID);

            if (contact != null)
                Console.WriteLine("Country Name: " + contact.CountryName);
            else
                Console.WriteLine($"ID {ID} is not Found!!");


        }

        static void testFindCountrybyName(string Name)
        {
            clsCountry contact = clsCountry.Find(Name);

            if (contact != null)
                Console.WriteLine("Country ID: " + contact.ID);
            else
                Console.WriteLine($"ID {Name} is not Found!!");


        }

        static void testAddNewCountryt()
        {
            clsCountry Country2 = new clsCountry();

            Country2.CountryName = "Jordan";

            if (Country2.Save())
                Console.WriteLine("Add New Country Successfully and ID= " + Country2.ID);

            else
                Console.WriteLine("Add New Country Failed ");

        }

        static void testUpdateContact(int ID)
        {
            clsCountry Country = clsCountry.Find(ID);


            Country.CountryName = "Moracco";
            if(Country.Save())
                Console.WriteLine("Update is Successfully");

            else
                Console.WriteLine("Update is Failed");


        }

        static void testDeleteContact(int ID)
        {


            if(clsCountry.DeleteCountry(ID))
                Console.WriteLine("Country Deleted Successfully");

            else
                Console.WriteLine("The country with id = " + ID + " is not found");


        }

        static void testIsContactExist(int ID)
        {


            if (clsCountry.isCountryExist(ID))
                Console.WriteLine("Country is Existed");

            else
                Console.WriteLine("The country with id = " + ID + " is not found");


        }

        static void ListCountries()
        {

            DataTable dataTable = clsCountry.GetAllCountries();

            Console.WriteLine("Country Data:");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CountryName"]}");
            }

        }


        static void testIsContactExist(String CountryName)
        {

            if (clsCountry.isCountryExist(CountryName))
            Console.WriteLine("Country is found:");
            else
                Console.WriteLine($"Country Name is not Found!");


        }

        static void Main(string[] args)
        {

            testFindCountrybyID(10);
            //  testAddNewCountryt();
            //testUpdateContact(1);

            //testDeleteContact(2);
            //testIsContactExist(1);
            //testIsContactExist(10);
            //ListCountries();

            // testIsContactExist("Egypt");
           // testFindCountrybyName("Egypt");
        }
    }
}
