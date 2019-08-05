using Microsoft.EntityFrameworkCore.Migrations;

namespace VelconLogistics.Migrations
{
    public partial class LoadSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd375809-169e-4c16-a103-2b2acb174835", "AQAAAAEAACcQAAAAEBKxYzd8H5HWc89GnDvWNMOI53STGnmyHtK8orQktZCIcMbjGSQWRiMjM9dBfaueHQ==" });

            migrationBuilder.UpdateData(
                table: "Load",
                keyColumn: "LoadId",
                keyValue: 2,
                column: "IsDeliverd",
                value: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                column: "IsDeliverd",
                value: true);
        }
    }
}
