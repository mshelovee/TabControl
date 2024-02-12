using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl___96
{
    public partial class Form1 : Form
    {
        decimal corba,salata,yemek,tatli,toplam = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTelefon.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";

                decimal corba = 0;

                if(nCorba.Value > 0)
                {
                    corba += nCorba.Value * 70; //Adet fiyatı 70 lira.
                    txtBilgi.Text += string.Format("\r\n" + "Çorba {0:C}", nCorba.Value*70) + "\r\n";
                }

                txtBilgi.Text += "_______________";
                txtBilgi.Text += string.Format("\r\n" + "Çorba {0:C}", corba);

                if (nSalata.Value > 0)
                {
                    salata += nSalata.Value * 50; //Adet fiyatı 50 lira.
                    txtBilgi.Text += string.Format("\r\n" + "Salata {0:C}", nSalata.Value * 50) + "\r\n";
                }

                txtBilgi.Text += "_______________";
                txtBilgi.Text += string.Format("\r\n" + "Salata {0:C}", salata);


                if (nYemek.Value > 0)
                {
                    yemek += nYemek.Value * 200; //Adet fiyatı 200 lira.
                    txtBilgi.Text += string.Format("\r\n" + "Ana Yemek {0:C}", nYemek.Value * 200) + "\r\n";
                }

                txtBilgi.Text += "_______________";
                txtBilgi.Text += string.Format("\r\n" + "Ana Yemek {0:C}", yemek);


                if (nTatli.Value > 0)
                {
                    tatli += nTatli.Value * 100; //Adet fiyatı 100 lira.
                    txtBilgi.Text += string.Format("\r\n" + "Tatlı {0:C}", nTatli.Value * 100) + "\r\n";
                }

                txtBilgi.Text += "_______________";
                txtBilgi.Text += string.Format("\r\n" + "Tatlı {0:C}", tatli);

                toplam = corba + salata + yemek + tatli;
                txtBilgi.Text += "_______________";
                txtBilgi.Text += string.Format("\r\n" + "TOPLAM ÖDENECEK TUTAR {0:C}", toplam);
            }

        }
    }
}
