using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> usaColor = new List<string>{"red", "white", "blue"}, canadaColor = new List<string> {"red", "white"}, chinaColor = new List<string> {"red", "yellow"};
            List<Country> CountryDB = new List<Country> {new Country("USA", "North America", usaColor), new Country("Canada", "North America", canadaColor), new Country("China", "Asia", chinaColor)};
            CountryController master = new CountryController(CountryDB);

            do
            {
                master.WelcomeAction();
                master.SelectCountry(Console.ReadLine());

                Console.WriteLine("Would you like to try another country? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");
        }
    }
}
