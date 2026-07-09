using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton1_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            tbOut1.Text = $"{today.Year}/{today.Month}/{today.Day}  {today.Hour}:{today.Minute}";
        }

        private void btButton2_Click(object sender, EventArgs e) {
            DateTime today = DateTime.Now;
            tbOut2.Text = $"{today.Year}”N{today.Month}ŒŽ{today.Day}“ú {today.Hour}Žž{today.Minute}•ª{today.Second}•b";
        }

        private void btButton3_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            var culture = new CultureInfo("jp-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            
            tbOut3.Text = today.ToString("ggyy”NMŒŽd“ú(dddd)", culture);
        }
    }
}
