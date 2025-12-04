namespace HR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Designations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        DesignationID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ShortCode = c.String(),
                    })
                .PrimaryKey(t => t.DesignationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Designations");
        }
    }
}
