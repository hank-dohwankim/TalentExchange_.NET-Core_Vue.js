using Microsoft.EntityFrameworkCore.Migrations;

namespace TalentExchange.Data.Migrations
{
    public partial class addReplyIdFKinpostmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReplyId",
                table: "Posts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReplyId",
                table: "Posts");
        }
    }
}
