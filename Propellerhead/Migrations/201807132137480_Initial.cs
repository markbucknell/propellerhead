namespace Propellerhead.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Mobile = c.String(),
                        Status = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Note",
                c => new
                    {
                        NoteId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.NoteId)
                .ForeignKey("dbo.Customer", t => t.Customer_CustomerId)
                .Index(t => t.Customer_CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Note", "Customer_CustomerId", "dbo.Customer");
            DropIndex("dbo.Note", new[] { "Customer_CustomerId" });
            DropTable("dbo.Note");
            DropTable("dbo.Customer");
        }
    }
}
