using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.ETPS4.Grupo13.WebApi.Migrations
{
    public partial class AddStatusColumToSaleHeaderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SaleHeaders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38d43087-3161-487f-a5c2-d8f242d3036a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eecf8e8d-47b6-4ed5-94f8-71423cb6465b", "AQAAAAEAACcQAAAAED3k5iXKdQoxnKvIqfOU0mZKoATRrVjhlXjo+OUK4oyO7t+9Jp6U++gNrHweqvHj5g==", "84876e87-0b20-4c05-971a-a3d60c08dd65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e275eee8-4036-4274-bc77-6e190643ba52",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a98d1104-4543-4ac5-b3ee-2731823899fc", "AQAAAAEAACcQAAAAENGEbNnqC2/G35WlpI4ixMuIrWGT1Yy5AcgAbcsIV6pe0dInbGEKEUCFOqM93JW5Fg==", "0aafb968-f761-4f48-9200-f0f93f5f9e11" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "SaleHeaders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38d43087-3161-487f-a5c2-d8f242d3036a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0ce4fb-bded-4a80-a775-3c7aec5ccba5", "AQAAAAEAACcQAAAAEEdUb2Tshq/W9bGI0mjkjyhjCmWbqfPUioDyWM05CBWJLSZkJQcPtDbv2VNR5IAw7w==", "b855de6e-3905-44a9-be0b-7ce9722d79f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e275eee8-4036-4274-bc77-6e190643ba52",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e52f7af8-8fe6-40f7-bdfc-fc6d6ba6abb9", "AQAAAAEAACcQAAAAEOkIjSu5xxIRqGUxTpnjSWq+0XGy9SzVWqzDW+pzGD+tRk/pr35NKrbc7OjPGdRBKQ==", "0a6acec0-f5cd-48ec-abfc-0215a52a3b7b" });
        }
    }
}
