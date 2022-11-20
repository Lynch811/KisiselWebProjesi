using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Hakkinda
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string metin { get; set; }
        public string resim { get; set; }

    }
}