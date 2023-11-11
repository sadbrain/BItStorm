using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations;

public partial class addSomeColumeForCommentsAndVideos : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {




        migrationBuilder.AddColumn<string>(
            name: "Image_url",
            table: "Videos",
            type: "nvarchar(max)",
            nullable: false,
            defaultValue: "");

        migrationBuilder.AddColumn<bool>(
            name: "IsAnonymous",
            table: "Comments",
            type: "bit",
            nullable: false,
            defaultValue: false);

    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {

        migrationBuilder.DropColumn(
            name: "Image_url",
            table: "Videos");

        migrationBuilder.DropColumn(
            name: "IsAnonymous",
            table: "Comments");




    }
}
