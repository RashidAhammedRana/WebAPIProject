using Microsoft.AspNetCore.Mvc;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet(Name = "GetInt")]
        public int GetInt(int id)
        {
            return id;
        }
    }
}
