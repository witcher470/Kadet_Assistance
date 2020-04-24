﻿// <auto-generated />
using System;
using DataTier.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataTier.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20200424131603_strings")]
    partial class strings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DataTier.Entities.Concrete.AccountingResponsiblePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("AccountingResponsiblePersons");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CarBrands");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ActionStartDate");

                    b.Property<string>("CardAppeal");

                    b.Property<int>("CardCost");

                    b.Property<string>("CardNumber")
                        .IsRequired();

                    b.Property<int>("CardStatus");

                    b.Property<int>("ClientId");

                    b.Property<int?>("ClientInfoId");

                    b.Property<string>("Color");

                    b.Property<DateTime>("DateOfContractWithClient");

                    b.Property<DateTime>("DateOfContractWithKadet");

                    b.Property<DateTime>("DeactivationDate");

                    b.Property<DateTime>("Duration");

                    b.Property<string>("EmployerFirstName")
                        .IsRequired();

                    b.Property<string>("EmployerSecondName")
                        .IsRequired();

                    b.Property<string>("EmployerThirdName")
                        .IsRequired();

                    b.Property<string>("ManagerFirstName")
                        .IsRequired();

                    b.Property<string>("ManagerSecondName")
                        .IsRequired();

                    b.Property<string>("ManagerThirdName")
                        .IsRequired();

                    b.Property<int>("NumberOfContractWithClient");

                    b.Property<int>("NumberOfContractWithKadet");

                    b.Property<string>("SellerFirstName")
                        .IsRequired();

                    b.Property<string>("SellerSecondName")
                        .IsRequired();

                    b.Property<string>("SellerThirdName")
                        .IsRequired();

                    b.Property<int>("ServicesId");

                    b.Property<string>("VIN")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ClientInfoId");

                    b.HasIndex("ServicesId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.ClientInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarBrandId");

                    b.Property<string>("ClientFristName")
                        .IsRequired();

                    b.Property<string>("ClientSecondName")
                        .IsRequired();

                    b.Property<string>("ClientThirdName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("Region")
                        .IsRequired();

                    b.Property<string>("StateNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.ToTable("ClientInfos");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.CommercialResponsiblePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("CommercialResponsiblePersons");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnotherPhoneNumber");

                    b.Property<int?>("AnotherServicesId");

                    b.Property<int>("CarryingCapacityOfTrucks");

                    b.Property<string>("Cities");

                    b.Property<int>("ContractorStatus");

                    b.Property<int>("CraneManipulatorStatus");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Login");

                    b.Property<int>("NumberOfTrucks");

                    b.Property<int?>("PaymentMethodId");

                    b.Property<int>("PaymnetMethodId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int>("PlatformLenght");

                    b.Property<string>("PriceList")
                        .IsRequired();

                    b.Property<int>("Rating");

                    b.Property<string>("SecondName")
                        .IsRequired();

                    b.Property<int?>("ServicesId");

                    b.Property<string>("ThirdName")
                        .IsRequired();

                    b.Property<int>("TrolleysStatus");

                    b.Property<string>("WorkTime");

                    b.Property<string>("YearOfManufactureOfTrucks");

                    b.HasKey("Id");

                    b.HasIndex("AnotherServicesId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("ServicesId");

                    b.ToTable("Contractors");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.DealerCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountingResponsiblePersonId");

                    b.Property<string>("AnotherProducts");

                    b.Property<string>("BillingInformation");

                    b.Property<int>("CarBrandId");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<int>("CommercialResponsiblePersonId");

                    b.Property<string>("CooperatorName");

                    b.Property<string>("CooperatorPhoneNumber");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("DateTimeOfContract");

                    b.Property<int>("DealerCenterStatus");

                    b.Property<int>("FillialId");

                    b.Property<string>("HomeNumber")
                        .IsRequired();

                    b.Property<int>("LegalPersonId");

                    b.Property<string>("Login");

                    b.Property<string>("MaterialsLink");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Password");

                    b.Property<string>("ReceptionPhoneNumber")
                        .IsRequired();

                    b.Property<int>("ServiceStationId");

                    b.Property<int?>("SettlementPeriodId");

                    b.Property<int?>("SettlementTypeId");

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("TechnicalAssistanceCardSeries");

                    b.Property<string>("TypesAndFillingOfServicePackages");

                    b.Property<string>("Website");

                    b.Property<DateTime>("WorkingHours");

                    b.HasKey("Id");

                    b.HasIndex("AccountingResponsiblePersonId");

                    b.HasIndex("CarBrandId");

                    b.HasIndex("CommercialResponsiblePersonId");

                    b.HasIndex("CountryId");

                    b.HasIndex("FillialId");

                    b.HasIndex("LegalPersonId");

                    b.HasIndex("ServiceStationId");

                    b.HasIndex("SettlementPeriodId");

                    b.HasIndex("SettlementTypeId");

                    b.ToTable("DealerCenters");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Enums.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("ServiceStatus");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Enums.SettlementPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SettlementPeriods");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Enums.SettlementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("SettlementTypes");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Fillial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CarBrandId");

                    b.Property<int>("FillialStatus");

                    b.Property<string>("Location")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.ToTable("Fillials");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.LegalPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillingInformation");

                    b.Property<string>("DirectorOrSignatory");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("LegalPersons");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<int?>("ClientInfoId");

                    b.Property<string>("ClientReview");

                    b.Property<int>("CompanyComission");

                    b.Property<DateTime>("DateTimeOrdered");

                    b.Property<string>("Location");

                    b.Property<string>("OperatorComment");

                    b.Property<int>("OrderStatus");

                    b.Property<int>("PaymentMethodId");

                    b.Property<string>("PointOfDeparture");

                    b.Property<string>("PointOfDestination");

                    b.Property<int>("ServiceId");

                    b.Property<int>("ServiceRating");

                    b.Property<DateTime>("ServiceTime");

                    b.Property<int>("ServicesCostForClient");

                    b.Property<int>("ServicesCostForContractor");

                    b.Property<string>("TechnicalAssistanceCardNumber");

                    b.HasKey("Id");

                    b.HasIndex("ClientInfoId");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.ServiceStation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int?>("CountryId");

                    b.Property<string>("HomeNumber");

                    b.Property<string>("Name");

                    b.Property<int>("ServiceStationStatus");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("ServiceStations");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnotherLanguage")
                        .IsRequired();

                    b.Property<int>("CountryId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Login");

                    b.Property<string>("MainLanguage")
                        .IsRequired();

                    b.Property<int>("NumberOfProcessedApplications");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("PhoneSIPNumber")
                        .IsRequired();

                    b.Property<int>("RoleId");

                    b.Property<string>("SecondName")
                        .IsRequired();

                    b.Property<DateTime>("StartWorkDate");

                    b.Property<string>("ThirdName")
                        .IsRequired();

                    b.Property<string>("Timezone");

                    b.Property<int>("UserStatus");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Card", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.ClientInfo", "ClientInfo")
                        .WithMany()
                        .HasForeignKey("ClientInfoId");

                    b.HasOne("DataTier.Entities.Concrete.Enums.Service", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.ClientInfo", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.CarBrand", "CarBrand")
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Contractor", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.Enums.Service", "AnotherServices")
                        .WithMany()
                        .HasForeignKey("AnotherServicesId");

                    b.HasOne("DataTier.Entities.Concrete.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodId");

                    b.HasOne("DataTier.Entities.Concrete.Enums.Service", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesId");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.DealerCenter", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.AccountingResponsiblePerson", "AccountingResponsiblePerson")
                        .WithMany()
                        .HasForeignKey("AccountingResponsiblePersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.CarBrand", "CarBrand")
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.CommercialResponsiblePerson", "CommercialResponsiblePerson")
                        .WithMany()
                        .HasForeignKey("CommercialResponsiblePersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.Fillial", "Fillial")
                        .WithMany()
                        .HasForeignKey("FillialId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.LegalPerson", "LegalPerson")
                        .WithMany()
                        .HasForeignKey("LegalPersonId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.ServiceStation", "ServiceStation")
                        .WithMany()
                        .HasForeignKey("ServiceStationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.Enums.SettlementPeriod", "SettlementPeriod")
                        .WithMany()
                        .HasForeignKey("SettlementPeriodId");

                    b.HasOne("DataTier.Entities.Concrete.Enums.SettlementType", "SettlementType")
                        .WithMany()
                        .HasForeignKey("SettlementTypeId");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Fillial", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.CarBrand", "CarBrand")
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.Order", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.ClientInfo", "ClientInfo")
                        .WithMany()
                        .HasForeignKey("ClientInfoId");

                    b.HasOne("DataTier.Entities.Concrete.PaymentMethod", "PaymentMethod")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.Enums.Service", "Services")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.ServiceStation", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("DataTier.Entities.Concrete.User", b =>
                {
                    b.HasOne("DataTier.Entities.Concrete.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DataTier.Entities.Concrete.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
