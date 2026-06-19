
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = [5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35];


            Console.WriteLine("7.1.1");
            Exercise1(numbers);

            Console.WriteLine("7.1.2");
            Exercise2(numbers);

            Console.WriteLine("7.1.3");
            Exercise3(numbers);

            Console.WriteLine("7.1.4");
            Exercise4(numbers);

            Console.WriteLine("7.1.5");
            Exercise5(numbers);
        }

        private static void Exercise1(int[] numbers) {
            Console.WriteLine("最大値：" + numbers.Max());
        }

        private static void Exercise2(int[] numbers) {
            foreach(var last in numbers.TakeLast(2))
            Console.WriteLine(last);
        }

        private static void Exercise3(int[] numbers) {
            Console.WriteLine("3桁の数値文字列");
            var s3 = numbers.Select(n => n.ToString("000")).ToList();
            s3.ForEach(Console.WriteLine);
            
        }

        private static void Exercise4(int[] numbers) {
            var sortednum = numbers.OrderBy(n => n).Take(3).ToList();
            sortednum.ForEach(Console.WriteLine);
        }

        private static void Exercise5(int[] numbers) {
        }
    }
}
