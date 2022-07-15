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
    public partial class AddPersonForm : Form
    {
        private MainForm _mainForm;
        private string conString = "Data Source=SKEEZE;Initial Catalog=kinda_CRM;Integrated Security=True";


        public AddPersonForm(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
            ControlBox = false;
        }

        private void AddPersonForm_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _mainForm.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        public void ClearField()
        {
            lastnameInput.Text = "";
            nameInput.Text = "";
            ageInput.Text = "";
            phoneInput.Text = "";
            addressInput.Text = "";
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (lastnameInput.Text != "" && nameInput.Text != "" && ageInput.Text != ""
                && phoneInput.Text != "" && addressInput.Text != "")
            {
                try
                {
                    string lastname = DeleteSpace(lastnameInput.Text);
                    string name = DeleteSpace(nameInput.Text);
                    int age = Int32.Parse(ageInput.Text);
                    string phone = DeleteSpace(phoneInput.Text);
                    string address = addressInput.Text;

                    
                    
                    string query = $"INSERT INTO people_list (ID, Lastname, Name, Age, PhoneNum, Address) VALUES " +
                        $"({MainForm.LastID + 1}, '{lastname}', '{name}', {age}, '{phone}', '{address}')";
                    
                    using (SqlConnection connection = new SqlConnection(conString))
                    {
                        connection.Open();
                        SqlCommand sqlCommand = new(query, connection);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show($"Пользователь успешно добавлен");

                        connection.Close();
                    }

                    this.Visible = false;
                    _mainForm.Visible = true;
                    lastnameInput.Text = "";
                    nameInput.Text = "";
                    ageInput.Text = "";
                    phoneInput.Text = "";
                    addressInput.Text = "";
                }
                catch
                {
                    MessageBox.Show("Одна или несколько строк имели неправильный формат данных.");
                }
            }
            else
            {
                MessageBox.Show("Убедитесь, что вы заполнили все поля");
            }
        }

        public static string DeleteSpace(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    str.Replace(str[i], Convert.ToChar(""));
                }
            }
            return str;
        }
    }
}
