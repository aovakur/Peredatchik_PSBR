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
    public partial class Form7 : Form
    {
        public int pp_summ;
        pp createPP = new pp();

        settings settings = new settings();

        FolderBrowserDialog FBD = new FolderBrowserDialog();
        string UIS = Convert.ToString(Form6.ReadSetting("UIS"));

        public Form7()
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

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

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

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {
            createPP.P0 = Convert.ToString(textBox10.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            createPP.P5 = Convert.ToString(textBox3.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            createPP.P101 = Convert.ToInt16(textBox8.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            createPP.P60 = Convert.ToString(textBox7.Text);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            createPP.P102 = Convert.ToString(textBox9.Text);
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            createPP.P9 = Convert.ToString(textBox37.Text);
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            createPP.P8 = Convert.ToString(textBox33.Text);
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            createPP.P11 = Convert.ToString(textBox29.Text);
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            createPP.P10 = Convert.ToString(textBox34.Text);
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            createPP.P12 = Convert.ToString(textBox38.Text);
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            createPP.P14 = Convert.ToString(textBox31.Text);
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            createPP.P15 = Convert.ToString(textBox30.Text);
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            createPP.P13 = Convert.ToString(textBox35.Text);
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            createPP.P17 = Convert.ToString(textBox32.Text);
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            createPP.P61 = Convert.ToString(textBox27.Text);
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            createPP.P103 = Convert.ToString(textBox28.Text);
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            createPP.P16 = Convert.ToString(textBox36.Text);
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            createPP.P18 = Convert.ToString(textBox20.Text);
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            createPP.P20 = Convert.ToInt16(textBox21.Text);
        }

        private void textBox22_TextChanged_1(object sender, EventArgs e)
        {
            createPP.P22 = Convert.ToString(textBox22.Text);
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
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
            {
                MessageBox.Show("Введите корректную очередность платежа");
                textBox24.ForeColor = Color.Red;
            }
           
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            createPP.P24 = Convert.ToString(textBox26.Text);
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "" )
            {
                createPP.Pdf(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P18, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);
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

            }


            //  MessageBox.Show("Платежное поручение сохранено");


        }

        private void записатьВБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "")
            {
                if (radioButton2.Checked == true && checkBox1.Checked == true)
                {
                    createPP.insertDB(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P18, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);
                    //  Close();
                }

                else if (radioButton1.Checked == true && checkBox1.Checked == false)
                {
                    createPP.insertDB_brief(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P18, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24);
                    // Close();
                }

                else if (radioButton2.Checked == true)
                {
                    createPP.insertDB_urgency(createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P18, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5);
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

            }
        }

        private void сформироватьED101ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string EDno = pp.GetEDNo();

            DateTime dt = DateTime.Now;
            string curDate = dt.ToShortDateString();

            String curentyear = dt.ToString("yyyy");
            String curentmonth = dt.ToString("MM");
            String curentday = dt.ToString("dd");

            string fulldate = curentyear + "-" + curentmonth + "-" + curentday;

            string currentday = Convert.ToString(Form6.ReadSetting("currentday"));

            try
            {

                if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "" )
                {

                    //MessageBox.Show("Платежное поручение в формате Ed101");
                    createPP.Ed101(fulldate, currentday, EDno, UIS, createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);

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


                }


            }

            finally
            {

            }
        }

        private void сформироватьEd501ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //получаем уникальный номер сообщения Ed501
            string MSGID = pp.generateMSDEd501ID();
            int CurrentIDED501 = Convert.ToInt16(pp.ReadSetting("MessageIDED501"));
            string CurrentIDED501_1 = CurrentIDED501.ToString("00000000");

            if (textBox10.Text != "" && textBox5.Text != "" && textBox24.Text != "" && textBox26.Text != "")
            {
                //Передаем все параметры
                createPP.Ed501(CurrentIDED501_1, MSGID, UIS, createPP.P0, createPP.P4, createPP.P6, createPP.P60, createPP.P102, createPP.P7, createPP.P8, createPP.P9, createPP.P10, createPP.P11, createPP.P12, createPP.P101, createPP.P13, createPP.P14, createPP.P15, createPP.P17, createPP.P61, createPP.P103, createPP.P16, createPP.P21, createPP.P24, createPP.P5, createPP.P22, createPP.P104, createPP.P105, createPP.P106, createPP.P107, createPP.P108, createPP.P109, createPP.P110);
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


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            createPP.P4 = Convert.ToString(textBox2.Text);
        }

        private void Form2_FormClosing(Object sender, FormClosingEventArgs e)
        {

            Form1 f2 = new Form1();
            f2.Show();
        }
    }
}
