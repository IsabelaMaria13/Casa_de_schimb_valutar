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
    public partial class Vezi_Curs_Valutar : Form
    {
        //public PortofoliuValutar portofoliu = new PortofoliuValutar();
        public Vezi_Curs_Valutar(List<Valute>listValute)
        {
            InitializeComponent();
            
        }
        public Vezi_Curs_Valutar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxValuta.Clear();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("ValuteNou.dat", FileMode.Open, FileAccess.Read);
            List<Valute> lista3 = (List<Valute>)bf.Deserialize(fs);
            foreach (Valute v in lista3)
                textBoxValuta.Text += v.ToString() + Environment.NewLine;
            fs.Close();
        }
    }
}

