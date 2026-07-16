using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;
        }
        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {

            tsslbMessage.Text = String.Empty;   //メッセージ領域のクリア


            if (cbAuthor.Text == String.Empty || cbCarName.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です。";
                return;
            }
            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPictuer.Image,
            };
            listCarReports.Add(carReport);

            imuputItemsAllClear();  //入力項目のクリア
        }
        private MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return MakerGroup.トヨタ;
            if (rbNissan.Checked)
                return MakerGroup.日産;
            if (rbHonda.Checked)
                return MakerGroup.ホンダ;
            if (rbSubaru.Checked)
                return MakerGroup.スバル;
            if (rbImport.Checked)
                return MakerGroup.輸入車;

            return MakerGroup.その他;
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFilOpen.ShowDialog() == DialogResult.OK) {
                pbPictuer.Image = Image.FromFile(ofdPicFilOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            imuputItemsAllClear();
        }

        private void imuputItemsAllClear() {
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            pbPictuer.Image = null;
        }

        private void dgvRecords_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;

            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pbPictuer.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
        }
    }
}
