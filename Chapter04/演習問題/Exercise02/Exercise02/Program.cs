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
        //p89～90を参考にする
        private static void Exercise1() {
            //if-else文を使用
            Console.Write("値を入力：");
            string? inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out var num)) {  //整数以外は「入力に誤りがあります」と出力
                if (num < 0) {                  //0未満
                    Console.WriteLine(num);
                } else if (num < 100) {         //0以上100未満
                    Console.WriteLine(num * 2); 
                } else if (num < 500) {         //100以上500未満
                    Console.WriteLine(num * 3); 
                } else {                        //500以上
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
                var result = num switch {
                    < 0 => num,
                    < 100 => num * 2,
                    < 500 => num * 3,
                    _ => num
                };

                Console.WriteLine(result);
            } else {
                Console.WriteLine("入力に誤りがあります");
            }
        }
    }
}
