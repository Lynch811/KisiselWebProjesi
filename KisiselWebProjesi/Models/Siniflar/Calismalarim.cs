using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Calismalarim
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        //-------------------------------------------------
        public string resim1 { get; set; }
        public string resimyazi1 { get; set; }
        
        //-------------------------------------------------
        public string resim2 { get; set; }
        public string resimyazi2 { get; set; }
        //-------------------------------------------------
        public string resim3 { get; set; }
        public string resimyazi3 { get; set; }
        //-------------------------------------------------
        public string resim4 { get; set; }
        public string resimyazi4 { get; set; }
        //-------------------------------------------------
        public string resim5 { get; set; }
        public string resimyazi5 { get; set; }
        //-------------------------------------------------
        public string resim6 { get; set; }
        public string resimyazi6 { get; set; }
        //-------------------------------------------------
        public string resim7 { get; set; }
        public string resimyazi7 { get; set; }
        //-------------------------------------------------
        public string resim8 { get; set; }
        public string resimyazi8 { get; set; }

    }
}