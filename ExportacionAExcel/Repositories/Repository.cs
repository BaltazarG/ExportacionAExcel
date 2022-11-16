
using ExportacionAExcel.Context;
using ExportacionAExcel.Models;
using System.Data;

namespace ExportacionAExcel.Repositories
{
    public class Repository : IRepository
    {
        internal readonly ExcelContext _context;

        public Repository(ExcelContext context)
        {
            _context = context;
        }
    }
}

