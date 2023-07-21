using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Detail(int id)
        {
            return View();
        }
		public IActionResult Contact()
		{
			return View();
		}
	}
}
