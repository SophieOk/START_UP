namespace Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2migr : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Sphere_Id", "dbo.Spheres");
            DropForeignKey("dbo.Answers", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Answers", new[] { "Category_Id" });
            DropIndex("dbo.Categories", new[] { "Sphere_Id" });
            AddColumn("dbo.Answers", "Category", c => c.String());
            AddColumn("dbo.Categories", "Sphere", c => c.String());
            DropColumn("dbo.Answers", "Category_Id");
            DropColumn("dbo.Categories", "Sphere_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Sphere_Id", c => c.Int());
            AddColumn("dbo.Answers", "Category_Id", c => c.Int());
            DropColumn("dbo.Categories", "Sphere");
            DropColumn("dbo.Answers", "Category");
            CreateIndex("dbo.Categories", "Sphere_Id");
            CreateIndex("dbo.Answers", "Category_Id");
            AddForeignKey("dbo.Answers", "Category_Id", "dbo.Categories", "Id");
            AddForeignKey("dbo.Categories", "Sphere_Id", "dbo.Spheres", "Id");
        }
    }
}
