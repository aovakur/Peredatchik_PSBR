using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   sealed class settings
    {
        public static string safepath;
        public static string safepathpdf;
        public static string safepathed101;
        public static string safepathed501;
        public static string safepatheMT101;
        public static string safepathetemplate;
        public static string safepatheesis;

        public static string safepath_1(string safepath1)
        {

            string pdf = "\\pdf\\";
            string ed501 = "\\ed501\\";
            string ed101 = "\\ed101\\";
            string template = "\\Template\\Template_10.pdf";
            string MT101 = "\\MT101\\";
            string esis = "\\esis\\";

            //path
            safepath = safepath1;
            
            //pdf
            safepathpdf =safepath+pdf;
            //ed501
            safepathed501=safepath + ed501;
            //template_pp
            safepathetemplate=safepath + template;
            //ed101
            safepathed101=safepath + ed101;
            //mt101
            safepatheMT101 = safepath + MT101;
            //esis 
            safepatheesis = safepath + esis;

            return safepath;
        }

    }
}
