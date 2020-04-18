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
using DataGridViewAutoFilter;
using DGVWF;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
        
        public string selectedState;
        public Form1()
        {
            InitializeComponent();
            // dataGridView1.Visible = false;
            //comboBox1.SelectedItem = "Созданные";
            //dataGridView1.Visible = true;


        }

        public DataGridViewWithFilter DG = new DataGridViewWithFilter();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cursor.Current = Cursors.Default;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
            //  string selectedState = comboBox1.SelectedItem.ToString();
            //button2.Visible =true;
            // Cursor.Current = Cursors.Default;

            this.Size = new Size(1500, 800);
            //  DataTable DT = new DataTable();


        }

        private void ручнаяВводToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form2 newForm2 = new Form2();
            newForm2.Show();
            this.Hide();

        }

        public void Form1_Load(object sender, EventArgs e)
        {
           
            string safepath = "C:\\Program Files\\Business architecture\\PeredatchikPSBR";
            settings.safepath_1(safepath);

            Cursor.Current = Cursors.Default;
            textBox1.ReadOnly = true;
            textBox1.Text = Convert.ToString(pp.Date1());


            DBUtils.Datasource1 = Convert.ToString(Form6.ReadSetting("datasource"));
            DBUtils.Database1 = Convert.ToString(Form6.ReadSetting("database"));
            DBUtils.Username1 = Convert.ToString(Form6.ReadSetting("username"));
            DBUtils.Password1 = Convert.ToString(Form6.ReadSetting("password"));

            this.Size = new Size(1500, 800);
            
            DG.Bounds = new Rectangle(10, 80, 1460, 650);
            DG.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right | AnchorStyles.Bottom)));
            DG.AllowUserToAddRows = false;
            this.Controls.Add(DG);


            if (DBUtils.Datasource1 != null && DBUtils.Database1 != null && DBUtils.Username1 != null && DBUtils.Password1 != null)
            {

                GetCurrentPP();

            }

            else
            {
                MessageBox.Show("К локальной/сетевой базе данных не удалось подключиться");
            }


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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void созданныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBUtils.Datasource1 != null && DBUtils.Database1 != null && DBUtils.Username1 != null && DBUtils.Password1 != null)
            {
                if (checkBox1.Checked == true)
                {
                    maindb();
                }
                else
                {
                    GetCurrentPP();
                }
            }

            else
            {
                MessageBox.Show("К локальной/сетевой базе данных не удалось подключиться");
            }

        }

        public void отправленныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataGridViewWithFilter DG = new DataGridViewWithFilter();
            //DG.Bounds = new Rectangle(10, 80, 1460, 650);
            //DG.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right | AnchorStyles.Bottom)));
            //DG.AllowUserToAddRows = false;
            //this.Controls.Add(DG);

            while (DG.Rows.Count > 1)
                for (int i = 0; i < DG.Rows.Count - 1; i++)
                    DG.Rows.Remove(DG.Rows[i]);

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();


            try
            {
                //MessageBox.Show("Openning Connection ...");
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = conn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select id as 'Порядковый номер ПП', " +
                    "postinbank as 'Поступило в банк', " +
                    "spissoschet as 'Списано со счета плательщика'," +
                    "form_okyd as 'Номер формы ОКУД'," +
                    "name_bank_docum as 'Наименование банковской документации'," +
                    "number_pp as 'Номер платежного поручения'," +
                    "date_pp as 'Списано со счета плательщика'," +
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
                    "shifr_pp as 'Вид операции'," +
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
                    "BANK_OTMETK as 'Отметка банка'" +
                    "from history_pp";

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                DG.DataSource = dtRecord;
                DG.ReadOnly = true;

                //   MessageBox.Show("Connection successful!");
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            finally
            {
                // закрываем подключение
                conn.Close();
                //MessageBox.Show("Подключение закрыто...");
            }

        }

        public void maindb()
        {

            //DataGridViewWithFilter DG = new DataGridViewWithFilter();
            // DG.Bounds = new Rectangle(10, 80, 1460, 650);
            //DG.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right | AnchorStyles.Bottom)));
            //DG.AllowUserToAddRows = false;
            // Form1.Controls.Add(DG);

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();


            try
            {


                //MessageBox.Show("Openning Connection ...");
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = conn;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "Select id as 'Порядковый номер ПП', " +
                    "status as 'Статус'," +
                    "postinbank as 'Поступило в банк', " +
                    "spissoschet as 'Списано со счета плательщика'," +
                    "form_okyd as 'Номер формы ОКУД'," +
                    "name_bank_docum as 'Наименование банковской документации'," +
                    "number_pp as 'Номер платежного поручения '," +
                    "date_pp as 'Списано со счета плательщика'," +
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
                    "shifr_pp as 'Вид операции'," +
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
                    "BANK_OTMETK as 'Отметка банка'" +
                    "from create_pp";

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                DG.DataSource = dtRecord;
                DG.ReadOnly = true;

                //   MessageBox.Show("Connection successful!");
                conn.Close();


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

        public void GetCurrentPP()
        {
            // DataGridViewWithFilter DG = new DataGridViewWithFilter();
            //this.Size = new Size(1500, 800);
            // DG.Bounds = new Rectangle(10, 80, 1460, 650);
            //DG.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) | AnchorStyles.Right | AnchorStyles.Bottom)));
            // DG.AllowUserToAddRows = false;
            //Form1.Controls.Add(DG);


            // public SqlConnection conn = DBUtils.GetDBConnection();
            //conn3.Open();

            try
            {
                //Выбор банка плательщика 
                SqlConnection conn3 = DBUtils.GetDBConnection();
                conn3.Open();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = conn3;
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "GETCORRENTPP";
                SqlParameter namecompany = new SqlParameter
                {
                    ParameterName = "@GETDATE",
                    Value = Convert.ToString(pp.Date1())
                };
                sqlCmd.Parameters.Add(namecompany);

                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                DataTable dtRecord = new DataTable();
                sqlDataAdap.Fill(dtRecord);
                DG.DataSource = dtRecord;
                DG.ReadOnly = true;

                //   MessageBox.Show("Connection successful!");
                conn3.Close();
            }

            catch
            {

            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //textBox2.Text = DBUtils.Datasource1;
            //textBox3.Text = DBUtils.Database1;
            // textBox4.Text = DBUtils.Username1;
            //textBox5.Text = DBUtils.Password1;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                maindb();
            }
            else
            {
                GetCurrentPP();
            }

        }

        private void статусыЭПДToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сегодняшниеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DBUtils.Datasource1 != null && DBUtils.Database1 != null && DBUtils.Username1 != null && DBUtils.Password1 != null)
            {
                GetCurrentPP();
            }

            else
            {
                MessageBox.Show("К локальной/сетевой базе данных не удалось подключиться");
            }

        }



        private void сохранитьВPdfToolStripMenuItem_Click(object sender, EventArgs e)

        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
        }
    }
}