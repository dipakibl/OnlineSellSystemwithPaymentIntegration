using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Selling_SIte.Migrations
{
    public partial class addreceipturlinorder13052020at0410pm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReceiptUrl",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReceiptUrl",
                table: "Orders");
        }
    }
}
