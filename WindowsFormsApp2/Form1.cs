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
    public partial class Form1 : Form
    
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           

            //dataGridView1.AutoSizeColumnsMode =
            // DataGridViewAutoSizeColumnsMode.AllCells;
            //  dataGridView1.AutoResizeColumns();

            // dataGridView1.AutoSizeRowsMode =
            //     DataGridViewAutoSizeRowsMode.AllCells;
            //  dataGridView1.AutoResizeRows(
            //     DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            button2.Visible =true;

            if (selectedState=="Созданные")
            {
                SqlConnection conn = DBUtils.GetDBConnection();

                try
                {
                    //MessageBox.Show("Openning Connection ...");
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = conn;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "Select id as 'Порядковый номер ПП', " +
                        "postinbank as 'Поступило в банк', " +
                        "spissoschet as 'Списано со сч.плат',"  +
                        "form_okyd as 'Номер формы ОКУД'," +
                        "name_bank_docum as 'Наименование банковской документации'," +
                        "number_pp as 'Номер платежного поручения '," +
                        "date_pp as 'Списано со сч.плат'," +
                        "vid_platezha as 'Вид платежа'," +
                        "status_platelshik as 'Статус платежа'," +
                        "summa_propisiu as 'Сумма прописью'," +
                        "INN_platelshika as 'ИНН плательщика'," +
                        "KPP_platelshika as 'КПП плательщика'," +
                        "Summa_platelshika as 'Сумма платежа'," +
                        "Name_platelshika as 'Наименование организации плательщика'," +
                        "Acc_platelshika as 'Счет плательщика'," +
                        "bank_platelshika as 'Банк плательщика'," +
                        "BIK_platelshika as 'БИК плательщика'," +
                        "KOR_poluchat as 'Кор.счет получателя'," +
                        "BANK_poluchat as 'Банк получателя'," +
                        "BIK_poluchat as 'БИК получателя'," +
                        "ACC_bank_poluchat as 'Счет банк получатель'," +
                        "INN_poluchat as 'ИНН получателя'," +
                        "KPP_poluchat as 'КПП получателя'," +
                        "ACC_poluchat as 'Номер счета получателя'," +
                        "name_poluchat as 'Наименование компании-получателя'," +
                        "shifr_pp as 'Шифр ПП'," +
                        "srochnost as 'Срочность ПП'," +
                        "naznachenie as 'Назначение платежа'," +
                        "ocherednost as 'Очередность'," +
                        "kod as 'УИН платежа'," +
                        "rezerv as 'Резервное поле'," +
                        "KBK as 'КБК'," +
                        "OKTMO as 'ОКТМО'," +
                        "osnovanie_pp as 'Основание платежа'," +
                        "nalog_period as 'Налоговый период'," +
                        "Nomer_docum as 'Номер документа'," +
                        "date_docum as 'Дата документа'," +
                        "kod_vyplatu as 'Код выплаты'," +
                        "naznachenie_PP as 'Назначение ПП'," +
                        "MP 'МП'," +
                        "PODPIS as 'Подпись'," +
                        "BANK_OTMETK as 'Отметка банка'," +
                        "Unknow as 'Дополнительное поле'" +
                        "from create_pp";

        SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;

                 //   MessageBox.Show("Connection successful!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // закрываем подключение
                    conn.Close();
                    //MessageBox.Show("Подключение закрыто...");
                }


            }
            else if (selectedState == "Полученные")
            {

                SqlConnection conn = DBUtils.GetDBConnection();

                try
                {
                    //MessageBox.Show("Openning Connection ...");
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = conn;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "Select id as 'Порядковый номер ПП', " +
                        "postinbank as 'Поступило в банк', " +
                        "spissoschet as 'Списано со сч.плат'," +
                        "form_okyd as 'Номер формы ОКУД'," +
                        "name_bank_docum as 'Наименование банковской документации'," +
                        "number_pp as 'Номер платежного поручения '," +
                        "date_pp as 'Списано со сч.плат'," +
                        "vid_platezha as 'Вид платежа'," +
                        "status_platelshik as 'Статус платежа'," +
                        "summa_propisiu as 'Сумма прописью'," +
                        "INN_platelshika as 'ИНН плательщика'," +
                        "KPP_platelshika as 'КПП плательщика'," +
                        "Summa_platelshika as 'Сумма платежа'," +
                        "Name_platelshika as 'Наименование организации плательщика'," +
                        "Acc_platelshika as 'Счет плательщика'," +
                        "bank_platelshika as 'Банк плательщика'," +
                        "BIK_platelshika as 'БИК плательщика'," +
                        "KOR_poluchat as 'Кор.счет получателя'," +
                        "BANK_poluchat as 'Банк получателя'," +
                        "BIK_poluchat as 'БИК получателя'," +
                        "ACC_bank_poluchat as 'Счет банк получатель'," +
                        "INN_poluchat as 'ИНН получателя'," +
                        "KPP_poluchat as 'КПП получателя'," +
                        "ACC_poluchat as 'Номер счета получателя'," +
                        "name_poluchat as 'Наименование компании-получателя'," +
                        "shifr_pp as 'Шифр ПП'," +
                        "srochnost as 'Срочность ПП'," +
                        "naznachenie as 'Назначение платежа'," +
                        "ocherednost as 'Очередность'," +
                        "kod as 'УИН платежа'," +
                        "rezerv as 'Резервное поле'," +
                        "KBK as 'КБК'," +
                        "OKTMO as 'ОКТМО'," +
                        "osnovanie_pp as 'Основание платежа'," +
                        "nalog_period as 'Налоговый период'," +
                        "Nomer_docum as 'Номер документа'," +
                        "date_docum as 'Дата документа'," +
                        "kod_vyplatu as 'Код выплаты'," +
                        "naznachenie_PP as 'Назначение ПП'," +
                        "MP 'МП'," +
                        "PODPIS as 'Подпись'," +
                        "BANK_OTMETK as 'Отметка банка'," +
                        "Unknow as 'Дополнительное поле'" +
                        "from history_pp";

                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;

                    //   MessageBox.Show("Connection successful!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // закрываем подключение
                    conn.Close();
                    //MessageBox.Show("Подключение закрыто...");
                }


            }
        }

        private void ручнаяВводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.Visible = false;

            Form2 newForm2 = new Form2();
            newForm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();

            if (selectedState == "Созданные")
            {
                SqlConnection conn = DBUtils.GetDBConnection();

                try
                {
                    //MessageBox.Show("Openning Connection ...");
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = conn;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "Select id as 'Порядковый номер ПП', " +
                        "postinbank as 'Поступило в банк', " +
                        "spissoschet as 'Списано со сч.плат'," +
                        "form_okyd as 'Номер формы ОКУД'," +
                        "name_bank_docum as 'Наименование банковской документации'," +
                        "number_pp as 'Номер платежного поручения '," +
                        "date_pp as 'Списано со сч.плат'," +
                        "vid_platezha as 'Вид платежа'," +
                        "status_platelshik as 'Статус платежа'," +
                        "summa_propisiu as 'Сумма прописью'," +
                        "INN_platelshika as 'ИНН плательщика'," +
                        "KPP_platelshika as 'КПП плательщика'," +
                        "Summa_platelshika as 'Сумма платежа'," +
                        "Name_platelshika as 'Наименование организации плательщика'," +
                        "Acc_platelshika as 'Счет плательщика'," +
                        "bank_platelshika as 'Банк плательщика'," +
                        "BIK_platelshika as 'БИК плательщика'," +
                        "KOR_poluchat as 'Кор.счет получателя'," +
                        "BANK_poluchat as 'Банк получателя'," +
                        "BIK_poluchat as 'БИК получателя'," +
                        "ACC_bank_poluchat as 'Счет банк получатель'," +
                        "INN_poluchat as 'ИНН получателя'," +
                        "KPP_poluchat as 'КПП получателя'," +
                        "ACC_poluchat as 'Номер счета получателя'," +
                        "name_poluchat as 'Наименование компании-получателя'," +
                        "shifr_pp as 'Шифр ПП'," +
                        "srochnost as 'Срочность ПП'," +
                        "naznachenie as 'Назначение платежа'," +
                        "ocherednost as 'Очередность'," +
                        "kod as 'УИН платежа'," +
                        "rezerv as 'Резервное поле'," +
                        "KBK as 'КБК'," +
                        "OKTMO as 'ОКТМО'," +
                        "osnovanie_pp as 'Основание платежа'," +
                        "nalog_period as 'Налоговый период'," +
                        "Nomer_docum as 'Номер документа'," +
                        "date_docum as 'Дата документа'," +
                        "kod_vyplatu as 'Код выплаты'," +
                        "naznachenie_PP as 'Назначение ПП'," +
                        "MP 'МП'," +
                        "PODPIS as 'Подпись'," +
                        "BANK_OTMETK as 'Отметка банка'," +
                        "Unknow as 'Дополнительное поле'" +
                        "from create_pp";
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;

                    //   MessageBox.Show("Connection successful!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // закрываем подключение
                    conn.Close();
                    //MessageBox.Show("Подключение закрыто...");
                }


            }
            else if (selectedState == "Полученные")
            {

                SqlConnection conn = DBUtils.GetDBConnection();

                try
                {
                    //MessageBox.Show("Openning Connection ...");
                    SqlCommand sqlCmd = new SqlCommand();
                    sqlCmd.Connection = conn;
                    sqlCmd.CommandType = CommandType.Text;
                    sqlCmd.CommandText = "Select * from history_pp";
                    SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                    DataTable dtRecord = new DataTable();
                    sqlDataAdap.Fill(dtRecord);
                    dataGridView1.DataSource = dtRecord;

                    //   MessageBox.Show("Connection successful!");

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // закрываем подключение
                    conn.Close();
                    //MessageBox.Show("Подключение закрыто...");
                }


            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public int a;
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f3 = new Form1();
           //f3.Visible = false;

            Form3 newForm3 = new Form3();
            newForm3.Show();
        }

        private void ручнойВводToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newForm5 = new Form5();
            newForm5.Show();
        }

        private void настройкиБазаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newForm6 = new Form6();
            newForm6.Show();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.Show();
        }
    }
}
