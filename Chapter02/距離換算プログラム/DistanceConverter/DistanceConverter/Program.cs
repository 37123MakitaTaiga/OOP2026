using System.Diagnostics.Metrics;

namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args){

            if (args.Length >= 1 && args[0] == "-tom"){
                PrintMeterToFeetList(int.Parse(args[1]), int.Parse(args[2]));
            }
            else if (args.Length >= 1 && args[0] == "-tof"){
                PrintFeetToMeterList(int.Parse(args[1]), int.Parse(args[2]));
            } else {
                Console.WriteLine("引数エラー");
            }
        }

        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++){
                double metre = MeterToFeet(feet);
                Console.WriteLine($"{feet}ft = {metre:0.0000}m");
            }
        }
        static void PrintFeetToMeterList(int start, int stop){
            for (int metre = start; metre <= stop; metre++){
                double feet = FeetToMeter(metre);
                Console.WriteLine($"{metre}m = {feet:0.0000}ft");
            }
        }
        static double MeterToFeet(double feet){
            return feet * 0.3048;
        }
        static double FeetToMeter(double metre){
            return metre / 0.3048;
        }
    }
}
