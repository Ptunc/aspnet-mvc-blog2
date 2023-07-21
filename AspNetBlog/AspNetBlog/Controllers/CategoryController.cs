using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Software(int id, int page)
		{
			return View();
		}
        public IActionResult Innovation(int id, int page)
        {
            return View();
        }
        public IActionResult Trends(int id, int page)
        {
            return View();
        }
        public IActionResult Social(int id, int page)
        {
            return View();
        }

        public IActionResult BlogSingle(int id, int page)
        {
            return View();
        }
		public IActionResult Index(int id, int page)
		{
			return View();
		}
	}
}
