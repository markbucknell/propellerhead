namespace Propellerhead.Migrations
{
    using Propellerhead.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Propellerhead.DataAccess.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Propellerhead.DataAccess.Context context)
        {
            //  This method will be called after migrating to the latest version.

            var customers = new List<Customer>
            {
                new Customer{FirstName="Kris",LastName="Bright",CreatedDate=DateTime.Parse("2018-09-01"),ModifiedDate=DateTime.Parse("2018-09-01"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Fabrizio",LastName="Tavano",CreatedDate=DateTime.Parse("2018-09-01"),ModifiedDate=DateTime.Parse("2018-09-01"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Darren",LastName="White",CreatedDate=DateTime.Parse("2018-09-01"),ModifiedDate=DateTime.Parse("2018-09-01"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Albert",LastName="Riera",CreatedDate=DateTime.Parse("2018-09-01"),ModifiedDate=DateTime.Parse("2018-09-01"),Active=true, Status=Models.Status.NonActive}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}
