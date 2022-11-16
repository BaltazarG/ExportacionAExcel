using ExportacionAExcel.Context;
using ExportacionAExcel.Models;
using Microsoft.EntityFrameworkCore;

namespace ExportacionAExcel.Repositories
{
    public class ProductRepository : Repository, IProductRepository
    {
        public ProductRepository(ExcelContext context) : base(context)
        {
        }

        public ICollection<Producto> GetProductos()
        {
            return _context.Productos.AsNoTracking().ToList();
        }
    }
}
