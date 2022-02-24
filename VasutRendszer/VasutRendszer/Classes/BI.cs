using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VasutRendszer.Classes
{
    public class BI
    {
        CityHelper ch;
        RailwayHelper rh;
        public bool vanbejelentkezes = false;
        #region Singleton initialization
        private static readonly object padlock = new object();
        private static BI _instance;

        public static BI Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new BI();
                        }
                    }
                }

                return _instance;
            }
        }
        #endregion
        public BI()
        {
            ch = new CityHelper();
            rh = new RailwayHelper(ch);
        }
        public void Celpontok(string honnan)
        {
            City city = ch.Founder(honnan);
            List<Railway> r = rh.HonnanKeres(city);
        }
    }
}
