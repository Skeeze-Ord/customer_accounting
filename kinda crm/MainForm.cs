﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kinda_crm
{
    public partial class MainForm : Form
    {
        private AddPersonForm _addPerson;
        public static int LastID { get; set; }

        public readonly string conString = "Data Source=SKEEZE;Initial Catalog=kinda_CRM;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            _addPerson = new AddPersonForm(this) { Visible = false };
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _addPerson.Visible = true;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchWord = searchInput.Text;
            if (searchWord != "")
            {
                using SqlConnection connection = new(conString);
                string query = $"SELECT * FROM people_list WHERE Lastname = '{searchWord}' OR Name = '{searchWord}' ORDER BY ID";
                connection.Open();
                SqlCommand command = new(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new();
                while (reader.Read())
                {
                    data.Add(new string[5]);

                    data[^1][0] = reader[0].ToString();
                    data[^1][1] = reader[1].ToString() + " " + reader[2].ToString();
                    data[^1][2] = reader[3].ToString();
                    data[^1][3] = reader[4].ToString();
                    data[^1][4] = reader[5].ToString();
                }
                reader.Close();

                connection.Close();

                dataGridView1.Rows.Clear();

                foreach (var items in data)
                {
                    dataGridView1.Rows.Add(items);
                }

                AllUsersCount.Text = Convert.ToString(data.Count);
            }
            else
            {
                dataGridView1.Rows.Clear();
                MainForm_Load(sender, e);
            }
            UpdateButton_Click(sender, e);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new(conString);
            sqlConnection.Open();
            string query = "SELECT * FROM people_list ORDER BY ID";
            SqlCommand command = new(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new();
            while (reader.Read())
            {
                data.Add(new string[5]);

                data[^1][0] = reader[0].ToString();
                data[^1][1] = reader[1].ToString() + " " + reader[2].ToString();
                data[^1][2] = reader[3].ToString();
                data[^1][3] = reader[4].ToString();
                data[^1][4] = reader[5].ToString();
            }
            reader.Close();
            sqlConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

            // Кол-во пользователей
            AllUsersCount.Text = Convert.ToString(data.Count);

            // Индекс если нет пользователей
            if(dataGridView1.Rows.Count != 0)
                LastID = Int32.Parse(data[^1][0]);
            else
                LastID = -1;

            ToolTip tool = new();
            tool.SetToolTip(UpdateButton, "Обновить");
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            if (searchInput.Text == "")
            {
                this.dataGridView1.Rows.Clear();
                MainForm_Load(sender, e);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            int currentID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = $"DELETE FROM people_list WHERE ID = {currentID}";
                SqlCommand sqlCommand = new(query, connection);
                int num = sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Пользователь удален");
                connection.Close();
            }

            dataGridView1.Update();
            dataGridView1.Refresh();

            UpdateButton_Click(sender, e);
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void ClearPic_Click(object sender, EventArgs e)
        {
            searchInput.Text = "";
        }
    }
}
