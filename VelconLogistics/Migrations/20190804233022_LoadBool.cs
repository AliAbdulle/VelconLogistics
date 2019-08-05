using Microsoft.EntityFrameworkCore.Migrations;

namespace VelconLogistics.Migrations
{
    public partial class LoadBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd1adcdc-f562-4b55-9067-282bc7460d6b", "AQAAAAEAACcQAAAAEOtdrF5aFlGrzP6XeQbxA0B/wzrg+ohaCDjCNqb0moFREVrTdRBn2lTzEQgnsNOkeQ==" });

            migrationBuilder.UpdateData(
                table: "Load",
                keyColumn: "LoadId",
                keyValue: 1,
                column: "IsDeliverd",
                value: true);

            migrationBuilder.UpdateData(
                table: "Load",
                keyColumn: "LoadId",
                keyValue: 2,
                column: "IsDeliverd",
                value: true);

            migrationBuilder.UpdateData(
                table: "Load",
                keyColumn: "LoadId",
                keyValue: 3,
                column: "IsDeliverd",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cca7fd36-5acd-4432-871b-cbe76778f0b0", "AQAAAAEAACcQAAAAEPq5yr5zhh/wgf6YwZZHSjBU+NipfWuxkO+Yx0hSu4+DwZ9gsTLfzfeuAqflL82JSA==" });

            migrationBuilder.UpdateData(
                table: "Load",
                keyColumn: "LoadId",
                keyValue: 1,
                column: "IsDeliverd",
                value: false);

            migrationBuilder.UpdateData(
                table: "Load",
                keyColumn: "LoadId",
                keyValue: 2,
                column: "IsDeliverd",
                value: false);

            migrationBuilder.UpdateData(
                table: "Load",
                keyColumn: "LoadId",
                keyValue: 3,
                column: "IsDeliverd",
                value: false);
        }
    }
}
