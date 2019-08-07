using Microsoft.EntityFrameworkCore.Migrations;

namespace VelconLogistics.Migrations
{
    public partial class InitialEdit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5e28a644-9a7e-4bb6-b547-7d9ad7de1752", "AQAAAAEAACcQAAAAEHX6xHPZ9GQcQ4ENn3jzfYyVMGA0IzV2iQpiWHeLnty1WcInbtHOAvSav/kOKxEoDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3d68b54-d5aa-45f7-b91d-c23f6ba09b6c", "AQAAAAEAACcQAAAAEAdN5BUhDVkAvMW5jqJ2rjQ54XvNE8bDHRNsZ5xYRIM95i8AeWMpAbfbUhfRggmm6Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-nnnn-nnnn-nnnn-nnnnnnnnnnnn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "75368c2d-408e-4236-b7e0-b3d62fb4b37f", "AQAAAAEAACcQAAAAEPQMTXzt30V/hV0LB4ILKa3FRP96PXWp10NzZa90lvvLou0Vf5GX1iJJgT/mwcr0Iw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1742ec1a-a4d6-41af-bb17-a4ab94d9f529", "AQAAAAEAACcQAAAAEF/rUKUuCEhhvJo+JhdaSc6si7BWuB3BKkgmjhQZ/qGJS45IY/ZnLtqDR+2lgR5AjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4edbad40-a5c1-40f8-b6fd-50b619446cd8", "AQAAAAEAACcQAAAAEC5E7Nxe2N9rrE0HBgjVjqvjoW969Q4uRulNx0DtQuNKIIJ4Jh5kGaPc51xDwVaKJQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-nnnn-nnnn-nnnn-nnnnnnnnnnnn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9c6e33e0-86bf-4b0e-8146-93a10cbf7377", "AQAAAAEAACcQAAAAEJEBE4nTRnRu4GV+FUsInWuDLQwkI12rZ+nTbdO3PFjdGp3DCl/TVzvXJ8wO7GmYiA==" });
        }
    }
}
