using Propellerhead.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Propellerhead.DataAccess
{
    public class Initialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var customers = new List<Customer>
            {
                new Customer{FirstName="Kris",LastName="Bright",CreatedDate=DateTime.Parse("2018-09-01")},
                new Customer{FirstName="Fabrizio",LastName="Tavano",CreatedDate=DateTime.Parse("2018-09-01")},
                new Customer{FirstName="Darren",LastName="White",CreatedDate=DateTime.Parse("2018-09-01")},
                new Customer{FirstName="Albert",LastName="Riera",CreatedDate=DateTime.Parse("2018-09-01")}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}