using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_schimb_Valutar_2
{
    [Serializable]
    public class CursuriValutare
    {
        private float cursValutar;
        private Tranzactii[] tranzactii;
        private int numar;

        public CursuriValutare()
        {
            cursValutar = 0f;
            tranzactii = null;
            numar = 0;
        }

        public CursuriValutare(float cursValutar, Tranzactii[] tranzactii, int numar)
        {
            this.cursValutar = cursValutar;
            this.tranzactii = new Tranzactii[tranzactii.Length];
            this.numar = numar;
            for (int i = 0; i < tranzactii.Length; i++)
            {
                this.tranzactii[i] = tranzactii[i];

            }
        }

        public float CursValutar
        {
            get { return cursValutar; }
            set { if(value>0)
                cursValutar = value; }
        }

        public int Numar
        {
            get { return numar; }
            set { if(value>0)
                numar = value; }
        }

        public Tranzactii[] TranzactiiArray
        {
            get { return (Tranzactii[])tranzactii.Clone(); }
            set
            {
                if (value != null)
                {
                    tranzactii = new Tranzactii[value.Length];
                    for (int i = 0; i < value.Length; i++)
                        tranzactii[i] = value[i];

                }
                else
                    tranzactii = null;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static CursuriValutare operator +(CursuriValutare cv, Tranzactii tranzactieNoua)
        {
            Tranzactii[] tranzactiiNoi = new Tranzactii[cv.tranzactii.Length + 1];
            for (int i = 0; i < cv.tranzactii.Length; i++)
                tranzactiiNoi[i] = cv.tranzactii[i];
            tranzactiiNoi[tranzactiiNoi.Length - 1] = tranzactieNoua;
            cv.tranzactii = tranzactiiNoi;
            return cv;

        }

        public static CursuriValutare operator -(CursuriValutare cv, Tranzactii tranzactieVeche)
        {
            int index = -1;
            for (int i = 0; i < cv.tranzactii.Length; i++)
                if (cv.tranzactii[i] == tranzactieVeche)
                {
                    index = i;
                    break;
                }

            if (index != -1)
            {
                for (int i = index; i < cv.tranzactii.Length - 1; i++)
                    cv.tranzactii[i] = cv.tranzactii[i + 1];


                Array.Resize(ref cv.tranzactii, cv.tranzactii.Length - 1);
            }
            return cv;
        }

        public Tranzactii this[int index]
        {
            get
            {
                if (tranzactii != null && index > 0 && index < tranzactii.Length)
                    return tranzactii[index];
                else
                    return null;
            }
            set
            {
                if (tranzactii != null && index > 0 && index < tranzactii.Length)
                {
                    tranzactii[index] = value;
                }

            }
        }
        float calculeazaSumaTranzactii()
        {
            float suma=0;
            for(int i=0;i<tranzactii.Length;i++)
            {
                suma += tranzactii[i].sumaTranzactie;
            }
            return suma;
        }

    }

}