using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = textBox1.Text;
            String password = textBox2.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `3` WHERE `username` = @usn and `password` = @pass", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Form3 mform = new Form3();
                mform.Show();
            }
            else 
            {
                MessageBox.Show("Invalid username or password please check again!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 regisform = new Form2();
            regisform.Show();
        }
    }
}
