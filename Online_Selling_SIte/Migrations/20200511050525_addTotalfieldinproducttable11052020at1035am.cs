using Microsoft.EntityFrameworkCore.Migrations;

namespace Online_Selling_SIte.Migrations
{
    public partial class addTotalfieldinproducttable11052020at1035am : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Total",
                table: "Products",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Products");
        }
    }
}
