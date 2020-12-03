namespace AJAXv1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingmodelprovince : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Provinces");
        }
    }
}
