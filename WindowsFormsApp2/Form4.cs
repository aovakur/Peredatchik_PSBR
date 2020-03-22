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
    
    public partial class Form4 : Form
    {

        public string safepath;
        //settings settings = new settings();
        FolderBrowserDialog FBD = new FolderBrowserDialog();

        public Form4()
        {
            InitializeComponent();
            

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(FBD.SelectedPath);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
            safepath = FBD.SelectedPath;
            textBox1.Text = settings.safepath;
            textBox6.Text = settings.safepathpdf;
            textBox4.Text = settings.safepathetemplate;
            textBox5.Text = settings.safepathed101;
            textBox2.Text = settings.safepathed501;
            textBox3.Text = settings.safepatheMT101;

            // textBox1.Text = Convert.ToString(safepath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                
                safepath = FBD.SelectedPath;
                textBox1.Text = Convert.ToString(safepath);
                settings.safepath_1(safepath);
                textBox6.Text = settings.safepathpdf;
                textBox4.Text = settings.safepathetemplate;
                textBox5.Text = settings.safepathed101;
                textBox2.Text = settings.safepathed501;
                textBox3.Text = settings.safepatheMT101;

                //MessageBox.Show(FBD.SelectedPath);

    }

            //Safepath settings()
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
