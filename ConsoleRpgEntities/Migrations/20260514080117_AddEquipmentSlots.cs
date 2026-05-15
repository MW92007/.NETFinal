using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleRpgEntities.Migrations
{
    /// <inheritdoc />
    public partial class AddEquipmentSlots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Slot",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "MonsterType",
                table: "Monsters",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(8)",
                oldMaxLength: 8);

            migrationBuilder.AddColumn<int>(
                name: "ConsumptionSpeed",
                table: "Monsters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EligibleSlot",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EquipmentSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlotType = table.Column<int>(type: "int", nullable: false),
                    EquippedItemId = table.Column<int>(type: "int", nullable: true),
                    EquipmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentSlots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentSlots_Containers_EquipmentId",
                        column: x => x.EquipmentId,
                        principalTable: "Containers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentSlots_Items_EquippedItemId",
                        column: x => x.EquippedItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSlots_EquipmentId",
                table: "EquipmentSlots",
                column: "EquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentSlots_EquippedItemId",
                table: "EquipmentSlots",
                column: "EquippedItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentSlots");

            migrationBuilder.DropColumn(
                name: "ConsumptionSpeed",
                table: "Monsters");

            migrationBuilder.DropColumn(
                name: "EligibleSlot",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "MonsterType",
                table: "Monsters",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Slot",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
