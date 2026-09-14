using SQLiteProductSample;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト

        private readonly BindingList<CarReport> _carreports = new();
        private readonly CarReportRepository _repository = new();

        //設定クラスのオブジェクトを生成
        //Settings settings =  Settings.Instance;

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = _carreports;
        }

        private void Form1_Load(object sender, EventArgs e) {
            //設定ファイルを読み込み背景色を設定する（逆シリアル化）
            try {
                Settings.Instance.Load();
                BackColor = Color.FromArgb(Settings.Instance.MainFormBackColor);

                ReloadCarReports();
            }
            catch (Exception ex) {
                tsslbMessage.Text = "ファイル書き出しエラー";
                MessageBox.Show(ex.Message);//←より具体的なエラーを出力

            }
        }


        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {

            tsslbMessage.Text = String.Empty;   //メッセージ領域のクリア


            if (cbAuthor.Text == String.Empty || cbCarName.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です。";
                return;
            }
            var carReport = new CarReport {
                Date = dtpDate.Value.Date,
                Author = cbAuthor.Text.Trim(),
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text.Trim(),
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            carReport.Id = _repository.Add(carReport);
            _carreports.Add(carReport);



            ReloadCarReports();

            dgvRecords.CurrentRow.Selected = false;
            InputItemsUpdate();
           
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
            if (ofdRepotFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdRepotFileOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            InuputItemsAllClear();
        }

        private void InuputItemsAllClear() {
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            dtpDate.Value = DateTime.Today;
            pbPicture.Image = null;
            
            dgvRecords.CurrentRow.Selected = false;
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
        private void btDeletePictuer_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        private void btDeleteRecord_Click(object sender, EventArgs e) {
            if ((dgvRecords.CurrentRow is null)
                || (!dgvRecords.CurrentRow.Selected)) return;

            //削除したいインデックスを指定してリストから削除
            if(dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                tsslbMessage.Text = "削除するレポートを選択してください";
                return;
            }

            _repository.Delete(carReport.Id);
            InuputItemsAllClear();
            _carreports.Remove(carReport);
            
        }

        private void btModifyRecord_Click(object sender, EventArgs e) {

            if (dgvRecords.SelectedRows.Count == 0) {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }

            if (cbAuthor.Text == String.Empty || cbCarName.Text == String.Empty) {
                tsslbMessage.Text = "記録者、または車名が未入力です。";
                return;
            }

            if (dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport) {
                tsslbMessage.Text = "修正するレポートを選択してください";
                return;
            }

            try {
                //選択中の商品のオブジェクトのデータを更新する
                carReport.Date = dtpDate.Value.Date;
                carReport.Author = cbAuthor.Text.Trim();
                carReport.Maker = GetRadioButtonMaker();
                carReport.CarName = cbCarName.Text.Trim();
                carReport.Report = tbReport.Text;
                carReport.Picture = pbPicture.Image;

                _repository.Update(carReport);

                ReloadCarReports();
            }
            catch {
            }
            //カーレポート管理用リストに該当する要素のデータを書き換える
            _carreports[dgvRecords.CurrentRow.Index].Date = dtpDate.Value.Date;
            _carreports[dgvRecords.CurrentRow.Index].Author = cbAuthor.Text.Trim();
            _carreports[dgvRecords.CurrentRow.Index].Maker = GetRadioButtonMaker();
            _carreports[dgvRecords.CurrentRow.Index].CarName = cbCarName.Text.Trim();
            _carreports[dgvRecords.CurrentRow.Index].Report = tbReport.Text;
            _carreports[dgvRecords.CurrentRow.Index].Picture = pbPicture.Image;

            SetCbAuthor(cbAuthor.Text.Trim());
            SetCbCarName(cbCarName.Text.Trim());

            dgvRecords.Refresh();   //データグリッドビューの更新
            tsslbMessage.Text = "レポートを修正しました";
        }

        public void InputItemsUpdate() {
            if (dgvRecords.CurrentRow is null
                      || !dgvRecords.CurrentRow.Selected)
                InuputItemsAllClear();
        }


        private void dgvRecords_SelectionChanged(object sender, EventArgs e) {

            if ((dgvRecords.CurrentRow?.DataBoundItem is not CarReport carReport)
                    || (!dgvRecords.CurrentRow.Selected)) return;


            dtpDate.Value = carReport.Date;
            cbAuthor.Text = carReport.Author;
            SetRadioButtonMaker(carReport.Maker);
            cbCarName.Text = carReport.CarName;
            tbReport.Text = carReport.Report;
            pbPicture.Image = carReport.Picture;
            InputItemsUpdate();     //データグリッドビューを更新したら呼ぶメソッド
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;

                Settings.Instance.MainFormBackColor = cdColor.Color.ToArgb();
            }
        }

        //フォームが閉じたら呼ばれるイベントハンドラ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルへ色情報を保存する処理（シリアル化）
            Settings.Instance.Save();
        }

       

        private void ReloadCarReports() {
            _carreports.Clear();

            cbAuthor.Items.Clear();
            cbCarName.Items.Clear();

            foreach (var report in _repository.GetAll()) {
                _carreports.Add(report);
                SetCbAuthor(report.Author);
                SetCbCarName(report.CarName);
            }
        }

    }
}

