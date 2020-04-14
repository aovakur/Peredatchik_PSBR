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
   
    public partial class Form3 : Form
    {
        //int find_pp;

        public Form3()
        {
            
            InitializeComponent();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

         
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string currentUIS = Convert.ToString(Form6.ReadSetting("UIS"));
            textBox1.Text = currentUIS;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
