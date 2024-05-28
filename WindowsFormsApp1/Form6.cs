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
    public partial class Form6 : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=LenFarZabod;Integrated Security=True;Encrypt=False";
        public Form6()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        private void CheckOrders_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Заказ";
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
                        UsersOrders.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }
        private void CheckItems_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Склад";
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
                        Nalichie.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }
        }
        private void SearchItem_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(IdItem.Text, out id))
            {
                MessageBox.Show("Введите корректный Id.");
                return;
            }

            // Создаем подключение к базе данных и команду SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Склад WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавляем параметр для безопасного поиска по Id
                    command.Parameters.AddWithValue("@Id", id);
                    try
                    {
                        // Открываем подключение и выполняем команду
                        connection.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        // Заполняем таблицу данными из базы данных
                        adapter.Fill(dataTable);

                        // Проверяем, есть ли результаты поиска
                        if (dataTable.Rows.Count > 0)
                        {
                            // Если есть, отображаем их в DataGridView или другом месте
                            Nalichie.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("Ничего не найдено по указанному Id.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                    }
                }
            }

        }
        private void AcceptOrder_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(OrderId.Text, out id))
            {
                MessageBox.Show("Введите корректный Id.");
                return;
            }

            // Создаем подключение к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываем подключение
                connection.Open();
                // Начинаем транзакцию
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Обновляем статус заказа на "принято" в таблице "Заказ"
                    string updateStatusQuery = "UPDATE Заказ SET Статус = 'принято' WHERE Id = @Id";
                    SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection, transaction);
                    updateStatusCommand.Parameters.AddWithValue("@Id", id);
                    updateStatusCommand.ExecuteNonQuery();
                    // Получаем количество товара из заказа
                    string getQuantityQuery = "SELECT Количество FROM Заказ WHERE Id = @Id";
                    SqlCommand getQuantityCommand = new SqlCommand(getQuantityQuery, connection, transaction);
                    getQuantityCommand.Parameters.AddWithValue("@Id", id);
                    int quantity = Convert.ToInt32(getQuantityCommand.ExecuteScalar());
                    // Вычитаем количество товара из таблицы "Склад"
                    string updateWarehouseQuery = "UPDATE Склад SET Количество = Количество - @Quantity WHERE Id = @Id";
                    SqlCommand updateWarehouseCommand = new SqlCommand(updateWarehouseQuery, connection, transaction);
                    updateWarehouseCommand.Parameters.AddWithValue("@Quantity", quantity);
                    updateWarehouseCommand.Parameters.AddWithValue("@Id", id);
                    updateWarehouseCommand.ExecuteNonQuery();
                    // Завершаем транзакцию
                    transaction.Commit();
                    MessageBox.Show("Заказ успешно принят и товар списан со склада.");
                }
                catch (Exception ex)
                {
                    // Откатываем транзакцию в случае ошибки
                    transaction.Rollback();
                    MessageBox.Show("Ошибка при принятии заказа: " + ex.Message);
                }
            }
        }
    private void CancelOrder_Click(object sender, EventArgs e)
        {
            // Получаем значение Id из текстового поля
            int id;
            if (!int.TryParse(OrderId.Text, out id))
            {
                MessageBox.Show("Введите корректный Id.");
                return;
            }

            // Создаем подключение к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открываем подключение
                connection.Open();

                // Начинаем транзакцию
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Обновляем статус заказа на "отклонен" в таблице "Заказ"
                    string updateStatusQuery = "UPDATE Заказ SET Статус = 'отклонен' WHERE Id = @Id";
                    SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection, transaction);
                    updateStatusCommand.Parameters.AddWithValue("@Id", id);
                    updateStatusCommand.ExecuteNonQuery();

                    // Удаляем запись из таблицы "Заказ"
                    string deleteOrderQuery = "DELETE FROM Заказ WHERE Id = @Id";
                    SqlCommand deleteOrderCommand = new SqlCommand(deleteOrderQuery, connection, transaction);
                    deleteOrderCommand.Parameters.AddWithValue("@Id", id);
                    deleteOrderCommand.ExecuteNonQuery();

                    // Завершаем транзакцию
                    transaction.Commit();
                    MessageBox.Show("Заказ успешно отклонен и удален из базы данных.");
                }
                catch (Exception ex)
                {
                    // Откатываем транзакцию в случае ошибки
                    transaction.Rollback();
                    MessageBox.Show("Ошибка при отклонении заказа: " + ex.Message);
                }
            }
        }
    }
}
