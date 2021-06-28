using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryBookingAPI.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "EResponse",
                columns: table => new
                {
                    ResponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RequestID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EResponse", x => x.ResponseID);
                    table.ForeignKey(
                        name: "FK_EResponse_UserRequest_RequestID",
                        column: x => x.RequestID,
                        principalTable: "UserRequest",
                        principalColumn: "RequestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EResponse_RequestID",
                table: "EResponse",
                column: "RequestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EResponse");

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    ResponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RequestID = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.ResponseID);
                    table.ForeignKey(
                        name: "FK_Response_UserRequest_RequestID",
                        column: x => x.RequestID,
                        principalTable: "UserRequest",
                        principalColumn: "RequestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Response_RequestID",
                table: "Response",
                column: "RequestID");
        }
    }
}
