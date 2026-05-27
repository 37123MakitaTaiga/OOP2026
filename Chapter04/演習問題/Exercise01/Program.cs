
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            //foreach文
            Console.WriteLine("foreach文で出力");
            var s = langs.Where(s => s.Contains('S'));
            foreach (var item in s) {
                Console.WriteLine(item);
            }

            //for文
            Console.WriteLine("\nfor文で出力");
            for(int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains('S')){
                    Console.WriteLine(langs[i]);
                }
            }

            //while文
            Console.WriteLine("\nwhile文で出力");
            int j = 0;
            while (j < langs.Count) {
                if (langs[j].Contains('S')) {
                    Console.WriteLine(langs[j]);
                }
                j++;
            }        
        }

        private static void Exercise2(List<string> langs) {
            Console.WriteLine("\n --- 4.1.2 ---");
            //LINQを使用する (Where)
            var selected = langs.Where(s => s.Contains('S'));
            foreach (var item in selected) {
                Console.WriteLine(item);
            }

        }

        private static void Exercise3(List<string> langs) {
            Console.WriteLine("\n --- 4.1.3 ---");
            var lang = langs.Find(s => s.Length == 10)?? "unknown";
            Console.WriteLine(lang);            
        }
    }
}
