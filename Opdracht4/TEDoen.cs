using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoen
{
    internal class TEDoen
    {
        int autoId;

        public int Id;
        public DateTime? Tijdstip;
        public string Titel;
        public string[] Informatie;

        public TEDoen(DateTime? tijd, string titel, string[] informatie)
        {
            autoId++;
            Id = autoId;

            if (tijd != null)
            {
                Tijdstip = tijd;
            }
            else
            {
                Tijdstip = null;
            }

            Titel = titel;
            Informatie = informatie;
        }

        public override string ToString()
        {
            return Titel.ToString();
        }

        public void Meedelen(string titel, string[] inhoud, bool dringend)
        {
            Titel = titel;
            Informatie = inhoud;

            if (Tijdstip == null)
            {
                dringend = true;
            }
        }
    }
}
