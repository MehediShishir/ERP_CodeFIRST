namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Leavetypetableadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaveTypes",
                c => new
                    {
                        LeaveTypeID = c.Int(nullable: false, identity: true),
                        LeaveTypeName = c.String(),
                    })
                .PrimaryKey(t => t.LeaveTypeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaveTypes");
        }
    }
}
