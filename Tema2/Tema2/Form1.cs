using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void BTN_add_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
            { output.Items.Add(input.Text); }
            output.Sorted = true;
            input.Text = "";
        }

        private void BTN_delete_Click(object sender, EventArgs e)
        {
            if (output.SelectedIndex != -1) output.Items.RemoveAt(output.SelectedIndex);
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            input.Text = Regex.Replace(input.Text, "[^A-Za-z0-9]", " ");
        }
    }
}
