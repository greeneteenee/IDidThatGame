﻿// <auto-generated />
using System;
using IDidThatGame.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IDidThatGame.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200516183011_SeedPlaceItems")]
    partial class SeedPlaceItems
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IDidThatGame.Models.ActionItem", b =>
                {
                    b.Property<int>("ActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Advanced")
                        .HasColumnType("bit");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActionId");

                    b.ToTable("Actions");

                    b.HasData(
                        new
                        {
                            ActionId = 1,
                            ActionName = "Crab walk",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 2,
                            ActionName = "Take giant steps",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 3,
                            ActionName = "Crawl",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 4,
                            ActionName = "Dance",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 5,
                            ActionName = "Skip",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 6,
                            ActionName = "Penguin walk",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 7,
                            ActionName = "Tip toe",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 8,
                            ActionName = "Hop",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 9,
                            ActionName = "Walk backwards",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 10,
                            ActionName = "Spin",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 11,
                            ActionName = "Gallop",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 12,
                            ActionName = "Roll",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 13,
                            ActionName = "Run",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 14,
                            ActionName = "Frog hop",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 15,
                            ActionName = "Jumping jack",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 16,
                            ActionName = "Lunge",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 17,
                            ActionName = "Tightrope",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 18,
                            ActionName = "Hop on one leg",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 19,
                            ActionName = "March",
                            Advanced = false,
                            Category = "default"
                        },
                        new
                        {
                            ActionId = 20,
                            ActionName = "Skate",
                            Advanced = false,
                            Category = "default"
                        });
                });

            modelBuilder.Entity("IDidThatGame.Models.ChallengeItem", b =>
                {
                    b.Property<int>("ChallengeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Advanced")
                        .HasColumnType("bit");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChallengeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChallengeId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("IDidThatGame.Models.PlaceItem", b =>
                {
                    b.Property<int>("PlaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlaceId");

                    b.ToTable("Places");

                    b.HasData(
                        new
                        {
                            PlaceId = 1,
                            Category = "home",
                            PlaceName = "to the fridge"
                        },
                        new
                        {
                            PlaceId = 2,
                            Category = "home",
                            PlaceName = "to a sink"
                        },
                        new
                        {
                            PlaceId = 3,
                            Category = "home",
                            PlaceName = "to the front door"
                        },
                        new
                        {
                            PlaceId = 4,
                            Category = "home",
                            PlaceName = "to four walls"
                        },
                        new
                        {
                            PlaceId = 5,
                            Category = "home",
                            PlaceName = "to two lightswitches"
                        },
                        new
                        {
                            PlaceId = 6,
                            Category = "home",
                            PlaceName = "to a tv"
                        },
                        new
                        {
                            PlaceId = 7,
                            Category = "home",
                            PlaceName = "to a mirror"
                        },
                        new
                        {
                            PlaceId = 8,
                            Category = "home",
                            PlaceName = "to a plant"
                        },
                        new
                        {
                            PlaceId = 9,
                            Category = "home",
                            PlaceName = "to a bathtub"
                        },
                        new
                        {
                            PlaceId = 10,
                            Category = "home",
                            PlaceName = "to a shower"
                        },
                        new
                        {
                            PlaceId = 11,
                            Category = "home",
                            PlaceName = "to a bookcase"
                        },
                        new
                        {
                            PlaceId = 12,
                            Category = "home",
                            PlaceName = "to a trashcan"
                        },
                        new
                        {
                            PlaceId = 13,
                            Category = "home",
                            PlaceName = "around a chair"
                        },
                        new
                        {
                            PlaceId = 14,
                            Category = "home",
                            PlaceName = "to a bedroom"
                        },
                        new
                        {
                            PlaceId = 15,
                            Category = "home",
                            PlaceName = "to three rooms"
                        },
                        new
                        {
                            PlaceId = 16,
                            Category = "home",
                            PlaceName = "around a table"
                        },
                        new
                        {
                            PlaceId = 17,
                            Category = "home",
                            PlaceName = "under a table and back"
                        },
                        new
                        {
                            PlaceId = 18,
                            Category = "home",
                            PlaceName = "over a bed"
                        },
                        new
                        {
                            PlaceId = 19,
                            Category = "home",
                            PlaceName = "over a sofa and back"
                        },
                        new
                        {
                            PlaceId = 20,
                            Category = "home",
                            PlaceName = "to two rugs"
                        },
                        new
                        {
                            PlaceId = 21,
                            Category = "home",
                            PlaceName = "to two doors"
                        },
                        new
                        {
                            PlaceId = 22,
                            Category = "home",
                            PlaceName = "to a toilet"
                        },
                        new
                        {
                            PlaceId = 23,
                            Category = "home",
                            PlaceName = "to a closet"
                        },
                        new
                        {
                            PlaceId = 24,
                            Category = "home",
                            PlaceName = "to a window and back"
                        },
                        new
                        {
                            PlaceId = 25,
                            Category = "home",
                            PlaceName = "to something red"
                        },
                        new
                        {
                            PlaceId = 26,
                            Category = "home",
                            PlaceName = "to something blue"
                        },
                        new
                        {
                            PlaceId = 27,
                            Category = "home",
                            PlaceName = "to something yellow"
                        },
                        new
                        {
                            PlaceId = 28,
                            Category = "home",
                            PlaceName = "to something green"
                        },
                        new
                        {
                            PlaceId = 29,
                            Category = "home",
                            PlaceName = "to something purple"
                        },
                        new
                        {
                            PlaceId = 30,
                            Category = "home",
                            PlaceName = "to something orange"
                        },
                        new
                        {
                            PlaceId = 31,
                            Category = "home",
                            PlaceName = "to something pink"
                        },
                        new
                        {
                            PlaceId = 32,
                            Category = "home",
                            PlaceName = "behind a curtain and back"
                        },
                        new
                        {
                            PlaceId = 33,
                            Category = "home",
                            PlaceName = "to a toy and back"
                        },
                        new
                        {
                            PlaceId = 34,
                            Category = "home",
                            PlaceName = "to a picture and back"
                        },
                        new
                        {
                            PlaceId = 35,
                            Category = "home",
                            PlaceName = "to a laundry basket"
                        },
                        new
                        {
                            PlaceId = 36,
                            Category = "home",
                            PlaceName = "to a computer"
                        },
                        new
                        {
                            PlaceId = 37,
                            Category = "home",
                            PlaceName = "to two lamps"
                        },
                        new
                        {
                            PlaceId = 38,
                            Category = "home",
                            PlaceName = "to a shoe and back"
                        },
                        new
                        {
                            PlaceId = 39,
                            Category = "home",
                            PlaceName = "over a pillow and back"
                        },
                        new
                        {
                            PlaceId = 40,
                            Category = "home",
                            PlaceName = "to your favorite thing"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
