using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DAL.Migrations
{
    public partial class InitMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Admins",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Admins", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "ApiUsers",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_ApiUsers", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Books",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Barcode = table.Column<string>(type: "nvarchar(450)", nullable: false),
            //        Total = table.Column<int>(type: "int", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Books", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Departments",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Departments", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "GeneralUsers",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        ClientNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_GeneralUsers", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserTypes",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserType = table.Column<int>(type: "int", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserTypes", x => x.ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Employees",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EmployeeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        DepartmentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employees", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Employees_Departments_DepartmentID",
            //            column: x => x.DepartmentID,
            //            principalTable: "Departments",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
            //        UserTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false),
            //        SyncTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        SyncClientID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_Users_UserTypes_UserTypeID",
            //            column: x => x.UserTypeID,
            //            principalTable: "UserTypes",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserAdminRel",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        AdminID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserAdminRel", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_UserAdminRel_Admins_AdminID",
            //            column: x => x.AdminID,
            //            principalTable: "Admins",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_UserAdminRel_Users_UserID",
            //            column: x => x.UserID,
            //            principalTable: "Users",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserEmployeeRel",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        EmployeeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserEmployeeRel", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_UserEmployeeRel_Employees_EmployeeID",
            //            column: x => x.EmployeeID,
            //            principalTable: "Employees",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_UserEmployeeRel_Users_UserID",
            //            column: x => x.UserID,
            //            principalTable: "Users",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserGeneralUsertRel",
            //    columns: table => new
            //    {
            //        ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        GeneralUsersID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        CreateDateTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
            //        ModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
            //        IsDeleted = table.Column<bool>(type: "bit", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserGeneralUsertRel", x => x.ID);
            //        table.ForeignKey(
            //            name: "FK_UserGeneralUsertRel_GeneralUsers_GeneralUsersID",
            //            column: x => x.GeneralUsersID,
            //            principalTable: "GeneralUsers",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_UserGeneralUsertRel_Users_UserID",
            //            column: x => x.UserID,
            //            principalTable: "Users",
            //            principalColumn: "ID",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.InsertData(
            //    table: "Admins",
            //    columns: new[] { "ID", "CreateDateTime", "Firstname", "IsDeleted", "Lastname", "MobileNo", "ModifiedDate", "SyncClientID", "SyncTime" },
            //    values: new object[] { new Guid("80123d35-faad-4d7e-b29c-2242527c6085"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 2, 0, 0, 0)), "Thabo", false, "Gelenja", "0734336271", new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 2, 0, 0, 0)), new Guid("b2355f1a-2552-42a1-acb2-e7a748469965"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 2, 0, 0, 0)) });

            //migrationBuilder.InsertData(
            //    table: "ApiUsers",
            //    columns: new[] { "ID", "CreateDateTime", "IsDeleted", "ModifiedDate", "Password", "Username" },
            //    values: new object[] { new Guid("5ede5b27-5d58-43f7-916a-6dd659d4334f"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 558, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 2, 0, 0, 0)), false, new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 560, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 2, 0, 0, 0)), "", "" });

            //migrationBuilder.InsertData(
            //    table: "UserTypes",
            //    columns: new[] { "ID", "CreateDateTime", "IsDeleted", "ModifiedDate", "Name", "SyncClientID", "SyncTime", "UserType" },
            //    values: new object[] { new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 562, DateTimeKind.Unspecified).AddTicks(9640), new TimeSpan(0, 2, 0, 0, 0)), false, null, "Admin", new Guid("324c7106-7e7b-44bc-83b2-ec9b0c05eb95"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 2, 0, 0, 0)), 0 });

            //migrationBuilder.InsertData(
            //    table: "Users",
            //    columns: new[] { "ID", "CreateDateTime", "IsDeleted", "ModifiedDate", "Password", "SyncClientID", "SyncTime", "UserTypeID", "Username" },
            //    values: new object[] { new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 2, 0, 0, 0)), false, new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 2, 0, 0, 0)), "TestPassword", new Guid("66fabf4f-4a2a-48fb-8905-cc8313504763"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1970), new TimeSpan(0, 2, 0, 0, 0)), new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"), "system@user.tst" });

            //migrationBuilder.InsertData(
            //    table: "UserAdminRel",
            //    columns: new[] { "ID", "AdminID", "CreateDateTime", "IsDeleted", "ModifiedDate", "UserID" },
            //    values: new object[] { new Guid("9d05c42b-bc57-4e14-877d-161e74065b91"), new Guid("80123d35-faad-4d7e-b29c-2242527c6085"), new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 2, 0, 0, 0)), false, new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 2, 0, 0, 0)), new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78") });

            //migrationBuilder.CreateIndex(
            //    name: "Index_Barcode",
            //    table: "Books",
            //    column: "Barcode",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Employees_DepartmentID",
            //    table: "Employees",
            //    column: "DepartmentID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserAdminRel_AdminID",
            //    table: "UserAdminRel",
            //    column: "AdminID",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserAdminRel_UserID",
            //    table: "UserAdminRel",
            //    column: "UserID",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserEmployeeRel_EmployeeID",
            //    table: "UserEmployeeRel",
            //    column: "EmployeeID",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserEmployeeRel_UserID",
            //    table: "UserEmployeeRel",
            //    column: "UserID");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserGeneralUsertRel_GeneralUsersID",
            //    table: "UserGeneralUsertRel",
            //    column: "GeneralUsersID",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserGeneralUsertRel_UserID",
            //    table: "UserGeneralUsertRel",
            //    column: "UserID",
            //    unique: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_UserTypeID",
            //    table: "Users",
            //    column: "UserTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "UserAdminRel");

            migrationBuilder.DropTable(
                name: "UserEmployeeRel");

            migrationBuilder.DropTable(
                name: "UserGeneralUsertRel");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "GeneralUsers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
