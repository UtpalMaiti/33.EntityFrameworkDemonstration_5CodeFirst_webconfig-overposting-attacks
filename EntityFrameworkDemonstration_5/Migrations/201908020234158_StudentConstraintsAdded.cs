namespace EntityFrameworkDemonstration_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentConstraintsAdded : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "ContactNo", newName: "ContactNumber");
            AlterColumn("dbo.Student", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Student", "EmailId", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Student", "ContactNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Student", "Qualification", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "Qualification", c => c.String());
            AlterColumn("dbo.Student", "ContactNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "EmailId", c => c.String(nullable: false));
            AlterColumn("dbo.Student", "Name", c => c.String(nullable: false));
            RenameColumn(table: "dbo.Student", name: "ContactNumber", newName: "ContactNo");
        }
    }
}
