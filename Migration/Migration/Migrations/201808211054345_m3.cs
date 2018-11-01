namespace Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "WorkPlace", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "WorkPlace");
        }
    }
}
