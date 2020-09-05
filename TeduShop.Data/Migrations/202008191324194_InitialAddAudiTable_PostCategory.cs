namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialAddAudiTable_PostCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String(maxLength: 500));
            AddColumn("dbo.PostCatagories", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCatagories", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCatagories", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.PostCatagories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCatagories", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostCatagories", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.PostCatagories", "UpdateBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostTags", "MetaKeyword", c => c.String(maxLength: 256));
            AddColumn("dbo.PostTags", "MetaDescription", c => c.String(maxLength: 256));
            AddColumn("dbo.PostTags", "Status", c => c.Boolean(nullable: false));
            AddColumn("dbo.PostTags", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostTags", "CreatedBy", c => c.String(maxLength: 256));
            AddColumn("dbo.PostTags", "UpdateDate", c => c.DateTime());
            AddColumn("dbo.PostTags", "UpdateBy", c => c.String(maxLength: 256));
            DropColumn("dbo.Products", "Desription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Desription", c => c.String(maxLength: 500));
            DropColumn("dbo.PostTags", "UpdateBy");
            DropColumn("dbo.PostTags", "UpdateDate");
            DropColumn("dbo.PostTags", "CreatedBy");
            DropColumn("dbo.PostTags", "CreatedDate");
            DropColumn("dbo.PostTags", "Status");
            DropColumn("dbo.PostTags", "MetaDescription");
            DropColumn("dbo.PostTags", "MetaKeyword");
            DropColumn("dbo.PostCatagories", "UpdateBy");
            DropColumn("dbo.PostCatagories", "UpdateDate");
            DropColumn("dbo.PostCatagories", "CreatedBy");
            DropColumn("dbo.PostCatagories", "CreatedDate");
            DropColumn("dbo.PostCatagories", "Status");
            DropColumn("dbo.PostCatagories", "MetaDescription");
            DropColumn("dbo.PostCatagories", "MetaKeyword");
            DropColumn("dbo.Products", "Description");
        }
    }
}

