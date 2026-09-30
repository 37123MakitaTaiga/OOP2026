using Microsoft.AspNetCore.Mvc;


namespace MvcBasicSample.Controllers;

//URLのHelloに対応する要求を受け取るController
public class HelloController : Controller{
    
    // /Hello/Indexで呼び出されるAction
    public IActionResult Index() {
        //Viewを使用せず文字列をHTTPの対応として返す
        //return Content("初めてのAPS.NET Core");
        return View();
    }
}
