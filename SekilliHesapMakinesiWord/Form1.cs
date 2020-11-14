using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekilliHesapMakinesiWord
{
    public partial class Form1 : Form
    {
        bool OptDurum;
        double sonuc = 0;
        string opt = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e)
        {
            if (tbSonuc.Text == "0" || OptDurum)
                tbSonuc.Clear();
            OptDurum = false;

            Button btn = (Button)sender;
            tbSonuc.Text += btn.Text;
        }

        private void Hesapla(object sender, EventArgs e)
        {
            OptDurum = true;
            Button btn = (Button) sender;
            string YenıOpt = btn.Text;
            lbSonuc.Text = lbSonuc.Text + " " + tbSonuc.Text + " " + YenıOpt;
            switch (opt)
            {
                case "+": tbSonuc.Text = (sonuc + Double.Parse(tbSonuc.Text)).ToString(); 
                     break;
                case "-":
                    tbSonuc.Text = (sonuc - Double.Parse(tbSonuc.Text)).ToString();
                    break;
                case "*":
                    tbSonuc.Text = (sonuc * Double.Parse(tbSonuc.Text)).ToString();
                    break;
                case "/":
                    tbSonuc.Text = (sonuc / Double.Parse(tbSonuc.Text)).ToString();
                    break;
            }
            sonuc = double.Parse(tbSonuc.Text);
            tbSonuc.Text = sonuc.ToString();
            opt = YenıOpt;
        }
        private void btTextiSilme_Click(object sender, EventArgs e)
        {
            tbSonuc.Text = "0";
        }

        private void btButunbilgi_Click(object sender, EventArgs e)
        {
            tbSonuc.Text = "0";
            lbSonuc.Text = "0";
            opt = "";
            sonuc = 0;
            OptDurum = false;
        }

        private void btEsıttır_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "";
            OptDurum = true;
            switch (opt)
            {
                case "+":
                    tbSonuc.Text = (sonuc + Double.Parse(tbSonuc.Text)).ToString();
                    break;
                case "-":
                    tbSonuc.Text = (sonuc - Double.Parse(tbSonuc.Text)).ToString();
                    break;
                case "*":
                    tbSonuc.Text = (sonuc * Double.Parse(tbSonuc.Text)).ToString();
                    break;
                case "/":
                    tbSonuc.Text = (sonuc / Double.Parse(tbSonuc.Text)).ToString();
                    break;
            }
            sonuc = double.Parse(tbSonuc.Text);
            tbSonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void btNokta_Click(object sender, EventArgs e)
        {
            if (tbSonuc.Text == "0")
            {
                tbSonuc.Text = "0";
            }
            else if (OptDurum)  // tekrar sıfıra basmasını önlemek için
            {
                tbSonuc.Text = "0";
            }
            if(!tbSonuc.Text.Contains(","))
            {
                tbSonuc.Text += ","; // ondalık sayı eklesin
            }
            OptDurum = false;
        }
    }
}
