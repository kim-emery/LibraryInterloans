using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Philson.Migrations
{
    public partial class ReceivedInterloans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReceivedInterloan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookTitle = table.Column<string>(nullable: true),
                    ReceivedDate = table.Column<DateTime>(nullable: false),
                    ILLNo = table.Column<string>(nullable: true),
                    PatronName = table.Column<string>(nullable: true),
                    Barcode = table.Column<string>(nullable: true),
                    OriginalDueDate = table.Column<DateTime>(nullable: false),
                    ReceivedBy = table.Column<string>(nullable: true),
                    DateOfReturn = table.Column<DateTime>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceivedInterloan", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReceivedInterloan");
        }
    }
}
