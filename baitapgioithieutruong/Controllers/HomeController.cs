using System.Web.Mvc;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        ViewBag.message = "Chào mừng bạn đến với đại học Nguyễn Trãi ";
        return View();
    }

    public ActionResult About()
    {
        ViewBag.message = "Giới thiệu về trường của em";
        return View();
    }

    public ActionResult Contact()
    {
        ViewBag.message = "Thông tin liên hệ";
        return View();
    }
}
