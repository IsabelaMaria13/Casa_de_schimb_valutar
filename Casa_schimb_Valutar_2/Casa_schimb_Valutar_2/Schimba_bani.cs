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
   
    public partial class Schimba_bani : Form
    {
        List<TranzactiiValute> listTranzactiiValute = new List<TranzactiiValute>();
        public Schimba_bani()
        {
            InitializeComponent();
        }
        public Schimba_bani(List<TranzactiiValute>lista)
        {
            InitializeComponent();
            listTranzactiiValute = lista;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            tbSuma.Visible = true;
            cbDAT.Visible = true;
            cbPRIMIT.Visible = true;
            labelSuma.Visible = true;
            labelDAT.Visible = true;
            labelPRIMIT.Visible = true;
            labelCumparare.Visible = true;
            tbCumparare.Visible = true;
            labelVanzare.Visible = false;
            tbVanzare.Visible = false;
            ConfirmareCumparare.Visible = true;
            ConfirmareVanzare.Visible = false;
            exchangeRateTextBox.Visible = true;
            button3.Visible = true;
            tbEURO.Visible = false;
            cb2.Visible = false;
            exchangeRateTextBox2.Visible = false;
            button4.Visible = false;
            label3.Visible = true;
            label2.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            tbSuma.Visible = true;
            cbDAT.Visible = false;
            cbPRIMIT.Visible = false;
            labelSuma.Visible = true;
            labelDAT.Visible = true;
            labelPRIMIT.Visible = true;
            labelCumparare.Visible = false;
            tbCumparare.Visible = false;
            labelVanzare.Visible = true;
            tbVanzare.Visible = true;
            ConfirmareCumparare.Visible = false;
            ConfirmareVanzare.Visible = true;
            exchangeRateTextBox.Visible = false;
            button3.Visible = false;
            tbEURO.Visible = true;
            cb2.Visible = true;
            exchangeRateTextBox2.Visible = true;
            button4.Visible = true;
            label3.Visible = true;
            label2.Visible = true;

        }

        private void cbDAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cbDAT.SelectedItem.ToString();
            decimal exchangeRate = GetExchangeRate(select);
            exchangeRateTextBox.Text = exchangeRate.ToString();
        }
        private decimal GetExchangeRate(string currency)
        {
            switch (currency)
            {
                case "RON":
                    return 0.2m;
                case "USD":
                    return 0.9m;
                case "EUR":
                    return 0m;
                case "GBP":
                    return 1.14m;
                case "CHF":
                    return 1.01m;
                case "AUD":
                    return 0.61m;
                case "BGN":
                    return 0.5m;
                case "JPY":
                    return 0.0007m;
                case "CZK":
                    return 0.04m;
                case "RUB":
                    return 0.01m;

                default:
                    return 0m;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbSuma.Text == "")
            {
                errorProvider1.SetError(tbSuma, "Introduceti suma.");
            }
            else
                 if (cbDAT.Text == "")
            {
                errorProvider1.SetError(cbDAT, "Alegeti moneda.");
            }
            else
            {
                float suma = float.Parse(tbSuma.Text);
                float curs = float.Parse(exchangeRateTextBox.Text);
                tbCumparare.Text = (suma * curs).ToString();

            }
          
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cb2.SelectedItem.ToString();
            decimal exchangeRate = GetExchangeRate2(select);
            exchangeRateTextBox2.Text = exchangeRate.ToString();
        }
        private decimal GetExchangeRate2(string currency)
        {
            switch (currency)
            {
                case "RON":
                    return 4.93m;
                case "USD":
                    return 1.08m;
                case "EUR":
                    return 0m;
                case "GBP":
                    return 0.88m;
                case "CHF":
                    return 1.01m;
                case "AUD":
                    return 1.62m;
                case "BGN":
                    return 1.96m;
                case "JPY":
                    return 141m;
                case "CZK":
                    return 23.68m;
                case "RUB":
                    return 83.16m;

                default:
                    return 0m;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbSuma.Text == "")
            {
                errorProvider1.SetError(tbSuma, "Introduceti suma.");
            }
            else
                  if (tbEURO.Text == "")
            {
                errorProvider1.SetError(tbEURO, "Alegeti moneda.");
            }
            else
            {
                float suma = float.Parse(tbSuma.Text);
                float curs = float.Parse(exchangeRateTextBox2.Text);
                tbVanzare.Text = (suma * curs).ToString();
            }
            
        }
       
        private void ConfirmareCumparare_Click(object sender, EventArgs e)
        {

            if (tbCumparare.Text == "")
            {
                errorProvider1.SetError(tbCumparare, "Completati toate campurile.");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    float suma = float.Parse(tbSuma.Text);
                    string unu = cbDAT.Text;
                    string doi = cbPRIMIT.Text;
                    float curs = float.Parse(exchangeRateTextBox.Text);
                    float rezultat = float.Parse(tbCumparare.Text);
                    TranzactiiValute tv = new TranzactiiValute(suma, unu, doi, curs, rezultat);
                    listTranzactiiValute.Add(tv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbSuma.Clear();
                    cbDAT.Text="";
                    cbPRIMIT.Text = "";
                    exchangeRateTextBox.Clear();
                    tbCumparare.Clear();

                }
            }

            string numeFisier = "cumparare.txt";
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
                foreach (TranzactiiValute tv in listTranzactiiValute)
                    sw.WriteLine($"Tranzactia efectuata din suma: {tv.suma}, din valuta: {tv.ValutaUnu}, in valuta: {tv.ValutaDoi}, este cumparata cu: {tv.Rezultat}");
        
        }

        private void ConfirmareVanzare_Click(object sender, EventArgs e)
        {
            if (tbVanzare.Text == "")
            {
                errorProvider1.SetError(tbVanzare, "Completati toate campurile.");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    float suma = float.Parse(tbSuma.Text);
                    string unu = tbEURO.Text;
                    string doi = cb2.Text;
                    float curs = float.Parse(exchangeRateTextBox2.Text);
                    float rezultat = float.Parse(tbVanzare.Text);
                    TranzactiiValute tv = new TranzactiiValute(suma, unu, doi, curs, rezultat);
                    listTranzactiiValute.Add(tv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbSuma.Clear();
                    tbEURO.Text = "";
                    cb2.Text = "";
                    exchangeRateTextBox2.Clear();
                    tbVanzare.Clear();

                }
            }

            string numeFisier = "vanzare.txt";
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
                foreach (TranzactiiValute tv in listTranzactiiValute)
                    sw.WriteLine($"Tranzactia efectuata din suma: {tv.suma}, din valuta: {tv.ValutaUnu}, in valuta: {tv.ValutaDoi}, este vanduta cu: {tv.Rezultat}");

        }

        private void cumparaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tbCumparare.Text == "")
            {
                errorProvider1.SetError(tbCumparare, "Completati toate campurile.");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    float suma = float.Parse(tbSuma.Text);
                    string unu = cbDAT.Text;
                    string doi = cbPRIMIT.Text;
                    float curs = float.Parse(exchangeRateTextBox.Text);
                    float rezultat = float.Parse(tbCumparare.Text);
                    TranzactiiValute tv = new TranzactiiValute(suma, unu, doi, curs, rezultat);
                    listTranzactiiValute.Add(tv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbSuma.Clear();
                    cbDAT.Text = "";
                    cbPRIMIT.Text = "";
                    exchangeRateTextBox.Clear();
                    tbCumparare.Clear();

                }
            }

            string numeFisier = "cumparare.txt";
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
                foreach (TranzactiiValute tv in listTranzactiiValute)
                    sw.WriteLine($"Tranzactia efectuata din suma: {tv.suma}, din valuta: {tv.ValutaUnu}, in valuta: {tv.ValutaDoi}, este cumparata cu: {tv.Rezultat}");

        }

        private void vindeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tbVanzare.Text == "")
            {
                errorProvider1.SetError(tbVanzare, "Completati toate campurile.");
            }
            else
            {
                errorProvider1.Clear();
                try
                {
                    float suma = float.Parse(tbSuma.Text);
                    string unu = tbEURO.Text;
                    string doi = cb2.Text;
                    float curs = float.Parse(exchangeRateTextBox2.Text);
                    float rezultat = float.Parse(tbVanzare.Text);
                    TranzactiiValute tv = new TranzactiiValute(suma, unu, doi, curs, rezultat);
                    listTranzactiiValute.Add(tv);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbSuma.Clear();
                    tbEURO.Text = "";
                    cb2.Text = "";
                    exchangeRateTextBox2.Clear();
                    tbVanzare.Clear();

                }
            }

            string numeFisier = "vanzare.txt";
            using (StreamWriter sw = new StreamWriter(numeFisier, true))
                foreach (TranzactiiValute tv in listTranzactiiValute)
                    sw.WriteLine($"Tranzactia efectuata din suma: {tv.suma}, din valuta: {tv.ValutaUnu}, in valuta: {tv.ValutaDoi}, este vanduta cu: {tv.Rezultat}");

        }
    }

}
