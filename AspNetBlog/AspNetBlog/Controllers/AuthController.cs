using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult ForgotPassword()
		{
			return View();
		}
		public IActionResult Register()
		{
			return View();
		}
		public IActionResult Login(string redirectUrl)
		{
			return View();
		}
	}
}
