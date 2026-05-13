namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {

            var songs = new List<Song>();   //コレクション

            while (true) {
            Console.Write("曲名：");
            string? artistname = Console.ReadLine();
                if (artistname == "end") {
                    break;
                } else {
                    Console.Write("アーティスト名：");
                    string? title = Console.ReadLine();

                    Console.Write("演奏時間(秒)：");
                    string? seconds = Console.ReadLine();
                    int length = int.Parse(seconds);
                    Song song = new Song(title, artistname, length);

                    songs.Add(song);

                }
            }
            PrintSongs(songs);
        }
        //出力
        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {
                var minutes = song.Length / 60;
                var seconds = song.Length % 60;
                Console.WriteLine($"{song.Title},{song.ArtistName},{minutes}:{seconds:00}");

            }
        }
    }
}
