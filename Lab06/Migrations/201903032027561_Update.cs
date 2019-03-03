namespace Lab06.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "Notes", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enrollments", "Notes", c => c.String());
        }
    }
}
