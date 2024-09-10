namespace deneme12
{
    partial class DüzenleFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DüzenleFrm));
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            TxtAd = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            CmbTur = new DevExpress.XtraEditors.ComboBoxEdit();
            TxtYazar = new DevExpress.XtraEditors.TextEdit();
            TxtSayfa = new DevExpress.XtraEditors.TextEdit();
            BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)TxtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CmbTur.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtYazar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TxtSayfa.Properties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(35, 19);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(87, 23);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Kitap Adı :";
            // 
            // TxtAd
            // 
            TxtAd.Location = new System.Drawing.Point(128, 16);
            TxtAd.Name = "TxtAd";
            TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            TxtAd.Properties.Appearance.Options.UseFont = true;
            TxtAd.Size = new System.Drawing.Size(195, 30);
            TxtAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(63, 60);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(59, 23);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Yazar :";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(63, 101);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(59, 23);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Sayfa :";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(80, 146);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(42, 23);
            labelControl4.TabIndex = 6;
            labelControl4.Text = "Tür :";
            // 
            // CmbTur
            // 
            CmbTur.Location = new System.Drawing.Point(128, 143);
            CmbTur.Name = "CmbTur";
            CmbTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            CmbTur.Properties.Appearance.Options.UseFont = true;
            CmbTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            CmbTur.Properties.Items.AddRange(new object[] { "Roman", "Edebiyat", "Biyografi", "Kişisel Gelişim", "Araştırma-İnceleme", "Psikoloji" });
            CmbTur.Size = new System.Drawing.Size(195, 30);
            CmbTur.TabIndex = 4;
            // 
            // TxtYazar
            // 
            TxtYazar.Location = new System.Drawing.Point(128, 57);
            TxtYazar.Name = "TxtYazar";
            TxtYazar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            TxtYazar.Properties.Appearance.Options.UseFont = true;
            TxtYazar.Size = new System.Drawing.Size(195, 30);
            TxtYazar.TabIndex = 2;
            // 
            // TxtSayfa
            // 
            TxtSayfa.Location = new System.Drawing.Point(128, 98);
            TxtSayfa.Name = "TxtSayfa";
            TxtSayfa.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            TxtSayfa.Properties.Appearance.Options.UseFont = true;
            TxtSayfa.Size = new System.Drawing.Size(195, 30);
            TxtSayfa.TabIndex = 3;
            // 
            // BtnEkle
            // 
            BtnEkle.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            BtnEkle.Appearance.Options.UseBackColor = true;
            BtnEkle.Appearance.Options.UseFont = true;
            BtnEkle.Location = new System.Drawing.Point(366, 70);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new System.Drawing.Size(90, 41);
            BtnEkle.TabIndex = 5;
            BtnEkle.Text = "Tamam";
            BtnEkle.Click += BtnEkle_Click_1;
            // 
            // DüzenleFrm
            // 
            AcceptButton = BtnEkle;
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Bisque;
            ClientSize = new System.Drawing.Size(484, 208);
            Controls.Add(TxtYazar);
            Controls.Add(labelControl1);
            Controls.Add(BtnEkle);
            Controls.Add(TxtAd);
            Controls.Add(labelControl3);
            Controls.Add(TxtSayfa);
            Controls.Add(labelControl4);
            Controls.Add(labelControl2);
            Controls.Add(CmbTur);
            Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 162);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5);
            Name = "DüzenleFrm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyon 0.1.0";
            ((System.ComponentModel.ISupportInitialize)TxtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)CmbTur.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtYazar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)TxtSayfa.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit CmbTur;
        private DevExpress.XtraEditors.TextEdit TxtYazar;
        private DevExpress.XtraEditors.TextEdit TxtSayfa;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
    }
}