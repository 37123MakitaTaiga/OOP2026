namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }

        private static void Exercise1() {
            //if-else文を使用
            Console.Write("値を入力：");
            string? inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out var num)) {
                if (num < 0) {
                    Console.WriteLine(num);
                } else if (num < 100) {
                    Console.WriteLine(num * 2);
                } else if (num < 500) {
                    Console.WriteLine(num * 3);
                } else {
                    Console.WriteLine(num);
                }
            } else {
                Console.WriteLine("入力に誤りがあります");
            }
        }

        private static void Exercise2() {
            //switch文を使用
            Console.Write("値を入力：");
            string? inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out var num)) {
                switch (num) {
                    case < 0:
                        Console.WriteLine(num);
                        break;
                    case < 100:
                        Console.WriteLine(num * 2);
                        break;
                    case < 500:
                        Console.WriteLine(num * 3);
                        break;
                    default:
                        Console.WriteLine(num);
                        break;
                }
            } else {
                Console.WriteLine("入力に誤りがあります");
            }
        }

        private static void Exercise3() {
            //switch式を使用

            Console.Write("値を入力：");
            string? inputNum = Console.ReadLine();

            if (int.TryParse(inputNum, out int num)) {
                int result = num switch {
                    < 0 => num,
                    < 100 => num * 2,
                    < 500 => num * 3,
                    _ => num
                };

                Console.WriteLine(result);
            } else {
                Console.WriteLine("エラー：整数を入力してください");
            }
        }
    }
}
