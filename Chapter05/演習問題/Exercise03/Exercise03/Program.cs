using Exercise01;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var y1 = new YearMonth(2026, 3);
            var y2 = new YearMonth(2026, 3);
            if (y1 == y2)
                Console.WriteLine("y1とy2は等しい");
            else
                Console.WriteLine("y1とy2は等しくない");
        }
    }
}
