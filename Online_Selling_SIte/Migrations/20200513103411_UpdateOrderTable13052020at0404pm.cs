using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Selling_SIte.Migrations
{
    public partial class UpdateOrderTable13052020at0404pm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Payment_TransactionId",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Payment_TransactionId",
                table: "Orders");
        }
    }
}
