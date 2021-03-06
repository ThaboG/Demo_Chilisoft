// <auto-generated />
using System;
using Demo.DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Demo.DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210509175756_InitMig")]
    partial class InitMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Demo.DAL.Entities.Admins", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("SyncClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("SyncTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ID");

                    b.ToTable("Admins");

                    b.HasData(
                        new
                        {
                            ID = new Guid("80123d35-faad-4d7e-b29c-2242527c6085"),
                            CreateDateTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4041), new TimeSpan(0, 2, 0, 0, 0)),
                            Firstname = "Thabo",
                            IsDeleted = false,
                            Lastname = "Gelenja",
                            MobileNo = "0734336271",
                            ModifiedDate = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4049), new TimeSpan(0, 2, 0, 0, 0)),
                            SyncClientID = new Guid("b2355f1a-2552-42a1-acb2-e7a748469965"),
                            SyncTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(4056), new TimeSpan(0, 2, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("Demo.DAL.Entities.ApiUser", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ApiUsers");

                    b.HasData(
                        new
                        {
                            ID = new Guid("5ede5b27-5d58-43f7-916a-6dd659d4334f"),
                            CreateDateTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 558, DateTimeKind.Unspecified).AddTicks(2769), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            ModifiedDate = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 560, DateTimeKind.Unspecified).AddTicks(4452), new TimeSpan(0, 2, 0, 0, 0)),
                            Password = "",
                            Username = ""
                        });
                });

            modelBuilder.Entity("Demo.DAL.Entities.Books", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("SyncClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("SyncTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex(new[] { "Barcode" }, "Index_Barcode")
                        .IsUnique();

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Demo.DAL.Entities.Departments", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SyncClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("SyncTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Demo.DAL.Entities.Employees", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("DepartmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmployeeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("SyncClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("SyncTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Demo.DAL.Entities.GeneralUsers", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("SyncClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("SyncTime")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("ID");

                    b.ToTable("GeneralUsers");
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserAdminRel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdminID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("AdminID")
                        .IsUnique();

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("UserAdminRel");

                    b.HasData(
                        new
                        {
                            ID = new Guid("9d05c42b-bc57-4e14-877d-161e74065b91"),
                            AdminID = new Guid("80123d35-faad-4d7e-b29c-2242527c6085"),
                            CreateDateTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            ModifiedDate = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(5323), new TimeSpan(0, 2, 0, 0, 0)),
                            UserID = new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78")
                        });
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserEmployeeRel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("EmployeeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.ToTable("UserEmployeeRel");
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserGeneralUsertRel", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("GeneralUsersID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("GeneralUsersID")
                        .IsUnique();

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("UserGeneralUsertRel");
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserTypes", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SyncClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("SyncTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("UserTypes");

                    b.HasData(
                        new
                        {
                            ID = new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"),
                            CreateDateTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 562, DateTimeKind.Unspecified).AddTicks(9640), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            Name = "Admin",
                            SyncClientID = new Guid("324c7106-7e7b-44bc-83b2-ec9b0c05eb95"),
                            SyncTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(95), new TimeSpan(0, 2, 0, 0, 0)),
                            UserType = 0
                        });
                });

            modelBuilder.Entity("Demo.DAL.Entities.Users", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDateTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SyncClientID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("SyncTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("UserTypeID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = new Guid("30be73c3-5a0f-45be-aa80-4ff5c50b6d78"),
                            CreateDateTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1943), new TimeSpan(0, 2, 0, 0, 0)),
                            IsDeleted = false,
                            ModifiedDate = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1951), new TimeSpan(0, 2, 0, 0, 0)),
                            Password = "TestPassword",
                            SyncClientID = new Guid("66fabf4f-4a2a-48fb-8905-cc8313504763"),
                            SyncTime = new DateTimeOffset(new DateTime(2021, 5, 9, 19, 57, 55, 563, DateTimeKind.Unspecified).AddTicks(1970), new TimeSpan(0, 2, 0, 0, 0)),
                            UserTypeID = new Guid("9d708a99-205c-4aba-bc99-c87f0ed26846"),
                            Username = "system@user.tst"
                        });
                });

            modelBuilder.Entity("Demo.DAL.Entities.Employees", b =>
                {
                    b.HasOne("Demo.DAL.Entities.Departments", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserAdminRel", b =>
                {
                    b.HasOne("Demo.DAL.Entities.Admins", "Admin")
                        .WithOne("UserAdminRel")
                        .HasForeignKey("Demo.DAL.Entities.UserAdminRel", "AdminID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo.DAL.Entities.Users", "User")
                        .WithOne("UserAdminRel")
                        .HasForeignKey("Demo.DAL.Entities.UserAdminRel", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserEmployeeRel", b =>
                {
                    b.HasOne("Demo.DAL.Entities.Employees", "Employee")
                        .WithOne("UserEmployeeRel")
                        .HasForeignKey("Demo.DAL.Entities.UserEmployeeRel", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo.DAL.Entities.Users", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserGeneralUsertRel", b =>
                {
                    b.HasOne("Demo.DAL.Entities.GeneralUsers", "GeneralUser")
                        .WithOne("UserClientRel")
                        .HasForeignKey("Demo.DAL.Entities.UserGeneralUsertRel", "GeneralUsersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Demo.DAL.Entities.Users", "User")
                        .WithOne("UserClientRel")
                        .HasForeignKey("Demo.DAL.Entities.UserGeneralUsertRel", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GeneralUser");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Demo.DAL.Entities.Users", b =>
                {
                    b.HasOne("Demo.DAL.Entities.UserTypes", "UserType")
                        .WithMany("Users")
                        .HasForeignKey("UserTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserType");
                });

            modelBuilder.Entity("Demo.DAL.Entities.Admins", b =>
                {
                    b.Navigation("UserAdminRel");
                });

            modelBuilder.Entity("Demo.DAL.Entities.Departments", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Demo.DAL.Entities.Employees", b =>
                {
                    b.Navigation("UserEmployeeRel");
                });

            modelBuilder.Entity("Demo.DAL.Entities.GeneralUsers", b =>
                {
                    b.Navigation("UserClientRel");
                });

            modelBuilder.Entity("Demo.DAL.Entities.UserTypes", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Demo.DAL.Entities.Users", b =>
                {
                    b.Navigation("UserAdminRel");

                    b.Navigation("UserClientRel");
                });
#pragma warning restore 612, 618
        }
    }
}
