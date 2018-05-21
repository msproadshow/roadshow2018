using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MspRoadShow.Api.Persistence.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                schema: "msproadshow",
                table: "Attendees");

            migrationBuilder.AddColumn<bool>(
                name: "IsAttendeePresented",
                schema: "msproadshow",
                table: "Attendees",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAttendeePresented",
                schema: "msproadshow",
                table: "Attendees");

            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                schema: "msproadshow",
                table: "Attendees",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
