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

namespace Windows_Forms__.NET_Framework_
{
    public partial class Form3 : Form
    {
        DataBase dataBase = new DataBase();
        public Form3()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var LoginUser = textBox1.Text;
            var PassUser = textBox2.Text;

            string querystring = $"insert into register([Login сотрудника], [Password сотрудника]) values('{LoginUser}', '{PassUser}')";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан", "Аккаунт успешно создан");
                Form3 frm3 = new Form3();
                this.Hide();
                frm3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан", "Создание аккаунта неуспешно");
            }
            dataBase.closeConnection();
        }
        private Boolean checuser()
        {
            var LoginUser = textBox1.Text;
            var PassUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select [Id сотрудника], [Login сотрудника], [Password сотрудника] from register where [Login сотрудника] = '{LoginUser}' and [Password сотрудника] = '{PassUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Сотрудник ранее был зарегистрирован");
                return true;    
            }
            else
            { 
            return false;
            }
        }

 private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
