using Microsoft.EntityFrameworkCore.Migrations;

namespace POS.EF.Migrations
{
    public partial class MD090012021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartyTables",
                columns: table => new
                {
                    PartyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreditLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AccountNo = table.Column<int>(type: "int", nullable: false),
                    PartyTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyTables", x => x.PartyID);
                });

            migrationBuilder.CreateTable(
                name: "PartyTypeTables",
                columns: table => new
                {
                    PartyTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartyType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyTypeTables", x => x.PartyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PartyAddressTables",
                columns: table => new
                {
                    PartyAddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartyAddressTables", x => x.PartyAddressID);
                    table.ForeignKey(
                        name: "FK_PartyAddressTables_PartyTables_PartyID",
                        column: x => x.PartyID,
                        principalTable: "PartyTables",
                        principalColumn: "PartyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartyAddressTables_PartyID",
                table: "PartyAddressTables",
                column: "PartyID",
                unique: true,
                filter: "[PartyID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartyAddressTables");

            migrationBuilder.DropTable(
                name: "PartyTypeTables");

            migrationBuilder.DropTable(
                name: "PartyTables");
        }
    }
}
