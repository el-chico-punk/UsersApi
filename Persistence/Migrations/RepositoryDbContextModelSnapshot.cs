﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(RepositoryDbContext))]
    partial class RepositoryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Permission", b =>
                {
                    b.Property<Guid>("permissionIdentifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("permissionDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("permissionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("permissionIdentifier");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("roleIdentifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleIdentifier");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<Guid>("userIdentifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("userEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userPhone")
                        .HasColumnType("int");

                    b.HasKey("userIdentifier");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.Property<Guid>("permissionspermissionIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("rolesroleIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("permissionspermissionIdentifier", "rolesroleIdentifier");

                    b.HasIndex("rolesroleIdentifier");

                    b.ToTable("PermissionRole");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<Guid>("rolesroleIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("usersuserIdentifier")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("rolesroleIdentifier", "usersuserIdentifier");

                    b.HasIndex("usersuserIdentifier");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("PermissionRole", b =>
                {
                    b.HasOne("Domain.Entities.Permission", null)
                        .WithMany()
                        .HasForeignKey("permissionspermissionIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("rolesroleIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("Domain.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("rolesroleIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("usersuserIdentifier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
