using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace sample_app.Migrations
{
    public partial class DeleteSKU : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "stockKeepingUnitProductOptionValues");

            migrationBuilder.DropTable(
                name: "StockKeepingUnitProducts");

            migrationBuilder.AddColumn<long>(
                name: "ProductId",
                table: "Options",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Options_ProductId",
                table: "Options",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Products_ProductId",
                table: "Options",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Products_ProductId",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_ProductId",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Options");

            migrationBuilder.CreateTable(
                name: "StockKeepingUnitProducts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PriceWithTax = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductId1 = table.Column<long>(type: "bigint", nullable: true),
                    StockAmount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockKeepingUnitProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockKeepingUnitProducts_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "stockKeepingUnitProductOptionValues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OptionValueId = table.Column<string>(type: "varchar(255)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductId1 = table.Column<long>(type: "bigint", nullable: true),
                    StockKeepingUnitProductId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockKeepingUnitProductOptionValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stockKeepingUnitProductOptionValues_OptionValues_OptionValue~",
                        column: x => x.OptionValueId,
                        principalTable: "OptionValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_stockKeepingUnitProductOptionValues_Products_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_stockKeepingUnitProductOptionValues_StockKeepingUnitProducts~",
                        column: x => x.StockKeepingUnitProductId,
                        principalTable: "StockKeepingUnitProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_stockKeepingUnitProductOptionValues_OptionValueId",
                table: "stockKeepingUnitProductOptionValues",
                column: "OptionValueId");

            migrationBuilder.CreateIndex(
                name: "IX_stockKeepingUnitProductOptionValues_ProductId1",
                table: "stockKeepingUnitProductOptionValues",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_stockKeepingUnitProductOptionValues_StockKeepingUnitProductId",
                table: "stockKeepingUnitProductOptionValues",
                column: "StockKeepingUnitProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockKeepingUnitProducts_ProductId1",
                table: "StockKeepingUnitProducts",
                column: "ProductId1");
        }
    }
}
