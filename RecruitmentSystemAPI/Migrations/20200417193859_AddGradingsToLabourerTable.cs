using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitmentSystemAPI.Migrations
{
    public partial class AddGradingsToLabourerTable : Migration
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

            migrationBuilder.AddColumn<decimal>(
                name: "QualityRating",
                table: "Labourers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SatefyRating",
                table: "Labourers",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb1acbc4-6abc-407a-af55-a9c2c3f0e17a", "e4205822-41fd-42cf-9e80-08589f70318d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a25a13e6-c820-4c40-ae34-9df7f8e23c51", "d656fcbb-b171-4749-9aa7-04954ff0ea0d", "Company", "COMPANY" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c26f8bd-bf3b-4550-ad04-43b093c360d9", "d58fd1b8-ee80-4f4a-b985-2ba118227227", "Labourer", "LABOURER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c26f8bd-bf3b-4550-ad04-43b093c360d9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a25a13e6-c820-4c40-ae34-9df7f8e23c51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb1acbc4-6abc-407a-af55-a9c2c3f0e17a");

            migrationBuilder.DropColumn(
                name: "QualityRating",
                table: "Labourers");

            migrationBuilder.DropColumn(
                name: "SatefyRating",
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
