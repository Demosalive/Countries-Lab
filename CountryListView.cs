using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lab_14_Countries
{
    class CountryListView
    {
       public List<Country> Countries { get; set; }

        public CountryListView()
        {

        }
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            for(int i = 0; i < Countries.Count; i++)
            {
                Console.WriteLine($"{i}"+ " "+ $"{Countries[i].Name}");
            }
        }
    }
}
