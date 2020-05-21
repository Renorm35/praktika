using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Tema5._2.Controller;

namespace Tema5._2
{
    public partial class Result : Form
    {
        Query2 controller;
        public Result()
        {
            InitializeComponent();
            controller = new Query2(ConnectionString.ConnStr);
        }
        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateInfo();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            controller.Add(int.Parse(Shop.Text), Film.Text, int.Parse(klkprd.Text));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Kod"].Value.ToString()));
        }

        private void filmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nF = new Form1();
            this.Close();
            nF.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
