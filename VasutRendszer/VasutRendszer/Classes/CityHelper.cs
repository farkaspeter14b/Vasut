using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VasutRendszer.Classes
{
    class CityHelper
    {
        public List<City> Cities = new List<City>();
        public CityHelper()
        {
            ReadAll();
        }
        public void ReadAll()
        {
            StreamReader read = new StreamReader("cities.txt");
            while (!read.EndOfStream)
            {
                string[] sor = read.ReadLine().Split(';');
                City c = new City();
                c.name = sor[0];
                Cities.Add(c);
            }
            read.Close();
        }

        public City Founder(string city) 
        {
            foreach (City item in Cities)
            {
                if (item.name == city)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
