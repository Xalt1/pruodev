using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace baris
{
    internal class context : DbContext
    {
        public context() : base("SQLEBAGLAN")
        {
               
        }
        public DbSet<ogrenci> ogrenciveri { get; set; }
        public DbSet<okulyonetim> okulyonetimveri { get; set; }
        public DbSet<ders> dersveri { get; set; }
        public DbSet<ogrenciders> ogrencidersveri { get; set; }
        
    }
}
