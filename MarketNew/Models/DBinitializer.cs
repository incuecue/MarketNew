using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MarketNew.Models
{
    public class DBinitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Huawei Honor 9", Price = 100000, Producer = "Huawei" });
            context.Phones.Add(new Phone() { Name = "Google Pixel 2 XL", Price = 50000, Producer = "Google" });
            context.Phones.Add(new Phone() { Name = "Essential PH-1", Price = 25000, Producer = "Essential" });

            base.Seed(context);
        }
    }
}