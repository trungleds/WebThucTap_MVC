namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class logisticDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 50),
                        Name = c.String(maxLength: 50),
                        Addess = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(),
                        CreateBy = c.String(maxLength: 50),
                        ModifedDate = c.DateTime(),
                        ModifedBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
