namespace Lab06.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enrollments", "Notes", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enrollments", "Notes", c => c.String(nullable: false));
        }
    }
}
