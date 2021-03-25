using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConfigrationId",
                table: "Phone",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RepairId",
                table: "Configration",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phone_ConfigrationId",
                table: "Phone",
                column: "ConfigrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Configration_RepairId",
                table: "Configration",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Configration_Repair_RepairId",
                table: "Configration",
                column: "RepairId",
                principalTable: "Repair",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Configration_ConfigrationId",
                table: "Phone",
                column: "ConfigrationId",
                principalTable: "Configration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configration_Repair_RepairId",
                table: "Configration");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Configration_ConfigrationId",
                table: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Phone_ConfigrationId",
                table: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Configration_RepairId",
                table: "Configration");

            migrationBuilder.DropColumn(
                name: "ConfigrationId",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "RepairId",
                table: "Configration");
        }
    }
}
