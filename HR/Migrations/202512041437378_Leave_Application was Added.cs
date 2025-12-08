namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Leave_ApplicationwasAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaveApplications",
                c => new
                    {
                        LeaveApplicationID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(nullable: false),
                        LeaveType = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LeaveApplicationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaveApplications");
        }
    }
}
