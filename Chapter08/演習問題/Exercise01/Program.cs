
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy Lummox gives smart squid who asks for job pen";

            Exercise1(text);
            Console.WriteLine();
            Exercise2(text);
        }

        private static void Exercise1(string text) {
            var alphabetDict = new Dictionary<char, int>();
            foreach (var alph in text.ToUpper()){
                if ('A' <= alph && alph <= 'Z') {
                    if (alphabetDict.ContainsKey(alph)) {
                        alphabetDict[alph]++;
                    }else {
                        alphabetDict[alph] = 1;
                    }
                } 
                
            }
            foreach (var item in alphabetDict.OrderBy(x => x.Key)) {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }



        private static void Exercise2(string text) {
        }
    }
}
