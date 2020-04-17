using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitmentSystemAPI.Migrations
{
    public partial class newFieldsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21d24935-996f-4673-9906-fe5f87d871cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c58a6a4f-d9e6-4a66-bb84-8a8cf6bd7e3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb6f260a-c0ed-43af-a9b3-bac807074990");

            migrationBuilder.AddColumn<float>(
                name: "QualityRating",
                table: "Labourers",
                unicode: false,
                maxLength: 450,
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SafetyRating",
                table: "Labourers",
                unicode: false,
                maxLength: 450,
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1096f9d5-54b8-4b6e-bfa0-aef4a68bb73c", "2ccb9818-480a-498a-8ff4-fb4d54139aa2", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "30d5a244-2fe2-4af8-92d6-b31a461dd38b", "58157368-675f-4fae-a706-715f2a4a3862", "Company", "COMPANY" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dcee60cc-4114-4149-9276-95e023690181", "6a161205-0049-4943-866e-6592c070d28e", "Labourer", "LABOURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1096f9d5-54b8-4b6e-bfa0-aef4a68bb73c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30d5a244-2fe2-4af8-92d6-b31a461dd38b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcee60cc-4114-4149-9276-95e023690181");

            migrationBuilder.DropColumn(
                name: "QualityRating",
                table: "Labourers");

            migrationBuilder.DropColumn(
                name: "SafetyRating",
                table: "Labourers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eb6f260a-c0ed-43af-a9b3-bac807074990", "76fcfcb6-959d-4c24-b3a8-cd4ebc234c1c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c58a6a4f-d9e6-4a66-bb84-8a8cf6bd7e3a", "176de32a-fabc-46ec-9f73-32a63cfa3859", "Company", "COMPANY" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21d24935-996f-4673-9906-fe5f87d871cc", "8adef531-9c3b-4163-9de1-35d4d08f3f68", "Labourer", "LABOURER" });
        }
    }
}
