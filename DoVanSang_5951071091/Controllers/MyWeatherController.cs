using DoVanSang_5951071091.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DoVanSang_5951071091.Controllers
{
    public class MyWeatherController : ApiController
    {
        // GET: api/MyWeather
        public IEnumerable<MyWeatherInfo> Get()
        {
            var myWeatherInlist = new List<MyWeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                var MyWeatherInfo = new MyWeatherInfo
                {
                    MyLocation = $"Location {i}",
                    MyDegree = i * 23 / 17,
                    MyDateTime = DateTime.Now.ToUniversalTime()
                };
                myWeatherInlist.Add(MyWeatherInfo);
            }

            return myWeatherInlist;
        }

        // GET: api/MyWeather/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/MyWeather
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MyWeather/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MyWeather/5
        public void Delete(int id)
        {
        }
    }
}
