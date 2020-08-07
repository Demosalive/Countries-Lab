using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_14_Countries
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView()
        {

        }

        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }
        
        public void Display()
        {
            Console.WriteLine(DisplayCountry.Name,DisplayCountry.Continent,DisplayCountry.Colors);
        }
    }
}
