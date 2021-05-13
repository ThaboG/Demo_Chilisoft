using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DAL.Migrations
{
    public partial class SetDefaultDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserEmployeeRel_UserID",
                table: "UserEmployeeRel");

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "ID",
                keyValue: new Guid("80123d35-faad-4d7e-b29c-2242527c6085"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(9823), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(9831), new TimeSpan(0, 2, 0, 0, 0)), new Guid("1eecaf14-6a8f-4aee-90e7-f2cb34a7b2f3"), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(9838), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ApiUsers",
                keyColumn: "ID",
                keyValue: new Guid("5ede5b27-5d58-43f7-916a-6dd659d4334f"),
                columns: new[] { "CreateDateTime", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 934, DateTimeKind.Unspecified).AddTicks(2354), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 936, DateTimeKind.Unspecified).AddTicks(1210), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "CreateDateTime", "IsDeleted", "ModifiedDate", "Name", "SyncClientID", "SyncTime" },
                values: new object[] { new Guid("f8369021-c2b0-4c0d-b91a-a7856b2cb0ca"), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(5412), new TimeSpan(0, 2, 0, 0, 0)), false, null, "Reception", new Guid("d85072fe-1e0e-4bed-9c18-9dc4b09c6bfc"), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(5441), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserAdminRel",
                keyColumn: "ID",
                keyValue: new Guid("9d05c42b-bc57-4e14-877d-161e74065b91"),
                columns: new[] { "CreateDateTime", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 940, DateTimeKind.Unspecified).AddTicks(1455), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 940, DateTimeKind.Unspecified).AddTicks(1463), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"),
                columns: new[] { "CreateDateTime", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(2672), new TimeSpan(0, 2, 0, 0, 0)), new Guid("90a196ea-9b19-490f-8f30-594c65fda492"), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(3269), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(6998), new TimeSpan(0, 2, 0, 0, 0)), new Guid("1ea6a6c6-03e0-42e8-8ae3-0d48a32a7a5b"), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(7006), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_UserEmployeeRel_UserID",
                table: "UserEmployeeRel",
                column: "UserID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserEmployeeRel_UserID",
                table: "UserEmployeeRel");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: new Guid("f8369021-c2b0-4c0d-b91a-a7856b2cb0ca"));

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
                columns: new[] { "CreateDateTime", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 689, DateTimeKind.Unspecified).AddTicks(6751), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 9, 20, 12, 23, 692, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 2, 0, 0, 0)) });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserEmployeeRel_UserID",
                table: "UserEmployeeRel",
                column: "UserID");
        }
    }
}
