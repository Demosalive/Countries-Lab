using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_14_Countries
{
    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country()
        {
                
        }
        
        public Country(string name, string continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }
}
