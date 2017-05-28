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
        List<string> name_universities;
        List<string> name_specialty;

        public Universities()
        {
            InitializeComponent();  
        }

        private void Universities_Load(object sender, EventArgs e)
        {
            readF = new ReadExternalFiles();
            UniversitiesList = readF.ReadFile();
            Showlist = UniversitiesList;

            name_universities = new List<string>();
            name_specialty = new List<string>();

            table = new DataTable();
            table.Columns.Add("Название ", typeof(string));
            table.Columns.Add("Адрес ", typeof(string));
            table.Columns.Add("Специальность", typeof(string));
            table.Columns.Add("Дневная", typeof(string));
            table.Columns.Add("Вечерняя", typeof(string));
            table.Columns.Add("Заочная", typeof(string));
            table.Columns.Add("Контракт", typeof(string));

            

            foreach (UniversityStruct univ in UniversitiesList)
            {
                table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);

                if (!Exist_data(name_specialty, univ.Specialty)) { name_specialty.Add(univ.Specialty); }
                if (!Exist_data(name_universities, univ.Name)) { name_universities.Add(univ.Name); }
            }

            dGV_tableUn.DataSource = table;

            cb_Name.DataSource = name_universities;
            cb_Name.SelectedIndex = -1;

            cb_specialty.DataSource = name_specialty;
            cb_specialty.SelectedIndex = -1;

            dGV_tableUn.AutoResizeColumns();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void cb_Name_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_Name.SelectedItem != null)
            {
                Showlist = UniversitiesList.FindAll(a => a.Name == cb_Name.SelectedItem.ToString());

                table.Clear();

                foreach (UniversityStruct univ in Showlist)
                {
                    table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
                }

                dGV_tableUn.DataSource = table;
            }
        }

        private void Show_Un_Click(object sender, EventArgs e)
        {
            table.Clear();
            Showlist = UniversitiesList;

            foreach (UniversityStruct univ in Showlist)
            {
                table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
            }
            dGV_tableUn.DataSource = table;
            cb_Name.SelectedIndex = -1;
        }

       
        private void cb_specialty_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_specialty.SelectedItem != null)
            {
                Showlist = UniversitiesList.FindAll(a => a.Specialty == cb_specialty.SelectedItem.ToString());

                table.Clear();

                foreach (UniversityStruct univ in Showlist)
                {
                    table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
                }

                dGV_tableUn.DataSource = table;
            }
        }

        private bool Exist_data (List<string> list, string data)
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

        private void Add_Specialty_Click(object sender, EventArgs e)
        {
            Specialties form = new Specialties(readF,UniversitiesList);
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    string lineForDelete = dGV_tableUn.CurrentRow.Cells[0].Value.ToString() + "|" +
                               dGV_tableUn.CurrentRow.Cells[1].Value.ToString() + "|" +
                               dGV_tableUn.CurrentRow.Cells[2].Value.ToString() + "|" +
                               dGV_tableUn.CurrentRow.Cells[3].Value.ToString() + "|" +
                               dGV_tableUn.CurrentRow.Cells[4].Value.ToString() + "|" +
                               dGV_tableUn.CurrentRow.Cells[5].Value.ToString() + "|" +
                               dGV_tableUn.CurrentRow.Cells[6].Value.ToString();


                    readF.DeleteLine(lineForDelete);

                    //Refresh data
                    table.Clear();
                    cb_Name.DataSource = null;
                    cb_specialty.DataSource = null;

                    name_specialty.Clear();
                    name_universities.Clear();
                    UniversitiesList = readF.ReadFile();

                    foreach (UniversityStruct univ in UniversitiesList)
                    {
                        table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);

                        if (!Exist_data(name_specialty, univ.Specialty)) { name_specialty.Add(univ.Specialty); }
                        if (!Exist_data(name_universities, univ.Name)) { name_universities.Add(univ.Name); }
                    }

                    dGV_tableUn.DataSource = table;
                    //cb_Name.DataSource = name_universities;
                    //cb_Name.SelectedIndex = -1;

                    cb_specialty.DataSource = name_specialty;
                    cb_specialty.SelectedIndex = -1;

                    dGV_tableUn.AutoResizeColumns();

                    MessageBox.Show("Delete is successful");

                }
            }
            catch
            {
                MessageBox.Show("Нельзя удалить запись, т.к. она не выбана");
            }
        }


        private void cb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_Name_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_specialty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_specialty_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
    }
}
