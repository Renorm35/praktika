using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema
{
    public partial class Form1 : Form
    {
        int[] mp = new int[6];
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mp[1] = Convert.ToInt32(x1.Text);
            mp[2] = Convert.ToInt32(x2.Text);
            mp[3] = Convert.ToInt32(y1.Text);
            mp[4] = Convert.ToInt32(y2.Text);
            mp[5] = Convert.ToInt32(n.Text);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
            
            e.Graphics.DrawLine(System.Drawing.Pens.Black, 0, pictureBox1.Height/2, pictureBox1.Width, pictureBox1.Height / 2);
           e.Graphics.DrawLine(System.Drawing.Pens.Black, pictureBox1.Width/2, 0, pictureBox1.Width/2,pictureBox1.Height );
            DrawLine(mp[1],mp[2],mp[3],mp[4],e);

            // DrawPoint(20, 20, e);
            int oldx=0, oldy=0;
            bool onetime = false;
            for (int x = -pictureBox1.Width / 2; x < pictureBox1.Width / 2; x++) 
            {

                //int y = (int)Math.Pow((double)x, (double)mp[5]);
                int y = (int)Math.Pow((double)(x-mp[1]), (double)mp[5])+mp[3];
                if (onetime == false)
                    onetime = true;
                if(x==0)
                    resultbox.Text="Заданная прямая пересекается с осью ординат в точке С"
                else DrawLine(x, y, oldx, oldy, e);
                 oldx = x; oldy = y;
                
            }
            
            
        }
        public void DrawPoint(int x, int y, PaintEventArgs k)
        {
            int xx = pictureBox1.Width / 2 + x;
            int yy = pictureBox1.Height / 2 - y;
            k.Graphics.DrawLine(System.Drawing.Pens.Black, xx, yy+1,xx,yy);

        }
        
        public void DrawLine(int x, int y,int x1,int y1, PaintEventArgs e)
        {
            int xx = pictureBox1.Width / 2 + x;
            int yy = pictureBox1.Height / 2 - y;
            int xx1 = pictureBox1.Width / 2 + x1;
            int yy1 = pictureBox1.Height / 2 - y1;
            e.Graphics.DrawLine(System.Drawing.Pens.Black, xx, yy, xx1, yy1);

        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void n_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
