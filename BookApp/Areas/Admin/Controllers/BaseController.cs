using Microsoft.AspNetCore.Mvc;

namespace WebApp.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
       protected AppRepository app = new AppRepository();  
    }
}
