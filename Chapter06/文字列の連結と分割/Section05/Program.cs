using System.Text;

namespace Section05 {
    internal class Program {
        static void Main(string[] args) {
            var separator = ",";
            var result = String.Join(separator, GetWord());
            Console.WriteLine(result);
        }

        private static IEnumerable<string> GetWord() {
            return ["Orange", "Lemon", "Strawberry"];
        }
    }
}
