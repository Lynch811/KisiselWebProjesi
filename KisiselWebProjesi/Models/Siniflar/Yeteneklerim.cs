using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Yeteneklerim
    {
        [Key]
        public int id { get; set; }
        public string anabaslik { get; set; }
        public string aciklama { get; set; }
        //--------------------------------------------
        public string icon1 { get; set; }
        public string baslik1 { get; set; }
        public string metin1 { get; set; }
        //--------------------------------------------
        public string icon2 { get; set; }
        public string baslik2 { get; set; }
        public string metin2 { get; set; }
        //--------------------------------------------
        public string icon3 { get; set; }
        public string baslik3 { get; set; }
        public string metin3 { get; set; }
        //--------------------------------------------
        public string icon4 { get; set; }
        public string baslik4 { get; set; }
        public string metin4 { get; set; }
        //--------------------------------------------
        public string icon5 { get; set; }
        public string baslik5 { get; set; }
        public string metin5 { get; set; }
        //--------------------------------------------
        public string icon6 { get; set; }
        public string baslik6 { get; set; }
        public string metin6 { get; set; }
        //--------------------------------------------






    }
}