using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewTable.Migrations
{
    /// <inheritdoc />
    public partial class Initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    TransactionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    PaidTo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PaidFrom = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Account = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    GBP = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EUR = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    USD = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    VAT = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Fees = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    InvDate = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastReceived = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ReceiptDate = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.TransactionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");
        }
    }
}
