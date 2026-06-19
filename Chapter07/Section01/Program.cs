namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
            
            var books = Books.GetBooks();
            var priceAverage = books.Average(x => x.Price);
            var pageSum = books.Sum(x => x.Pages);
            var maxPrice = books.Max(x => x.Price);
            

            Console.WriteLine("平均金額：" + priceAverage);
            Console.WriteLine("合計ページ：" + pageSum);
            Console.WriteLine("高価な本：" + maxPrice);

            Console.WriteLine("--- 500円以上の本 ---");
            foreach (var book in books.Where(x => x.Price >= 500)) {
                Console.WriteLine(book.Title);
            }

            //250ページの本を上位3冊出力
            Console.WriteLine("--- 250ページの本を上位3冊 ---");
            foreach (var top3 in books.Where(n => n.Pages >= 250).Take(3)) {
                Console.WriteLine(top3.Title);
            }
        }
    }
}
