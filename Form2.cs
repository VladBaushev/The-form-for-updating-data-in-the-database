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
using System.Globalization;
using System.Threading;
using System.Resources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_Forms__.NET_Framework_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS; Database=Задание2;Integrated Security=True";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                string query = "select * from Перевозка";
                SqlCommand command = new SqlCommand(query, myConnection);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    // Проверяем количество столбцов
                    int fieldCount = reader.FieldCount;
                    string[] row = new string[fieldCount];

                    for (int i = 0; i < fieldCount; i++)
                    {
                        row[i] = reader[i].ToString();
                    }

                    data.Add(row);
                }

                reader.Close();
                myConnection.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
        }

        private void InsertData(string field1, string field2, string field3, string field4, string field5, string field6, string field7)
        {
            string connectionString = "Data Source=.\\SQLEXPRESS; Database=Задание2;Integrated Security=True";
            using (SqlConnection myConnection = new SqlConnection(connectionString))
            {
                myConnection.Open();
                string query = "INSERT INTO Перевозка (id, Машина, [Время выезда], Выполнение, [Начальная остановка], [Конечная остановка], Груз) VALUES (@field1, @field2, @field3, @field4, @field5, @field6, @field7)";

                using (SqlCommand command = new SqlCommand(query, myConnection))
                {
                    command.Parameters.AddWithValue("@field1", field1);
                    command.Parameters.AddWithValue("@field2", field2);
                    command.Parameters.AddWithValue("@field3", field3);
                    command.Parameters.AddWithValue("@field4", field4);
                    command.Parameters.AddWithValue("@field5", field5);
                    command.Parameters.AddWithValue("@field6", field6);
                    command.Parameters.AddWithValue("@field7", field7);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string field1 = textBox1.Text.Trim();
            string field2 = textBox2.Text.Trim();
            string field3 = textBox3.Text.Trim();
            string field4 = textBox4.Text.Trim();
            string field5 = textBox5.Text.Trim();
            string field6 = textBox6.Text.Trim();
            string field7 = textBox7.Text.Trim();

            try
            {
                InsertData(field1, field2, field3, field4, field5, field6, field7);

                dataGridView1.Rows.Clear();

                LoadData(); // Обновление данных в DataGridView

                // Очистка текстовых полей после успешной вставки
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при вставке данных: " + ex.Message);
            }

            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(field1) ||
                string.IsNullOrWhiteSpace(field2) ||
                string.IsNullOrWhiteSpace(field3) ||
                string.IsNullOrWhiteSpace(field4) ||
                string.IsNullOrWhiteSpace(field5) ||
                string.IsNullOrWhiteSpace(field6) ||
                string.IsNullOrWhiteSpace(field7))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
        }

    }
}
