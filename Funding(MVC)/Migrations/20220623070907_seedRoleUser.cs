using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Funding_MVC_.Migrations
{
    public partial class seedRoleUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1371dd8f-2987-4f4e-a373-e97dec6a044b",
                column: "ConcurrencyStamp",
                value: "1cb1f8ba-20ba-4afe-b0b8-aae15ef749e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "zb8154b2-e26e-48a0-9168-7d1e63b53293",
                column: "ConcurrencyStamp",
                value: "5286f1f3-063c-4f80-9a74-769ba259fd9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab8154b2-e26e-48a0-9168-7d1e63b53293",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "524c4fdd-7466-4429-ad97-7d2aa540a605", "AQAAAAEAACcQAAAAEGE4jhpkixxWhspy6UW5Yz2ZFQFzb+u7SQYIQsBOJF06ApmVWsDKbalztorwVhcvAQ==", "959bcd8b-a0f5-4eac-9a2d-81240bbe6627" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e371dd8f-2987-4f4e-a373-e97dec6a044b",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "40ac68aa-4389-48d5-9c12-8cb8b3eaffb3", "admin999@admin.com", "ADMIN999@ADMIN.COM", "ADMIN999@ADMIN.COM", "AQAAAAEAACcQAAAAEGnnNVATpQeodA3G/tSvshgH7pKuSJZa/OkBcIqDnN4yX94ie9tZeTQoOAfzhiueaA==", "ad578a77-5402-47fd-902c-4c5b38ff715d", "admin999@admin.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1371dd8f-2987-4f4e-a373-e97dec6a044b",
                column: "ConcurrencyStamp",
                value: "ec93511d-ee38-44ef-8d30-719bc0eb6a39");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "zb8154b2-e26e-48a0-9168-7d1e63b53293",
                column: "ConcurrencyStamp",
                value: "5951ba73-139f-46b6-8833-55b6dc31a1d0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab8154b2-e26e-48a0-9168-7d1e63b53293",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "722281ab-9348-406d-bf71-0647e322f4a2", "AQAAAAEAACcQAAAAECWnWf57GwHJZaGEALOXN9Nk0JDDqa3weIrsdixhHASGChCMZW3nZ7Ui5Fe9qJc1AQ==", "3f03e0d6-6f7e-48a2-b28c-ed107e01ce73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e371dd8f-2987-4f4e-a373-e97dec6a044b",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c7b7db8a-599f-426f-b941-482fb1d1d4f2", "admin999@staff.com", "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEGzpkQfzoPZ2QfFTuPC1SqyY20mfMMSfRAkRMZI7PKK7D+s1hoNI4rLhD2HbqC0sZg==", "4fa3ee19-3658-49dc-b6be-279c318e9378", "admin999@staff.com" });
        }
    }
}
