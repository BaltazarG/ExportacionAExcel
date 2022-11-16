using ExportacionAExcel.Context;
using ExportacionAExcel.Models;
using Microsoft.EntityFrameworkCore;

namespace ExportacionAExcel.Repositories
{
    public class ClientRepository : Repository, IClientRepository
    {
        public ClientRepository(ExcelContext context) : base(context)
        {
        }

        public ICollection<Cliente> GetClientes()
        {
            return _context.Clientes.AsNoTracking().ToList();
        }
    }
}
