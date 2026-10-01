using Microsoft.AspNetCore.Mvc;         // MVCの機能を使用 
using MvcBasicSample.Models;            // Productを使用 

namespace MvcBasicSample.Controllers;

public class HelloController : Controller {
    public IActionResult Index() {
        // Productを複数まとめる一覧を作る 
        var products = new List<Product>
        {
            new Product
            {
                Name = "ハンバーガー",  // 1件目の商品名 
                Price = 500             // 1件目の価格 
            },
            new Product
            {
                Name = "紅茶",          // 2件目の商品名 
                Price = 450             // 2件目の価格 
            }
        };

        return View(products);          // 商品の一覧をViewへ渡す 
    }
}