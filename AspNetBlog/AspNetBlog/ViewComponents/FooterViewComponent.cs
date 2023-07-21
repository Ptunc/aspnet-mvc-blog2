using Microsoft.AspNetCore.Mvc;

namespace AspNetBlog.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();

        }
    }
}
