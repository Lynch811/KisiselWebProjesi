using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string resim { get; set; }
        public string anabaslik { get; set; }
        public string maviyazi { get; set; }
        public string maviyaziyani { get; set; }
        public string isim { get; set; }
        public string aciklama { get; set; }
        public string metin { get; set; }
        
       

    }
}