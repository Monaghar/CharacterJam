namespace CharacterJam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.studentdetails", newName: "Characters");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Characters", newName: "studentdetails");
        }
    }
}
