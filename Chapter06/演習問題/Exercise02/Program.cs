namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            //6.2
            Console.Write("整数を入力：");
            var input = Console.ReadLine();
            if ( int.TryParse(input, out var inputNum)) {
                var num = inputNum.ToString("#,0");
                Console.WriteLine(num);
            } else {
                Console.WriteLine("整数文字列ではありません");
            }
        
        }
    }
}
