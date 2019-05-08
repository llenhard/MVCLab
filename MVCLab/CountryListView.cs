using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class CountryListView
    {
        public List<Country> Countries { set; get; }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            foreach(Country country in Countries)
            {
                Console.WriteLine($"{Countries.IndexOf(country)+1}. {country.name}");
            }
        }
    }
}
