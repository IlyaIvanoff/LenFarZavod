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

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=LenFarZabod;Integrated Security=True;Encrypt=False";
        public Form5()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем подключение к базе данных
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открываем подключение
                    connection.Open();

                    // Создаем команду для вставки данных из таблицы "Корзина" в таблицу "Заказы"
                    string insertQuery = "INSERT INTO Заказ (Id, Количество, FIO) SELECT Id, Количество, FIO FROM Корзина";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);

                    // Выполняем команду
                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    // Создаем команду для очистки таблицы "Корзина"
                    string deleteQuery = "DELETE FROM Корзина";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);

                    // Выполняем команду очистки
                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Заказ успешно создан.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании заказа: " + ex.Message);
            }
        }

        private void SearchCart_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Корзина";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        // Открываем подключение и создаем адаптер данных
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Заполняем таблицу данными из базы данных
                        adapter.Fill(dataTable);

                        // Привязываем таблицу к элементу управления DataGridView
                        dataGridViewOrders.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }

        private void CancelUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываем подключение
                connection.Open();

                // Создаем команду для очистки таблицы "Корзина"
                SqlCommand deleteCommand = new SqlCommand("DELETE FROM Корзина", connection);

                try
                {
                    // Выполняем команду очистки
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Заказ отменен. Корзина очищена.");

                    // Закрываем форму
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отмене заказа: " + ex.Message);
                }
            }
        }
    }
}
