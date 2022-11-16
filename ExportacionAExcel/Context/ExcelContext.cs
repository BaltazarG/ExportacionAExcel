using ExportacionAExcel.Models;
using Microsoft.EntityFrameworkCore;

namespace ExportacionAExcel.Context
{
    public class ExcelContext : DbContext
    {
        public ExcelContext(DbContextOptions<ExcelContext> options)
       : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 1,
                Apellido = "Lopez",
                Direccion = "Pellegrini",
                Email = "lopez@gmail.com",
                Nombre = "Carlos",
                Pais = "Argentina",
                Telefono = "12345"
            });

            builder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 2,
                Apellido = "Garcia",
                Direccion = "Pellegrini",
                Email = "garcia@gmail.com",
                Nombre = "Julio",
                Pais = "Argentina",
                Telefono = "2312321135"
            });

            builder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 3,
                Apellido = "Romero",
                Direccion = "Belgrano",
                Email = "romero@gmail.com",
                Nombre = "Hugo",
                Pais = "Argentina",
                Telefono = "4421421124"
            });

            builder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 4,
                Apellido = "Gimenez",
                Direccion = "9 de julio",
                Email = "gimenez@gmail.com",
                Nombre = "Marcos",
                Pais = "Argentina",
                Telefono = "514314114"
            });

            builder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 5,
                Apellido = "Messi",
                Direccion = "25 de mayo",
                Email = "messi@gmail.com",
                Nombre = "Lionel",
                Pais = "Argentina",
                Telefono = "101001010"
            });

            builder.Entity<Cliente>().HasData(new Cliente
            {
                Id = 6,
                Apellido = "Gutierrez",
                Direccion = "Hernandarias",
                Email = "gutierrez@gmail.com",
                Nombre = "Gael",
                Pais = "Argentina",
                Telefono = "23151111"
            });

            builder.Entity<Producto>().HasData(new Producto
            {
                Id = 1,
                Name = "Camiseta de Argentina",
                Price = 17000,
            });

            builder.Entity<Producto>().HasData(new Producto
            {
                Id = 2,
                Name = "Short de Argentina",
                Price = 9500,
            });

            builder.Entity<Producto>().HasData(new Producto
            {
                Id = 3,
                Name = "Campera de Argentina",
                Price = 24400,
            });



            base.OnModelCreating(builder);
        }
    }
}
