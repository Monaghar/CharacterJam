namespace CharacterJam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.studentdetails",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Gender = c.String(),
                        Age = c.Int(nullable: false),
                        Languages = c.String(),
                        Race = c.String(),
                        Class = c.String(),
                        Stats = c.String(),
                        Skills = c.String(),
                        Tools = c.String(),
                        Lifestyle = c.String(),
                        Alignment = c.String(),
                        Background = c.String(),
                        Trait = c.String(),
                        Ideal = c.String(),
                        Bond = c.String(),
                        Flaw = c.String(),
                    })
                .PrimaryKey(t => t.CharacterId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.studentdetails");
        }
    }
}
