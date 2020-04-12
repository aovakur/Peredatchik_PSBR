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
using PdfiumViewer;
using System.Drawing.Printing;

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

            textBox24.ForeColor = Color.Black;


           
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

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox15.Items.Clear();
            createPP.P10 = listBox10.SelectedItem.ToString();
            //textBox33.Text = createPP.P10;


            //формируется БИК 29 text box

           createPP.P11 = Convert.ToString(createPP.GetBIC(createPP.P10));
           textBox29.Text = Convert.ToString(createPP.P11);

            //формируется кор счет 30 text box
            //createPP.P12 = Convert.ToString(createPP.GetCOR(createPP.P10));
            //textBox30.Text = Convert.ToString(createPP.P12);


            //Формируем Корр счет 

            createPP.P12 = Convert.ToString(createPP.GetAcc(createPP.P10));
            textBox30.Text = Convert.ToString(createPP.P12);


            //Формируется список счетов для плательщика

            //Выбор банка плательщика 
            SqlConnection conn3 = DBUtils.GetDBConnection();
            conn3.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn3;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETcompanyACC";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGETCompany",
                Value = createPP.P8
            };   
            sqlCmd.Parameters.Add(namecompany);

            SqlParameter namebank = new SqlParameter
            {
                ParameterName = "@companynameGETBANK",
                Value = createPP.P10
            };
            sqlCmd.Parameters.Add(namebank);

            SqlDataReader read = sqlCmd.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                // MessageBox.Show(read.GetValue(0).ToString());
                listBox15.Items.Add(read.GetValue(0).ToString());
            }

            conn3.Close(); //Закрываем соединение


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

        public void записатьВБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "" && Convert.ToString(listBox14.SelectedItem) != "" && Convert.ToString(listBox15.SelectedItem) != "" && Convert.ToString(listBox10.SelectedItem) != "" && Convert.ToString(listBox18.SelectedItem) != "" && Convert.ToString(listBox19.SelectedItem) != "" && Convert.ToString(listBox22.SelectedItem) != "")
            {
                if (radioButton2.Checked == true && checkBox1.Checked == true)
                {
                    createPP.insertDB(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);
                  //  Close();
                }

                else if (radioButton1.Checked == true && checkBox1.Checked == false)
                {
                    createPP.insertDB_brief(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24);
                   // Close();
                }

                else if (radioButton2.Checked == true)
                {
                    createPP.insertDB_urgency(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5);
                  //  Close();
                }
            }
            else
            {
                if (textBox10.Text == "")
                {
                    textBox10.BackColor = Color.Fuchsia;

                }

                if (textBox5.Text == "")
                {
                    textBox5.BackColor = Color.Fuchsia;

                }

                if (textBox24.Text == "")
                {
                    textBox24.BackColor = Color.Fuchsia;

                }

                if (textBox26.Text == "")
                {
                    textBox26.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox14.SelectedItem) == "")
                {
                    listBox14.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox15.SelectedItem) == "")
                {
                    listBox15.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox18.SelectedItem) == "")
                {
                    listBox18.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox19.SelectedItem) == "")
                {
                    listBox19.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox22.SelectedItem) == "")
                {
                    listBox22.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox10.SelectedItem) == "")
                {
                    listBox10.BackColor = Color.Fuchsia;

                }
            }

        }

        public void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "" && Convert.ToString(listBox14.SelectedItem) != "" && Convert.ToString(listBox15.SelectedItem) != "" && Convert.ToString(listBox10.SelectedItem) != "" && Convert.ToString(listBox18.SelectedItem) != "" && Convert.ToString(listBox19.SelectedItem) != "" && Convert.ToString(listBox22.SelectedItem) != "")
            {
                createPP.pdf(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);
                //Close();
            }
            else
            {
                if (textBox10.Text == "")
                {
                    textBox10.BackColor = Color.Fuchsia;

                }

                if (textBox5.Text == "")
                {
                    textBox5.BackColor = Color.Fuchsia;

                }

                if (textBox24.Text == "")
                {
                    textBox24.BackColor = Color.Fuchsia;

                }

                if (textBox26.Text == "")
                {
                    textBox26.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox14.SelectedItem) == "")
                {
                    listBox14.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox15.SelectedItem) == "")
                {
                    listBox15.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox18.SelectedItem) == "")
                {
                    listBox18.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox19.SelectedItem) == "")
                {
                    listBox19.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox22.SelectedItem) == "")
                {
                    listBox22.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox10.SelectedItem) == "")
                {
                    listBox10.BackColor = Color.Fuchsia;

                }
            }


            //  MessageBox.Show("Платежное поручение сохранено");
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Для передачи на сохранения 
            createPP.P4 = Convert.ToString(textBox2.Text);
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        public void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("Флаг  " + radioButton2.Text + " теперь включен");
                textBox3.ReadOnly = true;
             

            }
            else
            {
                MessageBox.Show("Флаг  " + radioButton1.Text + " теперь выключен");
         
                textBox3.ReadOnly = false;
            }
        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

            createPP.P5 = Convert.ToString(textBox3.Text);
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

                if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "" && Convert.ToString(listBox14.SelectedItem) != "" && Convert.ToString(listBox15.SelectedItem) != "" && Convert.ToString(listBox10.SelectedItem) != "" && Convert.ToString(listBox18.SelectedItem) != "" && Convert.ToString(listBox19.SelectedItem) != "" && Convert.ToString(listBox22.SelectedItem) != "")
                {
                    
                   //MessageBox.Show("Платежное поручение в формате Ed101");
                   createPP.ed101(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);
                       
                }
                else
                {
                    if (textBox10.Text == "")
                    {
                        textBox10.BackColor = Color.Fuchsia;

                    }

                    if (textBox5.Text == "")
                    {
                        textBox5.BackColor = Color.Fuchsia;

                    }

                    if (textBox24.Text == "")
                    {
                        textBox24.BackColor = Color.Fuchsia;

                    }

                    if (textBox26.Text == "")
                    {
                        textBox26.BackColor = Color.Fuchsia;

                    }


                    if (Convert.ToString(listBox14.SelectedItem) == "")
                    {
                        listBox14.BackColor = Color.Fuchsia;

                    }

                    if (Convert.ToString(listBox15.SelectedItem) == "")
                    {
                        listBox15.BackColor = Color.Fuchsia;

                    }

                    if (Convert.ToString(listBox18.SelectedItem) == "")
                    {
                        listBox18.BackColor = Color.Fuchsia;

                    }


                    if (Convert.ToString(listBox19.SelectedItem) == "")
                    {
                        listBox19.BackColor = Color.Fuchsia;

                    }

                    if (Convert.ToString(listBox22.SelectedItem) == "")
                    {
                        listBox22.BackColor = Color.Fuchsia;

                    }

                    if (Convert.ToString(listBox10.SelectedItem) == "")
                    {
                        listBox10.BackColor = Color.Fuchsia;

                    }
                }

               
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

            if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "" && Convert.ToString(listBox14.SelectedItem) != "" && Convert.ToString(listBox15.SelectedItem) != "" && Convert.ToString(listBox10.SelectedItem) != "" && Convert.ToString(listBox18.SelectedItem) != "" && Convert.ToString(listBox19.SelectedItem) != "" && Convert.ToString(listBox22.SelectedItem) != "")
            {
                MessageBox.Show("Платежное поручение в формате MT101 сохранено");
            }
            else
            {
                if (textBox10.Text == "")
                {
                    textBox10.BackColor = Color.Fuchsia;

                }

                if (textBox5.Text == "")
                {
                    textBox5.BackColor = Color.Fuchsia;

                }

                if (textBox24.Text == "")
                {
                    textBox24.BackColor = Color.Fuchsia;

                }

                if (textBox26.Text == "")
                {
                    textBox26.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox14.SelectedItem) == "")
                {
                    listBox14.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox15.SelectedItem) == "")
                {
                    listBox15.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox18.SelectedItem) == "")
                {
                    listBox18.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox19.SelectedItem) == "")
                {
                    listBox19.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox22.SelectedItem) == "")
                {
                    listBox22.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox10.SelectedItem) == "")
                {
                    listBox10.BackColor = Color.Fuchsia;

                }
            }


         

        }

        private void сформироватьEd501ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "" && Convert.ToString(listBox14.SelectedItem) != "" && Convert.ToString(listBox15.SelectedItem) != "" && Convert.ToString(listBox10.SelectedItem) != "" && Convert.ToString(listBox18.SelectedItem) != "" && Convert.ToString(listBox19.SelectedItem) != "" && Convert.ToString(listBox22.SelectedItem) != "")
            {
                //Передаем все параметры
                createPP.ed501(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);
            }
            else
            {
                if (textBox10.Text == "")
                {
                    textBox10.BackColor = Color.Fuchsia;

                }

                if (textBox5.Text == "")
                {
                    textBox5.BackColor = Color.Fuchsia;

                }

                if (textBox24.Text == "")
                {
                    textBox24.BackColor = Color.Fuchsia;

                }

                if (textBox26.Text == "")
                {
                    textBox26.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox14.SelectedItem) == "")
                {
                    listBox14.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox15.SelectedItem) == "")
                {
                    listBox15.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox18.SelectedItem) == "")
                {
                    listBox18.BackColor = Color.Fuchsia;

                }


                if (Convert.ToString(listBox19.SelectedItem) == "")
                {
                    listBox19.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox22.SelectedItem) == "")
                {
                    listBox22.BackColor = Color.Fuchsia;

                }

                if (Convert.ToString(listBox10.SelectedItem) == "")
                {
                    listBox10.BackColor = Color.Fuchsia;

                }
            }

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
            var path = @"C:\PeredatchikPSBR\pdf\03.04.2020_100.pdf";
            using (var document = PdfDocument.Load(path))
            {
                using (var printDocument = document.CreatePrintDocument())
                {
                    printDocument.PrinterSettings.PrintFileName = "Letter_SkidTags_Report_9ae93aa7-4359-444e-a033-eb5bf17f5ce6.pdf";
                    //printDocument.PrinterSettings.PrinterName = @"printerName";
                   // printDocument.DocumentName = "file.pdf";
                    //printDocument.PrinterSettings.PrintFileName = "file.pdf";
                    printDocument.PrintController = new StandardPrintController();
                    printDocument.Print();
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.Show();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void listBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Очищаем список счетов компании
            listBox19.Items.Clear();

            //передаем название банка 
            createPP.P13=listBox18.SelectedItem.ToString();

            //формируется БИК 29 text box

            createPP.P14 = Convert.ToString(createPP.GetBIC(createPP.P13));
            textBox31.Text = Convert.ToString(createPP.P14);


            //Формируем Корр счет 

            createPP.P15 = Convert.ToString(createPP.GetAcc(createPP.P13));
            textBox32.Text = Convert.ToString(createPP.P15);


            //Выбор банка плательщика 
            SqlConnection conn3 = DBUtils.GetDBConnection();
            conn3.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn3;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETcompanyACC";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGETCompany",
                Value = createPP.P16
            };
            sqlCmd.Parameters.Add(namecompany);

            SqlParameter namebank = new SqlParameter
            {
                ParameterName = "@companynameGETBANK",
                Value = createPP.P13
            };
            sqlCmd.Parameters.Add(namebank);

            SqlDataReader read = sqlCmd.ExecuteReader(); //Считываем и извлекаем данные
            while (read.Read()) //Читаем пока есть данные
            {
                // MessageBox.Show(read.GetValue(0).ToString());
                listBox19.Items.Add(read.GetValue(0).ToString());
            }

            conn3.Close(); //Закрываем соединение


        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            createPP.P24 = Convert.ToString(textBox29.Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public void textBox24_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox24.Text == "1")
            {
                MessageBox.Show("Выплаты, которые происходят по исполнительным актам о возмещении нанесенного вреда здоровью или жизни. Уплата алиментов");
                textBox24.ForeColor = Color.Black;
                createPP.P21 = Convert.ToInt16(textBox24.Text);
                textBox24.ReadOnly = true;


            }

            else if (textBox24.Text == "2")
            {
                MessageBox.Show("Выплаты, которые происходят по исполнительным актам о возмещении нанесенного вреда здоровью или жизни. Уплата алиментов");
                textBox24.ForeColor = Color.Black;
                createPP.P21 = Convert.ToInt16(textBox24.Text);
                textBox24.ReadOnly = true;
            }

            else if (textBox24.Text == "3")
            {
                MessageBox.Show("Оплата задолженности по налогам, сборам и взносам. Выдача заработной платы сотрудникам");
                textBox24.ForeColor = Color.Black;
                createPP.P21 = Convert.ToInt16(textBox24.Text);
                textBox24.ReadOnly = true;
            }

            else if (textBox24.Text == "4")
            {
                MessageBox.Show("Денежные выплаты по прочим исполнительным актам");
                textBox24.ForeColor = Color.Black;
                createPP.P21 = Convert.ToInt16(textBox24.Text);
                textBox24.ReadOnly = true;
            }

            else if (textBox24.Text == "5")
            {
                MessageBox.Show("Все остальные платежные документы в календарной последовательности их поступления");
                textBox24.ForeColor = Color.Black;
                createPP.P21 = Convert.ToInt16(textBox24.Text);
                textBox24.ReadOnly = true;

            }

            else if (textBox24.Text != "1" || textBox24.Text != "2" || textBox24.Text != "3" || textBox24.Text != "4" || textBox24.Text != "5") 
            { MessageBox.Show("Введите корректную очередность платежа");
                textBox24.ForeColor = Color.Red;
            }
                
           
        }

        private void listBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            createPP.P9 = listBox15.SelectedItem.ToString();
        }

        private void listBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            createPP.P17 = listBox19.SelectedItem.ToString();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //Для передачи на сохранения 
            createPP.P104 = Convert.ToString(textBox13.Text);
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            //Для передачи на сохранения 
            createPP.P22 = Convert.ToString(textBox22.Text);
            
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            //Для сохранения 
            createPP.P105 = Convert.ToString(textBox14.Text);
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            //Для сохранения 
            createPP.P106 = Convert.ToString(textBox15.Text);
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            //Для сохранения 
            createPP.P107 = Convert.ToString(textBox16.Text);
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            //Для сохранения 
            createPP.P108 = Convert.ToString(textBox17.Text);
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            //Для сохранения 
            createPP.P109 = Convert.ToString(textBox18.Text);
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            //Для сохранения 
            createPP.P110 = Convert.ToString(textBox19.Text);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            //Для сохранения 
            createPP.P0 = Convert.ToString(textBox10.Text);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

       
    }

 
}
