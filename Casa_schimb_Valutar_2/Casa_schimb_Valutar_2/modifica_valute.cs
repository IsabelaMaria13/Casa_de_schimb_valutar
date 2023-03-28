using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Casa_schimb_Valutar_2
{
    public partial class modifica_valute : Form
    {
        //Vezi_Curs_Valutar destinatie;
        //PortofoliuValutar portofoliu = new PortofoliuValutar();
        List<Valute> listValute = new List<Valute>();
        public modifica_valute()
        {
            InitializeComponent();
            //destinatie = new Vezi_Curs_Valutar();
            FileStream fs = new FileStream("ValuteNou.dat", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            if (new FileInfo("ValuteNou.dat").Length != 0)
                listValute = (List<Valute>)bf.Deserialize(fs);
            fs.Close();
    
        }

        
            //string codValutaNoua = textBoxCodValuta.Text;
            //string numeValutaNoua = textBoxNumeValuta.Text;
            //char simbolValutaNoua = textBoxSimbolValuta.Text[0];
            //float RataEuroNoua = float.Parse(textBoxRataEuro.Text);
            //Valute valutaNoua = new Valute(codValutaNoua, numeValutaNoua, simbolValutaNoua, RataEuroNoua);
            //portofoliu.AddValuta(portofoliu, valutaNoua);

            //destinatie.portofoliu = this.portofoliu;
            //destinatie.Show();
           

        

        private void buttonSerializare_Click(object sender, EventArgs e)
        {
            if (textBoxCodValuta.Text == "")
            {
                errorProvider1.SetError(textBoxCodValuta, "Codul este format din 3 litere mari.");
            }
            else
             if (textBoxNumeValuta.Text == "")
                errorProvider1.SetError(textBoxNumeValuta, "Introduceti numele.");
            else
            if (textBoxSimbolValuta.Text == "")
                errorProvider1.SetError(textBoxSimbolValuta, "Daca nu are simbol, introduceti -");
            else
            if (textBoxRataEuro.Text == "")
                errorProvider1.SetError(textBoxRataEuro, "Rata de schimb fata de euro");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string cod = textBoxCodValuta.Text;
                    string nume = textBoxNumeValuta.Text;
                    char simbol = textBoxSimbolValuta.Text[0];
                    float rata = float.Parse(textBoxRataEuro.Text);
                    Valute v = new Valute(cod, nume, simbol, rata);
                    listValute.Add(v);
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = new FileStream("ValuteNou.dat", FileMode.Create,
                        FileAccess.Write);
                    bf.Serialize(fs, listValute);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    textBoxCodValuta.Clear();
                    textBoxNumeValuta.Clear();
                    textBoxSimbolValuta.Text = "";
                    textBoxRataEuro.Clear();
                }
            }

       



        }
    }
}
