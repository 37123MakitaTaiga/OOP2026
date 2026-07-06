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
            btGet.Text = "取得";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // tbOut
            // 
            tbOut.Location = new Point(40, 118);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(196, 23);
            tbOut.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 570);
            Controls.Add(tbOut);
            Controls.Add(btGet);
            Controls.Add(dtpDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog ofdOpen;
        private DateTimePicker dtpDate;
        private Button btGet;
        private TextBox tbOut;
    }
}
