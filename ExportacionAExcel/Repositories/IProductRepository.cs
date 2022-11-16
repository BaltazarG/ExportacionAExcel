using ExportacionAExcel.Models;

namespace ExportacionAExcel.Repositories
{
    public interface IProductRepository
    {
        public ICollection<Producto> GetProductos();
    }
}
