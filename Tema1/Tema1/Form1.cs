using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form1 : Form
    { 
        double dovzhkim, shirkim, viskim, dovzhshp, shirshp, price1rul,finalprice,kilkstshp;

        private void DovzhKim_TextChanged(object sender, EventArgs e)
        {
            DovzhKim.Text = Regex.Replace(DovzhKim.Text,   "[^0-9.]", "");
            ShirKim.Text = Regex.Replace(ShirKim.Text,     "[^0-9.]", "");
            VisStel.Text = Regex.Replace(VisStel.Text,     "[^0-9.]", "");
            Price1rul.Text = Regex.Replace(Price1rul.Text, "[^0-9.]", "");
            ShirSHP.Text = Regex.Replace(ShirSHP.Text,     "[^0-9.]", "");
            DovzhSHP.Text = Regex.Replace(DovzhSHP.Text,   "[^0-9.]", "");
        }

        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double dovzhkim, shirkim, viskim, dovzhshp, shirshp, price1rul;
            double.TryParse(DovzhKim.Text, out dovzhkim);
            double.TryParse(ShirKim.Text, out shirkim);
            double.TryParse(VisStel.Text, out viskim);
            double.TryParse(DovzhSHP.Text, out dovzhshp);
            double.TryParse(ShirSHP.Text, out shirshp);
            double.TryParse(Price1rul.Text, out price1rul);

            kilkstshp = (2 * (dovzhkim + shirkim) * (viskim+0.1)) / (shirshp * dovzhshp); 
            KlkstSHP.Text =  kilkstshp.ToString("0");
            finalprice = kilkstshp * price1rul;
            Resultprice.Text = finalprice.ToString("0") ;
            
            if (DovzhKim.Text == "")
            {
                MessageBox.Show("Невказані дані: Довжина кімнати!!");
                DovzhKim.BackColor = Color.Red;
            }
            else { DovzhKim.BackColor = Color.White; }
            
            if (ShirKim.Text == "")
            { MessageBox.Show("Невказані дані: Ширина кімнати!");
                ShirKim.BackColor = Color.Red;
            }
            else { ShirKim.BackColor = Color.White; }

            if (VisStel.Text == "")
            {
                MessageBox.Show("Невказані дані: Висота стелі!");
                VisStel.BackColor = Color.Red;
            }
            else { VisStel.BackColor = Color.White; }

            if (DovzhSHP.Text == "")
            { MessageBox.Show("Невказані дані: Довжина шпалер!");
                DovzhSHP.BackColor = Color.Red;
            }
            else { DovzhSHP.BackColor = Color.White; }

            if (ShirSHP.Text == "")
            { MessageBox.Show("Невказані дані: Ширина шпалер!");
                ShirSHP.BackColor = Color.Red;
            }
            else { ShirSHP.BackColor = Color.White; }

            if (Price1rul.Text == "")
            { MessageBox.Show("Невказані дані: Ціна за шпалери!");
                Price1rul.BackColor = Color.Red;
                KlkstSHP.Text = "0";
            }
            else { Price1rul.BackColor = Color.White; }

            

            


        }
    }
}
