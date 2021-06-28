using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryBookingAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EResponse_UserRequest_RequestID",
                table: "EResponse");

            migrationBuilder.DropIndex(
                name: "IX_EResponse_RequestID",
                table: "EResponse");

            migrationBuilder.AlterColumn<int>(
                name: "RequestID",
                table: "EResponse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RequestID",
                table: "EResponse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_EResponse_RequestID",
                table: "EResponse",
                column: "RequestID");

            migrationBuilder.AddForeignKey(
                name: "FK_EResponse_UserRequest_RequestID",
                table: "EResponse",
                column: "RequestID",
                principalTable: "UserRequest",
                principalColumn: "RequestID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
