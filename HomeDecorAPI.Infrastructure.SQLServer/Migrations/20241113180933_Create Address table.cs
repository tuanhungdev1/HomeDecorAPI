using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeDecorAPI.Infrastructure.SQLServer.Migrations
{
    /// <inheritdoc />
    public partial class CreateAddresstable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Displayname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UsageLimit = table.Column<int>(type: "int", nullable: false),
                    UsageCount = table.Column<int>(type: "int", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ContactPerson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingFee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CouponCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AppliedDiscountId = table.Column<int>(type: "int", nullable: true),
                    AppliedCouponId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carts_Coupons_AppliedCouponId",
                        column: x => x.AppliedCouponId,
                        principalTable: "Coupons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Carts_Discounts_AppliedDiscountId",
                        column: x => x.AppliedDiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    BaseSKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Measurements = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Measurements = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    RoomType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    Material = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Features = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CareInStructions = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    WarrantyInfo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MaintenanceInstructions = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    RecommendedCleaningProducts = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SKU = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsMainVariant = table.Column<bool>(type: "bit", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: true),
                    DiscountStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsVerifiedPurchase = table.Column<bool>(type: "bit", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: true),
                    Dislikes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountedUnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMainImage = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductVariantId = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => new { x.UserId, x.ProductVariantId, x.Id });
                    table.ForeignKey(
                        name: "FK_WishlistItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItems_ProductVariants_ProductVariantId",
                        column: x => x.ProductVariantId,
                        principalTable: "ProductVariants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "LogoUrl", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5247), "Comfortable and modern home decor", true, null, "CozyNest", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5248) },
                    { 2, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5252), "High-end decoration products for home", true, null, "Luxurious Living", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5252) },
                    { 3, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5253), "Natural and eco-friendly decor", true, null, "Nature Harmony", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5254) },
                    { 4, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5254), "Rustic-themed decor for cozy homes", false, null, "Rustic Charm", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5255) },
                    { 5, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5256), "Modern and sleek decor solutions", true, null, "Urban Modern", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5256) },
                    { 6, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5257), "Vintage-inspired decor pieces", true, null, "Vintage Vibes", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5257) },
                    { 7, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5258), "Minimalist, clutter-free designs", true, null, "Minimalist Space", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5258) },
                    { 8, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5259), "Scandinavian-style simplicity", true, null, "Scandinavian Simplicity", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5259) },
                    { 9, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5260), "Industrial-themed home decor", false, null, "Industrial Touch", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5260) },
                    { 10, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5261), "Classic style for a sophisticated look", true, null, "Classic Elegance", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5262) },
                    { 11, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5263), "Boho-inspired vibrant decor", true, null, "Bohemian Bliss", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5263) },
                    { 12, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5264), "Eco-friendly decor products", true, null, "Eco Essentials", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5264) },
                    { 13, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5265), "Handmade artisan decor", false, null, "Artisan Crafted", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5265) },
                    { 14, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5266), "Modern farmhouse style decor", true, null, "Modern Farmhouse", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5266) },
                    { 15, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5267), "Contemporary decor for urban homes", true, null, "Contemporary Chic", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5268) },
                    { 16, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5268), "Soft, vintage-style decor", false, null, "Shabby Chic", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5269) },
                    { 17, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5270), "Elegant essentials for the home", true, null, "Elegant Essentials", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5270) },
                    { 18, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5271), "Beach-inspired comfortable decor", true, null, "Coastal Comfort", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5271) },
                    { 19, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5272), "Urban loft-style decor pieces", true, null, "Urban Loft", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5272) },
                    { 20, new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5273), "Timeless, classic decor pieces", true, null, "Timeless Heritage", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(5273) }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "ContactPerson", "Country", "CreatedAt", "Description", "Email", "IsActive", "LogoUrl", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "123 Decor St", "New York", "John Doe", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4551), "Contemporary furniture and decor", "johndoe@moderndesigns.com", true, null, "Modern Designs", "1234567890", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4555) },
                    { 2, "456 Wood Ave", "Austin", "Jane Smith", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4563), "Natural, rustic home goods", "janesmith@rusticroots.com", true, null, "Rustic Roots", "0987654321", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4563) },
                    { 3, "789 Green Blvd", "San Francisco", "Emma Johnson", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4565), "Eco-friendly decor solutions", "emma@ecoessentials.com", true, null, "Eco Essentials", "5678901234", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4565) },
                    { 4, "101 Trendy St", "Los Angeles", "James Brown", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4567), "Trendy decor for modern spaces", "james@urbandecor.com", false, null, "Urban Decor Co.", "4561237890", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4567) },
                    { 5, "202 Classic Way", "Chicago", "Sophia Williams", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4569), "Classic and vintage decor items", "sophia@vintagedecor.com", true, null, "Vintage Decor", "8901234567", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4569) },
                    { 6, "303 Simplicity St", "Seattle", "Olivia Taylor", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4571), "Minimalist-inspired decor", "olivia@minimalisttouch.com", true, null, "Minimalist Touch", "3216549870", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4571) },
                    { 7, "404 Freedom Ln", "Denver", "Liam Martinez", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4573), "Bohemian-style decor", "liam@bohobliss.com", false, null, "Boho Bliss", "9876543210", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4573) },
                    { 8, "505 Craft Rd", "Portland", "Mason Anderson", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4574), "Handcrafted decor for home", "mason@artisanhome.com", true, null, "Artisan Home", "2345678901", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4575) },
                    { 9, "606 Tradition Blvd", "Nashville", "Ava Thomas", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4576), "Timeless and classic home decor", "ava@timelessdecor.com", true, null, "Timeless Decor", "7654321098", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4576) },
                    { 10, "707 World St", "Phoenix", "Ethan White", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4578), "Globally inspired decor pieces", "ethan@globalgoods.com", true, null, "Global Goods", "6547893210", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4578) },
                    { 11, "808 Nature Dr", "Miami", "Amelia Harris", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4580), "Nature-inspired home goods", "amelia@naturalelements.com", true, null, "Natural Elements", "1239874560", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4580) },
                    { 12, "909 Trendy Ave", "Houston", "Lucas Clark", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4581), "Modern, urban-style decor", "lucas@urbantrends.com", false, null, "Urban Trends", "7894561230", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4582) },
                    { 13, "1010 Cozy Ln", "Charlotte", "Charlotte Robinson", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4583), "Rustic and cozy home decor", "charlotte@countrycottage.com", true, null, "Country Cottage", "4567890123", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4584) },
                    { 14, "1111 Shore St", "San Diego", "Jackson Lewis", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4585), "Beach-inspired decor items", "jackson@coastalliving.com", true, null, "Coastal Living", "0987123456", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4585) },
                    { 15, "1212 Farmhouse Ave", "Dallas", "Harper Lee", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4587), "Farmhouse-style decor for modern homes", "harper@modernfarmhouse.com", true, null, "Modern Farmhouse", "2345678909", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4587) },
                    { 16, "1313 Nordic Rd", "Boston", "Sebastian Wilson", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4589), "Scandinavian-inspired decor", "sebastian@scandihome.com", false, null, "Scandi Home", "6789012345", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4589) },
                    { 17, "1414 Glam Blvd", "Las Vegas", "Isabella King", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4590), "Luxury decor for upscale homes", "isabella@luxuryinteriors.com", true, null, "Luxury Interiors", "5432109876", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4591) },
                    { 18, "1515 Earth St", "Orlando", "Henry Scott", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4592), "Eco-conscious home decor solutions", "henry@ecohomedecor.com", true, null, "Eco Home Decor", "3456789012", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4592) },
                    { 19, "1616 Timeless Blvd", "Atlanta", "Grace Adams", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4594), "Elegant decor for classic homes", "grace@classicelegance.com", true, null, "Classic Elegance", "2109876543", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4594) },
                    { 20, "1717 Art St", "Los Angeles", "Sophia Young", "USA", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4595), "Art-inspired decor", "sophia@artisticspaces.com", true, null, "Artistic Spaces", "6785432109", new DateTime(2024, 11, 13, 18, 9, 33, 108, DateTimeKind.Utc).AddTicks(4596) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductVariantId",
                table: "CartItems",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppliedCouponId",
                table: "Carts",
                column: "AppliedCouponId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppliedDiscountId",
                table: "Carts",
                column: "AppliedDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                unique: true,
                filter: "[ProductId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductVariantId",
                table: "ProductImage",
                column: "ProductVariantId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariants",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_ProductVariantId",
                table: "WishlistItems",
                column: "ProductVariantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
