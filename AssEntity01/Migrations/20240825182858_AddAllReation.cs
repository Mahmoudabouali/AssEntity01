using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssEntity01.Migrations
{
    /// <inheritdoc />
    public partial class AddAllReation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmpQualifications",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cont_Person",
                table: "AirLine",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_AirLineId",
                table: "Transaction",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpQualifications_EmployeeId",
                table: "EmpQualifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_AirLineId",
                table: "Employee",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_AirCrafts_AirLineId",
                table: "AirCrafts",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_AirCraftRoute_RouteId",
                table: "AirCraftRoute",
                column: "RouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoute_AirCrafts_AirCraftId",
                table: "AirCraftRoute",
                column: "AirCraftId",
                principalTable: "AirCrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirCraftRoute_Routes_RouteId",
                table: "AirCraftRoute",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AirCrafts_AirLine_AirLineId",
                table: "AirCrafts",
                column: "AirLineId",
                principalTable: "AirLine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AirLinePhones_AirLine_AirLineId",
                table: "AirLinePhones",
                column: "AirLineId",
                principalTable: "AirLine",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_AirLine_AirLineId",
                table: "Employee",
                column: "AirLineId",
                principalTable: "AirLine",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmpQualifications_Employee_EmployeeId",
                table: "EmpQualifications",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_AirLine_AirLineId",
                table: "Transaction",
                column: "AirLineId",
                principalTable: "AirLine",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoute_AirCrafts_AirCraftId",
                table: "AirCraftRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_AirCraftRoute_Routes_RouteId",
                table: "AirCraftRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_AirCrafts_AirLine_AirLineId",
                table: "AirCrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_AirLinePhones_AirLine_AirLineId",
                table: "AirLinePhones");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_AirLine_AirLineId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_EmpQualifications_Employee_EmployeeId",
                table: "EmpQualifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_AirLine_AirLineId",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_AirLineId",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_EmpQualifications_EmployeeId",
                table: "EmpQualifications");

            migrationBuilder.DropIndex(
                name: "IX_Employee_AirLineId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_AirCrafts_AirLineId",
                table: "AirCrafts");

            migrationBuilder.DropIndex(
                name: "IX_AirCraftRoute_RouteId",
                table: "AirCraftRoute");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmpQualifications");

            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Employee",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Cont_Person",
                table: "AirLine",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
