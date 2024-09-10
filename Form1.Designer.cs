namespace deneme12
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colKitapAd = new DevExpress.XtraGrid.Columns.GridColumn();
            colYazar = new DevExpress.XtraGrid.Columns.GridColumn();
            colTur = new DevExpress.XtraGrid.Columns.GridColumn();
            colSayfa = new DevExpress.XtraGrid.Columns.GridColumn();
            Delete = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            update = new DevExpress.XtraGrid.Columns.GridColumn();
            Düzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(components);
            BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Düzenle).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = typeof(Book);
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            gridControl1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            gridControl1.Location = new System.Drawing.Point(56, 91);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemButtonEdit1, Düzenle });
            gridControl1.Size = new System.Drawing.Size(683, 267);
            gridControl1.TabIndex = 9;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colKitapAd, colYazar, colTur, colSayfa, Delete, update });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colKitapAd
            // 
            colKitapAd.FieldName = "KitapAd";
            colKitapAd.Name = "colKitapAd";
            colKitapAd.Visible = true;
            colKitapAd.VisibleIndex = 0;
            colKitapAd.Width = 170;
            // 
            // colYazar
            // 
            colYazar.FieldName = "Yazar";
            colYazar.Name = "colYazar";
            colYazar.Visible = true;
            colYazar.VisibleIndex = 1;
            colYazar.Width = 170;
            // 
            // colTur
            // 
            colTur.FieldName = "Tur";
            colTur.Name = "colTur";
            colTur.Visible = true;
            colTur.VisibleIndex = 2;
            colTur.Width = 170;
            // 
            // colSayfa
            // 
            colSayfa.FieldName = "Sayfa";
            colSayfa.Name = "colSayfa";
            colSayfa.Visible = true;
            colSayfa.VisibleIndex = 3;
            colSayfa.Width = 57;
            // 
            // Delete
            // 
            Delete.Caption = "Sil";
            Delete.ColumnEdit = repositoryItemButtonEdit1;
            Delete.Name = "Delete";
            Delete.Visible = true;
            Delete.VisibleIndex = 4;
            Delete.Width = 25;
            // 
            // repositoryItemButtonEdit1
            // 
            repositoryItemButtonEdit1.AutoHeight = false;
            repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete) });
            repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            repositoryItemButtonEdit1.Click += repositoryItemButtonEdit1_Click;
            // 
            // update
            // 
            update.Caption = "Düzenle";
            update.ColumnEdit = Düzenle;
            update.Name = "update";
            update.Visible = true;
            update.VisibleIndex = 5;
            update.Width = 40;
            // 
            // Düzenle
            // 
            Düzenle.AutoHeight = false;
            editorButtonImageOptions1.Image = (System.Drawing.Image)resources.GetObject("editorButtonImageOptions1.Image");
            Düzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 13, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default) });
            Düzenle.Name = "Düzenle";
            Düzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            Düzenle.Click += Düzenle_Click;
            // 
            // sqlDataSource1
            // 
            sqlDataSource1.Name = "sqlDataSource1";
            // 
            // BtnEkle
            // 
            BtnEkle.Appearance.BackColor = System.Drawing.Color.Salmon;
            BtnEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F);
            BtnEkle.Appearance.Options.UseBackColor = true;
            BtnEkle.Appearance.Options.UseFont = true;
            BtnEkle.Location = new System.Drawing.Point(56, 38);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new System.Drawing.Size(151, 34);
            BtnEkle.TabIndex = 1;
            BtnEkle.Text = "Ekle";
            BtnEkle.Click += BtnEkle_Click_1;
            // 
            // Form1
            // 
            AcceptButton = BtnEkle;
            Appearance.BackColor = System.Drawing.Color.Tan;
            Appearance.Options.UseBackColor = true;
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 462);
            Controls.Add(BtnEkle);
            Controls.Add(gridControl1);
            Font = new System.Drawing.Font("Tahoma", 14.25F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            IconOptions.Image = (System.Drawing.Image)resources.GetObject("Form1.IconOptions.Image");
            Margin = new System.Windows.Forms.Padding(5);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyon 0.1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemButtonEdit1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Düzenle).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraGrid.Columns.GridColumn colKitapAd;
        private DevExpress.XtraGrid.Columns.GridColumn colYazar;
        private DevExpress.XtraGrid.Columns.GridColumn colTur;
        private DevExpress.XtraGrid.Columns.GridColumn colSayfa;
        private DevExpress.XtraGrid.Columns.GridColumn Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit Düzenle;
        private DevExpress.XtraGrid.Columns.GridColumn update;
    }
}

