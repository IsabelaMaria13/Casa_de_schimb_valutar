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
    [Serializable]
    public partial class Verifica_tranzactii : Form
    {
        //List<Tranzactii> lista2;
        public Verifica_tranzactii(List<Tranzactii> listTranzactii)
        {
            InitializeComponent();
            //lista2 = listTranzactii;
            //foreach (Tranzactii t in listTranzactii)
            //    textBox1.Text += t.ToString() + Environment.NewLine;

        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("tranzactiiBinar.dat", FileMode.Open, FileAccess.Read);
            List<Tranzactii> lista3 = (List<Tranzactii>)bf.Deserialize(fs);
            foreach (Tranzactii t in lista3)
                textBox1.Text += t.ToString() + Environment.NewLine;
            fs.Close();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            //new Form1().Show();
         }
    }
}
