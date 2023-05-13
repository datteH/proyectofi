using AspNetCore.Reporting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Proyecto.ETPS4.Grupo13.Web.DsGlobalTableAdapters;
using System.Data;
using System.Text;

namespace Proyecto.ETPS4.Grupo13.Web.Controllers
{
    [Route("reports")]
    [Authorize]
    public class ReportsController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public ReportsController(IWebHostEnvironment environment)
        {
            _environment = environment;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("products")]
        public IActionResult PrintProducts()
        {
            var dt = new ProductsViewTableAdapter();
            string mimetype = "";
            int extension = 1;
            var path = $"{_environment.WebRootPath}\\Reporting\\ProductsReport.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            LocalReport lr = new LocalReport(path);
            lr.AddDataSource("DsProducts", dt.GetData().Rows);
            var result = lr.Execute(RenderType.Pdf, extension, parameters, mimetype);

            return File(result.MainStream, "application/pdf");
        }

        [HttpGet("sales")]
        public IActionResult PrintSales()
        {
            var dt = new SalesViewTableAdapter();
            string mimetype = "";
            int extension = 1;
            var path = $"{_environment.WebRootPath}\\Reporting\\SalesReport.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            LocalReport lr = new LocalReport(path);
            lr.AddDataSource("DsSales", dt.GetData().Rows);
            var result = lr.Execute(RenderType.Pdf, extension, parameters, mimetype);

            return File(result.MainStream, "application/pdf");
        }

        [HttpGet("purchases")]
        public IActionResult PrintPurchases()
        {
            var dt = new PurchasesViewTableAdapter();
            string mimetype = "";
            int extension = 1;
            var path = $"{_environment.WebRootPath}\\Reporting\\PurchasesReport.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            LocalReport lr = new LocalReport(path);
            lr.AddDataSource("DsPurchases", dt.GetData().Rows);
            var result = lr.Execute(RenderType.Pdf, extension, parameters, mimetype);

            return File(result.MainStream, "application/pdf");
        }
    }
}
