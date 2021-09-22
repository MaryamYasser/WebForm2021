using Microsoft.EntityFrameworkCore.Migrations;

namespace WebForm2021.Migrations
{
    public partial class SeededDataUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Name" },
                values: new object[,]
                {
                    { -1, "maryamyasser99@gmail.com", "Maryam Yasser" },
                    { -2, "Habibayasser99@gmail.com", "Habiba Yasser" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -1, "PHP" },
                    { -2, "Android" },
                    { -3, "iOS" },
                    { -4, "ASP.NET" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeSkills",
                columns: new[] { "ID", "EmployeeID", "SkillID" },
                values: new object[,]
                {
                    { -1, -1, -1 },
                    { -2, -1, -2 },
                    { -3, -2, -2 },
                    { -4, -2, -3 },
                    { -5, -2, -4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "EmployeeSkills",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "maryamyasser99@gmail.com", "Maryam Yasser" },
                    { 2, "Habibayasser99@gmail.com", "Habiba Yasser" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "PHP" },
                    { 2, "Android" },
                    { 3, "iOS" },
                    { 4, "ASP.NET" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeSkills",
                columns: new[] { "ID", "EmployeeID", "SkillID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 2 },
                    { 4, 2, 3 },
                    { 5, 2, 4 }
                });
        }
    }
}
