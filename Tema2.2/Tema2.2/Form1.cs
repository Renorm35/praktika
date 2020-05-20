using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2._2
{
    public partial class Form1 : Form
    {
         
       int n, m;
       int[,] A;
        int[] B;
   
        public Form1()
        {
            InitializeComponent();
           
        }
          
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formirov_Click(object sender, EventArgs e)
        {
            int.TryParse(KolStr.Text, out n);
            int.TryParse(KolStolb.Text, out m);
            A = new int[n, m];
            Random rnd = new Random();
            for (int h = 0; h < n; h++)
            {
                for (int g = 0; g < m; g++)
                { A[h, g] = rnd.Next(-20,30); }
            }
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            int i, j;
            for (i = 0; i < n; i++)
                for (j = 0; j < m; j++)
                    dataGridView1.Rows[i].Cells[j].Value = A[i, j].ToString();
            resultGen.Text = "";
            result.Text = "";
        }

        private void sort_Click(object sender, EventArgs e)
        {
            
            
           // B = new int[n];
            //Array.Resize(ref B, n);
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length-1; j++)
                {
                    if (B[j] <B[j+1])
                    {
                       int temp = B[j];
                       B[j] = B[j+1];
                       B[j+1] = temp;
                    }
              
                }
             }
            for (int q = 0; q < B.Length; q++) 
            {
                result.Text +=B[q] + " ";
            }
            
        }

        private void raschet_Click(object sender, EventArgs e)
        {
            
           
            if (stroka.Checked == true)
            {
                B = new int[n];
                int[] sum = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    for (int j = 0; j <m; ++j)
                    {
                        if (A[i, j] < 0)
                        {
                            sum[i] += A[i, j];
                        }

                        B[i] = sum[i];
                    }
                     resultGen.Text += sum[i]+" ";
                }
                
            }
            else if (stolbec.Checked==true)
                    {
                B = new int[m];
                int[] sum = new int[m];
                for (int i = 0; i <m; ++i)
                {
                    for (int j = 0; j < m; ++j)
                    {
                        if (A[j, i] < 0)
                        {
                            sum[i] += A[j, i];
                        
                        }

                    B[i]= sum[i];
                    }
                    resultGen.Text += sum[i] + " ";
                    
                }

            }


        }
    }
}
