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
    public partial class Form1 : Form
    {
        Query controller;
        public Form1()
        {
            InitializeComponent();
            controller = new Query(ConnectionString.ConnStr);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdateInfo();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            controller.Add(film.Text, zhanr.Text, int.Parse(Cena.Text));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.Delete(int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Kod_Filmu"].Value.ToString()));
        }
    }
}
