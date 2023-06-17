using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppCitas.Service.Data.Migrations
{
    public partial class PhotoApprovalAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Photos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TargetUserId",
                table: "Likes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "TargetUserId",
                table: "Likes");
        }
    }
}
