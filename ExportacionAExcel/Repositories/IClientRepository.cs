using ExportacionAExcel.Models;

namespace ExportacionAExcel.Repositories
{
    public interface IClientRepository
    {
        public ICollection<Cliente> GetClientes();
    }
}
