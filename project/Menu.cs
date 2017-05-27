using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Universities_Click(object sender, EventArgs e)
        {
            Universities form = new Universities();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void b_Specialties_Click(object sender, EventArgs e)
        {
            Specialties form = new Specialties();
            Hide();
            form.ShowDialog();
            Dispose();
        }
    }
}
