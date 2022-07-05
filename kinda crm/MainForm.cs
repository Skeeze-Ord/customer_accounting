using System;
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
            string conString = @"Data Source=SKEEZE;Initial Catalog=kinda_CRM;Integrated Security=True";
            SqlConnection sqlConnection = new(conString);
            sqlConnection.Open();
            string query = "SELECT * FROM people_list ORDER BY ID";
            SqlCommand command = new(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[1].ToString() + " " + reader[2].ToString();
                data[data.Count - 1][1] = reader[3].ToString();
                data[data.Count - 1][2] = reader[4].ToString();
                data[data.Count - 1][3] = reader[5].ToString();
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
    }
}
