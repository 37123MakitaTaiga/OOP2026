

namespace Section01 {
    internal class Program {
        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();

        static void Main(string[] args) {
            string? pref, prefCaptalLocation;

            Console.WriteLine("県庁所在地の登録【入力終了：Ctrl + 'Z'】");


            while (true) {
                //①都道府県の入力
                Console.Write("都道府県:");
                pref = Console.ReadLine();

                if (pref is null) break;    //無限ループを抜ける(Ctrl + 'Z')

                //②県庁所在地の入力
                Console.Write("県庁所在地:");
                prefCaptalLocation = Console.ReadLine();

                //③県庁所在地登録処理
                if (prefOfficeDict.ContainsKey(pref)) {
                    Console.Write("上書きしますか？(Y/N):");
                    if (Console.ReadLine() is "N") continue;
                }
                prefOfficeDict[pref] = prefCaptalLocation;
                Console.WriteLine();
            }

            Boolean endFlag = false; //終了フラグ
            while (!endFlag) {
                switch (menuDisp()) {
                    case 1:
                        allDisp();
                        break;
                    case 2:
                        searchPrefCaptalLocation();
                        break;
                    default:
                        endFlag = true;
                        break;
                }
                    
            }
        }
        
        private static int menuDisp() {
            Console.WriteLine("\n*** メニュー ***");
            Console.WriteLine("1:一覧表示");
            Console.WriteLine("2:検索");
            Console.WriteLine("3:終了");
            Console.Write("＞ ");


            return int.Parse(Console.ReadLine());
        }

        private static void allDisp() {
            foreach (var item in prefOfficeDict) {
                Console.WriteLine($"{item.Key}の県庁所在地は{item.Value}です");
            }
        }

        private static void searchPrefCaptalLocation() {
            Console.Write("検索:");
            var searchPerf = Console.ReadLine();
            if (searchPerf is null) return;

            if (prefOfficeDict.ContainsKey(searchPerf)) {
                Console.WriteLine($"{searchPerf}の県庁所在地は{prefOfficeDict[searchPerf]}です");
            }
    }
        }
}
