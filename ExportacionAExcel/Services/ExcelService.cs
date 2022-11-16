using ExportacionAExcel.Repositories;
using OfficeOpenXml;

namespace ExportacionAExcel.Services
{
    public class ExcelService : IExcelService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IProductRepository _productRepository;
        public ExcelService(IClientRepository clientRepository, IProductRepository productRepository)
        {
            _clientRepository = clientRepository;
            _productRepository = productRepository;
        }
        public byte[] ExportExcel()
        {
            var products = _productRepository.GetProductos();
            var clients = _clientRepository.GetClientes();

            using (var arch = new ExcelPackage())
            {
                var worksheetClients = arch.Workbook.Worksheets.Add("Clientes");
                worksheetClients.Cells["A1"].LoadFromCollection(clients, PrintHeaders: true);
                for (var col = 1; col < clients.Count + 1; col++)
                {
                    worksheetClients.Column(col).AutoFit();
                    worksheetClients.Column(col).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                };

                worksheetClients.TabColor = System.Drawing.Color.Red;
                worksheetClients.Row(1).Style.Font.Color.SetColor(System.Drawing.Color.Purple);


                var tableClients = worksheetClients.Tables.Add(new ExcelAddressBase(fromRow: 1, fromCol: 1, toRow: clients.Count + 1, toColumn: 7), "Clientes");
                tableClients.ShowHeader = true;
                tableClients.TableStyle = OfficeOpenXml.Table.TableStyles.Light4;
                tableClients.ShowTotal = true;



                var worksheetProducts = arch.Workbook.Worksheets.Add("Productos");
                worksheetProducts.Cells["A1"].LoadFromCollection(products, PrintHeaders: true);
                for (var col = 1; col < clients.Count + 1; col++)
                {
                    worksheetProducts.Column(col).AutoFit();
                    worksheetProducts.Column(col).Style.Font.Italic = true;
                    worksheetProducts.Column(col).Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                };

                worksheetProducts.TabColor = System.Drawing.Color.Green;
                worksheetProducts.Row(1).Style.Font.Color.SetColor(System.Drawing.Color.Purple);
                worksheetProducts.Column(3).Style.Font.Bold = true;

                var tableProducts = worksheetProducts.Tables.Add(new ExcelAddressBase(fromRow: 1, fromCol: 1, toRow: products.Count + 1, toColumn: 3), "Productos");
                tableProducts.ShowHeader = true;
                tableProducts.TableStyle = OfficeOpenXml.Table.TableStyles.Light4;
                tableProducts.ShowTotal = true;


                var total = 0.0;
                foreach (var item in products)
                {
                    total = total + item.Price;
                }

                worksheetProducts.Cells[products.Count + 4, 1].Value = "Total";
                worksheetProducts.Cells[products.Count + 4, 3].Value = $"$ {total}";

                worksheetProducts.Cells[products.Count + 6, 1].Value = "Total+IVA";
                worksheetProducts.Cells[products.Count + 6, 3].Value = $"$ {total * 1.21}";

                return arch.GetAsByteArray();
            };

        }
    }
}
