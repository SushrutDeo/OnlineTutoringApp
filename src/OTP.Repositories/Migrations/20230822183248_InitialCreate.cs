﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OTP.Repositories.Migrations
{
	/// <inheritdoc />
	public partial class InitialCreate : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "DocumentType",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_DocumentType", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "EducationLevel",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_EducationLevel", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Gender",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Gender", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Subject",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Subject", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "TeachingPreference",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TeachingPreference", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "TimeRange",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TimeRange", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "UserImage",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					UserId = table.Column<int>(type: "int", nullable: false),
					ImageName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					ImagePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_UserImage", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "WeekDay",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_WeekDay", x => x.Id);
				});

			migrationBuilder.CreateTable(
				name: "Student",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					LinkedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
					EducationLevelId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
					Address1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
					Address2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
					Address3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
					City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					County = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
					GenderId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Student", x => x.Id);
					table.ForeignKey(
						name: "FK_Student_EducationLevel_EducationLevelId",
						column: x => x.EducationLevelId,
						principalTable: "EducationLevel",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_Student_Gender_GenderId",
						column: x => x.GenderId,
						principalTable: "Gender",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "Tutor",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					LinkedUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Introduction = table.Column<string>(type: "nvarchar(max)", nullable: true),
					Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					Rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
					EnhancedDBSChecked = table.Column<bool>(type: "bit", nullable: false),
					RightToWorkVerified = table.Column<bool>(type: "bit", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false),
					FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
					Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
					PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
					Address1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
					Address2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
					Address3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
					City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					County = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
					GenderId = table.Column<int>(type: "int", nullable: true)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Tutor", x => x.Id);
					table.ForeignKey(
						name: "FK_Tutor_Gender_GenderId",
						column: x => x.GenderId,
						principalTable: "Gender",
						principalColumn: "Id");
				});

			migrationBuilder.CreateTable(
				name: "StudentSubject",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					StudentId = table.Column<int>(type: "int", nullable: false),
					SubjectId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_StudentSubject", x => x.Id);
					table.ForeignKey(
						name: "FK_StudentSubject_Student_StudentId",
						column: x => x.StudentId,
						principalTable: "Student",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_StudentSubject_Subject_SubjectId",
						column: x => x.SubjectId,
						principalTable: "Subject",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "TutorAvailibility",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					TutorId = table.Column<int>(type: "int", nullable: false),
					WeekDayId = table.Column<int>(type: "int", nullable: false),
					TimeRangeId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TutorAvailibility", x => x.Id);
					table.ForeignKey(
						name: "FK_TutorAvailibility_TimeRange_TimeRangeId",
						column: x => x.TimeRangeId,
						principalTable: "TimeRange",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_TutorAvailibility_Tutor_TutorId",
						column: x => x.TutorId,
						principalTable: "Tutor",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_TutorAvailibility_WeekDay_WeekDayId",
						column: x => x.WeekDayId,
						principalTable: "WeekDay",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "TutorDocument",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					TutorId = table.Column<int>(type: "int", nullable: false),
					DocumentType = table.Column<int>(type: "int", nullable: false),
					DocumentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
					DocumentPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TutorDocument", x => x.Id);
					table.ForeignKey(
						name: "FK_TutorDocument_Tutor_TutorId",
						column: x => x.TutorId,
						principalTable: "Tutor",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "TutorEducationLevel",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					TutorId = table.Column<int>(type: "int", nullable: false),
					EducationLevelId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TutorEducationLevel", x => x.Id);
					table.ForeignKey(
						name: "FK_TutorEducationLevel_EducationLevel_EducationLevelId",
						column: x => x.EducationLevelId,
						principalTable: "EducationLevel",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_TutorEducationLevel_Tutor_TutorId",
						column: x => x.TutorId,
						principalTable: "Tutor",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "TutorSubject",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					TutorId = table.Column<int>(type: "int", nullable: false),
					SubjectId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TutorSubject", x => x.Id);
					table.ForeignKey(
						name: "FK_TutorSubject_Subject_SubjectId",
						column: x => x.SubjectId,
						principalTable: "Subject",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_TutorSubject_Tutor_TutorId",
						column: x => x.TutorId,
						principalTable: "Tutor",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateTable(
				name: "TutorTeachingPreference",
				columns: table => new
				{
					Id = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					TutorId = table.Column<int>(type: "int", nullable: false),
					TeachingPreferenceId = table.Column<int>(type: "int", nullable: false),
					CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
					IsDeleted = table.Column<bool>(type: "bit", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_TutorTeachingPreference", x => x.Id);
					table.ForeignKey(
						name: "FK_TutorTeachingPreference_TeachingPreference_TeachingPreferenceId",
						column: x => x.TeachingPreferenceId,
						principalTable: "TeachingPreference",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
					table.ForeignKey(
						name: "FK_TutorTeachingPreference_Tutor_TutorId",
						column: x => x.TutorId,
						principalTable: "Tutor",
						principalColumn: "Id",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.InsertData(
				table: "DocumentType",
				columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
				values: new object[,]
				{
					{ 1, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5385), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5386), "Proof Of Address" },
					{ 2, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5388), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5388), "Proof Of Id" },
					{ 3, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5390), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5390), "Proof Of DBS" },
					{ 4, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5391), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5392), "Proof Of Eligibility To Work" }
				});

			migrationBuilder.InsertData(
				table: "EducationLevel",
				columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
				values: new object[,]
				{
					{ 1, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5566), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5567), "Primary" },
					{ 2, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5568), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5568), "Secondary" },
					{ 3, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5569), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5570), "GCSE" },
					{ 4, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5571), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5571), "A Level" },
					{ 5, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5572), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5573), "University" },
					{ 6, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5574), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5574), "Masters" }
				});

			migrationBuilder.InsertData(
				table: "Gender",
				columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
				values: new object[,]
				{
					{ 1, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5639), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5639), "Female" },
					{ 2, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5640), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5641), "Male" }
				});

			migrationBuilder.InsertData(
				table: "Subject",
				columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
				values: new object[,]
				{
					{ 1, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5715), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5715), "English" },
					{ 2, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5716), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5717), "Maths" },
					{ 3, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5718), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5718), "Physics" },
					{ 4, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5719), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5720), "Chemistry" },
					{ 5, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5720), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5721), "Biology" }
				});

			migrationBuilder.InsertData(
				table: "TeachingPreference",
				columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
				values: new object[,]
				{
					{ 1, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5791), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5791), "Online" },
					{ 2, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5792), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5793), "Student's Home" },
					{ 3, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5794), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5794), "Tutor's Home" }
				});

			migrationBuilder.InsertData(
				table: "TimeRange",
				columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
				values: new object[,]
				{
					{ 1, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5858), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5858), "Before 12" },
					{ 2, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5859), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5860), "12 - 5 pm" },
					{ 3, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5861), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5861), "After 5 pm" }
				});

			migrationBuilder.InsertData(
				table: "WeekDay",
				columns: new[] { "Id", "CreatedDate", "IsDeleted", "ModifiedDate", "Name" },
				values: new object[,]
				{
					{ 1, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5917), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5917), "Sunday" },
					{ 2, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5918), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5919), "Monday" },
					{ 3, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5920), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5920), "Tuesday" },
					{ 4, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5921), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5922), "Wednesday" },
					{ 5, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5922), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5923), "Thursday" },
					{ 6, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5924), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5924), "Friday" },
					{ 7, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5925), false, new DateTime(2023, 8, 22, 18, 32, 47, 942, DateTimeKind.Utc).AddTicks(5925), "Saturday" }
				});

			migrationBuilder.CreateIndex(
				name: "IX_Student_EducationLevelId",
				table: "Student",
				column: "EducationLevelId");

			migrationBuilder.CreateIndex(
				name: "IX_Student_GenderId",
				table: "Student",
				column: "GenderId");

			migrationBuilder.CreateIndex(
				name: "IX_StudentSubject_StudentId",
				table: "StudentSubject",
				column: "StudentId");

			migrationBuilder.CreateIndex(
				name: "IX_StudentSubject_SubjectId",
				table: "StudentSubject",
				column: "SubjectId");

			migrationBuilder.CreateIndex(
				name: "IX_Tutor_GenderId",
				table: "Tutor",
				column: "GenderId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorAvailibility_TimeRangeId",
				table: "TutorAvailibility",
				column: "TimeRangeId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorAvailibility_TutorId",
				table: "TutorAvailibility",
				column: "TutorId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorAvailibility_WeekDayId",
				table: "TutorAvailibility",
				column: "WeekDayId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorDocument_TutorId",
				table: "TutorDocument",
				column: "TutorId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorEducationLevel_EducationLevelId",
				table: "TutorEducationLevel",
				column: "EducationLevelId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorEducationLevel_TutorId",
				table: "TutorEducationLevel",
				column: "TutorId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorSubject_SubjectId",
				table: "TutorSubject",
				column: "SubjectId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorSubject_TutorId",
				table: "TutorSubject",
				column: "TutorId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorTeachingPreference_TeachingPreferenceId",
				table: "TutorTeachingPreference",
				column: "TeachingPreferenceId");

			migrationBuilder.CreateIndex(
				name: "IX_TutorTeachingPreference_TutorId",
				table: "TutorTeachingPreference",
				column: "TutorId");

			string sql = @"Create Procedure dbo.uspSetStudentDataFromIdentityServerData

							As

								Begin

									Update S

									Set S.Address1 = U.Address1, S.Address2 = U.Address2, S.Address3 = U.Address3, S.City = U.City, S.DateOfBirth = U.DateOfBirth, S.Email = U.Email,
									S.FirstName = U.FirstName, S.GenderId = U.GenderId, S.LastName = U.LastName, S.PhoneNumber = U.PhoneNumber

									From Student S

									Inner Join IdentityServerOTP.dbo.AspNetUsers U On U.Id = S.LinkedUserId

								End

							Go";

			migrationBuilder.Sql(sql);

			sql = @"Create Procedure dbo.uspSetTutorDataFromIdentityServerData

					As

						Begin

							Update T

							Set T.Address1 = U.Address1, T.Address2 = U.Address2, T.Address3 = U.Address3, T.City = U.City, T.DateOfBirth = U.DateOfBirth, T.Email = U.Email,
							T.FirstName = U.FirstName, T.GenderId = U.GenderId, T.LastName = U.LastName, T.PhoneNumber = U.PhoneNumber

							From Tutor T

							Inner Join IdentityServerOTP.dbo.AspNetUsers U On U.Id = T.LinkedUserId

						End

					Go";

			migrationBuilder.Sql(sql);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "DocumentType");

			migrationBuilder.DropTable(
				name: "StudentSubject");

			migrationBuilder.DropTable(
				name: "TutorAvailibility");

			migrationBuilder.DropTable(
				name: "TutorDocument");

			migrationBuilder.DropTable(
				name: "TutorEducationLevel");

			migrationBuilder.DropTable(
				name: "TutorSubject");

			migrationBuilder.DropTable(
				name: "TutorTeachingPreference");

			migrationBuilder.DropTable(
				name: "UserImage");

			migrationBuilder.DropTable(
				name: "Student");

			migrationBuilder.DropTable(
				name: "TimeRange");

			migrationBuilder.DropTable(
				name: "WeekDay");

			migrationBuilder.DropTable(
				name: "Subject");

			migrationBuilder.DropTable(
				name: "TeachingPreference");

			migrationBuilder.DropTable(
				name: "Tutor");

			migrationBuilder.DropTable(
				name: "EducationLevel");

			migrationBuilder.DropTable(
				name: "Gender");
		}
	}
}