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
    partial class Specialties : Form
    {
        ReadExternalFile readF;

        public Specialties(ReadExternalFile ReadF)
        {
            InitializeComponent();

            readF = ReadF;
 
        }

        private void Back_Click(object sender, EventArgs e)  // Going to the main menu. 
        {
            Menu form = new Menu();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void Add_Click(object sender, EventArgs e) // If we want to add a new information about the university.
        {
            UniversityStruct ExtraData = new UniversityStruct(tB_Univ.Text, tB_Address.Text,tB_Specialty.Text,tB_Day.Text,tB_Night.Text,tB_Dist.Text,tB_Pay.Text);
            readF.WriteData(ExtraData);
            MessageBox.Show("Запись была добавлена!");
        }

        private void back_List_Click(object sender, EventArgs e) // Going to the table with universities. 
        {
            Universities form = new Universities();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void tB_Day_TextChanged(object sender, EventArgs e)
        {
            if (tB_Day.Text != "")
            {                
                tB_Day.Text = String.Format("{0}", Convert.ToInt32(tB_Day.Text));
            }
            else tB_Day.Text = "0";
        }
    }
}
