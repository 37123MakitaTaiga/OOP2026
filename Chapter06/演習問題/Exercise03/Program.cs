namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            var count = text.Count(c => c == ' ');
            Console.WriteLine("空白文字：" + count);
        }

        private static void Exercise2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3(string text) {

        }

        private static void Exercise4(string text) {
            var count = text.Split(' ').Length;
            Console.WriteLine($"単語数：{count}");
        }

        private static void Exercise5(string text) {
            text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);            
        }
        //アルファベットの数をカウントして表示する
        private static void Exercise6(string text) {
            var str = text.ToLower().Replace(" ", "");

            //辞書（ディクショナリ）を使った集計
            //var alphDicCount = Enumerable.Range('a', 26).
            //    ToDictionary(num => ((char)num).ToString(), num => 0);

            var dict = new SortedDictionary<char, int>();
            foreach (var c in str) {
                if (dict.ContainsKey(c))
                    dict[c]++;      //登録されている場合
                else
                    dict[c] = 1;    //未登録の場合
            }
            foreach (var word in dict) {
                Console.WriteLine(word.Key + ":" + word.Value);
            }
            //配列を用いた集計


            //'a'から順にカウントして集計
        }
    }
}
