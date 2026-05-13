namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            PrintMeterTonchList(1, 10);
        }
            static void PrintMeterTonchList(int start, int stop) {

                for (int inch = start; inch <= stop; inch++) {
                    double metre = ToMeter(inch);
                    Console.WriteLine($"{inch}in = {metre:0.0000}m");
                }
            }
        private static readonly double ratio = 0.0254;   //定数
        //インチからメートルを求める
        public static double ToMeter(double inch) {
            return inch * ratio;
        }
    }
}
