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
using System.IO;
using System.Xml.Linq;
using System.Xml;
using iText;
using System.Web;
using iTextSharp.text.pdf.parser;
using System.util.collections;
using System.Net.Mail;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace WindowsFormsApp2
{
    class pp
    {
        string p1;
        string p0;
        int p2;
        int p3;
        string p4;
        string p5;
        int p7;
        string p6;
        string p8;
        string p60;
        string p61;
        string p9;
        string p10;
        string p11;
        string p12;
        string p13;
        string p15;
        string p17;
        string p18;
        int p21;
        int p102;
        int p103;
        int p101;
        string p24;
        string p16;
        string p14;
        string p22;
        string p104;
        string p105;
        string p106;
        string p107;
        string p108;
        string p109;
        string p110;

        

        SqlConnection conn = DBUtils.GetDBConnection();
        SqlCommand command = new SqlCommand();
       

        public string P0
        {
            get { return p0; }
            set { p0 = value; }
        }

        public string P1
        {
            get { return p1; }
            set { p1 = "Платежное поручение"; }
        }

        public int P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        public int P3
        {
            get { return p3; }
            set { p3 = value; }
        }
        public string P4
        {
            get { return p4; }
            set { p4 = value; }
        }

        public string P5
        {
            get { return p5; }
            set { p5 = value; }
        }

        public string Date_pp()
        {
            DateTime dt = DateTime.Now;
            string curDate = dt.ToShortDateString();
            return curDate;
        }

        public int P7
        {
            get { return p7; }
            set { p7 = value; }
        }

        public string P6
        {
            get { return p6; }
            set { p6 = value; }
        }

        public string P8
        {
            get { return p8; }
            set { p8 = value; }
        }

        public string P9
        {
            get { return p9; }
            set { p9 = value; }
        }

        public string P11
        {
            get { return p11; }
            set { p11 = value; }
        }

        public string P12
        {
            get { return p12; }
            set { p12 = value; }
        }


        public string P16
        {
            get { return p16; }
            set { p16 = value; }
        }

        public string P17
        {
            get { return p17; }
            set { p17 = value; }
        }

        public string P14
        {
            get { return p14; }
            set { p14 = value; }
        }

        public string P15
        {
            get { return p15; }
            set { p15 = value; }
        }

        public int P21
        {
            get { return p21; }
            set { p21 = value; }
        }

        public string P60
        {
            get { return p60; }
            set { p60 = value; }
        }

        public string P61
        {
            get { return p61; }
            set { p61 = value; }
        }


        public int P102
        {
            get { return p102; }
            set { p102 = value; }
        }

        public int P103
        {
            get { return p103; }
            set { p103 = value; }
        }

        public string P18
        {
            get { return p18; }
            set { p18 = value; }
        }

        public int P101
        {
            get { return p101; }
            set { p101 = value; }
        }

        public string P24
        {
            get { return p24; }
            set { p24 = value; }
        }

        //Банк отправителя

        public string P10
        {
            get { return p10; }
            set { p10 = value; }
        }

        //Банк получателя 

        public string P13
        {
            get { return p13; }
            set { p13 = value; }
        }


        //для срочного платежного поручения 

        public string P22
        {
            get { return p22; }
            set { p22 = value; }
        }

        public string P104
        {
            get { return p104; }
            set { p104 = value; }
        }

        public string P105
        {
            get { return p105; }
            set { p105 = value; }
        }

        public string P106
        {
            get { return p106; }
            set { p106 = value; }
        }

        public string P107
        {
            get { return p107; }
            set { p107 = value; }
        }

        public string P108
        {
            get { return p108; }
            set { p108 = value; }
        }

        public string P109
        {
            get { return p109; }
            set { p109 = value; }
        }

        public string P110
        {
            get { return p110; }
            set { p110 = value; }
        }


        public string summ_pp(int number)
        {

            int[] array_int = new int[4]; // нужно для разбивания число по сотням типа 123123123 == 123 123 123 в массиве
            string[,] array_string = new string[4, 3] {{" миллиард", " миллиарда", " миллиардов"}, // нужно для чисел больше миллиона
                {" миллион", " миллиона", " миллионов"},
                {" тысяча", " тысячи", " тысяч"},
                {"", "", ""}};
            array_int[0] = (number - (number % 1000000000)) / 1000000000; // здесь мы разбиваем наше число по элементам массива по 3 цифры
            array_int[1] = ((number % 1000000000) - (number % 1000000)) / 1000000;// допустим мы ввели 123345, значит  array_int[3] == 345  ,  array_int[2] == 123  
            array_int[2] = ((number % 1000000) - (number % 1000)) / 1000;
            array_int[3] = number % 1000;
            string result = ""; // строка для вывода результата
            for (int i = 0; i < 4; i++)
            {
                if (array_int[i] != 0) //array_int[0] != 0 если число больше миллиарда, array_int[1] != 0 если число больше миллиона , array_int[2] != 0 если число больше сто тысяч
                {
                    if (((array_int[i] - (array_int[i] % 100)) / 100) != 0) // проверяем имеет ли число третьий разряд
                        switch (((array_int[i] - (array_int[i] % 100)) / 100))
                        {
                            case 1: result += " сто"; break;
                            case 2: result += " двести"; break;
                            case 3: result += " триста"; break;
                            case 4: result += " четыреста"; break;
                            case 5: result += " пятьсот"; break;
                            case 6: result += " шестьсот"; break;
                            case 7: result += " семьсот"; break;
                            case 8: result += " восемьсот"; break;
                            case 9: result += " девятьсот"; break;
                        }
                    if (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10 != 1)// проверяем имеет ли число второй разряд
                    {
                        switch (((array_int[i] % 100) - ((array_int[i] % 100) % 10)) / 10)
                        {
                            case 2: result += " двадцать"; break;
                            case 3: result += " тридцать"; break;
                            case 4: result += " сорок"; break;
                            case 5: result += " пятьдесят"; break;
                            case 6: result += " шестьдесят"; break;
                            case 7: result += " семьдесят"; break;
                            case 8: result += " восемьдесят"; break;
                            case 9: result += " девяносто"; break;
                        }
                    }
                    switch (array_int[i] % 10)
                    {
                        case 1: if (i == 2) result += " одна"; else result += " один рубль"; break;//условие нужно для чисел больше миллиона
                        case 2: if (i == 2) result += " две"; else result += " два рубля"; break;
                        case 3: result += " три рубля"; break;
                        case 4: result += " четыре рубля"; break;
                        case 5: result += " пять рубля"; break;
                        case 6: result += " шесть рублей"; break;
                        case 7: result += " семь рублей"; break;
                        case 8: result += " восемь рублей"; break;
                        case 9: result += " девять рублей"; break;
                    }
                }
                else switch (array_int[i] % 100) // здесь проверяем второй разряд | если второй разряд >= 10 && второй разряд <= 19
                    {
                        case 10: result += " десять"; break;
                        case 11: result += " одиннадцать"; break;
                        case 12: result += " двенадцать"; break;
                        case 13: result += " тринадцать"; break;
                        case 14: result += " четырнадцать"; break;
                        case 15: result += " пятнадцать"; break;
                        case 16: result += " шестнадцать"; break;
                        case 17: result += " семнадцать"; break;
                        case 18: result += " восемннадцать"; break;
                        case 19: result += " девятнадцать"; break;
                    }
                if (array_int[i] % 100 >= 10 && array_int[i] % 100 <= 19) result += " " + array_string[i, 2] + " ";
                else switch (array_int[i] % 10)
                    {
                        case 1: result += " " + array_string[i, 0] + " "; break; // 1 тысяча, 1 миллион, 1 миллиард
                        case 2:
                        case 3:
                        case 4: result += " " + array_string[i, 1] + " "; break;// 3 тысячи , 3 миллиона, 3 миллиарда
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9: result += " " + array_string[i, 2] + " "; break;// 9 тысяч , 9 миллионов, 9 миллиардов
                    }
            }

            return result;
        }


        public string GetINN(string companyname)
        {

            //Генерация ИНН
            SqlConnection conn1 = DBUtils.GetDBConnection();
            conn1.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn1;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETINN";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGETINN",
                Value = companyname
            };
            sqlCmd.Parameters.Add(namecompany);
            string INN_orgatization = Convert.ToString(sqlCmd.ExecuteScalar());
           // textBox27.Text = Convert.ToString(INN_orgatization);

            conn1.Close(); //Закрываем соединение

            return INN_orgatization;
        }


        public int GetKPP(string companyname)
        {

            //Генерация ИНН
            SqlConnection conn2 = DBUtils.GetDBConnection();
            conn2.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn2;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETKPP";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGETKPP",
                Value = companyname
            };
            sqlCmd.Parameters.Add(namecompany);
            int KPP_orgatization = Convert.ToInt32(sqlCmd.ExecuteScalar());
            // textBox27.Text = Convert.ToString(INN_orgatization);

            conn2.Close(); //Закрываем соединение

            return KPP_orgatization;



        }

        public int Get101(string companyname)
        {
            //Генерация ИНН
            SqlConnection conn3 = DBUtils.GetDBConnection();
            conn3.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn3;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GET101";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGET101",
                Value = companyname
            };
            sqlCmd.Parameters.Add(namecompany);
            Int16 KPP_orgatization = Convert.ToInt16(sqlCmd.ExecuteScalar());

            conn3.Close(); //Закрываем соединение

            return KPP_orgatization;

        }

        public string GetBIC(string bank)
        {

            //Генерация БИК
            SqlConnection conn6 = DBUtils.GetDBConnection();
            conn6.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn6;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETBIK_1";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGETBIK",
                Value = bank
            };

            sqlCmd.Parameters.Add(namecompany);
            string BIC_orgatization = Convert.ToString(sqlCmd.ExecuteScalar());
            conn6.Close(); //Закрываем соединение

            return BIC_orgatization;

        }


        public string GetAcc(string bank)
        {

            //Генерация ACC
            SqlConnection conn6 = DBUtils.GetDBConnection();
            conn6.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn6;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "GETACC";
            SqlParameter namecompany = new SqlParameter
            {
                ParameterName = "@companynameGETACC",
                Value = bank
            };

            sqlCmd.Parameters.Add(namecompany);
            string ACC_bank = Convert.ToString(sqlCmd.ExecuteScalar());
            conn6.Close(); //Закрываем соединение

            return ACC_bank;

        }



        public string ed101(string p4)
        {
            string a;
            StreamWriter f = new StreamWriter("C:\\PeredatchikPSBR\\test3.ed101");
            f.WriteLine("" + p4);
            f.WriteLine("<?xml version=" + '\u0022' + "1.0" + '\u0022' + "encoding=" + '\u0022' + "WINDOWS-1251" + '\u0022' + "?>");
            f.WriteLine("<ED101 xmlns=" + '\u0022' + "urn:cbr-ru:ed:v2.0" + '\u0022' + "EDNo=" + '\u0022' + "1" + '\u0022' + " " + "EDDate=" + '\u0022' + p4 + '\u0022' + "EDAuthor=" + '\u0022' + "4525545000" + '\u0022' + " " + "TransKind=" + '\u0022' + "01" + '\u0022' + " Priority=" + '\u0022' + "5" + '\u0022' + "Sum = " + "2400000" + '\u0022' + "PaymentPrecedence=" + '\u0022' + "60" + '\u0022' + "SystemCode=" + '\u0022' + "05" + '\u0022' + " PaytKind=" + '\u0022' + "4" + '\u0022' + "ReceiptDate=" + '\u0022' + "2018-07-02" + '\u0022' + "ChargeOffDate=" + '\u0022' + "2018-07-02" + '\u0022' + ">");
            f.WriteLine("       <AccDoc AccDocNo=" + '\u0022' + "10" + '\u0022' + "AccDocDate=" + '\u0022' + "2018-07-02" + '\u0022' + "/>");
            f.WriteLine("       <Payer PersonalAcc=" + '\u0022' + "40702810200203001037" + '\u0022' + "INN=" + '\u0022' + "7726274727" + '\u0022' + ">");
            f.WriteLine("               <Name>ООО ТЕХНО ПЛЮС</Name>");
            f.WriteLine("               <Bank BIC=" + '\u0022' + "044525545" + '\u0022' + "CorrespAcc=" + '\u0022' + "30101810300000000545" + '\u0022' + "/>");
            f.WriteLine("       </Payer>");
            f.WriteLine("       <Payee PersonalAcc=" + '\u0022' + "40702810010130010079" + '\u0022' + "INN=" + '\u0022' + "7726062105" + '\u0022' + ">");
            f.WriteLine("           <Payee PersonalAcc=" + '\u0022' + "40702810010130010079" + '\u0022' + "INN=" + '\u0022' + "7726062105" + '\u0022' + ">");
            f.WriteLine("           <Bank BIC=" + '\u0022' + "044525411" + '\u0022' + "CorrespAcc=" + '\u0022' + "30101810145250000411" + '\u0022' + "/>");
            f.WriteLine("       <Bank BIC=" + '\u0022' + "044525411" + '\u0022' + "CorrespAcc=" + '\u0022' + "30101810145250000411" + '\u0022' + "/>");
            f.WriteLine("       <Purpose>ОПЛАТА ПО ДОГОВОРУ 95456 ОТ 15.01.2018 В ТОМ ЧИСЛЕ НДС 4000 РУБ</Purpose>");
            f.WriteLine("/ED101");
            f.Close();
            a = "Платежное поручение в формате ED101 сохранено";
            MessageBox.Show(a);
            return a;
        }


        public string pdf(string p0, string p4, string p6, string p60, int p102, int p7, string p8, string p9, string p10, string p11, string p12, int p101, string p13, string p14, string p15, string p17, string p61, int p103, string p16, int p21, string p24, string p5, string p22, string p104, string p105, string p106, string p107, string p108, string p109, string p110)
        {
            string b;
            string pathsafe = "C:\\PeredatchikPSBR\\pdf\\" + p4 + "_" + p0 + ".pdf";
            BaseFont baseFont = BaseFont.CreateFont(@"C:\PeredatchikPSBR\Template\Tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            PdfReader template = new PdfReader("C:\\PeredatchikPSBR\\Template\\Template_10.pdf");
            PdfStamper stamper = new PdfStamper(template, new FileStream(pathsafe, FileMode.Create));
            AcroFields fields = stamper.AcroFields;
            fields.AddSubstitutionFont(baseFont);

            // Поля для не срочного платежного поручения 

            fields.SetField("p4", p4);
            fields.SetField("p3", p0);
            fields.SetField("p6", p6);
            fields.SetField("p7", p7.ToString());
            fields.SetField("p8", p8);
            fields.SetField("p60", p60);
            fields.SetField("p102", p102.ToString());
            fields.SetField("p9", p9);
            fields.SetField("p10", p10);
            fields.SetField("p11", p11);
            fields.SetField("p12", p12);
            fields.SetField("p101", p101.ToString());
            fields.SetField("p13", p13);
            fields.SetField("p14", p14);
            fields.SetField("p15", p15);
            fields.SetField("p17", p17);
            fields.SetField("p61", p61);
            fields.SetField("p103", p103.ToString());
            fields.SetField("p16", p16);
            fields.SetField("p21", p21.ToString());
            fields.SetField("p24", p24);


            // Поля срочного платежного поручения 
            fields.SetField("p5", p5);

            // Поля бюджетного платежного поручения 
            fields.SetField("p22", p22);
            fields.SetField("p104", p104);
            fields.SetField("p105", p105);
            fields.SetField("p106", p106);
            fields.SetField("p107", p107);
            fields.SetField("p108", p108);
            fields.SetField("p109", p109);
            fields.SetField("p110", p110);

            //Форматирование 
            stamper.FormFlattening = false;
            stamper.Close();

            b = "Платежное поручение в pdf сохранено";
            MessageBox.Show(b);
            return b;
        }
        

        public string insertDB (string p0, string p4, string p6, string p60, int p102, int p7, string p8, string p9, string p10, string p11, string p12, int p101, string p13, string p14, string p15, string p17, string p61, int p103, string p16, int p21, string p24, string p5, string p22, string p104, string p105, string p106, string p107, string p108, string p109, string p110)
        {
            string b;

            SqlConnection conn6 = DBUtils.GetDBConnection();
            conn6.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn6;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "creatnewPP_full";

            sqlCmd.Parameters.AddWithValue("@p0", 123);
            sqlCmd.Parameters.AddWithValue("@p4", p4);
            sqlCmd.Parameters.AddWithValue("@p6", p6);
            sqlCmd.Parameters.AddWithValue("@p60", p60);
            sqlCmd.Parameters.AddWithValue("@p102", p102);
            sqlCmd.Parameters.AddWithValue("@p7", p7);
            sqlCmd.Parameters.AddWithValue("@p8", p8);
            sqlCmd.Parameters.AddWithValue("@p9", p9);
            sqlCmd.Parameters.AddWithValue("@p10", p10);
            sqlCmd.Parameters.AddWithValue("@p11", p11);
            sqlCmd.Parameters.AddWithValue("@p12", p12);
            sqlCmd.Parameters.AddWithValue("@p101", p101);
            sqlCmd.Parameters.AddWithValue("@p13", p13);
            sqlCmd.Parameters.AddWithValue("@p14", p14);
            sqlCmd.Parameters.AddWithValue("@p15", p15);
            sqlCmd.Parameters.AddWithValue("@p17", p17);
            sqlCmd.Parameters.AddWithValue("@p61", p61);
            sqlCmd.Parameters.AddWithValue("@p103", p103);
            sqlCmd.Parameters.AddWithValue("@p16", p16);
            sqlCmd.Parameters.AddWithValue("@p21", p21);
            sqlCmd.Parameters.AddWithValue("@p24", p24);
            sqlCmd.Parameters.AddWithValue("@p5", p5);
            sqlCmd.Parameters.AddWithValue("@p22", p22);
            sqlCmd.Parameters.AddWithValue("@p104", p104);
            sqlCmd.Parameters.AddWithValue("@p105", p105);
            sqlCmd.Parameters.AddWithValue("@p106", p106);
            sqlCmd.Parameters.AddWithValue("@p107", p107);
            sqlCmd.Parameters.AddWithValue("@p108", p108);
            sqlCmd.Parameters.AddWithValue("@p109", p109);
            sqlCmd.Parameters.AddWithValue("@p110", p110);

            var result = sqlCmd.ExecuteScalar();
            MessageBox.Show("Создана новая запись в БД  " + Convert.ToString(result));
            conn6.Close(); //Закрываем соединение

            b = "Данные в БД записаны";
        
            return b;
        }


        public string insertDB_brief(string p0, string p4, string p6, string p60, int p102, int p7, string p8, string p9, string p10, string p11, string p12, int p101, string p13, string p14, string p15, string p17, string p61, int p103, string p16, int p21, string p24)
        {
            string b;

            SqlConnection conn6 = DBUtils.GetDBConnection();
            conn6.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn6;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "creatnewPP_brief";
            sqlCmd.Parameters.AddWithValue("@p0", 123);
            sqlCmd.Parameters.AddWithValue("@p4", p4);
            sqlCmd.Parameters.AddWithValue("@p6", p6);
            sqlCmd.Parameters.AddWithValue("@p60", p60);
            sqlCmd.Parameters.AddWithValue("@p102", p102);
            sqlCmd.Parameters.AddWithValue("@p7", p7);
            sqlCmd.Parameters.AddWithValue("@p8", p8);
            sqlCmd.Parameters.AddWithValue("@p9", p9);
            sqlCmd.Parameters.AddWithValue("@p10", p10);
            sqlCmd.Parameters.AddWithValue("@p11", p11);
            sqlCmd.Parameters.AddWithValue("@p12", p12);
            sqlCmd.Parameters.AddWithValue("@p101", p101);
            sqlCmd.Parameters.AddWithValue("@p13", p13);
            sqlCmd.Parameters.AddWithValue("@p14", p14);
            sqlCmd.Parameters.AddWithValue("@p15", p15);
            sqlCmd.Parameters.AddWithValue("@p17", p17);
            sqlCmd.Parameters.AddWithValue("@p61", p61);
            sqlCmd.Parameters.AddWithValue("@p103", p103);
            sqlCmd.Parameters.AddWithValue("@p16", p16);
            sqlCmd.Parameters.AddWithValue("@p21", p21);
            sqlCmd.Parameters.AddWithValue("@p24", p24);
            var result = sqlCmd.ExecuteScalar();
            MessageBox.Show("Создана новая запись в БД  " + Convert.ToString(result));
            conn6.Close(); //Закрываем соединение

            b = "Данные в БД записаны";
         
            return b;
        }


        public string insertDB_urgency(string p0, string p4, string p6, string p60, int p102, int p7, string p8, string p9, string p10, string p11, string p12, int p101, string p13, string p14, string p15, string p17, string p61, int p103, string p16, int p21, string p24, string p5)
        {
            string b;

            SqlConnection conn6 = DBUtils.GetDBConnection();
            conn6.Open();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = conn6;
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "creatnewPP_urgency";
            sqlCmd.Parameters.AddWithValue("@p0", 123);
            sqlCmd.Parameters.AddWithValue("@p4", p4);
            sqlCmd.Parameters.AddWithValue("@p6", p6);
            sqlCmd.Parameters.AddWithValue("@p60", p60);
            sqlCmd.Parameters.AddWithValue("@p102", p102);
            sqlCmd.Parameters.AddWithValue("@p7", p7);
            sqlCmd.Parameters.AddWithValue("@p8", p8);
            sqlCmd.Parameters.AddWithValue("@p9", p9);
            sqlCmd.Parameters.AddWithValue("@p10", p10);
            sqlCmd.Parameters.AddWithValue("@p11", p11);
            sqlCmd.Parameters.AddWithValue("@p12", p12);
            sqlCmd.Parameters.AddWithValue("@p101", p101);
            sqlCmd.Parameters.AddWithValue("@p13", p13);
            sqlCmd.Parameters.AddWithValue("@p14", p14);
            sqlCmd.Parameters.AddWithValue("@p15", p15);
            sqlCmd.Parameters.AddWithValue("@p17", p17);
            sqlCmd.Parameters.AddWithValue("@p61", p61);
            sqlCmd.Parameters.AddWithValue("@p103", p103);
            sqlCmd.Parameters.AddWithValue("@p16", p16);
            sqlCmd.Parameters.AddWithValue("@p21", p21);
            sqlCmd.Parameters.AddWithValue("@p24", p24);
            sqlCmd.Parameters.AddWithValue("@p5", p5);

            var result = sqlCmd.ExecuteScalar();
            MessageBox.Show("Создана новая запись в БД  " + Convert.ToString(result));
            conn6.Close(); //Закрываем соединение

            b = "Данные в БД записаны";
            
            return b;
        }






        public string ed501(string p4)
        {
           string b;
                XDocument doc = new XDocument(new XElement("Document",
                                                   new XElement("CstmrCdtTrfInitn",
                                                       new XElement("GrpHdr",
                                                            new XElement("MsgId", "other text"),
                                                            new XElement("CreDtTm", p4),
                                                            new XElement("NbOfTxs", "other text"),
                                                                new XElement("InitgPty",
                                                                  new XElement("Nm", "text"),
                                                                  new XElement("id",
                                                                     new XElement("OrgId",
                                                                     new XElement("Othr",
                                                                      new XElement("Id", "text"),
                                                                      new XElement("SchmeNm",
                                                                        new XElement("cd", "text")
                                             )))))),
                                             new XElement("PmtInf",
                                                            new XElement("PmtInfId", "other text"),
                                                            new XElement("PmtMtd", "text"),
                                                            new XElement("PmtTpInf",
                                                                new XElement("InstrPrty", "text"),
                                                                new XElement("SvcLvl",
                                                                  new XElement("Cd", "text")
                                                                  
                                             )),
                                                            new XElement("ReqdExctnDt", "text"),
                                                                     new XElement("Dbtr",
                                                                     new XElement("Nm", "text"),
                                                                     new XElement("PstlAdr",
                                                                      new XElement("Ctry", "text")
                                             ),
                                                                      new XElement("id",
                                                                      new XElement("OrgId",
                                                                        new XElement("id", "text"),
                                                                            new XElement("SchmeNm",
                                                                            new XElement("Cd", "text"))
                                                                     

                                             ))),
                                                                     new XElement("DbtrAcct",
                                                                      new XElement("Id",
                                                                        new XElement("Othr",
                                                                           
                                                                            new XElement("Id", "text"),
                                                                            new XElement("SchmeNm",
                                                                            new XElement("Cd", "text")
                                                                            )

                                             )),
                                             new XElement("Ccy", "text")
                                             ),
                                              new XElement("DbtrAg",
                                                                      new XElement("FinInstnId",
                                                                        new XElement("ClrSysMmbId",
                                                                             new XElement("ClrSysId",
                                                                                 new XElement("Cd", "text")
                                             ),    
                                                                            new XElement("MmbId", "text")

                                             ),
                                                                              new XElement("PstlAdr",
                                                                                 new XElement("Ctry", "text")
                                             ))),
                                             new XElement("DbtrAgtAcct",
                                                        new XElement("Id",
                                                            new XElement("Othr",
                                                                                 new XElement("id", "text")


                                             )))))));

                doc.Save("C:\\PeredatchikPSBR\\test.ed501");

            b = "Платежное поручение в формате ED501 сохранено";
            MessageBox.Show(b);
            return b;

        }


    }
}
