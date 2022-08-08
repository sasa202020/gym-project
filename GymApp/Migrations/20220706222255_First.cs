using Microsoft.EntityFrameworkCore.Migrations;

namespace GymApp.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOuts_ExercisesTypes_ExerciseTypeId",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "WorkOuts");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Exercises");

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseTypeId",
                table: "WorkOuts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOuts_ExercisesTypes_ExerciseTypeId",
                table: "WorkOuts",
                column: "ExerciseTypeId",
                principalTable: "ExercisesTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkOuts_ExercisesTypes_ExerciseTypeId",
                table: "WorkOuts");

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseTypeId",
                table: "WorkOuts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "WorkOuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Exercises",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkOuts_ExercisesTypes_ExerciseTypeId",
                table: "WorkOuts",
                column: "ExerciseTypeId",
                principalTable: "ExercisesTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
