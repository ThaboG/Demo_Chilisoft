using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DAL.DataContext
{
        public class DatabaseContext : DbContext
        {
            public class OptionsBuild //Allow us to initiate database connections with options
            {
                public OptionsBuild()
                {
                    settings = new AppConfiguration();
                    opsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                    opsBuilder.UseSqlServer(settings.sqlConnectionString);
                    dbOptions = opsBuilder.Options;
                }

                public DbContextOptionsBuilder<DatabaseContext> opsBuilder { get; set; }
                public DbContextOptions<DatabaseContext> dbOptions { get; set; }
                private AppConfiguration settings { get; set; }
            }
            public static OptionsBuild ops = new OptionsBuild();
            public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
            {
                this.Database.SetCommandTimeout(TimeSpan.FromMinutes(10));
                Database.EnsureCreated();
                ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Guid apiUserID = "5ede5b27-5d58-43f7-916a-6dd659d4334f".ToGuid();

            modelBuilder.Entity<ApiUser>().HasData(new ApiUser()
            {
                ID = apiUserID,
                Username = CustomHttpClient.ApiDefaultUsername,
                Password = CustomHttpClient.ApiDefaultPassword,
                CreateDateTime = DateTimeOffset.Now,
                ModifiedDate = DateTimeOffset.Now,
                IsDeleted = false,
            });

            Guid AdminUserTypeID = Enums.UserTypes.Admin.GetDBIDAttribute();
            string AdminUserTypeTex = Enums.UserTypes.Admin.Text();
            modelBuilder.Entity<UserTypes>().HasData(new UserTypes()
            {
                ID = AdminUserTypeID,
                Name = AdminUserTypeTex,
                CreateDateTime = DateTimeOffset.Now,
                IsDeleted = false,
                ModifiedDate = null,
                SyncClientID = Guid.NewGuid(),
                SyncTime = DateTimeOffset.Now,
                UserType = Enums.UserTypes.Admin
            });

            Guid DefaultDepartmentID = "F8369021-C2B0-4C0D-B91A-A7856B2CB0CA".ToGuid();
            modelBuilder.Entity<Departments>().HasData(new Departments()
            {
                ID = DefaultDepartmentID,
                Name = "Reception",
                CreateDateTime = DateTimeOffset.Now,
                IsDeleted = false,
                ModifiedDate = null,
                SyncClientID = Guid.NewGuid(),
                SyncTime = DateTimeOffset.Now,
            });

            Guid SystemUserID = "30BE73C3-5A0F-45BE-AA80-4FF5C50B6D78".ToGuid();
            modelBuilder.Entity<Users>().HasData(new Users()
            {
                ID = SystemUserID,
                Password = "TestPassword",
                Username = "system@user.tst",
                CreateDateTime = DateTimeOffset.Now,
                ModifiedDate = DateTimeOffset.Now,
                SyncClientID = Guid.NewGuid(),
                SyncTime = DateTimeOffset.Now,
                IsDeleted = false,
                UserTypeID = AdminUserTypeID,
            });

            Guid SystemAdminID = "80123D35-FAAD-4D7E-B29C-2242527C6085".ToGuid();
            modelBuilder.Entity<Admins>().HasData(new Admins()
            {
                ID = SystemAdminID,
                Firstname = "Thabo",
                Lastname = "Gelenja",
                MobileNo = "0734336271",
                CreateDateTime = DateTimeOffset.Now,
                ModifiedDate = DateTimeOffset.Now,
                SyncClientID = Guid.NewGuid(),
                SyncTime = DateTimeOffset.Now,
                IsDeleted = false
            });

            Guid UserAdminRelID = "9D05C42B-BC57-4E14-877D-161E74065B91".ToGuid();

            modelBuilder.Entity<UserAdminRel>().HasData(new UserAdminRel()
            {
                ID = UserAdminRelID,
                AdminID = SystemAdminID,
                UserID = SystemUserID,
                CreateDateTime = DateTimeOffset.Now,
                ModifiedDate = DateTimeOffset.Now,
                IsDeleted = false,
            });

            //this will return true when checking if "Thabo" == "ThAbO", Otherwise it would use server settings which might return false if the server is set to "SQL_Latin1_General_CP1_CS_AS"
            modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        }

            public DbSet<ApiUser> ApiUsers { get; set; }
            public DbSet<Users> Users { get; set; }
            public DbSet<GeneralUsers> GeneralUsers { get; set; }
            public DbSet<UserTypes> UserTypes { get; set; }
            public DbSet<Departments> Departments { get; set; }
            public DbSet<UserGeneralUserRel> UserClientRels { get; set; }
            public DbSet<Admins> Admins { get; set; }
            public DbSet<UserAdminRel> UserAdminRels { get; set; }
            public DbSet<Books> Books { get; set; }
            public DbSet<Employees> Employees { get; set; }
        }
}
