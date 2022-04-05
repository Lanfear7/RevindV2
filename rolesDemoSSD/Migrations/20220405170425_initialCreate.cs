using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace rolesDemoSSD.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IPNs",
                columns: table => new
                {
                    paymentID = table.Column<string>(type: "TEXT", nullable: false),
                    custom = table.Column<string>(type: "TEXT", nullable: true),
                    cart = table.Column<string>(type: "TEXT", nullable: true),
                    create_time = table.Column<string>(type: "TEXT", nullable: true),
                    payerID = table.Column<string>(type: "TEXT", nullable: true),
                    payerFirstName = table.Column<string>(type: "TEXT", nullable: true),
                    payerLastName = table.Column<string>(type: "TEXT", nullable: true),
                    payerMiddleName = table.Column<string>(type: "TEXT", nullable: true),
                    payerEmail = table.Column<string>(type: "TEXT", nullable: true),
                    payerCountryCode = table.Column<string>(type: "TEXT", nullable: true),
                    payerStatus = table.Column<string>(type: "TEXT", nullable: true),
                    amount = table.Column<string>(type: "TEXT", nullable: true),
                    currency = table.Column<string>(type: "TEXT", nullable: true),
                    intent = table.Column<string>(type: "TEXT", nullable: true),
                    paymentMethod = table.Column<string>(type: "TEXT", nullable: true),
                    paymentState = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPNs", x => x.paymentID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(type: "TEXT", nullable: true),
                    PosterSource = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Duration = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<string>(type: "TEXT", nullable: true),
                    Distributor = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "MovieVM",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieName = table.Column<string>(type: "TEXT", nullable: true),
                    PosterSource = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    Duration = table.Column<string>(type: "TEXT", nullable: true),
                    ReleaseDate = table.Column<string>(type: "TEXT", nullable: true),
                    Distributor = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieVM", x => x.MovieID);
                });

            migrationBuilder.CreateTable(
                name: "MyRegisteredUsers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyRegisteredUsers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoleVM",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    RoleName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleVM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleVM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleVM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserVM",
                columns: table => new
                {
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVM", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieVMMovieID = table.Column<int>(type: "INTEGER", nullable: true),
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserVMEmail = table.Column<string>(type: "TEXT", nullable: true),
                    ReviewTitle = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    ReviewContent = table.Column<string>(type: "TEXT", nullable: true),
                    ReviewDate = table.Column<string>(type: "TEXT", nullable: true),
                    Rating = table.Column<int>(type: "INTEGER", nullable: false),
                    Flag = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_MovieVM_MovieVMMovieID",
                        column: x => x.MovieVMMovieID,
                        principalTable: "MovieVM",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_UserVM_UserVMEmail",
                        column: x => x.UserVMEmail,
                        principalTable: "UserVM",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Distributor", "Duration", "Genre", "MovieName", "PosterSource", "ReleaseDate" },
                values: new object[] { 1, "Janus Films", "113 minutes", "War", "La Grande Illusion", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8NFGY_qLiXHGNgA0fXo59tn4iapzfYwQNiQ&usqp=CAU", "1937" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Distributor", "Duration", "Genre", "MovieName", "PosterSource", "ReleaseDate" },
                values: new object[] { 2, "Eagle Lion Films", "97 minutes", "Romance", "Brief Encounter", "data:image/jpeg;base64,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", "1945" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Distributor", "Duration", "Genre", "MovieName", "PosterSource", "ReleaseDate" },
                values: new object[] { 3, "Paramount Pictures Studio", "105 minutes", "Comedy/Crime", "Paper Moon", "data:image/jpeg;base64,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", "1973" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_MovieVMMovieID",
                table: "Reviews",
                column: "MovieVMMovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserVMEmail",
                table: "Reviews",
                column: "UserVMEmail");
        }

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
                name: "IPNs");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "MyRegisteredUsers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoleVM");

            migrationBuilder.DropTable(
                name: "UserRoleVM");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MovieVM");

            migrationBuilder.DropTable(
                name: "UserVM");
        }
    }
}
