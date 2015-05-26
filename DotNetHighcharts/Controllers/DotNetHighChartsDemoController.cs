namespace DotNetHighcharts.Controllers
{
    using System.Drawing;
    using System.Web.Mvc;

    using DotNet.Highcharts;
    using DotNet.Highcharts.Enums;
    using DotNet.Highcharts.Helpers;
    using DotNet.Highcharts.Options;

    using Point = DotNet.Highcharts.Options.Point;

    public class DotNetHighChartsDemoController : Controller
    {
        // GET: DotNetHighChartsDemo
        public ActionResult Index()
        {
            Highcharts chart = new Highcharts("chart")
                .InitChart(new Chart())
                .SetTitle(new Title { Text = "Browser market shares, 2014" })
               .SetSeries(new Series
                {
                    Type = ChartTypes.Pie,
                    Data = new Data(new object[]
                    {
                        new object[] { "Firefox", 45.0 },
                        new object[] { "IE", 26.8 },
                        new Point
                        {
                            Name = "Chrome",
                            Y = 12.8,
                            Sliced = true,
                            Color = Color.Red
                        },
                        new object[] { "Safari", 8.5 },
                        new object[] { "Opera", 6.2 },
                        new object[] { "Others", 0.7 }
                    })
                });

            return View(chart);
        }
    }
}