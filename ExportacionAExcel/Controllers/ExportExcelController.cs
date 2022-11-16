using ExportacionAExcel.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExportacionAExcel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportExcelController : ControllerBase
    {
        private readonly IExcelService _excelService;

        public ExportExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        [HttpGet]
        public IActionResult ExportarExcel()
        {
            var excelContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            return File(_excelService.ExportExcel(), excelContentType, "Clientes.xlsx");
        }
    }
}
