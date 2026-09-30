using Microsoft.AspNetCore.Mvc;
using MvcBasicSample.Models;


namespace MvcBasicSample.Controllers;

//URLのHelloに対応する要求を受け取るController
public class HelloController : Controller{
    
    // /Hello/Indexで呼び出されるAction
    public IActionResult Index() {
        //Productを複数まとめる一覧を作る
        var products = new List<Product> {

            new Product {
            Name = "ハンバーガー",    //１件目の商品名
            Price = 500               //１件目の価格
            },
            new Product {
            Name = "紅茶",            //２件目の商品名
            Price = 450               //２件目の価格
            }
        };

        return View(products);
    }
}
