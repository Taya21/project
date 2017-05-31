using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace project
{
    public partial class Universities : Form
    {
        DataTable table;
        List<UniversityStruct> UniversitiesList; // Keep data about all the universities and specialties. 
        List<UniversityStruct> Showlist; // The list which is shown in dataGridview. Its values are changing.
        ReadExternalFile readF;          // The variable for getting access to the funcions for work with a file.
        List<string> name_universities;  // List of universities from text file. 
        List<string> name_specialty;     // List of specialties from text file. 

        public Universities()
        {
            InitializeComponent();  
        }

       
        private void Universities_Load(object sender, EventArgs e) // Main table with universities. 
        {
            readF = new ReadExternalFile();
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
            table.Columns.Add("Контракт (дневная форма), грн", typeof(string));
            
            foreach (UniversityStruct univ in UniversitiesList) // Going through the university structure and fiil in the table
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

        private void Back_Click(object sender, EventArgs e) // Going to the main menu. 
        {
            Menu form = new Menu();
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void cb_Name_DropDownClosed(object sender, EventArgs e) // Choose one of the given universities.
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

        private void Show_Un_Click(object sender, EventArgs e) // Show all the universities without any chosen parametrs. 
        {
            table.Clear();
            Showlist = UniversitiesList;

            foreach (UniversityStruct univ in Showlist)
            {
                table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
            }

            dGV_tableUn.DataSource = table;
            cb_Name.SelectedIndex = -1;
            cb_specialty.SelectedIndex = -1;
        }

       
        private void cb_specialty_DropDownClosed(object sender, EventArgs e)  // Choose one of the given specialties.
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

        private bool Exist_data (List<string> list, string data)  // Check if this data in the list.
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

        private void Add_Specialty_Click(object sender, EventArgs e) // Going to another form, where we add a iniversity.
        {
            Specialties form = new Specialties(readF);
            Hide();
            form.ShowDialog();
            Dispose();
        }

        private void Delete_Click(object sender, EventArgs e) // Delete all the information about chosen university. Also we delete from text file.
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
                  
                    table.Clear();                      //Refresh data
                   
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

                    cb_specialty.DataSource = name_specialty;
                    cb_specialty.SelectedIndex = -1;

                    dGV_tableUn.AutoResizeColumns();

                    MessageBox.Show("Удаление прошло успешно");
                }
            }

            catch
            {
                MessageBox.Show("Нельзя удалить запись, т.к. она не выбрана");
            }
        }


        private void cb_Name_KeyPress(object sender, KeyPressEventArgs e) // Forbid the user to enter any iformation.
        {
            e.Handled = true;
        }

        private void cb_Name_KeyDown(object sender, KeyEventArgs e) // Forbid the user to enter any iformation.
        {
            e.Handled = true;
        }

        private void cb_specialty_KeyPress(object sender, KeyPressEventArgs e) // Forbid the user to enter any iformation.
        {
            e.Handled = true;
        }

        private void cb_specialty_KeyDown(object sender, KeyEventArgs e) // Forbid the user to enter any iformation.
        {
            e.Handled = true;
        }

        private void chBox_MinComp_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_specialty.SelectedItem != null && chBox_MinComp.Checked)
            {
                chBox_MinPay.Checked = false;
                Showlist = UniversitiesList.FindAll(a => a.Specialty == cb_specialty.SelectedItem.ToString());
                table.Clear();

                SortList_byConcurs(Showlist);

                foreach (UniversityStruct univ in Showlist)
                {
                    table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
                }
            }
            else if (chBox_MinComp.Checked)
            {
                chBox_MinPay.Checked = false;
                table.Clear();
                Showlist = UniversitiesList;
                SortList_byConcurs(Showlist);

                foreach (UniversityStruct univ in Showlist)
                {
                    table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
                }
            }
        }

        private void SortList_byConcurs(List<UniversityStruct> list)
        {
            UniversityStruct prom;
            double count = 0;
            do
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i + 1].CountDay < list[i].CountDay)
                    {
                        prom = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = prom;
                    }
                }
                count++;
            } while (count < list.Count);

        }

        private void chBox_MinPay_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_specialty.SelectedItem != null && chBox_MinPay.Checked)
            {
                chBox_MinComp.Checked = false;
                Showlist = UniversitiesList.FindAll(a => a.Specialty == cb_specialty.SelectedItem.ToString());
                table.Clear();

                SortList_byPrice(Showlist);

                foreach (UniversityStruct univ in Showlist)
                {
                    table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
                }
            }
            else if (chBox_MinPay.Checked)
            {
                chBox_MinComp.Checked = false;
                table.Clear();
                Showlist = UniversitiesList;
                SortList_byPrice(Showlist);

                foreach (UniversityStruct univ in Showlist)
                {
                    table.Rows.Add(univ.Name, univ.Address, univ.Specialty, univ.CountDay, univ.CountNight, univ.CountDist, univ.Payment);
                }
            }
        }

        private void SortList_byPrice(List<UniversityStruct> list)
        {
            UniversityStruct prom;
            double count = 0;
            do
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i + 1].Payment < list[i].Payment)
                    {
                        prom = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = prom;
                    }
                }
                count++;
            } while (count < list.Count);
        }
    }
}
