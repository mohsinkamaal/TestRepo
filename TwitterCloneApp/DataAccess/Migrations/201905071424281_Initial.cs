namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FOLLOWING",
                c => new
                    {
                        demo_id = c.Int(nullable: false, identity: true),
                        user_id = c.String(nullable: false, maxLength: 25, unicode: false),
                        following_id = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.demo_id)
                .ForeignKey("dbo.PERSON", t => t.user_id)
                .ForeignKey("dbo.PERSON", t => t.following_id)
                .Index(t => t.user_id)
                .Index(t => t.following_id);
            
            CreateTable(
                "dbo.PERSON",
                c => new
                    {
                        user_id = c.String(nullable: false, maxLength: 25, unicode: false),
                        password = c.String(nullable: false, maxLength: 50, unicode: false),
                        fullname = c.String(nullable: false, maxLength: 30, unicode: false),
                        email = c.String(nullable: false, maxLength: 50, unicode: false),
                        joined = c.DateTime(nullable: false),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.user_id);
            
            CreateTable(
                "dbo.TWEET",
                c => new
                    {
                        tweet_id = c.Int(nullable: false, identity: true),
                        user_id = c.String(nullable: false, maxLength: 25, unicode: false),
                        message = c.String(nullable: false, maxLength: 140, unicode: false),
                        created = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.tweet_id)
                .ForeignKey("dbo.PERSON", t => t.user_id)
                .Index(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TWEET", "user_id", "dbo.PERSON");
            DropForeignKey("dbo.FOLLOWING", "following_id", "dbo.PERSON");
            DropForeignKey("dbo.FOLLOWING", "user_id", "dbo.PERSON");
            DropIndex("dbo.TWEET", new[] { "user_id" });
            DropIndex("dbo.FOLLOWING", new[] { "following_id" });
            DropIndex("dbo.FOLLOWING", new[] { "user_id" });
            DropTable("dbo.TWEET");
            DropTable("dbo.PERSON");
            DropTable("dbo.FOLLOWING");
        }
    }
}
