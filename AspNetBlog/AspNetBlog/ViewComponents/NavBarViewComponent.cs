using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.ViewComponents
{
    public class NavBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
