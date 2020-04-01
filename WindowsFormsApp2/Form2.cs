using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Data.OleDb;


namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public int pp_summ;
        pp createPP = new pp();

        settings settings = new settings();
        FolderBrowserDialog FBD = new FolderBrowserDialog();

        public Form2()
        {
            InitializeComponent();

            textBox3.ReadOnly = true;
            radioButton1.Checked = true;
            textBox4.Text = "Платежное поручение";
            textBox1.Text = "0401060";
            textBox2.Text = createPP.Date_pp();
         
            textBox23.ReadOnly = true;
            textBox21.ReadOnly = true;
            textBox25.ReadOnly = true;
            createPP.P18 = "01";
            textBox20.Text = createPP.P18;
            textBox20.ReadOnly = true;
            textBox22.ReadOnly = true;

            textBox13.ReadOnly = true;
            textBox14.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox16.ReadOnly = true;
            textBox17.ReadOnly = true;
            textBox18.ReadOnly = true;
            textBox19.ReadOnly = true;
        }

       

        private void ручнаяВводToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void listBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            createPP.P10 = listBox10.SelectedItem.ToString();
            //textBox33.Text = createPP.P10;


            //формируется БИК 29 text box

           createPP.P11 = Convert.ToString(createPP.GetBIC(createPP.P10));
           textBox29.Text = Convert.ToString(createPP.P11);

            //формируется кор счет 30 text box
            //createPP.P12 = Convert.ToString(createPP.GetCOR(createPP.P10));
           //textBox30.Text = Convert.ToString(createPP.P12);

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            

            // MessageBox.Show(createPP.P4);
            SqlConnection conn = DBUtils.GetDBConnection();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "Select Company_name from dbo.Company";
            conn.Open(); //Открываем соединение
            SqlDataReader read = sqlCmd.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                // MessageBox.Show(read.GetValue(0).ToString());
                listBox14.Items.Add(read.GetValue(0).ToString());
                listBox22.Items.Add(read.GetValue(0).ToString());
                // INN.Add(read.GetValue(1).ToString());
                //KPP.Add(read.GetValue(2).ToString());

                //listBox14.Items.Add(read.GetValue(1).ToString());
                //listBox22.Items.Add(read.GetValue(0).ToString());
                //Добавляем данные в лист итем
            }

            conn.Close(); //Закрываем соединение


            // Вывод элементов списка.
           // foreach (var item in INN)
          //  {
            //    listBox22.Items.Add(item.ToString());
                //Console.WriteLine(item);
           // }
        }

        private void записатьВБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqlExpression = String.Format("INSERT INTO dbo.create_pp (form_okyd,name_bank_docum,number_pp,date_pp,summa_propisiu,Summa_platelshika,Name_platelshika) VALUES ({0}, '{1}',{2},'{3}','{4}',{5},{6})", createPP.P2, createPP.P0, createPP.P3,createPP.P4,createPP.P6, createPP.P7, createPP.P8);
        }

        public void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            createPP.P0 = Convert.ToString(textBox10.Text);
            createPP.P4 = Convert.ToString(textBox2.Text);
            //  MessageBox.Show("Платежное поручение сохранено");
            createPP.pdf(createPP.P0, createPP.P4, createPP.P6, createPP.P7, createPP.P8);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        public void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Флажок " + radioButton2.Text + "  теперь включен");
                textBox3.ReadOnly = true;
                //textBox3.ReadOnly = false;
                // createPP.nesrochpp();

            }
            else
            {
                MessageBox.Show("Флажок " + radioButton1.Text + "  теперь выключен");
                // createPP.srochpp();
                textBox3.ReadOnly = false;
            }
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {
           
          
        }

        private void listBox11_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox5_TextChanged(object sender, EventArgs e)
        {
            createPP.P7 = Convert.ToInt32(textBox5.Text);
           // pp_summ = createPP.P7;

            //textBox6.Text=Convert.ToString(createPP.summ_pp(createPP.P7));
            createPP.P6 = Convert.ToString(createPP.summ_pp(createPP.P7));
            textBox6.Text = Convert.ToString(createPP.P6);
            //pp_summ = Convert.ToInt32(textBox5.Text);

            // Поле 24 - назначение платежа
            textBox26.Text = "Сумма " + "" + createPP.P7 + ", Без налога (НДС)";
            createPP.P24 = textBox26.Text;

        }


        public void listBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox10.Items.Clear();
            // Передаем название организации 
            createPP.P8 = listBox14.SelectedItem.ToString();


            // Формируем ИНН
            createPP.P60 = Convert.ToString(createPP.GetINN(createPP.P8));
            textBox7.Text = Convert.ToString(createPP.P60);

            //Генерация КПП

            createPP.P102 = Convert.ToInt32(createPP.GetKPP(createPP.P8));
            textBox9.Text = Convert.ToString(createPP.P102);

            //Генерация Поля 101

            createPP.P101 = Convert.ToInt32(createPP.Get101(createPP.P8));
            textBox8.Text = Convert.ToString(createPP.P101);

            //Выбор банка плательщика 
            SqlConnection conn3 = DBUtils.GetDBConnection();
            conn3.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn3;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETBANK";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGETBANK",
                Value = createPP.P8
            };
            sqlCmd.Parameters.Add(namecompany);
            SqlDataReader read = sqlCmd.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                // MessageBox.Show(read.GetValue(0).ToString());
                listBox10.Items.Add(read.GetValue(0).ToString());
            }

            conn3.Close(); //Закрываем соединение


            


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очищаем банк 
            listBox18.Items.Clear();

            // передаем название организации
            createPP.P16 = listBox22.SelectedItem.ToString();

            // Формируем ИНН
            createPP.P61 = Convert.ToString(createPP.GetINN(createPP.P16));
            textBox27.Text = Convert.ToString(createPP.P61);

            //Генерация КПП

            createPP.P103 = Convert.ToInt32(createPP.GetKPP(createPP.P16));
            textBox28.Text = Convert.ToString(createPP.P103);

            //Выбор банка получателя 

            SqlConnection conn4 = DBUtils.GetDBConnection();
            conn4.Open();
            SqlCommand sqlCmd1 = new SqlCommand();
            sqlCmd1.Connection = conn4;
            sqlCmd1.CommandType = CommandType.StoredProcedure;
            sqlCmd1.CommandText = "GETBANK";
            SqlParameter namecompany1 = new SqlParameter
            {
                ParameterName = "@companynameGETBANK",
                Value = createPP.P16
            };
            sqlCmd1.Parameters.Add(namecompany1);
            SqlDataReader read1 = sqlCmd1.ExecuteReader(); //Считываем и извлекаем данные
            while (read1.Read()) //Читаем пока есть данные
            {
                // MessageBox.Show(read.GetValue(0).ToString());
                listBox18.Items.Add(read1.GetValue(0).ToString());
            }

            conn4.Close(); //Закрываем соединение


        }

        public void сформироватьED101ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("Платежное поручение в формате Ed101");
                createPP.ed101(createPP.P4);
            }

            finally
            {

            }
                
        }

        private void статусыЭПДToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void сформироватьSwiftСообщениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Платежное поручение в формате MT101 сохранено");

        }

        private void сформироватьEd501ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //передача даты
            createPP.P4 = Convert.ToString(textBox2.Text);

            //Передаем все параметры
            createPP.ed501(createPP.P4);
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                

                textBox13.ReadOnly = false;
                textBox14.ReadOnly = false;
                textBox15.ReadOnly = false;
                textBox16.ReadOnly = false;
                textBox17.ReadOnly = false;
                textBox18.ReadOnly = false;
                textBox19.ReadOnly = false;
                textBox22.ReadOnly = false;
            }
            else
            {
                textBox13.ReadOnly = true;
                textBox14.ReadOnly = true;
                textBox15.ReadOnly = true;
                textBox16.ReadOnly = true;
                textBox17.ReadOnly = true;
                textBox18.ReadOnly = true;
                textBox19.ReadOnly = true;
                textBox22.ReadOnly = true;
            }
               

        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form1 f2 = new Form1();
            //f2.Visible = false;

            Form4 newForm4 = new Form4();
            newForm4.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // settings settings = new settings();
         //   MessageBox.Show(Form2.safepath);
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.Show();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            

        }

        public void listBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            createPP.P13=listBox18.SelectedItem.ToString();

            //формируется БИК 29 text box

            createPP.P14 = Convert.ToString(createPP.GetBIC(createPP.P13));
            textBox31.Text = Convert.ToString(createPP.P14);

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

 
}
