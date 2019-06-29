using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketNew.Models
{
    public class Purcashe
    {
        public int PurcasheId { get; set; }

        public int PhoneId { get; set; }

        public DateTime DateTime { get; set; }

        public string Email { get; set; }

        public string FIO { get; set; }

        public string Address { get; set; }
    }
}