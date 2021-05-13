using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DAL.Migrations
{
    public partial class AddApiUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "ID",
                keyValue: new Guid("80123d35-faad-4d7e-b29c-2242527c6085"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(7646), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(7656), new TimeSpan(0, 2, 0, 0, 0)), new Guid("cf177065-c69f-4d54-b151-8a71111653e5"), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(7663), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ApiUsers",
                keyColumn: "ID",
                keyValue: new Guid("5ede5b27-5d58-43f7-916a-6dd659d4334f"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "Password", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 689, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 692, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 2, 0, 0, 0)), "8566435F-B5CF-4285-9A44-E9F2A810C44D", "TestUser" });

            migrationBuilder.UpdateData(
                table: "UserAdminRel",
                keyColumn: "ID",
                keyValue: new Guid("9d05c42b-bc57-4e14-877d-161e74065b91"),
                columns: new[] { "CreateDateTime", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(9045), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(9053), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"),
                columns: new[] { "CreateDateTime", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(2385), new TimeSpan(0, 2, 0, 0, 0)), new Guid("a3093f86-89c3-4e9e-a6a6-5fb39148935b"), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(2892), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(4990), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(5000), new TimeSpan(0, 2, 0, 0, 0)), new Guid("0dc83f9b-2b91-4f3c-ba07-ecacf68ec586"), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 695, DateTimeKind.Unspecified).AddTicks(5021), new TimeSpan(0, 2, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "ID",
                keyValue: new Guid("80123d35-faad-4d7e-b29c-2242527c6085"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 2, 0, 0, 0)), new Guid("b2355f1a-2552-42a1-acb2-e7a748469965"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ApiUsers",
                keyColumn: "ID",
                keyValue: new Guid("5ede5b27-5d58-43f7-916a-6dd659d4334f"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "Password", "Username" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 558, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 560, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 2, 0, 0, 0)), "", "" });

            migrationBuilder.UpdateData(
                table: "UserAdminRel",
                keyColumn: "ID",
                keyValue: new Guid("9d05c42b-bc57-4e14-877d-161e74065b91"),
                columns: new[] { "CreateDateTime", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"),
                columns: new[] { "CreateDateTime", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 562, DateTimeKind.Unspecified).AddTicks(9640), new TimeSpan(0, 2, 0, 0, 0)), new Guid("324c7106-7e7b-44bc-83b2-ec9b0c05eb95"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 2, 0, 0, 0)), new Guid("66fabf4f-4a2a-48fb-8905-cc8313504763"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1970), new TimeSpan(0, 2, 0, 0, 0)) });
        }
    }
}
