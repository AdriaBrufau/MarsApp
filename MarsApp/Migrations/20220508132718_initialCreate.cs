using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarsApp.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    MapID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X_Axis = table.Column<int>(type: "int", nullable: false),
                    Y_Axis = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.MapID);
                });

            migrationBuilder.CreateTable(
                name: "Rovers",
                columns: table => new
                {
                    RoverID = table.Column<int>(type: "int", nullable: false),
                    X_Position = table.Column<int>(type: "int", nullable: false),
                    Y_Position = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Or_Grade = table.Column<int>(type: "int", nullable: false),
                    Compass = table.Column<int>(type: "int", nullable: false),
                    IsAlive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rovers", x => x.RoverID);
                });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "MapID", "X_Axis", "Y_Axis" },
                values: new object[] { 1, 3, 4 });

            migrationBuilder.InsertData(
                table: "Rovers",
                columns: new[] { "RoverID", "Compass", "IsAlive", "Or_Grade", "Order", "X_Position", "Y_Position" },
                values: new object[] { 1, 0, true, 0, "", 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Rovers");
        }
    }
}
