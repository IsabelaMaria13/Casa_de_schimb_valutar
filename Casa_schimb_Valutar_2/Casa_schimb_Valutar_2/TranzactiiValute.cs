using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Casa_schimb_Valutar_2
{
    [Serializable]
     public class TranzactiiValute
    {
        public float suma;
        private string valutaUnu;
        private string valutaDoi;
        private float curs;
        private float rezultat;

        public TranzactiiValute()
        {
            suma = 0f;
            valutaUnu = "";
            valutaDoi = "";
            curs = 0f;
            rezultat = 0f;
        }
        public TranzactiiValute(float s, string unu, string doi,float c, float r)
        {
            suma = s;
            valutaUnu = unu;
            valutaDoi = doi;
            curs = c;
            rezultat = r;
        }

        public float Suma
        {
            get { return suma; }
            set { suma = value; }
        }
        public string ValutaUnu
        {
            get { return valutaUnu; }
            set { valutaUnu = value; }
        }
        public string ValutaDoi
        {
            get { return valutaDoi; }
            set
            {
                valutaDoi = value;
            }
        }
        public float Curs
        {
            get { return curs; }
            set
            {
                curs = value;
            }
        }
        public float Rezultat
        {
            get { return rezultat; }
            set { rezultat = value; }
        }


    }
}
