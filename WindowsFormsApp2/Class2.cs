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
using System.Configuration;


namespace WindowsFormsApp2
{
    partial class pp
    {
        string a;

        public string createed999()
        {
            string safeed999 = settings.safepatheesis + p4 + "_" + p0 + ".ed999";
            StreamWriter f = new StreamWriter(safeed999);
            f.WriteLine("<?xml version=" + '\u0022' + "1.0" + '\u0022' + " " + "encoding=" + '\u0022' + "WINDOWS-1251" + '\u0022' + "?>");
            f.WriteLine("<ED101 xmlns=" + '\u0022' + "urn:cbr-ru:ed:v2.0" + '\u0022' + " " + "EDNo=" + '\u0022' + "1" + '\u0022' + " " + "EDDate=" + '\u0022' + p4 + '\u0022' + " " + "EDAuthor=" + '\u0022' + "4525545000" + '\u0022' + " " + "TransKind=" + '\u0022' + p101 + '\u0022' + " Priority=" + '\u0022' + p21 + '\u0022' + " " + "Sum=" + '\u0022' + p7 + '\u0022' + " " + "PaymentPrecedence=" + '\u0022' + "60" + '\u0022' + " " + "SystemCode=" + '\u0022' + "05" + '\u0022' + " PaytKind=" + '\u0022' + "4" + '\u0022' + " " + "ReceiptDate=" + '\u0022' + "2018-07-02" + '\u0022' + " " + "ChargeOffDate=" + '\u0022' + "2018-07-02" + '\u0022' + ">");
            f.WriteLine("       <AccDoc AccDocNo=" + '\u0022' + p0 + '\u0022' + " " + "AccDocDate=" + '\u0022' + p4 + '\u0022' + "/>");
            f.WriteLine("       <Payer PersonalAcc=" + '\u0022' + p9 + '\u0022' + " " + "INN=" + '\u0022' + p60 + '\u0022' + ">");
            f.WriteLine("               <Name>" + p8 + "</Name>");
            f.WriteLine("               <Bank BIC=" + '\u0022' + p11 + '\u0022' + " " + "CorrespAcc=" + '\u0022' + p12 + '\u0022' + "/>");
            f.WriteLine("       </Payer>");
            f.WriteLine("       <Payee PersonalAcc=" + '\u0022' + p17 + '\u0022' + " " + "INN=" + '\u0022' + p61 + '\u0022' + ">");
            f.WriteLine("       <Name>" + p16 + "</Name>");
            f.WriteLine("       <Bank BIC=" + '\u0022' + p14 + '\u0022' + " " + "CorrespAcc=" + '\u0022' + p17 + '\u0022' + "/>");
            f.WriteLine("       </Payee>");
            f.WriteLine("       <Purpose>" + p24 + "</Purpose>");
            f.WriteLine("</ED101>");
            f.Close();
            a = "Платежное поручение в формате ED101 сохранено";
            MessageBox.Show(a);
            return a;
        }

        public static string generateMSDEd501ID()
        {
            DateTime dt = DateTime.Now;
            string curDate = dt.ToShortDateString();

            String curentyear = dt.ToString("yyyy");
            String curentmonth = dt.ToString("MM");
            String curentday = dt.ToString("dd");

            string fulldate = curentyear+curentmonth+curentday;
            string currentday = ReadSetting("currentday");

            if (fulldate == currentday)
            {
                string msgName = ReadSetting("MessageName");
                int CurrentIDED501 = Convert.ToInt16(ReadSetting("MessageIDED501"));
                int NewIDED501 = CurrentIDED501+1;

                //Генерирую полное имя
                String NewfullmsgID = msgName + "_pain_MSG_" + fulldate + "_"+NewIDED501;

                //Обновляю счетчик
                AddUpdateAppSettings("MessageIDED501", Convert.ToString(NewIDED501));

                //Обновляю последнее полное имя 
                AddUpdateAppSettings("MessageIDED501_full", Convert.ToString(NewfullmsgID));

                int CurrentIDED501_new = Convert.ToInt16(ReadSetting("MessageIDED501"));
                string CurrentIDED501FULL_new = Convert.ToString(ReadSetting("MessageIDED501_full"));
                return CurrentIDED501FULL_new;
            }

            else
            {
                AddUpdateAppSettings("currentday", fulldate);
                AddUpdateAppSettings("MessageIDED501", "0");

                string msgName = ReadSetting("MessageName");

                int CurrentIDED501 = Convert.ToInt16(ReadSetting("MessageIDED501"));
                int NewIDED501 = CurrentIDED501 + 1;

                //Генерирую полное имя
                String NewfullmsgID = msgName + "_pain_MSG_" + fulldate + "_" + NewIDED501;

                //Обновляю счетчик
                AddUpdateAppSettings("MessageIDED501", Convert.ToString(NewIDED501));

                //Обновляю последнее полное имя 
                AddUpdateAppSettings("MessageIDED501_full", Convert.ToString(NewfullmsgID));

                int CurrentIDED501_new = Convert.ToInt16(ReadSetting("MessageIDED501"));
                string CurrentIDED501FULL_new = Convert.ToString(ReadSetting("MessageIDED501_full"));
                return CurrentIDED501FULL_new;
            }
        }


        static void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var value in appSettings.AllKeys)
                    {
                        MessageBox.Show(Convert.ToString(value));
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
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
                //Message.Show();
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }



    }
}
