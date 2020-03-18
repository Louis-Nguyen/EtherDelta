using Microsoft.EntityFrameworkCore.Migrations;

namespace EtherDeltaAPI.Migrations
{
    public partial class InitialForkDelta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Info = table.Column<string>(nullable: true),
                    Keyprivate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Address);
                });

            migrationBuilder.CreateTable(
                name: "Token",
                columns: table => new
                {
                    Address = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Decimal = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Token", x => x.Address);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Token");
        }
    }
}
