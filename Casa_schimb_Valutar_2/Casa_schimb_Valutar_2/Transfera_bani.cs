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
    public partial class transferuri : Form
    {
        List<Tranzactii> listTranzactii = new List<Tranzactii>();
        private int id;
        public transferuri()
        {
            InitializeComponent();
            FileStream fs = new FileStream("tranzactiiBinar.dat", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            if (new FileInfo("tranzactiiBinar.dat").Length != 0)
                listTranzactii = (List<Tranzactii>)bf.Deserialize(fs);
            fs.Close();
            timer1.Start();
        }
        public transferuri(List<Tranzactii> lista)
        {
            InitializeComponent();
            listTranzactii = lista;
        }

        private void Transfera_bani_Load(object sender, EventArgs e)
        {
            id = new Random().Next(10000); 
            tbID.Text = id.ToString();
        }

        
        private void buttonBinar_Click(object sender, EventArgs e)
        {
            double sumaS;
            if (tbID.Text == "")
            {
                errorProvider1.SetError(tbID, "ID invalid.");
            } 
            else
           if (tbSuma.Text == "")
                errorProvider1.SetError(tbSuma, "Va rugam introduceti suma.");
            if ((!double.TryParse(tbSuma.Text, out sumaS) || sumaS <= 0))
                errorProvider1.SetError(tbSuma, "Va rugam introduceti suma valida mai mare decat 0.");
            else
             if (cbTip.Text == "")
                errorProvider1.SetError(cbTip, "Va rugam sa alegeti o valoare.");
            else
             if (tbContSursa.Text == "")
                errorProvider1.SetError(tbContSursa, "Va rugam introduceti contul sursa.");
            else
             if (tbContSursa.Text.Length!=10)
                errorProvider1.SetError(tbContSursa, "Va rugam introduceti contul sursa corect(10 caractere).");
            else
             if (tbContDestinatie.Text == "")
                errorProvider1.SetError(tbContDestinatie, "Va rugam introduceti contul destinatie.");
            else
             if (tbContDestinatie.Text.Length!= 10)
                errorProvider1.SetError(tbContDestinatie, "Va rugam introduceti contul destinatie corect(10 caractere).");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string id = tbID.Text;
                    float suma = float.Parse(tbSuma.Text);
                    tipTranzactie tip = (tipTranzactie)Convert.ToInt32(cbTip.Text);
                    string sursa = tbContSursa.Text;
                    string destinatie = tbContDestinatie.Text;
                    Tranzactii t = new Tranzactii(id, suma, tip, sursa, destinatie);
                    listTranzactii.Add(t);
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = new FileStream("tranzactiiBinar.dat", FileMode.Create,
                        FileAccess.Write);
                    bf.Serialize(fs, listTranzactii);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbID.Clear();
                    id = new Random().Next(10000);
                    tbID.Text = id.ToString();

                    tbSuma.Clear();
                    cbTip.Text = "";
                    tbContSursa.Clear();
                    tbContDestinatie.Clear();
                }
            }
            
        }

       
        private void transferaCriptatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            double sumaS;
            if (tbID.Text == "")
            {
                errorProvider1.SetError(tbID, "ID invalid.");
            }
            else
           if (tbSuma.Text == "")
                errorProvider1.SetError(tbSuma, "Va rugam introduceti suma.");
            if ((!double.TryParse(tbSuma.Text, out sumaS) || sumaS <= 0))
                errorProvider1.SetError(tbSuma, "Va rugam introduceti suma valida mai mare decat 0.");
            else
             if (cbTip.Text == "")
                errorProvider1.SetError(cbTip, "Va rugam sa alegeti o valoare.");
            else
             if (tbContSursa.Text == "")
                errorProvider1.SetError(tbContSursa, "Va rugam introduceti contul sursa.");
            else
             if (tbContSursa.Text.Length != 10)
                errorProvider1.SetError(tbContSursa, "Va rugam introduceti contul sursa corect(10 caractere)");
            else
             if (tbContDestinatie.Text == "")
                errorProvider1.SetError(tbContDestinatie, "Va rugam introduceti contul destinatie.");
            else
             if (tbContDestinatie.Text.Length != 10)
                errorProvider1.SetError(tbContDestinatie, "Va rugam introduceti contul destinatie corect(10 caractere).");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string id = tbID.Text;
                    float suma = float.Parse(tbSuma.Text);
                    tipTranzactie tip = (tipTranzactie)Convert.ToInt32(cbTip.Text);
                    string sursa = tbContSursa.Text;
                    string destinatie = tbContDestinatie.Text;
                    Tranzactii t = new Tranzactii(id, suma, tip, sursa, destinatie);
                    listTranzactii.Add(t);
                    BinaryFormatter bf = new BinaryFormatter();
                    FileStream fs = new FileStream("tranzactiiBinar.dat", FileMode.Create,
                        FileAccess.Write);
                    bf.Serialize(fs, listTranzactii);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbID.Clear();
                    id = new Random().Next(10000);
                    tbID.Text = id.ToString();

                    tbSuma.Clear();
                    cbTip.Text = "";
                    tbContSursa.Clear();
                    tbContDestinatie.Clear();
                }
            }
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}

