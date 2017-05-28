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
        ReadExternalFiles readF;
        List<UniversityStruct> UnList;

        public Specialties(ReadExternalFiles ReadF, List<UniversityStruct> UniversitiesList)
        {
            InitializeComponent();

            readF = ReadF;
            UnList = UniversitiesList;

            List<string> name_universities = new List<string>();
            List<string> name_specialty = new List<string>();

            foreach (UniversityStruct univ in UniversitiesList)
            {
                if (!Exist_data(name_universities, univ.Name)) { name_universities.Add(univ.Name); }
            }

            cB_Un.DataSource = name_universities;
            cB_Un.SelectedIndex = -1;

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void Specialties_Load(object sender, EventArgs e)
        {

        }

        private bool Exist_data(List<string> list, string data)
        {
            bool res = false;
            foreach (string l in list)
            {
                if (l == data)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        
        private void cB_Un_DropDownClosed(object sender, EventArgs e)
        {
            List<UniversityStruct> univ = new List<UniversityStruct>();
            univ = UnList.FindAll(a => a.Name == cB_Un.SelectedItem.ToString());
            
            tB_Univ.Text = univ[0].Name;
            tB_Address.Text = univ[0].Address;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            UniversityStruct WData = new UniversityStruct(tB_Univ.Text, tB_Address.Text,tB_Specialty.Text,tB_Day.Text,tB_Night.Text,tB_Dist.Text,tB_Pay.Text);
            readF.Write_Data(WData);
        }

        private void back_List_Click(object sender, EventArgs e)
        {
            Universities form = new Universities();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        
    }
}
