using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLab
{
    class Country
    {
        public string name { get; set; }
        public string continent { get; set; }
        public List<string> colors { get; set; }

        public Country()
        {

        }
        
        public Country(string _name, string _continent, List<string> _colors)
        {
            name = _name;
            continent = _continent;
            colors = _colors;
        }
    }
}
