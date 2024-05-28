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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public Form1()
        {
            InitializeComponent();
            Password.TextChanged += Password_TextChanged;
            show.CheckedChanged += show_CheckedChanged;
            InitializeDatabaseConnection();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=LenFarZabod;Integrated Security=True;Encrypt=False";
            sqlConnection = new SqlConnection(connectionString);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
            if (!show.Checked)
            {
                Password.PasswordChar = '*';
            }
            else
            {
                Password.PasswordChar = '\0';
            }
        }
        private void show_CheckedChanged(object sender, EventArgs e)
        {
                Password_TextChanged(sender, e);
        }

        private void Registr_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); /*переход на другую форму*/
            form2.Show();
            this.Hide();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            string login = Login.Text;
            string password = Password.Text;

            if (ValidateUser(login, password)) /*проверка логина и пароля*/
            {
                if (login == "admin" && password == "admin")
                {
                    Form6 form6 = new Form6();
                    form6.Show();
                    this.Hide();
                }
                else
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
        private bool ValidateUser(string login, string password)
        {
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Data WHERE Login = @Login AND Password = @Password", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Login", login);
                sqlCommand.Parameters.AddWithValue("@Password", password);

                int result = (int)sqlCommand.ExecuteScalar();

                return result > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
    }
