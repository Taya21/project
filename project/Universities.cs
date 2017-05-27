using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace project
{
    public partial class Universities : Form
    {
        DataTable table;
        List<UniversityStruct> UniversitiesList;
        List<UniversityStruct> Showlist;
        ReadExternalFiles readF;

        public Universities()
        {
            InitializeComponent();  
        }

        private void Universities_Load(object sender, EventArgs e)
        {
            readF = new ReadExternalFiles();
            UniversitiesList = readF.ReadFile();
            Showlist = UniversitiesList;

            List<string> name_universities = new List<string>();

            table = new DataTable();
            table.Columns.Add("Название ", typeof(string));
            table.Columns.Add("Адресс ", typeof(string));
            table.Columns.Add("Дневная", typeof(string));
            table.Columns.Add("Вечерняя", typeof(string));
            table.Columns.Add("Заочная", typeof(string));

            foreach (UniversityStruct univ in UniversitiesList)
            {
                table.Rows.Add(univ.Name, univ.Address, univ.CountDay, univ.CountNight, univ.CountDist);
                name_universities.Add(univ.Name);
            }

            dGV_tableUn.DataSource = table;

            cb_Name.DataSource = name_universities;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void cb_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Showlist = UniversitiesList.FindAll(a => a.Name == cb_Name.SelectedItem.ToString());

            table.Clear();

            foreach (UniversityStruct univ in Showlist)
            {
                table.Rows.Add(univ.Name, univ.Address, univ.CountDay, univ.CountNight, univ.CountDist);
            }

            dGV_tableUn.DataSource = table;
        }

        private void Show_Un_Click(object sender, EventArgs e)
        {
            table.Clear();
            Showlist = UniversitiesList;

            foreach (UniversityStruct univ in Showlist)
            {
                table.Rows.Add(univ.Name, univ.Address, univ.CountDay, univ.CountNight, univ.CountDist);
            }
            dGV_tableUn.DataSource = table;
        }
    }
}
