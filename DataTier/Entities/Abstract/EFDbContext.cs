using DataTier.Entities.Concrete;
using DataTier.Entities.Concrete.Enums;
using DataTier.Entities.Concrete.Statuses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Abstract
{
    public class EFDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<DealerCenter> DealerCenters { get; set; }
        public DbSet<Fillial> Fillials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ServiceStation> ServiceStations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<HasFillial> HasFillials { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SettlementPeriod> SettlementPeriods { get; set; }
        public DbSet<SettlementType> SettlementTypes { get; set; }
        public DbSet<ClientInfo> ClientInfos { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CommercialResponsiblePerson> CommercialResponsiblePersons { get; set; }
        public DbSet<AccountingResponsiblePerson> AccountingResponsiblePersons { get; set; }
        public DbSet<LegalPerson> LegalPersons { get; set; }

        /*  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          {
              optionsBuilder.UseSqlServer("Server=(local)\\sqlexpress;Database=KadetDb;Trusted_Connection=true;MultipleActiveResultSets=True");
          }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=drona.db.elephantsql.com;Port=5432;Database=qcpcclyr; Username=qcpcclyr;Password=jQVFgyTjSnKKs9u9bZjh2P1l6u3tfukj;");
        }

    }

}
