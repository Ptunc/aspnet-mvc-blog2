using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.ViewComponents
{
	public class SideBarViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{

			return View();

		}
	}
}
