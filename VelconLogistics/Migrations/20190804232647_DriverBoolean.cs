using Microsoft.EntityFrameworkCore.Migrations;

namespace VelconLogistics.Migrations
{
    public partial class DriverBoolean : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeliverd",
                table: "Driver");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeliverd",
                table: "Load",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cca7fd36-5acd-4432-871b-cbe76778f0b0", "AQAAAAEAACcQAAAAEPq5yr5zhh/wgf6YwZZHSjBU+NipfWuxkO+Yx0hSu4+DwZ9gsTLfzfeuAqflL82JSA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeliverd",
                table: "Load");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeliverd",
                table: "Driver",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ab9b2d9-dffa-4286-a3c2-311d6ca14056", "AQAAAAEAACcQAAAAEDpATFLop10XSCZTvnKvK0gR2S17FwdrCPS6MXYUnW0leDzpJYoHVI/GebqHEF7/lQ==" });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeliverd",
                value: true);

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeliverd",
                value: true);
        }
    }
}
