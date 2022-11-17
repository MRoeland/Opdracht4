using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoen
{
    internal class TEDoen
    {
        int autoId = 0;

        public int Id;
        public DateTime? Tijdstip = null;
        public string Titel;
        public string[] Informatie = new string[0];

        public TEDoen(DateTime? tijd, string titel, string[] informatie)
        {
            autoId++;
            Id = autoId;
            Tijdstip = tijd;
            Titel = titel;
            Informatie = informatie;
        }

        public override string ToString()
        {
            return Titel.ToString() + " | " + Tijdstip.ToString();
        }

        public void Meedelen(string titel, string[] inhoud, bool dringend)
        {
            //Titel = titel;
            //Informatie = inhoud;
            titel = Titel;
            inhoud = Informatie;

            if (Tijdstip == null)
            {
                dringend = true;
            }
        }
    }
}
