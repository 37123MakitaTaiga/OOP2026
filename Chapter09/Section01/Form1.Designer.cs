namespace Section01 {
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
            ofdOpen = new OpenFileDialog();
            dtpDate = new DateTimePicker();
            btGet = new Button();
            tbOut = new TextBox();
            nudDay = new NumericUpDown();
            label1 = new Label();
            dtpBirthday = new DateTimePicker();
            label2 = new Label();
            btBirthCalc = new Button();
            label3 = new Label();
            label4 = new Label();
            tbOut2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(40, 33);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(196, 35);
            dtpDate.TabIndex = 0;
            // 
            // btGet
            // 
            btGet.Location = new Point(273, 33);
            btGet.Name = "btGet";
            btGet.Size = new Size(103, 35);
            btGet.TabIndex = 1;
            btGet.Text = "計算";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(40, 398);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(338, 35);
            tbOut.TabIndex = 2;
            // 
            // nudDay
            // 
            nudDay.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudDay.Location = new Point(116, 99);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(120, 39);
            nudDay.TabIndex = 3;
            nudDay.ValueChanged += nudDay_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(264, 103);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 4;
            label1.Text = "日後";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirthday.Location = new Point(40, 268);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(196, 35);
            dtpBirthday.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 244);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "生年月日";
            // 
            // btBirthCalc
            // 
            btBirthCalc.Location = new Point(276, 269);
            btBirthCalc.Name = "btBirthCalc";
            btBirthCalc.Size = new Size(100, 34);
            btBirthCalc.TabIndex = 6;
            btBirthCalc.Text = "計算";
            btBirthCalc.UseVisualStyleBackColor = true;
            btBirthCalc.Click += btBirthCalc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 318);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "年齢";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 380);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "日数経過";
            // 
            // tbOut2
            // 
            tbOut2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut2.Location = new Point(42, 336);
            tbOut2.Name = "tbOut2";
            tbOut2.Size = new Size(336, 35);
            tbOut2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 570);
            Controls.Add(btBirthCalc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudDay);
            Controls.Add(tbOut2);
            Controls.Add(tbOut);
            Controls.Add(btGet);
            Controls.Add(dtpBirthday);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdOpen;
        private DateTimePicker dtpDate;
        private Button btGet;
        private TextBox tbOut;
        private NumericUpDown nudDay;
        private Label label1;
        private DateTimePicker dtpBirthday;
        private Label label2;
        private Button btBirthCalc;
        private Label label3;
        private Label label4;
        private TextBox tbOut2;
    }
}
