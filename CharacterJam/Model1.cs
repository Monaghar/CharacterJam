namespace CharacterJam
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.Entity.Migrations;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CharacterDBO> Characters { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}