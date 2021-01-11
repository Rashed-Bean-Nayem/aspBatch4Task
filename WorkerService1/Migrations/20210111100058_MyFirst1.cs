using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkerService1.Migrations
{
    public partial class MyFirst1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cid = table.Column<string>(nullable: true),
                    TradingCODE = table.Column<string>(nullable: true),
                    Ltp = table.Column<string>(nullable: true),
                    High = table.Column<string>(nullable: true),
                    Low = table.Column<string>(nullable: true),
                    Closep = table.Column<string>(nullable: true),
                    Ycp = table.Column<string>(nullable: true),
                    Change = table.Column<string>(nullable: true),
                    Trade = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Volume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_company", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "company");
        }
    }
}
