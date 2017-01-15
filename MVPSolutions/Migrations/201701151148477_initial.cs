namespace MVPSolutions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Concepts",
                c => new
                    {
                        Concept_ID = c.Int(nullable: false, identity: true),
                        Credit_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Concept_ID)
                .ForeignKey("dbo.Credits", t => t.Credit_ID, cascadeDelete: true)
                .Index(t => t.Credit_ID);
            
            CreateTable(
                "dbo.Credits",
                c => new
                    {
                        Credit_ID = c.Int(nullable: false, identity: true),
                        Photography = c.String(),
                        MUA = c.String(),
                        Hair = c.String(),
                        Styling = c.String(),
                        Concept = c.String(),
                    })
                .PrimaryKey(t => t.Credit_ID);
            
            CreateTable(
                "dbo.Pics",
                c => new
                    {
                        Pic_ID = c.Int(nullable: false, identity: true),
                        Story_ID = c.Int(nullable: true),
                        Concept_ID = c.Int(nullable: true),
                        Path = c.String(),
                    })
                .PrimaryKey(t => t.Pic_ID)
                .ForeignKey("dbo.Concepts", t => t.Concept_ID)
                .ForeignKey("dbo.Stories", t => t.Story_ID)
                .Index(t => t.Story_ID)
                .Index(t => t.Concept_ID);
            
            CreateTable(
                "dbo.Stories",
                c => new
                    {
                        Story_ID = c.Int(nullable: false, identity: true),
                        Story = c.String(),
                        Credit_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Story_ID)
                .ForeignKey("dbo.Credits", t => t.Credit_ID, cascadeDelete: true)
                .Index(t => t.Credit_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pics", "Story_ID", "dbo.Stories");
            DropForeignKey("dbo.Stories", "Credit_ID", "dbo.Credits");
            DropForeignKey("dbo.Pics", "Concept_ID", "dbo.Concepts");
            DropForeignKey("dbo.Concepts", "Credit_ID", "dbo.Credits");
            DropIndex("dbo.Stories", new[] { "Credit_ID" });
            DropIndex("dbo.Pics", new[] { "Concept_ID" });
            DropIndex("dbo.Pics", new[] { "Story_ID" });
            DropIndex("dbo.Concepts", new[] { "Credit_ID" });
            DropTable("dbo.Stories");
            DropTable("dbo.Pics");
            DropTable("dbo.Credits");
            DropTable("dbo.Concepts");
        }
    }
}
