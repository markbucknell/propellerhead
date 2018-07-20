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
                new Customer{FirstName="Ali",LastName="Riley",Email="Ali.Riley@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Abby",LastName="Erceg",Email="Abby.Erceg@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Darren",LastName="White",Email="Darren.White@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Katie",LastName="Boewn",Email="Katie.Boewn@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.NonActive},
                new Customer{FirstName="Kris",LastName="Bright",Email="Kris.Bright@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Kirsty",LastName="Yallop",Email="Kirsty.Yallop@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Amber",LastName="Hearn",Email="Amber.Hearn@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.Current},
                new Customer{FirstName="Albert",LastName="Riera",Email="Albert.Riera@propellerhead.com",Mobile="0123456789",CreatedDate=DateTime.Parse("2018-09-01 09:00"),ModifiedDate=DateTime.Parse("2018-09-01 09:00"),Active=true, Status=Models.Status.NonActive}
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();
        }
    }
}
