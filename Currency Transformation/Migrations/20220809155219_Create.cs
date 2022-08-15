using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Currency_Transformation.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    swiftcode = table.Column<string>(type: "nvarchar(15)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
