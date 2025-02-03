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
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 50;
            textBox2.MaxLength = 50;
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var LoginUser = textBox1.Text;
            var PassUser = textBox2.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select [Id сотрудника], [Login сотрудника],[Password сотрудника] from register where [Login сотрудника] = '{LoginUser}' and [Password сотрудника] = '{PassUser}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Доступ предоставлен", "Доступ не предоставлен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.Show();
            }
            else
            {
                MessageBox.Show("Доступ не предоставлен", "Доступ предоставлен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            button3.Visible = true;
            button4.Visible = false;
        }
    }
}