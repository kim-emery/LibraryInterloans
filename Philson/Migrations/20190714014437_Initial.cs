using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Philson.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuppliedInterloan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    StaffRequesting = table.Column<string>(nullable: true),
                    ILLRequestNo = table.Column<string>(nullable: true),
                    CallNo = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    ItemType = table.Column<string>(nullable: true),
                    Handler = table.Column<string>(nullable: true),
                    ReturnDate = table.Column<DateTime>(nullable: false),
                    FurtherDetails = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliedInterloan", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuppliedInterloan");
        }
    }
}
