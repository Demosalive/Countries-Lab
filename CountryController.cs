using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab_14_Countries
{
    class CountryController
    {
        public List<Country> CountryDB { get; set; }

        public CountryController()
        {

        }
        public CountryController(List<Country> countryDB)
        {
            CountryDB = countryDB;
        }
        public void CountryAction(Country c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display();
        }
        public void WelcomeAction()
        {
            CountryListView countryViewList = new CountryListView(CountryDB);

            Console.WriteLine("Hello, welcome to the country app.  Please select a country from the following list: ");
            string response = "y";

            while (response == "y")
            {
                countryViewList.Display();

                Console.WriteLine("Please select number");
                int answer = int.Parse(Console.ReadLine());
                CountryAction(CountryDB[answer]);

                Console.WriteLine("Would you like to learn about another country? (y/n)");
                response = Console.ReadLine().ToLower();

                if (response != "y" && response != "n")
                {
                    while (response != "y" && response != "n")
                    {
                        Console.WriteLine("Please choose y or n");
                        response = Console.ReadLine();
                    }
                }
                if (response == "n")
                {
                    Console.WriteLine("Goodbye");
                }
            }
        }
    }
}
