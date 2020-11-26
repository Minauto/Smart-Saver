using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Provider;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        Account account = new Account();
        SQLLoginReader sqlLogRead = new SQLLoginReader();

        private static readonly string[] Summaries = new[]
        {

            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        /*
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        */
        [HttpGet]
        public Account GetAccount()
        {
            account = sqlLogRead.Read("Minde");
            return account;
        }

        // GET api/weatherforecast/firstName
        //                                                          GET api/weatherforecast?firstName=
        [HttpGet("{firstName}")]
        public Account GetAccountWithParameters(string firstName)
        {
            account = sqlLogRead.Read(firstName);
            return account;
        }
    }
}
