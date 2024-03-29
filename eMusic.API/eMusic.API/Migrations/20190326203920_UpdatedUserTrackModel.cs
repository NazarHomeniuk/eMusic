﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace eMusic.API.Migrations
{
    public partial class UpdatedUserTrackModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isBuy",
                table: "UserTrack",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isBuy",
                table: "UserTrack");
        }
    }
}
