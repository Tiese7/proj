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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            textBoxpass.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            textBoxpass.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            textBoxconpass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            textBoxconpass.UseSystemPasswordChar = true;
        }

        private void buttonregis_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `3`(`email`, `username`, `password`) VALUES (@email, @usn, @pass)", db.GetConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBoxusername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxpass.Text;

            db.openConnection();

            if (!checkTextBoxesValues())
            {
                if (textBoxpass.Text.Equals(textBoxconpass.Text))
                {
                    if (checkusername())
                    {
                        MessageBox.Show("This Username Already taken!");
                    }
                    else
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("REGISTER SUCCESS!!");
                            this.Hide();
                            Form1 loginform = new Form1();
                            loginform.Show();
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password invalid!!");
                }
            }
            else
            {
                MessageBox.Show("Please type your information first");
            }

            db.closeConnection();
        }

        public Boolean checkusername()
        {
            DB db = new DB();

            String username = textBoxusername.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `3` WHERE `username` = @usn", db.GetConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkTextBoxesValues()
        {

            String email = textBoxmail.Text;
            String usern = textBoxusername.Text;
            String pass = textBoxpass.Text;
            if (email.Equals("") || usern.Equals("") || pass.Equals(""))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginform = new Form1();
            loginform.Show();
        }
    }
}
