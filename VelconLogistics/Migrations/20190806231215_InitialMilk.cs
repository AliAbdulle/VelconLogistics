using Microsoft.EntityFrameworkCore.Migrations;

namespace VelconLogistics.Migrations
{
    public partial class InitialMilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_AspNetUsers_ApplicationUserId",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Driver",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_ApplicationUserId",
                table: "Driver",
                newName: "IX_Driver_UserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_AspNetUsers_UserId",
                table: "Driver",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_AspNetUsers_UserId",
                table: "Driver");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Driver",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_UserId",
                table: "Driver",
                newName: "IX_Driver_ApplicationUserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "66954ff9-2f53-458c-9614-9c24abbe1a0a", "AQAAAAEAACcQAAAAEJW7kDAIj73X7KJS2XhR58EXw6TTk2e0RocCWEHCRMzkeM/6v90lDhNK3/gLOVYpKw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-kkkk-kkkk-kkkk-kkkkkkkkkkkk",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffe4d748-f62f-4835-af69-71a5b6525b2e", "AQAAAAEAACcQAAAAEE2mV4/i8a90gjgIpsoCJTvtDRilnfeMkxXrThRY+B2MHKT5bYsKe7/lMxk2SQmvkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-nnnn-nnnn-nnnn-nnnnnnnnnnnn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38a69e6e-7c5f-4b8e-a674-8a7e883c182b", "AQAAAAEAACcQAAAAECsao8BIhTexZNW7ExWb6HFL693CXEoF5XWPN9r8JmEVjfQbV30DUGGAjfAdVrMALw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_AspNetUsers_ApplicationUserId",
                table: "Driver",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
