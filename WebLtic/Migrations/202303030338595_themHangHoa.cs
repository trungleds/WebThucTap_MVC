namespace WebLtic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class themHangHoa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HangHoas", "HienThi", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HangHoas", "HienThi", c => c.Boolean());
        }
    }
}
