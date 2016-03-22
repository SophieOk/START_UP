namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1migration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Answers", newName: "Answer");
            RenameTable(name: "dbo.Categories", newName: "Category");
            RenameTable(name: "dbo.Spheres", newName: "Sphere");
            AddColumn("dbo.Answer", "Category_Id", c => c.Int());
            AddColumn("dbo.Category", "Sphere_Id", c => c.Int());
            CreateIndex("dbo.Answer", "Category_Id");
            CreateIndex("dbo.Category", "Sphere_Id");
            AddForeignKey("dbo.Category", "Sphere_Id", "dbo.Sphere", "Id");
            AddForeignKey("dbo.Answer", "Category_Id", "dbo.Category", "Id");
            DropColumn("dbo.Answer", "Category");
            DropColumn("dbo.Category", "Sphere");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "Sphere", c => c.String());
            AddColumn("dbo.Answer", "Category", c => c.String());
            DropForeignKey("dbo.Answer", "Category_Id", "dbo.Category");
            DropForeignKey("dbo.Category", "Sphere_Id", "dbo.Sphere");
            DropIndex("dbo.Category", new[] { "Sphere_Id" });
            DropIndex("dbo.Answer", new[] { "Category_Id" });
            DropColumn("dbo.Category", "Sphere_Id");
            DropColumn("dbo.Answer", "Category_Id");
            RenameTable(name: "dbo.Sphere", newName: "Spheres");
            RenameTable(name: "dbo.Category", newName: "Categories");
            RenameTable(name: "dbo.Answer", newName: "Answers");
        }
    }
}
