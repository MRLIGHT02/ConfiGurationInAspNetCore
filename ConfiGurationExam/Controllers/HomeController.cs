using Microsoft.AspNetCore.Mvc;

namespace ConfiGurationExam.Controllers
{
    public class HomeController : Controller
    {
        IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [Route("/")]
        public IActionResult Index()
        {
           //var data= "Secrect Key: "+ _configuration["DataJson:ClientSecrect"] +"\nClient Id: "+ _configuration["DataJson:ClientId"];
           var data= _configuration.GetSection("DataJson").Get<DataJsonOptions>();
            var result = new Dictionary<string, string>();


            

            return Ok(data);
        }
    }
}
