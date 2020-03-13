using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataTier.Migrations
{
    public partial class Db_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    ServiceStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DealerCenters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false),
                    HasFillialId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    HomeNumber = table.Column<string>(nullable: false),
                    CarBrandId = table.Column<int>(nullable: false),
                    DealerCenterStatus = table.Column<int>(nullable: false),
                    Website = table.Column<string>(nullable: true),
                    ReceptionPhoneNumber = table.Column<string>(nullable: false),
                    WorkingHours = table.Column<DateTime>(nullable: false),
                    BillingInformation = table.Column<string>(nullable: true),
                    LegalPersonId = table.Column<int>(nullable: false),
                    DateTimeOfContract = table.Column<DateTime>(nullable: false),
                    SettlementPeriodId = table.Column<int>(nullable: true),
                    SettlementTypeId = table.Column<int>(nullable: true),
                    CommercialResponsiblePersonId = table.Column<int>(nullable: false),
                    AccountingResponsiblePersonId = table.Column<int>(nullable: false),
                    TechnicalAssistanceCardSeries = table.Column<string>(nullable: true),
                    TypesAndFillingOfServicePackages = table.Column<string>(nullable: true),
                    MaterialsLink = table.Column<string>(nullable: true),
                    AnotherProducts = table.Column<string>(nullable: true),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    CooperatorName = table.Column<string>(nullable: true),
                    CooperatorPhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealerCenters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountingResponsiblePersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountingResponsiblePersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountingResponsiblePersons_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommercialResponsiblePersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommercialResponsiblePersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommercialResponsiblePersons_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HasFillials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HasFillials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HasFillials_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LegalPersons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    BillingInformation = table.Column<string>(nullable: true),
                    DirectorOrSignatory = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalPersons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalPersons_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SettlementPeriods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettlementPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettlementPeriods_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SettlementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettlementTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SettlementTypes_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClientInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClientFristName = table.Column<string>(nullable: false),
                    ClientSecondName = table.Column<string>(nullable: false),
                    ClientThirdName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    CarBrandId = table.Column<int>(nullable: false),
                    StateNumber = table.Column<string>(nullable: false),
                    Region = table.Column<string>(nullable: false),
                    CardId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CardNumber = table.Column<int>(nullable: false),
                    CardCost = table.Column<int>(nullable: false),
                    ClientInfoId = table.Column<int>(nullable: true),
                    Duration = table.Column<DateTime>(nullable: false),
                    VIN = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    ServicesId = table.Column<int>(nullable: false),
                    SellerFirstName = table.Column<string>(nullable: false),
                    SellerSecondName = table.Column<string>(nullable: false),
                    SellerThirdName = table.Column<string>(nullable: false),
                    NumberOfContractWithKadet = table.Column<int>(nullable: false),
                    DateOfContractWithKadet = table.Column<DateTime>(nullable: false),
                    NumberOfContractWithClient = table.Column<int>(nullable: false),
                    DateOfContractWithClient = table.Column<DateTime>(nullable: false),
                    ActionStartDate = table.Column<DateTime>(nullable: false),
                    ManagerFirstName = table.Column<string>(nullable: false),
                    ManagerSecondName = table.Column<string>(nullable: false),
                    ManagerThirdName = table.Column<string>(nullable: false),
                    CardStatus = table.Column<int>(nullable: false),
                    DeactivationDate = table.Column<DateTime>(nullable: false),
                    CardAppeal = table.Column<string>(nullable: true),
                    EmployerFirstName = table.Column<string>(nullable: false),
                    EmployerSecondName = table.Column<string>(nullable: false),
                    EmployerThirdName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_ClientInfos_ClientInfoId",
                        column: x => x.ClientInfoId,
                        principalTable: "ClientInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cards_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fillials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    DealerCenterId = table.Column<int>(nullable: true),
                    CarBrandId = table.Column<int>(nullable: true),
                    FillialStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fillials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fillials_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    ClientInfoId = table.Column<int>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true),
                    FillialId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarBrands_ClientInfos_ClientInfoId",
                        column: x => x.ClientInfoId,
                        principalTable: "ClientInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarBrands_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CarBrands_Fillials_FillialId",
                        column: x => x.FillialId,
                        principalTable: "Fillials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    DateTimeOrdered = table.Column<DateTime>(nullable: false),
                    ClientInfoId = table.Column<int>(nullable: false),
                    TechnicalAssistanceCardNumber = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    PointOfDeparture = table.Column<string>(nullable: true),
                    PointOfDestination = table.Column<string>(nullable: true),
                    ServicesId = table.Column<int>(nullable: false),
                    ServicesCostForClient = table.Column<int>(nullable: false),
                    ServicesCostForContractor = table.Column<int>(nullable: false),
                    CompanyComission = table.Column<int>(nullable: false),
                    ContractorId = table.Column<int>(nullable: false),
                    ServiceTime = table.Column<DateTime>(nullable: false),
                    OrderStatus = table.Column<int>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: true),
                    ServiceRating = table.Column<int>(nullable: false),
                    OperatorComment = table.Column<string>(nullable: true),
                    ClientReview = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_ClientInfos_ClientInfoId",
                        column: x => x.ClientInfoId,
                        principalTable: "ClientInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    ContractorId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentMethods_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contractors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    ThirdName = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    ContractorStatus = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    ServicesId = table.Column<int>(nullable: true),
                    Cities = table.Column<string>(nullable: true),
                    PriceList = table.Column<string>(nullable: false),
                    PaymentMethodId = table.Column<int>(nullable: false),
                    AnotherPhoneNumber = table.Column<string>(nullable: true),
                    WorkTime = table.Column<string>(nullable: true),
                    NumberOfTrucks = table.Column<int>(nullable: false),
                    CarryingCapacityOfTrucks = table.Column<int>(nullable: false),
                    PlatformLenght = table.Column<int>(nullable: false),
                    YearOfManufactureOfTrucks = table.Column<string>(nullable: true),
                    TrolleysStatus = table.Column<int>(nullable: false),
                    CraneManipulatorStatus = table.Column<int>(nullable: false),
                    AnotherServicesId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contractors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contractors_Services_AnotherServicesId",
                        column: x => x.AnotherServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractors_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contractors_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contractors_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ServiceStations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    HomeNumber = table.Column<string>(nullable: true),
                    ServiceStationStatus = table.Column<int>(nullable: false),
                    DealerCenterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceStations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServiceStations_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    ThirdName = table.Column<string>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    StartWorkDate = table.Column<DateTime>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    MainLanguage = table.Column<string>(nullable: false),
                    AnotherLanguage = table.Column<string>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    UserStatus = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Timezone = table.Column<string>(nullable: true),
                    PhoneSIPNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    DealerCenterId = table.Column<int>(nullable: true),
                    ServiceStationId = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_DealerCenters_DealerCenterId",
                        column: x => x.DealerCenterId,
                        principalTable: "DealerCenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_ServiceStations_ServiceStationId",
                        column: x => x.ServiceStationId,
                        principalTable: "ServiceStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountingResponsiblePersons_DealerCenterId",
                table: "AccountingResponsiblePersons",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_CarBrands_ClientInfoId",
                table: "CarBrands",
                column: "ClientInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarBrands_DealerCenterId",
                table: "CarBrands",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_CarBrands_FillialId",
                table: "CarBrands",
                column: "FillialId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ClientInfoId",
                table: "Cards",
                column: "ClientInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_ServicesId",
                table: "Cards",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInfos_CarBrandId",
                table: "ClientInfos",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInfos_CardId",
                table: "ClientInfos",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInfos_OrderId",
                table: "ClientInfos",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_CommercialResponsiblePersons_DealerCenterId",
                table: "CommercialResponsiblePersons",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_AnotherServicesId",
                table: "Contractors",
                column: "AnotherServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_OrderId",
                table: "Contractors",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_PaymentMethodId",
                table: "Contractors",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Contractors_ServicesId",
                table: "Contractors",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DealerCenterId",
                table: "Countries",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ServiceStationId",
                table: "Countries",
                column: "ServiceStationId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_UserId",
                table: "Countries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_AccountingResponsiblePersonId",
                table: "DealerCenters",
                column: "AccountingResponsiblePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_CarBrandId",
                table: "DealerCenters",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_CommercialResponsiblePersonId",
                table: "DealerCenters",
                column: "CommercialResponsiblePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_CountryId",
                table: "DealerCenters",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_HasFillialId",
                table: "DealerCenters",
                column: "HasFillialId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_LegalPersonId",
                table: "DealerCenters",
                column: "LegalPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_SettlementPeriodId",
                table: "DealerCenters",
                column: "SettlementPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_SettlementTypeId",
                table: "DealerCenters",
                column: "SettlementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Fillials_CarBrandId",
                table: "Fillials",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Fillials_DealerCenterId",
                table: "Fillials",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_HasFillials_DealerCenterId",
                table: "HasFillials",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalPersons_DealerCenterId",
                table: "LegalPersons",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientInfoId",
                table: "Orders",
                column: "ClientInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ContractorId",
                table: "Orders",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ServicesId",
                table: "Orders",
                column: "ServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_ContractorId",
                table: "PaymentMethods",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethods_OrderId",
                table: "PaymentMethods",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UserId",
                table: "Roles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStations_CountryId",
                table: "ServiceStations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStations_DealerCenterId",
                table: "ServiceStations",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SettlementPeriods_DealerCenterId",
                table: "SettlementPeriods",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SettlementTypes_DealerCenterId",
                table: "SettlementTypes",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_CarBrands_CarBrandId",
                table: "DealerCenters",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_AccountingResponsiblePersons_AccountingRespon~",
                table: "DealerCenters",
                column: "AccountingResponsiblePersonId",
                principalTable: "AccountingResponsiblePersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_CommercialResponsiblePersons_CommercialRespon~",
                table: "DealerCenters",
                column: "CommercialResponsiblePersonId",
                principalTable: "CommercialResponsiblePersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_Countries_CountryId",
                table: "DealerCenters",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_HasFillials_HasFillialId",
                table: "DealerCenters",
                column: "HasFillialId",
                principalTable: "HasFillials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_LegalPersons_LegalPersonId",
                table: "DealerCenters",
                column: "LegalPersonId",
                principalTable: "LegalPersons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_SettlementPeriods_SettlementPeriodId",
                table: "DealerCenters",
                column: "SettlementPeriodId",
                principalTable: "SettlementPeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_SettlementTypes_SettlementTypeId",
                table: "DealerCenters",
                column: "SettlementTypeId",
                principalTable: "SettlementTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientInfos_CarBrands_CarBrandId",
                table: "ClientInfos",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientInfos_Cards_CardId",
                table: "ClientInfos",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClientInfos_Orders_OrderId",
                table: "ClientInfos",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Fillials_CarBrands_CarBrandId",
                table: "Fillials",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentMethods_PaymentMethodId",
                table: "Orders",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Contractors_ContractorId",
                table: "Orders",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Contractors_ContractorId",
                table: "PaymentMethods",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceStations_Countries_CountryId",
                table: "ServiceStations",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountingResponsiblePersons_DealerCenters_DealerCenterId",
                table: "AccountingResponsiblePersons");

            migrationBuilder.DropForeignKey(
                name: "FK_CarBrands_DealerCenters_DealerCenterId",
                table: "CarBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_CommercialResponsiblePersons_DealerCenters_DealerCenterId",
                table: "CommercialResponsiblePersons");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_DealerCenters_DealerCenterId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Fillials_DealerCenters_DealerCenterId",
                table: "Fillials");

            migrationBuilder.DropForeignKey(
                name: "FK_HasFillials_DealerCenters_DealerCenterId",
                table: "HasFillials");

            migrationBuilder.DropForeignKey(
                name: "FK_LegalPersons_DealerCenters_DealerCenterId",
                table: "LegalPersons");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceStations_DealerCenters_DealerCenterId",
                table: "ServiceStations");

            migrationBuilder.DropForeignKey(
                name: "FK_SettlementPeriods_DealerCenters_DealerCenterId",
                table: "SettlementPeriods");

            migrationBuilder.DropForeignKey(
                name: "FK_SettlementTypes_DealerCenters_DealerCenterId",
                table: "SettlementTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_CarBrands_ClientInfos_ClientInfoId",
                table: "CarBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_Cards_ClientInfos_ClientInfoId",
                table: "Cards");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ClientInfos_ClientInfoId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_CarBrands_Fillials_FillialId",
                table: "CarBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Services_AnotherServicesId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Services_ServicesId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Services_ServicesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_Orders_OrderId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Orders_OrderId",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_Contractors_PaymentMethods_PaymentMethodId",
                table: "Contractors");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_ServiceStations_ServiceStationId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Users_UserId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_UserId",
                table: "Roles");

            migrationBuilder.DropTable(
                name: "DealerCenters");

            migrationBuilder.DropTable(
                name: "AccountingResponsiblePersons");

            migrationBuilder.DropTable(
                name: "CommercialResponsiblePersons");

            migrationBuilder.DropTable(
                name: "HasFillials");

            migrationBuilder.DropTable(
                name: "LegalPersons");

            migrationBuilder.DropTable(
                name: "SettlementPeriods");

            migrationBuilder.DropTable(
                name: "SettlementTypes");

            migrationBuilder.DropTable(
                name: "ClientInfos");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Fillials");

            migrationBuilder.DropTable(
                name: "CarBrands");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Contractors");

            migrationBuilder.DropTable(
                name: "ServiceStations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
