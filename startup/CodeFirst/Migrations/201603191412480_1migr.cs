namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1migr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Sphere_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Spheres", t => t.Sphere_Id)
                .Index(t => t.Sphere_Id);
            
            CreateTable(
                "dbo.Spheres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Categories", "Sphere_Id", "dbo.Spheres");
            DropIndex("dbo.Categories", new[] { "Sphere_Id" });
            DropIndex("dbo.Answers", new[] { "Category_Id" });
            DropTable("dbo.Spheres");
            DropTable("dbo.Categories");
            DropTable("dbo.Answers");
        }
    }
}
