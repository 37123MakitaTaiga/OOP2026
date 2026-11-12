using SelfOrderSystem.Models;

namespace SelfOrderSystem.Services;

public interface IOrderService              // 注文処理に必要なメソッドを定義 
{
    Task<PlaceOrderResult> PlaceAsync(      // 注文を確認してDBへ保存する 
                            List<CartItem> cartItems,           // Sessionから取得したカート 
                            int tableNumber);                   // 入力されたテーブル番号 
}