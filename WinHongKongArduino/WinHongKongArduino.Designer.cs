namespace WinHongKongArduino
{
    partial class WinHongKongArduino
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExtract = new System.Windows.Forms.Button();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.lbROMSize = new System.Windows.Forms.Label();
            this.btnGetROMInfo = new System.Windows.Forms.Button();
            this.lbMakerCode = new System.Windows.Forms.Label();
            this.txtMakerCode = new System.Windows.Forms.TextBox();
            this.cmbROMType = new System.Windows.Forms.ComboBox();
            this.lbROMType = new System.Windows.Forms.Label();
            this.cmbROMCompo = new System.Windows.Forms.ComboBox();
            this.lbROMCompo = new System.Windows.Forms.Label();
            this.cmbROMSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRAMSize = new System.Windows.Forms.ComboBox();
            this.lbRAMSize = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtGameCode = new System.Windows.Forms.TextBox();
            this.lbGameCode = new System.Windows.Forms.Label();
            this.lbSpecialVer = new System.Windows.Forms.Label();
            this.txtSpecialVer = new System.Windows.Forms.TextBox();
            this.lbSubNumber = new System.Windows.Forms.Label();
            this.txtSubNumber = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCoPro = new System.Windows.Forms.Label();
            this.cmbCoPro = new System.Windows.Forms.ComboBox();
            this.lbExRAMSize = new System.Windows.Forms.Label();
            this.txtExRAMSize = new System.Windows.Forms.TextBox();
            this.lbROMSpeed = new System.Windows.Forms.Label();
            this.txtROMSpeed = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.lbComplementCheck = new System.Windows.Forms.Label();
            this.txtComplementCheck = new System.Windows.Forms.TextBox();
            this.lbCheckSum = new System.Windows.Forms.Label();
            this.txtCheckSum = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(402, 244);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(104, 23);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "ROM吸い出し";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(84, 9);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(76, 20);
            this.cmbCOMPort.TabIndex = 1;
            // 
            // lbROMSize
            // 
            this.lbROMSize.AutoSize = true;
            this.lbROMSize.Location = new System.Drawing.Point(270, 126);
            this.lbROMSize.Name = "lbROMSize";
            this.lbROMSize.Size = new System.Drawing.Size(61, 12);
            this.lbROMSize.TabIndex = 3;
            this.lbROMSize.Text = "ROMサイズ:";
            // 
            // btnGetROMInfo
            // 
            this.btnGetROMInfo.Location = new System.Drawing.Point(272, 244);
            this.btnGetROMInfo.Name = "btnGetROMInfo";
            this.btnGetROMInfo.Size = new System.Drawing.Size(104, 23);
            this.btnGetROMInfo.TabIndex = 4;
            this.btnGetROMInfo.Text = "ROM情報取得";
            this.btnGetROMInfo.UseVisualStyleBackColor = true;
            this.btnGetROMInfo.Click += new System.EventHandler(this.btnGetROMInfo_Click);
            // 
            // lbMakerCode
            // 
            this.lbMakerCode.AutoSize = true;
            this.lbMakerCode.Location = new System.Drawing.Point(11, 73);
            this.lbMakerCode.Name = "lbMakerCode";
            this.lbMakerCode.Size = new System.Drawing.Size(42, 12);
            this.lbMakerCode.TabIndex = 5;
            this.lbMakerCode.Text = "メーカー";
            // 
            // txtMakerCode
            // 
            this.txtMakerCode.Location = new System.Drawing.Point(84, 70);
            this.txtMakerCode.Name = "txtMakerCode";
            this.txtMakerCode.ReadOnly = true;
            this.txtMakerCode.Size = new System.Drawing.Size(163, 19);
            this.txtMakerCode.TabIndex = 6;
            // 
            // cmbROMType
            // 
            this.cmbROMType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbROMType.FormattingEnabled = true;
            this.cmbROMType.Location = new System.Drawing.Point(343, 44);
            this.cmbROMType.Name = "cmbROMType";
            this.cmbROMType.Size = new System.Drawing.Size(163, 20);
            this.cmbROMType.TabIndex = 7;
            // 
            // lbROMType
            // 
            this.lbROMType.AutoSize = true;
            this.lbROMType.Location = new System.Drawing.Point(270, 48);
            this.lbROMType.Name = "lbROMType";
            this.lbROMType.Size = new System.Drawing.Size(50, 12);
            this.lbROMType.TabIndex = 8;
            this.lbROMType.Text = "マッピング:";
            // 
            // cmbROMCompo
            // 
            this.cmbROMCompo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbROMCompo.FormattingEnabled = true;
            this.cmbROMCompo.Location = new System.Drawing.Point(343, 70);
            this.cmbROMCompo.Name = "cmbROMCompo";
            this.cmbROMCompo.Size = new System.Drawing.Size(163, 20);
            this.cmbROMCompo.TabIndex = 9;
            // 
            // lbROMCompo
            // 
            this.lbROMCompo.AutoSize = true;
            this.lbROMCompo.Location = new System.Drawing.Point(270, 74);
            this.lbROMCompo.Name = "lbROMCompo";
            this.lbROMCompo.Size = new System.Drawing.Size(56, 12);
            this.lbROMCompo.TabIndex = 10;
            this.lbROMCompo.Text = "ROM構成:";
            // 
            // cmbROMSize
            // 
            this.cmbROMSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbROMSize.FormattingEnabled = true;
            this.cmbROMSize.Location = new System.Drawing.Point(343, 122);
            this.cmbROMSize.Name = "cmbROMSize";
            this.cmbROMSize.Size = new System.Drawing.Size(163, 20);
            this.cmbROMSize.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "シリアルポート:";
            // 
            // cmbRAMSize
            // 
            this.cmbRAMSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRAMSize.FormattingEnabled = true;
            this.cmbRAMSize.Location = new System.Drawing.Point(343, 148);
            this.cmbRAMSize.Name = "cmbRAMSize";
            this.cmbRAMSize.Size = new System.Drawing.Size(163, 20);
            this.cmbRAMSize.TabIndex = 14;
            // 
            // lbRAMSize
            // 
            this.lbRAMSize.AutoSize = true;
            this.lbRAMSize.Location = new System.Drawing.Point(270, 152);
            this.lbRAMSize.Name = "lbRAMSize";
            this.lbRAMSize.Size = new System.Drawing.Size(61, 12);
            this.lbRAMSize.TabIndex = 13;
            this.lbRAMSize.Text = "RAMサイズ:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 282);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(518, 22);
            this.statusStrip.TabIndex = 15;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // txtGameCode
            // 
            this.txtGameCode.Location = new System.Drawing.Point(84, 96);
            this.txtGameCode.Name = "txtGameCode";
            this.txtGameCode.ReadOnly = true;
            this.txtGameCode.Size = new System.Drawing.Size(163, 19);
            this.txtGameCode.TabIndex = 17;
            // 
            // lbGameCode
            // 
            this.lbGameCode.AutoSize = true;
            this.lbGameCode.Location = new System.Drawing.Point(11, 99);
            this.lbGameCode.Name = "lbGameCode";
            this.lbGameCode.Size = new System.Drawing.Size(29, 12);
            this.lbGameCode.TabIndex = 18;
            this.lbGameCode.Text = "型番";
            // 
            // lbSpecialVer
            // 
            this.lbSpecialVer.AutoSize = true;
            this.lbSpecialVer.Location = new System.Drawing.Point(11, 199);
            this.lbSpecialVer.Name = "lbSpecialVer";
            this.lbSpecialVer.Size = new System.Drawing.Size(64, 12);
            this.lbSpecialVer.TabIndex = 20;
            this.lbSpecialVer.Text = "Special Ver";
            // 
            // txtSpecialVer
            // 
            this.txtSpecialVer.Location = new System.Drawing.Point(84, 196);
            this.txtSpecialVer.Name = "txtSpecialVer";
            this.txtSpecialVer.ReadOnly = true;
            this.txtSpecialVer.Size = new System.Drawing.Size(163, 19);
            this.txtSpecialVer.TabIndex = 19;
            // 
            // lbSubNumber
            // 
            this.lbSubNumber.AutoSize = true;
            this.lbSubNumber.Location = new System.Drawing.Point(11, 174);
            this.lbSubNumber.Name = "lbSubNumber";
            this.lbSubNumber.Size = new System.Drawing.Size(48, 12);
            this.lbSubNumber.TabIndex = 22;
            this.lbSubNumber.Text = "サブ番号";
            // 
            // txtSubNumber
            // 
            this.txtSubNumber.Location = new System.Drawing.Point(84, 171);
            this.txtSubNumber.Name = "txtSubNumber";
            this.txtSubNumber.ReadOnly = true;
            this.txtSubNumber.Size = new System.Drawing.Size(163, 19);
            this.txtSubNumber.TabIndex = 21;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(84, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(163, 19);
            this.txtTitle.TabIndex = 24;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(11, 48);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(40, 12);
            this.lbTitle.TabIndex = 23;
            this.lbTitle.Text = "タイトル";
            // 
            // lbCoPro
            // 
            this.lbCoPro.AutoSize = true;
            this.lbCoPro.Location = new System.Drawing.Point(270, 100);
            this.lbCoPro.Name = "lbCoPro";
            this.lbCoPro.Size = new System.Drawing.Size(56, 12);
            this.lbCoPro.TabIndex = 26;
            this.lbCoPro.Text = "拡張チップ:";
            // 
            // cmbCoPro
            // 
            this.cmbCoPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoPro.FormattingEnabled = true;
            this.cmbCoPro.Location = new System.Drawing.Point(343, 96);
            this.cmbCoPro.Name = "cmbCoPro";
            this.cmbCoPro.Size = new System.Drawing.Size(163, 20);
            this.cmbCoPro.TabIndex = 25;
            // 
            // lbExRAMSize
            // 
            this.lbExRAMSize.AutoSize = true;
            this.lbExRAMSize.Location = new System.Drawing.Point(270, 202);
            this.lbExRAMSize.Name = "lbExRAMSize";
            this.lbExRAMSize.Size = new System.Drawing.Size(54, 12);
            this.lbExRAMSize.TabIndex = 28;
            this.lbExRAMSize.Text = "拡張RAM";
            // 
            // txtExRAMSize
            // 
            this.txtExRAMSize.Location = new System.Drawing.Point(343, 199);
            this.txtExRAMSize.Name = "txtExRAMSize";
            this.txtExRAMSize.ReadOnly = true;
            this.txtExRAMSize.Size = new System.Drawing.Size(163, 19);
            this.txtExRAMSize.TabIndex = 27;
            // 
            // lbROMSpeed
            // 
            this.lbROMSpeed.AutoSize = true;
            this.lbROMSpeed.Location = new System.Drawing.Point(270, 177);
            this.lbROMSpeed.Name = "lbROMSpeed";
            this.lbROMSpeed.Size = new System.Drawing.Size(54, 12);
            this.lbROMSpeed.TabIndex = 30;
            this.lbROMSpeed.Text = "ROM速度";
            // 
            // txtROMSpeed
            // 
            this.txtROMSpeed.Location = new System.Drawing.Point(343, 174);
            this.txtROMSpeed.Name = "txtROMSpeed";
            this.txtROMSpeed.ReadOnly = true;
            this.txtROMSpeed.Size = new System.Drawing.Size(163, 19);
            this.txtROMSpeed.TabIndex = 29;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(11, 124);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(29, 12);
            this.lbCountry.TabIndex = 32;
            this.lbCountry.Text = "国名";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(84, 121);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.ReadOnly = true;
            this.txtCountry.Size = new System.Drawing.Size(163, 19);
            this.txtCountry.TabIndex = 31;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(11, 149);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(50, 12);
            this.lbVersion.TabIndex = 34;
            this.lbVersion.Text = "バージョン";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(84, 146);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.ReadOnly = true;
            this.txtVersion.Size = new System.Drawing.Size(163, 19);
            this.txtVersion.TabIndex = 33;
            // 
            // lbComplementCheck
            // 
            this.lbComplementCheck.AutoSize = true;
            this.lbComplementCheck.Location = new System.Drawing.Point(11, 249);
            this.lbComplementCheck.Name = "lbComplementCheck";
            this.lbComplementCheck.Size = new System.Drawing.Size(60, 12);
            this.lbComplementCheck.TabIndex = 36;
            this.lbComplementCheck.Text = "チェック補数";
            // 
            // txtComplementCheck
            // 
            this.txtComplementCheck.Location = new System.Drawing.Point(84, 246);
            this.txtComplementCheck.Name = "txtComplementCheck";
            this.txtComplementCheck.ReadOnly = true;
            this.txtComplementCheck.Size = new System.Drawing.Size(163, 19);
            this.txtComplementCheck.TabIndex = 35;
            // 
            // lbCheckSum
            // 
            this.lbCheckSum.AutoSize = true;
            this.lbCheckSum.Location = new System.Drawing.Point(11, 224);
            this.lbCheckSum.Name = "lbCheckSum";
            this.lbCheckSum.Size = new System.Drawing.Size(56, 12);
            this.lbCheckSum.TabIndex = 38;
            this.lbCheckSum.Text = "チェックサム";
            // 
            // txtCheckSum
            // 
            this.txtCheckSum.Location = new System.Drawing.Point(84, 221);
            this.txtCheckSum.Name = "txtCheckSum";
            this.txtCheckSum.ReadOnly = true;
            this.txtCheckSum.Size = new System.Drawing.Size(163, 19);
            this.txtCheckSum.TabIndex = 37;
            // 
            // WinHongKongArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 304);
            this.Controls.Add(this.lbCheckSum);
            this.Controls.Add(this.txtCheckSum);
            this.Controls.Add(this.lbComplementCheck);
            this.Controls.Add(this.txtComplementCheck);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbROMSpeed);
            this.Controls.Add(this.txtROMSpeed);
            this.Controls.Add(this.lbExRAMSize);
            this.Controls.Add(this.txtExRAMSize);
            this.Controls.Add(this.lbCoPro);
            this.Controls.Add(this.cmbCoPro);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbSubNumber);
            this.Controls.Add(this.txtSubNumber);
            this.Controls.Add(this.lbSpecialVer);
            this.Controls.Add(this.txtSpecialVer);
            this.Controls.Add(this.lbGameCode);
            this.Controls.Add(this.txtGameCode);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.cmbRAMSize);
            this.Controls.Add(this.lbRAMSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbROMSize);
            this.Controls.Add(this.lbROMCompo);
            this.Controls.Add(this.cmbROMCompo);
            this.Controls.Add(this.lbROMType);
            this.Controls.Add(this.cmbROMType);
            this.Controls.Add(this.txtMakerCode);
            this.Controls.Add(this.lbMakerCode);
            this.Controls.Add(this.btnGetROMInfo);
            this.Controls.Add(this.lbROMSize);
            this.Controls.Add(this.cmbCOMPort);
            this.Controls.Add(this.btnExtract);
            this.Name = "WinHongKongArduino";
            this.RightToLeftLayout = true;
            this.Text = "WinHongKongArduino";
            this.Load += new System.EventHandler(this.WinHongKongArduino_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.Label lbROMSize;
        private System.Windows.Forms.Button btnGetROMInfo;
        private System.Windows.Forms.Label lbMakerCode;
        private System.Windows.Forms.TextBox txtMakerCode;
        private System.Windows.Forms.ComboBox cmbROMType;
        private System.Windows.Forms.Label lbROMType;
        private System.Windows.Forms.ComboBox cmbROMCompo;
        private System.Windows.Forms.Label lbROMCompo;
        private System.Windows.Forms.ComboBox cmbROMSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRAMSize;
        private System.Windows.Forms.Label lbRAMSize;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TextBox txtGameCode;
        private System.Windows.Forms.Label lbGameCode;
        private System.Windows.Forms.Label lbSpecialVer;
        private System.Windows.Forms.TextBox txtSpecialVer;
        private System.Windows.Forms.Label lbSubNumber;
        private System.Windows.Forms.TextBox txtSubNumber;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCoPro;
        private System.Windows.Forms.ComboBox cmbCoPro;
        private System.Windows.Forms.Label lbExRAMSize;
        private System.Windows.Forms.TextBox txtExRAMSize;
        private System.Windows.Forms.Label lbROMSpeed;
        private System.Windows.Forms.TextBox txtROMSpeed;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label lbComplementCheck;
        private System.Windows.Forms.TextBox txtComplementCheck;
        private System.Windows.Forms.Label lbCheckSum;
        private System.Windows.Forms.TextBox txtCheckSum;
    }
}

