using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index(int id, int page)
		{
			return View();
		}
	}
}
