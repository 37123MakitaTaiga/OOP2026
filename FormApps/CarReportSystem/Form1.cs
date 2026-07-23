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
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);

            SetCbAuthor(cbAuthor.Text);
            SetCbCarName(cbCarName.Text);

            dgvRecords.CurrentRow.Selected = false;
            ImputItemsUpdate();
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
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            ImuputItemsAllClear();
        }

        private void ImuputItemsAllClear() {
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            pbPicture.Image = null;

            dgvRecords.CurrentRow.Selected = false;
        }

        private void dgvRecords_Click(object sender, EventArgs e) {

            //if ((dgvRecords.CurrentRow is null)
            // || (!dgvRecords.CurrentRow.Selected)) return;

            //cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;
            //SetRadioButtonMaker((MakerGroup)dgvRecords.CurrentRow.Cells["Maker"].Value);
            //cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            //tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            //pbPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
            //ImputItemsUpdate();
        }

        private void SetRadioButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }
        //記入者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //車名のの入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btDeletePictuer_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btDeleteRecord_Click(object sender, EventArgs e) {

            if ((dgvRecords.CurrentRow is null)
                || (!dgvRecords.CurrentRow.Selected)) return;
            listCarReports.RemoveAt(dgvRecords.CurrentRow.Index);
            
        }

        private void btModifyRecord_Click(object sender, EventArgs e) {
            dgvRecords.CurrentRow.Cells["Author"].Value = cbAuthor.Text;
            dgvRecords.CurrentRow.Cells["Maker"].Value = GetRadioButtonMaker();
            dgvRecords.CurrentRow.Cells["CarName"].Value = cbCarName.Text;
            dgvRecords.CurrentRow.Cells["Report"].Value = tbReport.Text;
            dgvRecords.CurrentRow.Cells["Picture"].Value = pbPicture.Image;

            dgvRecords.Refresh();
        }

        public void ImputItemsUpdate() {
            if (!dgvRecords.CurrentRow.Selected)
                ImuputItemsAllClear();
        }

        private void dgvRecords_SystemColorsChanged(object sender, EventArgs e) {
            if ((dgvRecords.CurrentRow is null)
                 || (!dgvRecords.CurrentRow.Selected)) return;

            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;
            SetRadioButtonMaker((MakerGroup)dgvRecords.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
            ImputItemsUpdate();     //データグリッドビューを更新したら呼ぶメソッド
        }
    }
}

