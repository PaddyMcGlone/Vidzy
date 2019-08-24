namespace Vidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES(ID, NAME) VALUES(1 ,'ACTION')");
            Sql("INSERT INTO GENRES(ID, NAME) VALUES(2 ,'HORROR')");
        }

        public override void Down()
        {
            Sql("TRUNCATE TABLE GENRES");
        }
    }
}
