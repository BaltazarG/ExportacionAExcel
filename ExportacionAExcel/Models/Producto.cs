using System.ComponentModel.DataAnnotations;

namespace ExportacionAExcel.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
