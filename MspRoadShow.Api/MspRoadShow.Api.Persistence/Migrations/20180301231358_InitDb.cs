using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MspRoadShow.Api.Persistence.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "msproadshow");

            migrationBuilder.CreateTable(
                name: "Attendees",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Activity = table.Column<string>(maxLength: 15, nullable: false),
                    CityId = table.Column<Guid>(nullable: false),
                    Company = table.Column<string>(maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    FirstName = table.Column<string>(maxLength: 15, nullable: false),
                    LastName = table.Column<string>(maxLength: 15, nullable: false),
                    Position = table.Column<string>(maxLength: 20, nullable: true),
                    Score = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EndDate = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(maxLength: 10, nullable: false),
                    Place = table.Column<string>(maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Speakers",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Note = table.Column<decimal>(nullable: false),
                    PhotoUrl = table.Column<string>(maxLength: 100, nullable: true),
                    SpeakerBio = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sponsors",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsActiveSponsor = table.Column<bool>(nullable: false),
                    LogoUrl = table.Column<string>(maxLength: 100, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SponsorLevel = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AttendeeCity",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AttendeesId = table.Column<Guid>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendeeCity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttendeeCity_Attendees_AttendeesId",
                        column: x => x.AttendeesId,
                        principalSchema: "msproadshow",
                        principalTable: "Attendees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendeeCity_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "msproadshow",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvaluateQuestions",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Answers = table.Column<string>(nullable: true),
                    CityId = table.Column<Guid>(nullable: false),
                    IsMultipleChoisePossible = table.Column<bool>(nullable: false),
                    Text = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluateQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvaluateQuestions_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "msproadshow",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Speeches",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: false),
                    EndTime = table.Column<DateTimeOffset>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Location = table.Column<string>(maxLength: 20, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SpeakerId = table.Column<Guid>(nullable: false),
                    StartTime = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speeches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Speeches_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "msproadshow",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Speeches_Speakers_SpeakerId",
                        column: x => x.SpeakerId,
                        principalSchema: "msproadshow",
                        principalTable: "Speakers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitySponsors",
                schema: "msproadshow",
                columns: table => new
                {
                    CityId = table.Column<Guid>(nullable: false),
                    SponsorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitySponsors", x => new { x.CityId, x.SponsorId });
                    table.ForeignKey(
                        name: "FK_CitySponsors_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "msproadshow",
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitySponsors_Sponsors_SponsorId",
                        column: x => x.SponsorId,
                        principalSchema: "msproadshow",
                        principalTable: "Sponsors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizzQuestions",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsMultipleChoiseActive = table.Column<bool>(nullable: false),
                    SpeechId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizzQuestions_Speeches_SpeechId",
                        column: x => x.SpeechId,
                        principalSchema: "msproadshow",
                        principalTable: "Speeches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpeechAttendees",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AttendeeId = table.Column<Guid>(nullable: false),
                    Comment = table.Column<string>(maxLength: 200, nullable: true),
                    Rating = table.Column<decimal>(nullable: true),
                    SpeechId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeechAttendees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpeechAttendees_Attendees_AttendeeId",
                        column: x => x.AttendeeId,
                        principalSchema: "msproadshow",
                        principalTable: "Attendees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpeechAttendees_Speeches_SpeechId",
                        column: x => x.SpeechId,
                        principalSchema: "msproadshow",
                        principalTable: "Speeches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizzQuestionAnswers",
                schema: "msproadshow",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsCorrect = table.Column<bool>(nullable: false),
                    QuestionId = table.Column<Guid>(nullable: false),
                    Text = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizzQuestionAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuizzQuestionAnswers_QuizzQuestions_QuestionId",
                        column: x => x.QuestionId,
                        principalSchema: "msproadshow",
                        principalTable: "QuizzQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeCity_AttendeesId",
                schema: "msproadshow",
                table: "AttendeeCity",
                column: "AttendeesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttendeeCity_CityId",
                schema: "msproadshow",
                table: "AttendeeCity",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CitySponsors_SponsorId",
                schema: "msproadshow",
                table: "CitySponsors",
                column: "SponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_EvaluateQuestions_CityId",
                schema: "msproadshow",
                table: "EvaluateQuestions",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzQuestionAnswers_QuestionId",
                schema: "msproadshow",
                table: "QuizzQuestionAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizzQuestions_SpeechId",
                schema: "msproadshow",
                table: "QuizzQuestions",
                column: "SpeechId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeechAttendees_AttendeeId",
                schema: "msproadshow",
                table: "SpeechAttendees",
                column: "AttendeeId");

            migrationBuilder.CreateIndex(
                name: "IX_SpeechAttendees_SpeechId_AttendeeId",
                schema: "msproadshow",
                table: "SpeechAttendees",
                columns: new[] { "SpeechId", "AttendeeId" });

            migrationBuilder.CreateIndex(
                name: "IX_Speeches_CityId",
                schema: "msproadshow",
                table: "Speeches",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Speeches_SpeakerId",
                schema: "msproadshow",
                table: "Speeches",
                column: "SpeakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttendeeCity",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "CitySponsors",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "EvaluateQuestions",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "QuizzQuestionAnswers",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "SpeechAttendees",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "Sponsors",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "QuizzQuestions",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "Attendees",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "Speeches",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "msproadshow");

            migrationBuilder.DropTable(
                name: "Speakers",
                schema: "msproadshow");
        }
    }
}
