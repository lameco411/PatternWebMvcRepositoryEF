using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class BaseController : Controller
    {
        protected AppRepository app = new();
    }
}
