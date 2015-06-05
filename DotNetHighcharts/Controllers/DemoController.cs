namespace DotNetHighcharts.Controllers
{
    using System.Web.Mvc;
    using System.Drawing;

    using hc = DotNet.Highcharts;

    public class DemoController : Controller
    {
        // GET: Demo

        #region Public Methods and Operators

        public ActionResult Index()
        {
            var pieChart = new hc.Highcharts("pieChart");
            return View(pieChart);
        }

        #endregion
    }
}