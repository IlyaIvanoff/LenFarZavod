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
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source=DESKTOP-CTEHH5B\SQLEXPRESS;Initial Catalog=LenFarZabod;Integrated Security=True;Encrypt=False";
        public Form4()
        {
            InitializeComponent();
        }
        private void AddToCart_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Проверяем, что введены корректные числа в текстовые поля
                int numberBalet;
                int kolvoBalet;

                if (!int.TryParse(NumberBalet.Text, out numberBalet) ||
                    !int.TryParse(KolvoBalet.Text, out kolvoBalet))
                {
                    MessageBox.Show("Введите корректные числа.");
                    return;
                }

                // Создаем подключение к базе данных и команду SQL
                string query = "INSERT INTO Корзина (Id, Количество, FIO) VALUES (@NumberBalet, @KolvoBalet, @FIO)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Добавляем параметры для безопасной вставки данных
                    command.Parameters.AddWithValue("@NumberBalet", numberBalet);
                    command.Parameters.AddWithValue("@KolvoBalet", kolvoBalet);
                    command.Parameters.AddWithValue("@FIO", FIO.Text);

                    try
                    {
                        // Открываем подключение и выполняем команду
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Товар успешно добавлен в корзину.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при добавлении товара: " + ex.Message);
                    }
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Close();
        }

        private void GoToCart_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
