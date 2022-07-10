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
        public List<Person> Members { get; set; }

        private string conString = "Data Source=SKEEZE;Initial Catalog=kinda_CRM;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
            _addPerson = new AddPersonForm(this) { Visible = false };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _addPerson.Visible = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString() + " " + reader[2].ToString();
                data[data.Count - 1][2] = reader[3].ToString();
                data[data.Count - 1][3] = reader[4].ToString();
                data[data.Count - 1][4] = reader[5].ToString();
            }
            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

            AllUsersCount.Text = Convert.ToString(data.Count);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            int currentID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                string query = $"DELETE FROM people_list WHERE ID = {currentID}";
                SqlCommand sqlCommand = new(query, connection);
                int num = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"Удалено объектов: {num}");
                connection.Close();
            }

            dataGridView1.Update();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
