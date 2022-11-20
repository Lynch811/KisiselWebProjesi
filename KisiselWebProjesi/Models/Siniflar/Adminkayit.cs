using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Adminkayit
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string mailadresi { get; set; }
        public string sifre { get; set; }
        public string tekrarsifre { get; set; }

    }
}