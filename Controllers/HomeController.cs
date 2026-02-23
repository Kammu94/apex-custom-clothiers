using Microsoft.AspNetCore.Mvc;

namespace ApexCustomClothiers.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var homeData = new
            {
                Title = "Welcome to Apex Custom Clothiers",
                Subtitle = "Tailored Just For You",
                Description = "Discover the perfect fit and style with our custom clothing options."
            }; 
            return Json(homeData);
        }
    }
}