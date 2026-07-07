using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;

            tbOut.Text = date.AddDays((double)nudDay.Value).ToString();
        }

        private void nudDay_ValueChanged(object sender, EventArgs e) {

        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth = dtpBirthday.Value;     //生まれた日付
            DateTime today = DateTime.Today;    //今日の日付
            TimeSpan diff = today.Date - birth.Date;
            //int age = today.Year - birth.Year;

            //if (today < birth.AddYears(age)) {
            //    age--;
            //}
            var date = new CultureInfo("ja-JP");
            date.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dayofweek = date.DateTimeFormat.GetShortestDayName(birth.DayOfWeek);

            tbOut2.Text = $"{GetAge(birth, today)}歳です";
            tbOut.Text = $"生まれてから{diff.Days}日です";
            tbOut3.Text = $"生まれた{birth.Month}月{birth.Day}日は第{NthWeek(birth)}週の{dayofweek}曜日です";

        }

        //年齢を求めるメソッド
        static int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
        //指定した日が第何週か求める
        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }
    }
}
