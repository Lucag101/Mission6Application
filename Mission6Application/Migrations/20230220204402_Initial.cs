using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6Application.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_responses_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Sci-Fi/ Fantasy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Children" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Thriller" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Action" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 6, "Suspense" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 7, "Comedy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 8, "Romance" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 9, "Holiday" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 10, "Animated" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "CategoryId", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Not sure", true, "Sarah Mackinley", "Good Movie. A Little Old", "PG", "Harry Potter and the Sorcerer's stone", 2004 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "CategoryId", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 1, "I feel like I should know, but I don't", true, "I would never lend this to anybody", "", "PG-13", "Lord Of the Rings", 2006 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "CategoryId", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 6, "Again,Not sure", false, "", "Kind of sad but good", "PG-13", "The Prestige", 2008 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryId",
                table: "responses",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
