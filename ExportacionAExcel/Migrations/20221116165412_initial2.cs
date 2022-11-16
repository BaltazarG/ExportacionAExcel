using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExportacionAExcel.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellido", "Email", "Nombre", "Telefono" },
                values: new object[] { "Lopez", "lopez@gmail.com", "Carlos", "12345" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Apellido", "Direccion", "Email", "Nombre", "Pais", "Telefono" },
                values: new object[,]
                {
                    { 2, "Garcia", "Pellegrini", "garcia@gmail.com", "Julio", "Argentina", "2312321135" },
                    { 3, "Romero", "Belgrano", "romero@gmail.com", "Hugo", "Argentina", "4421421124" },
                    { 4, "Gimenez", "9 de julio", "gimenez@gmail.com", "Marcos", "Argentina", "514314114" },
                    { 5, "Messi", "25 de mayo", "messi@gmail.com", "Lionel", "Argentina", "101001010" },
                    { 6, "Gutierrez", "Hernandarias", "gutierrez@gmail.com", "Gael", "Argentina", "23151111" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Apellido", "Email", "Nombre", "Telefono" },
                values: new object[] { "Garcia", "garcia@gmail.com", "Julio", "2312321135" });
        }
    }
}
