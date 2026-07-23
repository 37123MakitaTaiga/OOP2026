namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbSubaru = new RadioButton();
            rbImport = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            dgvRecords = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            tbReport = new TextBox();
            btNewInput = new Button();
            label6 = new Label();
            label7 = new Label();
            btPicOpen = new Button();
            btDeletePictuer = new Button();
            btAddRecord = new Button();
            btModifyRecord = new Button();
            btDeleteRecord = new Button();
            pbPicture = new PictureBox();
            cbCarName = new ComboBox();
            cbAuthor = new ComboBox();
            menuStrip1 = new MenuStrip();
            ファイルFToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ヘルプHToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tsslbMessage = new ToolStripStatusLabel();
            ofdPicFileOpen = new OpenFileDialog();
            cdColor = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(105, 46);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 35);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(24, 150);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(24, 100);
            label3.Name = "label3";
            label3.Size = new Size(76, 30);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(105, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 51);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Location = new Point(309, 21);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(182, 21);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 0;
            rbSubaru.TabStop = true;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(242, 21);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 0;
            rbImport.TabStop = true;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(124, 21);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 0;
            rbHonda.TabStop = true;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(68, 22);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 0;
            rbNissan.TabStop = true;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(12, 21);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.TabStop = true;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(105, 422);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(643, 186);
            dgvRecords.TabIndex = 3;
            dgvRecords.SelectionChanged += dgvRecords_SelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(21, 281);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 0;
            label4.Text = "レポート";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(489, 46);
            label5.Name = "label5";
            label5.Size = new Size(55, 30);
            label5.TabIndex = 0;
            label5.Text = "画像";
            // 
            // tbReport
            // 
            tbReport.Location = new Point(105, 281);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(353, 125);
            tbReport.TabIndex = 4;
            // 
            // btNewInput
            // 
            btNewInput.BackColor = Color.SlateGray;
            btNewInput.Location = new Point(347, 42);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(111, 43);
            btNewInput.TabIndex = 5;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = false;
            btNewInput.Click += btNewInput_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(40, 225);
            label6.Name = "label6";
            label6.Size = new Size(55, 30);
            label6.TabIndex = 0;
            label6.Text = "車名";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(40, 422);
            label7.Name = "label7";
            label7.Size = new Size(55, 30);
            label7.TabIndex = 0;
            label7.Text = "一覧";
            // 
            // btPicOpen
            // 
            btPicOpen.BackColor = Color.Orange;
            btPicOpen.Location = new Point(556, 41);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(93, 34);
            btPicOpen.TabIndex = 6;
            btPicOpen.Text = "開く...";
            btPicOpen.UseVisualStyleBackColor = false;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btDeletePictuer
            // 
            btDeletePictuer.BackColor = Color.Salmon;
            btDeletePictuer.Location = new Point(655, 42);
            btDeletePictuer.Name = "btDeletePictuer";
            btDeletePictuer.Size = new Size(93, 34);
            btDeletePictuer.TabIndex = 6;
            btDeletePictuer.Text = "削除";
            btDeletePictuer.UseVisualStyleBackColor = false;
            btDeletePictuer.Click += btDeletePictuer_Click;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = SystemColors.ActiveCaption;
            btAddRecord.Location = new Point(489, 336);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(97, 70);
            btAddRecord.TabIndex = 7;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btModifyRecord
            // 
            btModifyRecord.BackColor = Color.OldLace;
            btModifyRecord.Location = new Point(592, 336);
            btModifyRecord.Name = "btModifyRecord";
            btModifyRecord.Size = new Size(97, 70);
            btModifyRecord.TabIndex = 7;
            btModifyRecord.Text = "修正";
            btModifyRecord.UseVisualStyleBackColor = false;
            btModifyRecord.Click += btModifyRecord_Click;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.Salmon;
            btDeleteRecord.Location = new Point(695, 336);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(56, 70);
            btDeleteRecord.TabIndex = 7;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            btDeleteRecord.Click += btDeleteRecord_Click;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(489, 84);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(259, 246);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 8;
            pbPicture.TabStop = false;
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(105, 222);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(241, 38);
            cbCarName.TabIndex = 9;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(105, 97);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(241, 38);
            cbAuthor.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルFToolStripMenuItem, ヘルプHToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(809, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            ファイルFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator2, 色設定ToolStripMenuItem, toolStripSeparator1, 終了ToolStripMenuItem });
            ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            ファイルFToolStripMenuItem.Size = new Size(67, 20);
            ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(119, 22);
            開くToolStripMenuItem.Text = "開く...";
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(119, 22);
            保存ToolStripMenuItem.Text = "保存...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(116, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(119, 22);
            色設定ToolStripMenuItem.Text = "色設定...";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(116, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(119, 22);
            終了ToolStripMenuItem.Text = "終了(&X)";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // ヘルプHToolStripMenuItem
            // 
            ヘルプHToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem });
            ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            ヘルプHToolStripMenuItem.Size = new Size(65, 20);
            ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(164, 22);
            このアプリについてToolStripMenuItem.Text = "このアプリについて...";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            statusStrip1.Location = new Point(0, 618);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(809, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 17);
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 640);
            Controls.Add(statusStrip1);
            Controls.Add(cbAuthor);
            Controls.Add(cbCarName);
            Controls.Add(pbPicture);
            Controls.Add(btDeleteRecord);
            Controls.Add(btModifyRecord);
            Controls.Add(btAddRecord);
            Controls.Add(btDeletePictuer);
            Controls.Add(btPicOpen);
            Controls.Add(btNewInput);
            Controls.Add(tbReport);
            Controls.Add(dgvRecords);
            Controls.Add(groupBox1);
            Controls.Add(dtpDate);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbImport;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private DataGridView dgvRecords;
        private Label label4;
        private Label label5;
        private TextBox tbReport;
        private Button btNewInput;
        private Label label6;
        private Label label7;
        private Button btPicOpen;
        private Button btDeletePictuer;
        private Button btAddRecord;
        private Button btModifyRecord;
        private Button btDeleteRecord;
        private PictureBox pbPicture;
        private ComboBox cbCarName;
        private ComboBox cbAuthor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルFToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private RadioButton rbOther;
        private ToolStripMenuItem ヘルプHToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private RadioButton rbSubaru;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tsslbMessage;
        private OpenFileDialog ofdPicFileOpen;
        private ColorDialog cdColor;
    }
}
