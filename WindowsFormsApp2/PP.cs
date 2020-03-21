﻿using System;
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



namespace WindowsFormsApp2
{
    class pp
    {
        string p1;
        int p0;
        int p2;
        int p3;
        string p4;
        int p7;
        string p6;
        string p8;
        int p60;
        int p102;
        int p101;

        SqlConnection conn = DBUtils.GetDBConnection();
        SqlCommand command = new SqlCommand();
       

        public int P0
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

        public int P60
        {
            get { return p60; }
            set { p60 = value; }
        }

        public int P102
        {
            get { return p102; }
            set { p102 = value; }
        }

        public int P101
        {
            get { return p101; }
            set { p101 = value; }
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


        public int GetINN(string companyname)
        {
            int INN = 10;
            return INN;
        }


        public int GetKPP(string companyname)
        {
            int KPP = 10;

            return KPP;

        }

        public int Get101(string companyname)
        {
            int Get101 = 10;

            return Get101;

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


        public string ed501(string p4)
        {
           string b;
            ///string xml ="<Document xmlns=urn: iso: std: iso: 20022:tech: xsd: pain.001.001.06> " +
            //   "</Document>";


            //XElement xElement = XElement.Parse(xml);
            // Console.WriteLine(xElement);

            // xElement.Save("C:\\PeredatchikPSBR\\test.ed501");

                XDocument doc = new XDocument(new XElement("Document",
                                                   new XElement("CstmrCdtTrfInitn",
                                                       new XElement("GrpHdr",
                                                            new XElement("MsgId", "other text"),
                                                            new XElement("CreDtTm", "text"),
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

                                             )
                                             
                                             
                                             ))));

                doc.Save("C:\\PeredatchikPSBR\\test.ed501");

            b = "Платежное поручение в формате ED501 сохранено";
            MessageBox.Show(b);
            return b;

        }


    }
}
