using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_schimb_Valutar_2
{
    
    public enum tipTranzactie
    {
        RON=0,
        USD=1,
        EUR=2,
        GBP=3,
        CHF=4,
        AUD=5,
        BGN=6,
        JPY=7,
        CSZ=8,
        RUB=9
    }
    [Serializable]
    public class Tranzactii : ICloneable, IComparable
    {
        private string idTranzactie;
        public float sumaTranzactie;
        private tipTranzactie tipTranzactie;
        private string contSursa;
        private string contDestinatie;


        public Tranzactii()
        {
            idTranzactie = "N/A";
            sumaTranzactie = 0f;
            tipTranzactie= tipTranzactie.RON;
            contSursa = "N/A";
            contDestinatie = "N/A";
        }
        public Tranzactii(string id, float suma, tipTranzactie t, string s, string d)
        {
            idTranzactie = id;
            sumaTranzactie = suma;
            tipTranzactie = t;
            contSursa = s;
            contDestinatie = d;
        }
        public string IdTranzactie
        {
            get { return idTranzactie; }
            set { idTranzactie = value; }
        }
        public float SumaTranzactie
        {
            get { return sumaTranzactie; }
            set { if(value>0)
                sumaTranzactie = value; }
        }
      
        public tipTranzactie TipTranzactie
        {
            get { return tipTranzactie; }
            set { if(value==0) tipTranzactie = value; }
        }
        public string ContSursa
        {
            get { return contSursa; }
            set { if(value.Length==24)
                contSursa = value; }
        }
        public string ContDestinatie
        {
            get { return contDestinatie; }
            set { if(value.Length==24)
                contDestinatie = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public static explicit operator float(Tranzactii t)
        {
            return t.sumaTranzactie;
        }


        public int CompareTo(object obj)
        {
            Tranzactii t = (Tranzactii)obj;
            if ((float)this > (float)t)
                return -1;
            else
                 if ((float)this < (float)t)
                return 1;
            else
                return string.Compare(this.contSursa, t.contSursa);

        }

        public Tranzactii schimbaMoneda(int moneda)
        {
            sumaTranzactie += sumaTranzactie * moneda;
            return this;
        }

        public override string ToString()
        {
            return "Tranzactia cu id-ul: " + idTranzactie +
                " de tipul: " + tipTranzactie +
                " in valoare de: " + sumaTranzactie +
                " din contul: " + contSursa +
                " a fost trimisa in contul: " + contDestinatie;

        }
    }
}
