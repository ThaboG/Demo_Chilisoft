using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DAL.Migrations
{
    public partial class AddErrorLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorLog",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLog", x => x.ID);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "ID",
                keyValue: new Guid("80123d35-faad-4d7e-b29c-2242527c6085"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(9734), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(9747), new TimeSpan(0, 2, 0, 0, 0)), new Guid("2a8fc445-8524-47ad-8986-6644fbdac104"), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(9756), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "ApiUsers",
                keyColumn: "ID",
                keyValue: new Guid("5ede5b27-5d58-43f7-916a-6dd659d4334f"),
                columns: new[] { "CreateDateTime", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 455, DateTimeKind.Unspecified).AddTicks(1293), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 459, DateTimeKind.Unspecified).AddTicks(2853), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: new Guid("f8369021-c2b0-4c0d-b91a-a7856b2cb0ca"),
                columns: new[] { "CreateDateTime", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(5223), new TimeSpan(0, 2, 0, 0, 0)), new Guid("36dc3535-8c3b-402c-8356-50c229a7ed4d"), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(5259), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserAdminRel",
                keyColumn: "ID",
                keyValue: new Guid("9d05c42b-bc57-4e14-877d-161e74065b91"),
                columns: new[] { "CreateDateTime", "ModifiedDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 464, DateTimeKind.Unspecified).AddTicks(1430), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 464, DateTimeKind.Unspecified).AddTicks(1440), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "ID",
                keyValue: new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"),
                columns: new[] { "CreateDateTime", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(2202), new TimeSpan(0, 2, 0, 0, 0)), new Guid("e102b502-ca8c-404c-a5b2-b71e6af9df52"), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(2884), new TimeSpan(0, 2, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78"),
                columns: new[] { "CreateDateTime", "ModifiedDate", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(6840), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(6851), new TimeSpan(0, 2, 0, 0, 0)), new Guid("2219769a-31c5-4acd-a51a-e1312dd11631"), new DateTimeOffset(new DateTime(2021, 5, 20, 17, 35, 11, 463, DateTimeKind.Unspecified).AddTicks(6862), new TimeSpan(0, 2, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorLog");

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

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: new Guid("f8369021-c2b0-4c0d-b91a-a7856b2cb0ca"),
                columns: new[] { "CreateDateTime", "SyncClientID", "SyncTime" },
                values: new object[] { new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(5412), new TimeSpan(0, 2, 0, 0, 0)), new Guid("d85072fe-1e0e-4bed-9c18-9dc4b09c6bfc"), new DateTimeOffset(new DateTime(2021, 5, 10, 0, 11, 19, 939, DateTimeKind.Unspecified).AddTicks(5441), new TimeSpan(0, 2, 0, 0, 0)) });

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
        }
    }
}
