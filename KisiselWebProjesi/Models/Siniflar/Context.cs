using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admingiris> Admingirises { get; set; } 
        public DbSet<Adminkayit> Adminkayits { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Hakkinda> Hakkindas { get; set; }
        public DbSet<Yeteneklerim> Yeteneklerims { get; set; }
        public DbSet<Calismalarim> Calismalarims { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Copyright> Copyrights { get; set; }
        public DbSet<İconlar> İconlars { get; set; }









    }
}