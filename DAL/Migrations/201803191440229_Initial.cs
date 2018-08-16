namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contactss",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        TipBroja = c.Int(nullable: false),
                        Address = c.String(),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID)
                .ForeignKey("dbo.Peoplee", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Peoplee",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contactss", "PersonID", "dbo.Peoplee");
            DropIndex("dbo.Contactss", new[] { "PersonID" });
            DropTable("dbo.Peoplee");
            DropTable("dbo.Contactss");
        }
    }
}
