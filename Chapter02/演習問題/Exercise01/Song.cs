using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    internal class Song {
        //タイトル
        public string Title { get; set; } = string.Empty;
        //アーティスト名
        public string ArtistName { get; set; } = string.Empty;
        //演奏時間
        public int Length { get; set; }

        //コンストラクター
        public Song(string title, string artistname, int length) {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
