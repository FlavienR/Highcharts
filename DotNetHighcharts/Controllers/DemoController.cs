using System.Drawing;
using System.Web.Mvc;

namespace DotNetHighcharts.Controllers
{
    using hc = DotNet.Highcharts;

    public class DemoController : Controller
    {
        // GET: DotNetHighChartsDemo
        public ActionResult Index()
        {
            var pieChart = new hc.Highcharts("pieChart");

            pieChart.InitChart(new hc.Options.Chart());
            pieChart.SetTitle(new hc.Options.Title {Text = "Browser market shares, 2014"});
            pieChart.SetSeries(new hc.Options.Series
            {
                Type = hc.Enums.ChartTypes.Pie,
                Data = new hc.Helpers.Data(new[]
                {
                    new hc.Options.Point
                    {
                        Name = "Firefox",
                        Y = 45.0
                    },
                    new hc.Options.Point
                    {
                        Name = "IE",
                        Y = 26.8
                    },
                    new hc.Options.Point
                    {
                        Name = "Chrome",
                        Y = 12.8,
                        Sliced = true,
                        Color = Color.Red
                    },
                    new hc.Options.Point
                    {
                        Name = "Safari",
                        Y = 8.5
                    },
                    new hc.Options.Point
                    {
                        Name = "Opera",
                        Y = 6.2
                    },
                    new hc.Options.Point
                    {
                        Name = "Others",
                        Y = 0.7
                    }
                })
            });

            return View(pieChart);
        }
    }
}