using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            bool isFull = true;

            if (tB_Univ.Text == "")
            {
                label2.BackColor = Color.Red;
                isFull = false;
            }
            else label2.BackColor = Color.White;

            if (tB_Address.Text == "")
            {
                label4.BackColor = Color.Red;
                isFull = false;
            }
            else label4.BackColor = Color.White;

            if (tB_Specialty.Text == "")
            {
                label3.BackColor = Color.Red;
                isFull = false;
            }
            else label3.BackColor = Color.White;

            Regex regexp = new Regex(@"^[0-9]+([\,\.]{0,1}[0-9]+)?$");

            if (!regexp.IsMatch(tB_Day.Text))
            {
                label5.BackColor = Color.Red;
                isFull = false;
            }
            else label5.BackColor = Color.White;

            if (!regexp.IsMatch(tB_Night.Text))
            {
                label6.BackColor = Color.Red;
                isFull = false;
            }
            else label6.BackColor = Color.White;

            if (!regexp.IsMatch(tB_Dist.Text))
            {
                label7.BackColor = Color.Red;
                isFull = false;
            }
            else label7.BackColor = Color.White;

            if (!regexp.IsMatch(tB_Pay.Text))
            {
                label8.BackColor = Color.Red;
                isFull = false;
            }
            else label8.BackColor = Color.White;

            if (isFull)
            {
                UniversityStruct ExtraData = new UniversityStruct(tB_Univ.Text, tB_Address.Text, tB_Specialty.Text, tB_Day.Text, tB_Night.Text, tB_Dist.Text, tB_Pay.Text);
                readF.WriteData(ExtraData);
                MessageBox.Show("Запись была добавлена!");
            }
            else
            {
                MessageBox.Show("Убедитесь в правильности ввода данных");
            }

        }

        private void back_List_Click(object sender, EventArgs e) // Going to the table with universities. 
        {
            Universities form = new Universities();
            Hide();
            form.ShowDialog();
            Dispose();
        }


    }
}
