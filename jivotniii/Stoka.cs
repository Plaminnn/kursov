using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jivotniii
{
    internal class Stoka
    {
        private string Ime;
        private string Jivotno;
        internal readonly object Vid;

        public string ime
        {
            get { return Ime; }
            set { Ime = value; }

        }
        public string jivotno
        {
            get { return Jivotno; }
            set { Jivotno = value; }
        }
        public Stoka(string ime, string jivotno)
        {
            Ime = ime;
            Jivotno = jivotno;
        }

      
    }
}
