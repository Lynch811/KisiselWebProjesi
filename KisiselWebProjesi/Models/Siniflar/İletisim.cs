using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class İletisim
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string ileti { get; set; }
        public string mesage { get; set; }
        public string buton { get; set; }



    }
}