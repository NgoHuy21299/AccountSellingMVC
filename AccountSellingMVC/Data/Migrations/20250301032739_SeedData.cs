using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccountSellingMVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "CreatedAt", "Password", "RecoveryEmail", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8979), "qn30mqmm", "4tfa2nff77@nguyenmail.top", null, "4qa7ma3m@c.cmkee.life" },
                    { 2, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8982), "1cksbx7o", "e529nid7a@nguyenmail.top", null, "vn5c2n45@c.cmkee.life" },
                    { 3, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8984), "nrkq5159", "umlddfrd@nguyenmail.top", null, "7tb4g6vl@c.cmkee.life" },
                    { 4, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8986), "14lbf3nc", "2776amyzv@nguyenmail.top", null, "r0mbh3tz@c.cmkee.life" },
                    { 5, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8988), "wzg3a8if", "fh5etxbn@nguyenmail.top", null, "v8vgfmpn@c.cmkee.life" },
                    { 6, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8991), "ng2f509e", "998bekgyp@nguyenmail.top", null, "z1hvkld2@c.cmkee.life" },
                    { 7, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8993), "vo0tn80s", "d4qs3klqh@nguyenmail.top", null, "mq3rvwmy@c.cmkee.life" },
                    { 8, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8995), "shb3ppr3", "xqq3fi17@nguyenmail.top", null, "7cq1xt3f@c.cmkee.life" },
                    { 9, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8996), "qmlxskwg", "ovgfoxdui9@nguyenmail.top", null, "i4ntmlot@c.cmkee.life" },
                    { 10, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(8999), "bgzgy62l", "h9a5ovfbhn@nguyenmail.top", null, "ozc5hvb9@c.cmkee.life" },
                    { 11, new DateTime(2025, 3, 1, 3, 27, 39, 124, DateTimeKind.Utc).AddTicks(9067), "4iowfnuq", "3ksn5d6r@nguyenmail.top", null, "3412tp9l@c.cmkee.life" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
