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
    public partial class Universities : Form
    {
        public Universities()
        {
            InitializeComponent();
        }

        private void Universities_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            Hide();
            form.ShowDialog();
            Dispose();
        }
    }
}
