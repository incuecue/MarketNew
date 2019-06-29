using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MarketNew.Models
{
    public class PhoneContext : DbContext
    {
        public virtual DbSet<Phone> Phones { get; set; }

        public virtual DbSet<Purcashe> Purcashes { get; set; }
    }
}