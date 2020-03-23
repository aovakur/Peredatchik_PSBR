using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            DBUtils.Datasource1 =Convert.ToString(textBox1.Text);
            DBUtils.Database1=Convert.ToString(textBox2.Text);
            DBUtils.Username1=Convert.ToString(textBox3.Text);
            DBUtils.Password1=Convert.ToString(textBox4.Text);
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(DBUtils.Datasource1);
            textBox2.Text = Convert.ToString(DBUtils.Database1);
            textBox3.Text = Convert.ToString(DBUtils.Username1);
            textBox4.Text = "**********";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string datasource = @".\SQLEXPRESS";
            string database = "ps_bankrussia";
            string username = "adminkbr";
            string password = "aA12345678";

            if (checkBox1.Checked == true)
                {
                 
                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    textBox3.ReadOnly = true;
                    textBox4.ReadOnly = true;

                    textBox1.Text = datasource;
                    textBox2.Text = database;
                    textBox3.Text = "**********";
                    textBox4.Text = "**********";

                    DBUtils.Datasource1 = datasource;
                    DBUtils.Database1 = database;
                    DBUtils.Username1 = username;
                    DBUtils.Password1 = password;

                    button1.Visible = false;
            }

            else
            {

                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                button1.Visible = true;
            }

        }
    }
}
