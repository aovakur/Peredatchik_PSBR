using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApp2
{

    
    public partial class Form6 : Form
    {
       
        public Form6()
        {
            InitializeComponent();
            //ReadAllSettings();
            checkBox1.Checked = true;

           // ReadSetting("NotValid");
           //AddUpdateAppSettings("NewSetting", "May 7, 2014");
           //AddUpdateAppSettings("Setting1", "May 8, 2014");
          
        }




        public static string ReadSetting(string key)
        {
            string ErrorMSG = "Error ";

            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;

            }
            catch (ConfigurationErrorsException)
            {
                //Console.WriteLine("Error reading app settings");
                return ErrorMSG;
            }

           
        }

        static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
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

            //string datasource = @"DESKTOP-9H4S4ED\SQLEXPRESS";
            //string database = "ps_bankrussia";
            //string username = "adminkbr";
            //string password = "aA12345678";

            if (checkBox1.Checked == true)
                {

                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                button1.Visible = false;

                DBUtils.Datasource1 = Convert.ToString(Form6.ReadSetting("datasource"));
                DBUtils.Database1 = Convert.ToString(Form6.ReadSetting("database"));
                DBUtils.Username1 = Convert.ToString(Form6.ReadSetting("username"));
                DBUtils.Password1 = Convert.ToString(Form6.ReadSetting("password"));


                textBox1.Text = DBUtils.Datasource1;
                textBox2.Text = DBUtils.Database1;
                textBox3.Text = DBUtils.Username1;
                textBox4.Text = DBUtils.Password1;
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
