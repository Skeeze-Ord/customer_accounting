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

                    _mainForm.Members.Add(new Person(0, lastname, name, age, phone, address));

                    string conString = @"Data Source=SKEEZE;Initial Catalog=kinda_CRM;Integrated Security=True";

                    using (SqlConnection connection = new(conString))
                    {
                        connection.Open();
                        //string add = "INSERT people_list(Lastname, Name, Age, PhoneNum, Address) VALUES" +

                        //    $"({lastname}, {name}, {age}, {phone}, {address})";
                        string add = "INSERT people_list(ID, Lastname, Name, Age, PhoneNum, Address) VALUES" +
                           "(13, 'lastname', 'name', 'age', 'phone', 'address'";
                        SqlCommand addNew = new(add, connection);
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
