using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VasutRendszer.Classes
{
    class RailwayHelper
    {
        public List<Railway> Vonalak = new List<Railway>();
        public RailwayHelper(CityHelper ch)
        {
            ReadLines(ch);
        }
        public void ReadLines(CityHelper help)
        {
            StreamReader read = new StreamReader("railways.txt");
            while (!read.EndOfStream)
            {
                string[] sor = read.ReadLine().Split(';');
                Railway r = new Railway();
                r.Honnan = help.Founder(sor[0]);
                r.Hova = help.Founder(sor[1]);
                r.Tav = int.Parse(sor[2]);
                Vonalak.Add(r);
            }
            read.Close();
        }
        public List<Railway> HonnanKeres(City city)
        {
            return Vonalak.Where(x => x.Honnan == city).ToList();
        }
    }
}
