using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
