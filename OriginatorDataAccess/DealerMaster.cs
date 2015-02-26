
namespace Originator.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DealerMaster : DbContext
    {
        public DealerMaster()
            : base("name=DealerMaster")
        {
        }

        public DbSet<DLRMAST> DLRMASTs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.Trail_Rate)
                .HasPrecision(5, 4);

            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.ApnRate_Addon)
                .HasPrecision(5, 4);

            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.Monthly_Service_Fee)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.MSF_Previous_Rate)
                .IsFixedLength();

            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.Monthly_Service_Fee_BL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.Monthly_Service_Fee_VL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.Monthly_Service_Fee_PL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DLRMAST>()
                .Property(e => e.Monthly_Service_Fee_RCF)
                .HasPrecision(19, 4);

        }
    }
}
