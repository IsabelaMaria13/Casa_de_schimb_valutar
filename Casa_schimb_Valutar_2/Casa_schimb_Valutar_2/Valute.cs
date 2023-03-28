using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_schimb_Valutar_2
{
    [Serializable]
    public class Valute
    {
        public string codValuta;  //EUR, USD, RON
        public string numeValuta; //euro, dolar american
        public char simbolValuta; //"$", "€", "£"
        public float rataEuro; //rata de schimb fata de euro

        public Valute()
        {
            codValuta = "N/A";
            numeValuta = "N/A";
            simbolValuta = '-';
            rataEuro = -1f;
        }
        public Valute(string cod, string nume, char simbol, float rata)
        {
            codValuta = cod;
            numeValuta = nume;
            simbolValuta = simbol;
            rataEuro = rata;
        }

        public string CodValuta
        {
            get { return codValuta; }
            set { if(value.Length==3)
                codValuta = value; }
        }
        public string NumeValuta
        {
            get { return numeValuta; }
            set { numeValuta = value; }
        }
        public char SimbolValuta
        {
            get { return simbolValuta; }
            set { simbolValuta = value; } //validare oferita de tipul datei
        }
        public float RataEuro
        {
            get { return rataEuro; }
            set { if(value>0)
                rataEuro = value; } 
        }

        public override string ToString()
        {
            return "Valuta: " + numeValuta + ", " + codValuta + ", " + simbolValuta + "are rata de schimb fata de EURO egala cu: " + rataEuro;

        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }


}
