using Microsoft.EntityFrameworkCore.Migrations;

namespace CreditCardApplication.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Card_ApplicationCardResultCardId",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.RenameTable(
                name: "Card",
                newName: "Cards");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "CardId");

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "APR", "PromotionalMessage", "Type" },
                values: new object[] { 1, 10m, "If you get a card you will also get a free online banking for an year", 0 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "CardId", "APR", "PromotionalMessage", "Type" },
                values: new object[] { 2, 20m, "If you order a credit card you can take part in a lottary for five ski vacations in Zillertal.", 1 });

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Cards_ApplicationCardResultCardId",
                table: "Applications",
                column: "ApplicationCardResultCardId",
                principalTable: "Cards",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Cards_ApplicationCardResultCardId",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "CardId",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Card");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Card_ApplicationCardResultCardId",
                table: "Applications",
                column: "ApplicationCardResultCardId",
                principalTable: "Card",
                principalColumn: "CardId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
