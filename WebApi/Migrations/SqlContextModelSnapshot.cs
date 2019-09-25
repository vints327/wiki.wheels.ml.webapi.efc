﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.DataAccess.Base;

namespace WebApi.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebApi.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uObjectUUID");

                    b.Property<int>("nDelFlag")
                        .HasColumnName("nDelFlag");

                    b.Property<int>("nFlag")
                        .HasColumnName("nFlag");

                    b.Property<string>("strImage")
                        .HasColumnName("strImage");

                    b.Property<string>("strTitle")
                        .HasColumnName("strTitle");

                    b.Property<int>("uOwnerUUID")
                        .HasColumnName("uOwnerUUID");

                    b.HasKey("ID");

                    b.ToTable("t_wiki_category");
                });

            modelBuilder.Entity("WebApi.Entities.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uObjectUUID");

                    b.Property<int>("nDelFlag")
                        .HasColumnName("nDelFlag");

                    b.Property<string>("strID")
                        .HasColumnName("strID");

                    b.Property<string>("strImage")
                        .HasColumnName("strImage");

                    b.Property<string>("strName")
                        .HasColumnName("strName");

                    b.Property<string>("strNote")
                        .HasColumnName("strNote");

                    b.Property<string>("strTempUser")
                        .HasColumnName("strTempUser");

                    b.Property<int>("uCreatorUUID")
                        .HasColumnName("uCreatorUUID");

                    b.Property<int>("uDutyUserUUID")
                        .HasColumnName("uDutyUserUUID");

                    b.Property<int>("uObjectCategoryUUID")
                        .HasColumnName("uObjectCategoryUUID");

                    b.HasKey("ID");

                    b.ToTable("t_wiki_topic");
                });

            modelBuilder.Entity("WebApi.Entities.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<string>("Email")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .HasColumnName("LastName");

                    b.Property<string>("Password")
                        .HasColumnName("Password");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnName("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnName("PasswordSalt");

                    b.Property<string>("UserName")
                        .HasColumnName("UserName");

                    b.Property<string>("userId")
                        .HasColumnName("userId");

                    b.HasKey("ID");

                    b.ToTable("user");
                });

            modelBuilder.Entity("WebApi.Entities.Wiki", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("uObjectUUID");

                    b.Property<DateTime>("dtCreate")
                        .HasColumnName("dtCreate");

                    b.Property<DateTime>("dtUpdate")
                        .HasColumnName("dtUpdate");

                    b.Property<int>("nCore")
                        .HasColumnName("nCore");

                    b.Property<int>("nDelFlag")
                        .HasColumnName("nDelFlag");

                    b.Property<int>("nFlag")
                        .HasColumnName("nFlag");

                    b.Property<int>("nHasChildren")
                        .HasColumnName("nHasChildren");

                    b.Property<string>("strContent")
                        .HasColumnName("strContent");

                    b.Property<string>("strDesc")
                        .HasColumnName("strDesc");

                    b.Property<string>("strImage")
                        .HasColumnName("strImage");

                    b.Property<string>("strLabel")
                        .HasColumnName("strLabel");

                    b.Property<string>("strNote")
                        .HasColumnName("strNote");

                    b.Property<string>("strTitle")
                        .HasColumnName("strTitle");

                    b.Property<int>("uCategoryUUID")
                        .HasColumnName("uCategoryUUID");

                    b.Property<int>("uObjectParentUUID")
                        .HasColumnName("uObjectParentUUID");

                    b.Property<int>("uOwnerUUID")
                        .HasColumnName("uOwnerUUID");

                    b.Property<int>("uPublisherUUID")
                        .HasColumnName("uPublisherUUID");

                    b.Property<int>("uTopicUUID")
                        .HasColumnName("uTopicUUID");

                    b.HasKey("ID");

                    b.ToTable("t_wiki_item");
                });

            modelBuilder.Entity("WebApi.Models.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("WebApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<int>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("WebApi.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("WebApi.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("WebApi.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("WebApi.Models.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApi.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("WebApi.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
