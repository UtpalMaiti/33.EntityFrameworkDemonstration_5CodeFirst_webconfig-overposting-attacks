namespace EntityFrameworkDemonstration_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentCourseValidationChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "Address", c => c.String());
            AlterColumn("dbo.Course", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "EmailId", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "ContactNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "ContactNo", c => c.String());
            AlterColumn("dbo.Student", "EmailId", c => c.String());
            AlterColumn("dbo.Student", "Name", c => c.String());
            AlterColumn("dbo.Course", "Name", c => c.String());
            DropColumn("dbo.Student", "Address");
        }
    }
}
