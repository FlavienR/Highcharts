namespace JSONAPI.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using System.Web.Http.Results;

    using JSONAPI.Models;

    /// <summary>
    /// JSON controller
    /// </summary>
    public class JsonController : ApiController
    {
        private List<Data> DataList = new List<Data>();

        public JsonResult<List<Data>> Get()
        {
            DataList.Add(new Data("Firefox", 11.61 * (1 + GetRandomNumber(0, 20)/ 500)));
            DataList.Add(new Data("IE", 13.17* (1 + GetRandomNumber(0, 20)/ 500)));
            DataList.Add(new Data("Chrome", 44.33* (1 + GetRandomNumber(0, 10)/ 500)));
            DataList.Add(new Data("Safari", 12.93* (1 + GetRandomNumber(0, 20)/ 500)));
            DataList.Add(new Data("Opera", 3.99* (1 + GetRandomNumber(0, 30)/ 500)));
            DataList.Add(new Data("Android", 6.55* (1 + GetRandomNumber(0, 10)/ 500)));
            DataList.Add(new Data("Others", Math.Abs(100 - DataList.Sum(p => p.y))));

            return Json(DataList);
        }

        private double GetRandomNumber(double minimum, double maximum)
        {
            Random random = new Random();
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
