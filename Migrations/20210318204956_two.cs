using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Configration_ConfigrationId1",
                table: "Repair");

            migrationBuilder.DropIndex(
                name: "IX_Repair_ConfigrationId1",
                table: "Repair");

            migrationBuilder.DropColumn(
                name: "ConfigrationId1",
                table: "Repair");

            migrationBuilder.AlterColumn<int>(
                name: "ConfigrationId",
                table: "Repair",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repair_ConfigrationId",
                table: "Repair",
                column: "ConfigrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Repair_Configration_ConfigrationId",
                table: "Repair",
                column: "ConfigrationId",
                principalTable: "Configration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Repair_Configration_ConfigrationId",
                table: "Repair");

            migrationBuilder.DropIndex(
                name: "IX_Repair_ConfigrationId",
                table: "Repair");

            migrationBuilder.AlterColumn<string>(
                name: "ConfigrationId",
                table: "Repair",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ConfigrationId1",
                table: "Repair",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Repair_ConfigrationId1",
                table: "Repair",
                column: "ConfigrationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Repair_Configration_ConfigrationId1",
                table: "Repair",
                column: "ConfigrationId1",
                principalTable: "Configration",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
