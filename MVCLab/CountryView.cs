using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class CountryView
    {
        public Country DisplayCountry { set; get; }
        
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.name}" +
                $"\nContinent: {DisplayCountry.continent}");

            Console.Write($"Colors: ");
            foreach(string color in DisplayCountry.colors)
            {
                Console.Write($"{color} ");
            }
            Console.WriteLine();
        }
    }
}
