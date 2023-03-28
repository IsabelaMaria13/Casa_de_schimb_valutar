using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_schimb_Valutar_2
{
    [Serializable]
    public class PortofoliuValutar: ICloneable, IComparable//, IEnumerable
    {
        private Valute[] valute;
        private int numarValute;

       public PortofoliuValutar()
        {
            valute = null;
            numarValute = 0;
        }
        public PortofoliuValutar(Valute[] valute, int numarValute)
        {
            this.numarValute = numarValute;
            for (int i = 0; i < valute.Length; i++)
                this.valute[i] = valute[i];
        }

        public Valute[] ValuteArray
        {
            get { return (Valute[])valute.Clone(); }
            set
            {
                if (value != null)
                {
                    valute = new Valute[value.Length];
                    for (int i = 0; i < value.Length; i++)
                        valute[i] = value[i];

                }
                else
                   valute = null;
            }
        }
      

        public object Clone()
        {
            PortofoliuValutar clona = (PortofoliuValutar)this.MemberwiseClone();
            Valute[] valuteNoi = (Valute[])valute.Clone();
            clona.valute = valuteNoi;
            return clona;
        }

        public int CompareTo(object obj)
        {
            PortofoliuValutar t = (PortofoliuValutar)obj;
            for (int i = 0; i < valute.Length; i++)
            {
                if (string.Compare(this.valute[i].numeValuta, t.valute[i].numeValuta) == -1)
                {
                    if (this.valute[i].rataEuro < t.valute[i].rataEuro)
                    {
                        if (this.valute[i].simbolValuta < t.valute[i].simbolValuta)
                        { return -1; }
                    }
                }
                else
                    if (string.Compare(this.valute[i].numeValuta, t.valute[i].numeValuta) == 1)
                    {
                        if (this.valute[i].rataEuro > t.valute[i].rataEuro)
                        {
                            if (this.valute[i].simbolValuta > t.valute[i].simbolValuta)
                            { return 1; }
                        }
                    }
                    else return 0;
            }
            return 9;
        }

        public PortofoliuValutar AddValuta(PortofoliuValutar pv, Valute valutaNoua)
        {
            Valute[] valuteNoi = new Valute[pv.valute.Length + 1];
            for (int i = 0; i < valute.Length; i++)
                valuteNoi[i] = pv.valute[i];
            valuteNoi[valuteNoi.Length - 1] = valutaNoua;
            pv.valute = valuteNoi;
            return this;
        }

        public PortofoliuValutar RemoveValuta(PortofoliuValutar pv, Valute valutaVeche)
        {
            int index = -1;
            for (int i = 0; i < pv.valute.Length; i++)
            {
                if (pv.valute[i] == valutaVeche)
                {
                    index = i;
                    break;
                }
                         
            }
            if (index != -1)
            {
                for (int i = index; i < pv.valute.Length - 1; i++)
                    pv.valute[i] = pv.valute[i + 1];
                Array.Resize(ref pv.valute, pv.valute.Length - 1);
            }
            return this;
        }
        //public IEnumerator<Valute> GetEnumerator()
        //{
        //    for (int i = 0; i < valute.Length; i++)
        //    {
        //        yield return valute[i];
        //    }
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}




    }
}
