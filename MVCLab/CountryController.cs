using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class CountryController
    {
        public List<Country> CountryDB { set; get; }

        public CountryController(List<Country> countryDB)
        {
            CountryDB = countryDB;
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView cl = new CountryListView(CountryDB);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
            cl.Display();
        }
        
        public void SelectCountry(string input)
        {//not sure what the best naming convention is for 1 use objects like this
            //I've mostly observed people doing 1/2 letters though
            try
            {
                CountryView cv = new CountryView(CountryDB[int.Parse(input)-1]);
                cv.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine("That isn't a valid country! Please select a countries index from the list.");
                SelectCountry(Console.ReadLine());
            }
        }
    }
}
