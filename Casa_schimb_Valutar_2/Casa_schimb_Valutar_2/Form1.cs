using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa_schimb_Valutar_2
{
    public partial class Form1 : Form
    {
        List<Tranzactii> listTranzactii = new List<Tranzactii>();
        public Form1()
        {
            InitializeComponent();
            user.DropDownStyle = ComboBoxStyle.DropDownList;
            administrator.DropDownStyle = ComboBoxStyle.DropDownList;
            utilizator.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            user.SelectionChangeCommitted += new EventHandler(user_SelectionChangeCommitted);
        }

        private void titlu_TextChanged(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (user.SelectedIndex == 0) // Administrator
                {
                       switch (administrator.SelectedIndex)
                    {
                        case 0:
                            Vezi_Curs_Valutar curs_valutar = new Vezi_Curs_Valutar();
                            curs_valutar.Show();
                            break;
                        case 1:
                            new Verifica_tranzactii(listTranzactii).Show();
                            //this.Close();
                            break;
                        case 2:
                            modifica_valute adauga_valute = new modifica_valute();
                        adauga_valute.Show();
                            break;
                        default:
                            break;
                    }
                }
                else if (user.SelectedIndex == 1) // Utilizator
                {
                    switch (utilizator.SelectedIndex)
                    {
                            case 0:
                        Vezi_Curs_Valutar curs_valutar = new Vezi_Curs_Valutar();
                            curs_valutar.Show();
                            break;
                        case 1:
                            Schimba_bani schimba_bani = new Schimba_bani();
                            schimba_bani.Show();
                            break;
                        case 2:
                            transferuri transfera_bani = new transferuri();
                            transfera_bani.Show();
                            break;
                        default:
                            break;
                    }
                }
            }

        private void user_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (user.SelectedIndex == 0) // Administrator
            {
                administrator.Visible = true;
                utilizator.Visible = false;
            }
            else if (user.SelectedIndex == 1) // Utilizator
            {
                administrator.Visible = false;
                utilizator.Visible = true;
            }
            else
            {
                administrator.Visible = false;
                utilizator.Visible = false;
            }
        }

        
    }
}
