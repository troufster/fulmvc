using System.Linq;
using System.Management;
using System.Web.Mvc;

namespace fulmvc.Areas.Majorbyte.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Majorbyte/Major/

        public ActionResult Index()
        {
            return View();
        }

        public string Cpu()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                 (@"\\.\root\CIMV2",
                  "SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor WHERE Name=\"_Total\"");

            ManagementObjectCollection collection = searcher.Get();
            ManagementObject queryObj = collection.Cast<ManagementObject>().First();
            return queryObj["PercentIdleTime"].ToString(); ;
        }

        public ActionResult WebWorker()
        {
            return View();
        }
    }
}
