﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online_Shopping.Models;

#nullable disable

namespace Online_Shopping.Migrations
{
    [DbContext(typeof(shopContext))]
    [Migration("20241110054958_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Online_Shopping.Models.Catalog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("id");

                    b.ToTable("Catalogs");

                    b.HasData(
                        new
                        {
                            id = 1,
                            desc = "All electronic devices",
                            name = "Electronics"
                        },
                        new
                        {
                            id = 2,
                            desc = "Collection of books",
                            name = "Books"
                        },
                        new
                        {
                            id = 3,
                            desc = "Apparel and accessories",
                            name = "Clothing"
                        },
                        new
                        {
                            id = 4,
                            desc = "Appliances for home use",
                            name = "Home Appliances"
                        },
                        new
                        {
                            id = 5,
                            desc = "Kids' toys and games",
                            name = "Toys"
                        });
                });

            modelBuilder.Entity("Online_Shopping.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("amount")
                        .HasColumnType("int");

                    b.Property<int>("cat_id")
                        .HasColumnType("int");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("cat_id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            id = 1,
                            amount = 15,
                            cat_id = 1,
                            desc = "High-performance laptop",
                            name = "Laptop",
                            price = 999.99000000000001
                        },
                        new
                        {
                            id = 2,
                            amount = 30,
                            cat_id = 1,
                            desc = "Latest model smartphone",
                            name = "Smartphone",
                            price = 599.99000000000001
                        },
                        new
                        {
                            id = 3,
                            amount = 50,
                            cat_id = 2,
                            desc = "Best-selling novel",
                            name = "Novel",
                            price = 19.989999999999998
                        },
                        new
                        {
                            id = 4,
                            amount = 100,
                            cat_id = 3,
                            desc = "Comfortable cotton T-shirt",
                            name = "T-shirt",
                            price = 9.9900000000000002
                        },
                        new
                        {
                            id = 5,
                            amount = 20,
                            cat_id = 4,
                            desc = "Kitchen blender with multiple settings",
                            name = "Blender",
                            price = 49.990000000000002
                        });
                });

            modelBuilder.Entity("Online_Shopping.Models.Product", b =>
                {
                    b.HasOne("Online_Shopping.Models.Catalog", "catalog")
                        .WithMany("Products")
                        .HasForeignKey("cat_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("catalog");
                });

            modelBuilder.Entity("Online_Shopping.Models.Catalog", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
