namespace BigShool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql(" Insert into categories (id, name ) values (1, 'development') ");
            Sql(" Insert into categories (id, name ) values (2, 'business') ");
            Sql(" Insert into categories (id, name ) values (3, 'marketing') ");
        }
        
        public override void Down()
        {
        }
    }
}
