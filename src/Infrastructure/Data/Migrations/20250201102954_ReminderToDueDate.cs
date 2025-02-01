using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MSAFocus_TechnicalAssessment.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReminderToDueDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reminder",
                table: "TodoItems",
                newName: "DueDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DueDate",
                table: "TodoItems",
                newName: "Reminder");
        }
    }
}
