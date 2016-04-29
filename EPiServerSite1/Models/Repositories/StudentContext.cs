namespace EPiServerSite1.Models.Repositories
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using EPiServerSite1.Models.Data;

    public partial class StudentContext : DbContext
    {
        public StudentContext()
            : base("name=EPiServerDB")
        {
        }

        public DbSet<Student> Students { get; set; }

        //public System.Data.Entity.DbSet<EPiServerSite1.Models.Data.Student> Students { get; set; }
    }
}
