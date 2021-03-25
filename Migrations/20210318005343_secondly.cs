using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Migrations
{
    public partial class secondly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configration_Phone_PhoneId1",
                table: "Configration");

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
                name: "IX_Configration_PhoneId1",
                table: "Configration");

            migrationBuilder.DropIndex(
                name: "IX_Configration_RepairId",
                table: "Configration");

            migrationBuilder.DropColumn(
                name: "ConfigrationId",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "PhoneId1",
                table: "Configration");

            migrationBuilder.DropColumn(
                name: "RepairId",
                table: "Configration");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneId",
                table: "Configration",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Configration_PhoneId",
                table: "Configration",
                column: "PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Configration_Phone_PhoneId",
                table: "Configration",
                column: "PhoneId",
                principalTable: "Phone",
                principalColumn: "PhoneId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configration_Phone_PhoneId",
                table: "Configration");

            migrationBuilder.DropIndex(
                name: "IX_Configration_PhoneId",
                table: "Configration");

            migrationBuilder.AddColumn<int>(
                name: "ConfigrationId",
                table: "Phone",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneId",
                table: "Configration",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PhoneId1",
                table: "Configration",
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
                name: "IX_Configration_PhoneId1",
                table: "Configration",
                column: "PhoneId1");

            migrationBuilder.CreateIndex(
                name: "IX_Configration_RepairId",
                table: "Configration",
                column: "RepairId");

            migrationBuilder.AddForeignKey(
                name: "FK_Configration_Phone_PhoneId1",
                table: "Configration",
                column: "PhoneId1",
                principalTable: "Phone",
                principalColumn: "PhoneId",
                onDelete: ReferentialAction.Restrict);

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
    }
}
