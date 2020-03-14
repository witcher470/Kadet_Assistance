using Microsoft.EntityFrameworkCore.Migrations;

namespace DataTier.Migrations
{
    public partial class UpdateLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountingResponsiblePersons_DealerCenters_DealerCenterId",
                table: "AccountingResponsiblePersons");

            migrationBuilder.DropForeignKey(
                name: "FK_CarBrands_ClientInfos_ClientInfoId",
                table: "CarBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_CarBrands_DealerCenters_DealerCenterId",
                table: "CarBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_CarBrands_Fillials_FillialId",
                table: "CarBrands");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientInfos_Cards_CardId",
                table: "ClientInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_ClientInfos_Orders_OrderId",
                table: "ClientInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_CommercialResponsiblePersons_DealerCenters_DealerCenterId",
                table: "CommercialResponsiblePersons");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_DealerCenters_DealerCenterId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_ServiceStations_ServiceStationId",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Fillials_CarBrands_CarBrandId",
                table: "Fillials");

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
                name: "FK_Orders_ClientInfos_ClientInfoId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Contractors_ContractorId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Services_ServicesId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceStations_DealerCenters_DealerCenterId",
                table: "ServiceStations");

            migrationBuilder.DropForeignKey(
                name: "FK_SettlementPeriods_DealerCenters_DealerCenterId",
                table: "SettlementPeriods");

            migrationBuilder.DropForeignKey(
                name: "FK_SettlementTypes_DealerCenters_DealerCenterId",
                table: "SettlementTypes");

            migrationBuilder.DropIndex(
                name: "IX_SettlementTypes_DealerCenterId",
                table: "SettlementTypes");

            migrationBuilder.DropIndex(
                name: "IX_SettlementPeriods_DealerCenterId",
                table: "SettlementPeriods");

            migrationBuilder.DropIndex(
                name: "IX_ServiceStations_DealerCenterId",
                table: "ServiceStations");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ContractorId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_LegalPersons_DealerCenterId",
                table: "LegalPersons");

            migrationBuilder.DropIndex(
                name: "IX_HasFillials_DealerCenterId",
                table: "HasFillials");

            migrationBuilder.DropIndex(
                name: "IX_Fillials_DealerCenterId",
                table: "Fillials");

            migrationBuilder.DropIndex(
                name: "IX_Countries_DealerCenterId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Countries_ServiceStationId",
                table: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_CommercialResponsiblePersons_DealerCenterId",
                table: "CommercialResponsiblePersons");

            migrationBuilder.DropIndex(
                name: "IX_ClientInfos_CardId",
                table: "ClientInfos");

            migrationBuilder.DropIndex(
                name: "IX_ClientInfos_OrderId",
                table: "ClientInfos");

            migrationBuilder.DropIndex(
                name: "IX_CarBrands_ClientInfoId",
                table: "CarBrands");

            migrationBuilder.DropIndex(
                name: "IX_CarBrands_DealerCenterId",
                table: "CarBrands");

            migrationBuilder.DropIndex(
                name: "IX_CarBrands_FillialId",
                table: "CarBrands");

            migrationBuilder.DropIndex(
                name: "IX_AccountingResponsiblePersons_DealerCenterId",
                table: "AccountingResponsiblePersons");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "SettlementTypes");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "SettlementPeriods");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "ServiceStations");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "LegalPersons");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "HasFillials");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "Fillials");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ServiceStationId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "CommercialResponsiblePersons");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "ClientInfos");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ClientInfos");

            migrationBuilder.DropColumn(
                name: "ClientInfoId",
                table: "CarBrands");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "CarBrands");

            migrationBuilder.DropColumn(
                name: "FillialId",
                table: "CarBrands");

            migrationBuilder.DropColumn(
                name: "DealerCenterId",
                table: "AccountingResponsiblePersons");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "Orders",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "ContractorId",
                table: "Orders",
                newName: "ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ServicesId",
                table: "Orders",
                newName: "IX_Orders_ServiceId");

            migrationBuilder.AlterColumn<int>(
                name: "ClientInfoId",
                table: "Orders",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CarBrandId",
                table: "Fillials",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FillialId",
                table: "DealerCenters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStationId",
                table: "DealerCenters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Cards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_FillialId",
                table: "DealerCenters",
                column: "FillialId");

            migrationBuilder.CreateIndex(
                name: "IX_DealerCenters_ServiceStationId",
                table: "DealerCenters",
                column: "ServiceStationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_Fillials_FillialId",
                table: "DealerCenters",
                column: "FillialId",
                principalTable: "Fillials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DealerCenters_ServiceStations_ServiceStationId",
                table: "DealerCenters",
                column: "ServiceStationId",
                principalTable: "ServiceStations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Fillials_CarBrands_CarBrandId",
                table: "Fillials",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ClientInfos_ClientInfoId",
                table: "Orders",
                column: "ClientInfoId",
                principalTable: "ClientInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Services_ServiceId",
                table: "Orders",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DealerCenters_Fillials_FillialId",
                table: "DealerCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_DealerCenters_ServiceStations_ServiceStationId",
                table: "DealerCenters");

            migrationBuilder.DropForeignKey(
                name: "FK_Fillials_CarBrands_CarBrandId",
                table: "Fillials");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_ClientInfos_ClientInfoId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Services_ServiceId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_DealerCenters_FillialId",
                table: "DealerCenters");

            migrationBuilder.DropIndex(
                name: "IX_DealerCenters_ServiceStationId",
                table: "DealerCenters");

            migrationBuilder.DropColumn(
                name: "FillialId",
                table: "DealerCenters");

            migrationBuilder.DropColumn(
                name: "ServiceStationId",
                table: "DealerCenters");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Orders",
                newName: "ServicesId");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Orders",
                newName: "ContractorId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ServiceId",
                table: "Orders",
                newName: "IX_Orders_ServicesId");

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "SettlementTypes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "SettlementPeriods",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "ServiceStations",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientInfoId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "LegalPersons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "HasFillials",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CarBrandId",
                table: "Fillials",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "Fillials",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceStationId",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "CommercialResponsiblePersons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "ClientInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ClientInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientInfoId",
                table: "CarBrands",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "CarBrands",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FillialId",
                table: "CarBrands",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DealerCenterId",
                table: "AccountingResponsiblePersons",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SettlementTypes_DealerCenterId",
                table: "SettlementTypes",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_SettlementPeriods_DealerCenterId",
                table: "SettlementPeriods",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceStations_DealerCenterId",
                table: "ServiceStations",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ContractorId",
                table: "Orders",
                column: "ContractorId");

            migrationBuilder.CreateIndex(
                name: "IX_LegalPersons_DealerCenterId",
                table: "LegalPersons",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_HasFillials_DealerCenterId",
                table: "HasFillials",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Fillials_DealerCenterId",
                table: "Fillials",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DealerCenterId",
                table: "Countries",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ServiceStationId",
                table: "Countries",
                column: "ServiceStationId");

            migrationBuilder.CreateIndex(
                name: "IX_CommercialResponsiblePersons_DealerCenterId",
                table: "CommercialResponsiblePersons",
                column: "DealerCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInfos_CardId",
                table: "ClientInfos",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientInfos_OrderId",
                table: "ClientInfos",
                column: "OrderId");

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
                name: "IX_AccountingResponsiblePersons_DealerCenterId",
                table: "AccountingResponsiblePersons",
                column: "DealerCenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountingResponsiblePersons_DealerCenters_DealerCenterId",
                table: "AccountingResponsiblePersons",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarBrands_ClientInfos_ClientInfoId",
                table: "CarBrands",
                column: "ClientInfoId",
                principalTable: "ClientInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarBrands_DealerCenters_DealerCenterId",
                table: "CarBrands",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarBrands_Fillials_FillialId",
                table: "CarBrands",
                column: "FillialId",
                principalTable: "Fillials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_CommercialResponsiblePersons_DealerCenters_DealerCenterId",
                table: "CommercialResponsiblePersons",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_DealerCenters_DealerCenterId",
                table: "Countries",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_ServiceStations_ServiceStationId",
                table: "Countries",
                column: "ServiceStationId",
                principalTable: "ServiceStations",
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
                name: "FK_Fillials_DealerCenters_DealerCenterId",
                table: "Fillials",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HasFillials_DealerCenters_DealerCenterId",
                table: "HasFillials",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LegalPersons_DealerCenters_DealerCenterId",
                table: "LegalPersons",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_ClientInfos_ClientInfoId",
                table: "Orders",
                column: "ClientInfoId",
                principalTable: "ClientInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Contractors_ContractorId",
                table: "Orders",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Services_ServicesId",
                table: "Orders",
                column: "ServicesId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceStations_DealerCenters_DealerCenterId",
                table: "ServiceStations",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SettlementPeriods_DealerCenters_DealerCenterId",
                table: "SettlementPeriods",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SettlementTypes_DealerCenters_DealerCenterId",
                table: "SettlementTypes",
                column: "DealerCenterId",
                principalTable: "DealerCenters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
