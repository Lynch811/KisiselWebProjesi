using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Copyright
    {
        [Key]
        public int id { get; set; }
        public string yazi { get; set; }

    }
}