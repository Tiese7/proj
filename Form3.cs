using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class Form3 : Form
    {
        bool check_americano = false;
        bool check_espr = false;
        bool check_cappu = false;
        bool check_latte = false;
        bool check_moc = false;
        bool check_BT = false;
        bool check_GT = false;
        bool check_MT = false;
        bool check_LT = false;
        bool check_cocoa = false;
        bool check_cara = false;
        bool check_Lsoda = false;
        bool check_Hlemon = false;

        public Form3()
        {
            InitializeComponent();
            numericUpDownmerica.Enabled = false;
            numericUpDownespr.Enabled = false;
            numericUpDowncappu.Enabled = false;
            numericUpDownlatte.Enabled = false;
            numericUpDownmoc.Enabled = false;
            numericUpDownBT.Enabled = false;
            numericUpDownMT.Enabled = false;
            numericUpDownGT.Enabled = false;
            numericUpDownLT.Enabled = false;
            numericUpDowncocoa.Enabled = false;
            numericUpDowncara.Enabled = false;
            numericUpDownLsoda.Enabled = false;
            numericUpDownHlemon.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            String[] mune = { "อเมริกาโน่", "เอสเพรสโซ่", "คาปูชิโน่", "ลาเต้", "มอคค่า", "ชาดำเย็น", "ชานมเย็น", "ชาเขียว", "ชามะนาว", "โกโก้",
                "คาราเมลนมสด", "มะนาวโซดา", "น้ำผึ้งมะนาว" };
            int k = 0;
            while (k < 13)
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = mune[k];
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = "0";
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = "0";
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = "";
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                k++;
            }
            this.Hide();
            Form1 loginform = new Form1();
            loginform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c1, c2, c3, c4, c5, t1, t2, t3, t4, o1, o2, o3, o4;
            if (check_americano == true)
            {
                c1 = int.Parse(numericUpDownmerica.Text);
            }
            else
            {
                c1 = 0;
            }
            if (check_espr == true)
            {
                c2 = int.Parse(numericUpDownespr.Text);
            }
            else 
            {
                c2 = 0;
            }
            if (check_cappu == true)
            {
                c3 = int.Parse(numericUpDowncappu.Text);
            }
            else
            {
                c3 = 0;
            }
            if (check_latte == true)
            {
                c4 = int.Parse(numericUpDownlatte.Text);
            }
            else
            {
                c4 = 0;
            }
            if (check_moc == true)
            {
                c5 = int.Parse(numericUpDownmoc.Text);
            }
            else 
            {
                c5 = 0;
            }
            if (check_BT == true)
            {
                t1 = int.Parse(numericUpDownBT.Text);
            }
            else
            {
                t1 = 0;
            }
            if (check_MT == true)
            {
                t2 = int.Parse(numericUpDownMT.Text);
            }
            else
            {
                t2 = 0;
            }
            if (check_GT == true)
            {
                t3 = int.Parse(numericUpDownGT.Text);
            }
            else
            {
                t3 = 0;
            }
            if (check_LT == true)
            {
                t4 = int.Parse(numericUpDownLT.Text);
            }
            else
            {
                t4 = 0;
            }
            if (check_cocoa == true)
            {
                o1 = int.Parse(numericUpDowncocoa.Text);
            }
            else
            {
                o1 = 0;
            }
            if (check_cara == true)
            {
                o2 = int.Parse(numericUpDowncara.Text);
            }
            else
            {
                o2 = 0;
            }
            if (check_Lsoda == true)
            {
                o3 = int.Parse(numericUpDownLsoda.Text);
            }
            else
            {
                o3 = 0;
            }
            if (check_Hlemon == true)
            {
                o4 = int.Parse(numericUpDownHlemon.Text);
            }
            else
            {
                o4 = 0;
            }
            
            
            int total;
            total = (c1 * 25) + (c2 * 25) + (c3 * 25) + (c4 * 25) + (c5 * 25) 
                + (t1 * 25) + (t2 * 25) + (t3 * 25) + (t4 * 25) + (o1 * 25) + (o2 * 25) 
                + (o3 * 25) + (o4 * 25);
            totalprice.Text = total.ToString();
            
        }

        private void checkBoxamerica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxamerica.Checked == true)
            {
                numericUpDownmerica.Enabled = true;
                check_americano = true;
                
            }
            else
            {
                numericUpDownmerica.Enabled = false;
                check_americano = false;
            }
        }

        private void checkBoxespress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxespress.Checked == true)
            {
                numericUpDownespr.Enabled = true;
                check_espr = true;
            }
            else
            {
                numericUpDownespr.Enabled = false;
                check_espr = false;
            }
        }

        private void checkBoxcappu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcappu.Checked == true)
            {
                numericUpDowncappu.Enabled = true;
                check_cappu = true;
            }
            else
            {
                numericUpDowncappu.Enabled = false;
                check_cappu = false;
            }
        }

        private void checkBoxlatte_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxlatte.Checked == true)
            {
                numericUpDownlatte.Enabled = true;
                check_latte = true;
            }
            else
            {
                numericUpDownlatte.Enabled = false;
                check_latte = false;
            }
        }

        private void checkBoxmoc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxmoc.Checked == true)
            {
                numericUpDownmoc.Enabled = true;
                check_moc = true;
            }
            else
            {
                numericUpDownmoc.Enabled = false;
                check_moc = false;
            }
        }

        private void checkBoxBT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBT.Checked == true)
            {
                numericUpDownBT.Enabled = true;
                check_BT = true;
            }
            else
            {
                numericUpDownBT.Enabled = false;
                check_BT = false;
            }
        }

        private void checkBoxMT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMT.Checked == true)
            {
                numericUpDownMT.Enabled = true;
                check_MT = true;
            }
            else
            {
                numericUpDownMT.Enabled = false;
                check_MT = false;
            }
        }

        private void checkBoxGT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGT.Checked == true)
            {
                numericUpDownGT.Enabled = true;
                check_GT = true;
            }
            else
            {
                numericUpDownGT.Enabled = false;
                check_GT = false;
            }
        }

        private void checkBoxLT_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLT.Checked == true)
            {
                numericUpDownLT.Enabled = true;
                check_LT = true;
            }
            else
            {
                numericUpDownLT.Enabled = false;
                check_LT = false;
            }
        }

        private void checkBoxcocoa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcocoa.Checked == true)
            {
                numericUpDowncocoa.Enabled = true;
                check_cocoa = true;
            }
            else
            {
                numericUpDowncocoa.Enabled = false;
                check_cocoa = false;
            }
        }

        private void checkBoxcara_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxcara.Checked == true)
            {
                numericUpDowncara.Enabled = true;
                check_cara = true;
            }
            else
            {
                numericUpDowncara.Enabled = false;
                check_cara = false;
            }
        }

        private void checkBoxLsoda_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLsoda.Checked == true)
            {
                numericUpDownLsoda.Enabled = true;
                check_Lsoda = true;
            }
            else
            {
                numericUpDownLsoda.Enabled = false;
                check_Lsoda = false;
            }
        }

        private void checkBoxHlemon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHlemon.Checked == true)
            {
                numericUpDownHlemon.Enabled = true;
                check_Hlemon = true;
            }
            else
            {
                numericUpDownHlemon.Enabled = false;
                check_Hlemon = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ORDER COMPLETE!");
            if (checkBoxamerica.Checked == true)
            {
                
                string meca = "อเมริกาโน่";
                String o = Convert.ToInt32(numericUpDownmerica.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownmerica.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if(checkBoxespress.Checked)
            {
                string meca = "เอสเพรสโซ่";
                String o = Convert.ToInt32(numericUpDownespr.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownespr.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxcappu.Checked)
            {
                string meca = "คาปูชิโน่";
                String o = Convert.ToInt32(numericUpDowncappu.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDowncappu.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxlatte.Checked)
            {
                string meca = "ลาเต้";
                String o = Convert.ToInt32(numericUpDownlatte.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownlatte.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxmoc.Checked)
            {
                string meca = "มอคค่า";
                String o = Convert.ToInt32(numericUpDownmoc.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownmoc.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxBT.Checked)
            {
                string meca = "ชาดำเย็น";
                String o = Convert.ToInt32(numericUpDownBT.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownBT.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxMT.Checked)
            {
                string meca = "ชานมเย็น";
                String o = Convert.ToInt32(numericUpDownMT.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownMT.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxGT.Checked)
            {
                string meca = "ชาเขียว";
                String o = Convert.ToInt32(numericUpDownGT.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownGT.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxLT.Checked)
            {
                string meca = "ชามะนาว";
                String o = Convert.ToInt32(numericUpDownLT.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownLT.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxcocoa.Checked)
            {
                string meca = "โกโก้";
                String o = Convert.ToInt32(numericUpDowncocoa.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDowncocoa.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxcara.Checked)
            {
                string meca = "คาราเมลนมสด";
                String o = Convert.ToInt32(numericUpDowncara.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDowncara.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxLsoda.Checked)
            {
                string meca = "มะนาวโซดา";
                String o = Convert.ToInt32(numericUpDownLsoda.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownLsoda.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
            if (checkBoxHlemon.Checked)
            {
                string meca = "น้ำผึ้งมะนาว";
                String o = Convert.ToInt32(numericUpDownHlemon.Value).ToString();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `lnwza007` SET `count`=@cunt,`price`=@pri,`address`=@adr WHERE `namai`=@nama", db.GetConnection());

                command.Parameters.Add("@nama", MySqlDbType.VarChar).Value = meca;
                command.Parameters.Add("@cunt", MySqlDbType.VarChar).Value = o.ToString();
                command.Parameters.Add("@pri", MySqlDbType.VarChar).Value = Convert.ToDouble(numericUpDownHlemon.Value * 25).ToString();
                command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = textBox2.Text;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void totalprice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
