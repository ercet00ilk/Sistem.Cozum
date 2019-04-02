using System;
using DevExpress.XtraBars;

namespace Sistem.Masaustu.Paneller.Cari
{
    partial class CariListesi
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnYeniCari = new DevExpress.XtraBars.BarButtonItem();
            this.BtnSeciliCariSil = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem3 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnPdfAktar = new DevExpress.XtraBars.BarButtonItem();
            this.btnExcelAktar = new DevExpress.XtraBars.BarButtonItem();
            this.btnHtmlAktar = new DevExpress.XtraBars.BarButtonItem();
            this.cbxMusteriGrubu = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbxSehir = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbxMusteriTipi = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbxMusteriTemsilcisi = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.cbxBorcAlacak = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnFiltrele = new DevExpress.XtraBars.BarButtonItem();
            this.btnFiltreyiTemizle = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.BtnYeniCari,
            this.BtnSeciliCariSil,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barStaticItem3,
            this.barStaticItem4,
            this.barSubItem1,
            this.btnPdfAktar,
            this.btnExcelAktar,
            this.btnHtmlAktar,
            this.cbxMusteriGrubu,
            this.cbxSehir,
            this.cbxMusteriTipi,
            this.cbxMusteriTemsilcisi,
            this.cbxBorcAlacak,
            this.btnFiltrele,
            this.btnFiltreyiTemizle});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2,
            this.repositoryItemComboBox3,
            this.repositoryItemComboBox4,
            this.repositoryItemComboBox5});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1124, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BtnYeniCari
            // 
            this.BtnYeniCari.Caption = "Yeni Cari Ekle";
            this.BtnYeniCari.Id = 1;
            this.BtnYeniCari.ImageOptions.LargeImage = global::Sistem.Masaustu.Properties.Resources.add_group;
            this.BtnYeniCari.Name = "BtnYeniCari";
            this.BtnYeniCari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnYeniCari_ItemClick);
            // 
            // BtnSeciliCariSil
            // 
            this.BtnSeciliCariSil.Caption = "Cariyi Sil";
            this.BtnSeciliCariSil.Id = 2;
            this.BtnSeciliCariSil.ImageOptions.LargeImage = global::Sistem.Masaustu.Properties.Resources.delete;
            this.BtnSeciliCariSil.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3));
            this.BtnSeciliCariSil.Name = "BtnSeciliCariSil";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Cari Kaydı: 105";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Alacak: 0,00 TL";
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barStaticItem3
            // 
            this.barStaticItem3.Caption = "Borç: 0,00 TL";
            this.barStaticItem3.Id = 5;
            this.barStaticItem3.Name = "barStaticItem3";
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Bakiye: 0,00 TL";
            this.barStaticItem4.Id = 6;
            this.barStaticItem4.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.barStaticItem4.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Blue;
            this.barStaticItem4.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem4.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Dışa Aktar";
            this.barSubItem1.Id = 7;
            this.barSubItem1.ImageOptions.LargeImage = global::Sistem.Masaustu.Properties.Resources.share;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfAktar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelAktar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHtmlAktar)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnPdfAktar
            // 
            this.btnPdfAktar.Caption = "PDF\'e Aktar";
            this.btnPdfAktar.Id = 8;
            this.btnPdfAktar.Name = "btnPdfAktar";
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Caption = "Excel\'e Aktar";
            this.btnExcelAktar.Id = 9;
            this.btnExcelAktar.Name = "btnExcelAktar";
            // 
            // btnHtmlAktar
            // 
            this.btnHtmlAktar.Caption = "HTML\'e Aktar";
            this.btnHtmlAktar.Id = 10;
            this.btnHtmlAktar.Name = "btnHtmlAktar";
            // 
            // cbxMusteriGrubu
            // 
            this.cbxMusteriGrubu.Caption = "Müşteri Grubu  ";
            this.cbxMusteriGrubu.Edit = this.repositoryItemComboBox1;
            this.cbxMusteriGrubu.EditWidth = 200;
            this.cbxMusteriGrubu.Id = 11;
            this.cbxMusteriGrubu.Name = "cbxMusteriGrubu";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // cbxSehir
            // 
            this.cbxSehir.Caption = "Şehir                ";
            this.cbxSehir.Edit = this.repositoryItemComboBox2;
            this.cbxSehir.EditWidth = 200;
            this.cbxSehir.Id = 12;
            this.cbxSehir.Name = "cbxSehir";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // cbxMusteriTipi
            // 
            this.cbxMusteriTipi.Caption = "Müşteri Tipi      ";
            this.cbxMusteriTipi.Edit = this.repositoryItemComboBox3;
            this.cbxMusteriTipi.EditWidth = 200;
            this.cbxMusteriTipi.Id = 13;
            this.cbxMusteriTipi.Name = "cbxMusteriTipi";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // cbxMusteriTemsilcisi
            // 
            this.cbxMusteriTemsilcisi.Caption = "Müşteri Temsilcisi    ";
            this.cbxMusteriTemsilcisi.Edit = this.repositoryItemComboBox4;
            this.cbxMusteriTemsilcisi.EditWidth = 200;
            this.cbxMusteriTemsilcisi.Id = 14;
            this.cbxMusteriTemsilcisi.Name = "cbxMusteriTemsilcisi";
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // cbxBorcAlacak
            // 
            this.cbxBorcAlacak.Caption = "Borç / Alacak          ";
            this.cbxBorcAlacak.Edit = this.repositoryItemComboBox5;
            this.cbxBorcAlacak.EditWidth = 200;
            this.cbxBorcAlacak.Id = 15;
            this.cbxBorcAlacak.Name = "cbxBorcAlacak";
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Caption = "Filtreyi Uygula";
            this.btnFiltrele.Id = 16;
            this.btnFiltrele.ImageOptions.LargeImage = global::Sistem.Masaustu.Properties.Resources.filter;
            this.btnFiltrele.Name = "btnFiltrele";
            // 
            // btnFiltreyiTemizle
            // 
            this.btnFiltreyiTemizle.Caption = "Filtreyi Temizle";
            this.btnFiltreyiTemizle.Id = 17;
            this.btnFiltreyiTemizle.ImageOptions.LargeImage = global::Sistem.Masaustu.Properties.Resources.cancel;
            this.btnFiltreyiTemizle.Name = "btnFiltreyiTemizle";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnYeniCari);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnSeciliCariSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.barSubItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Dosya";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.cbxMusteriGrubu);
            this.ribbonPageGroup2.ItemLinks.Add(this.cbxSehir);
            this.ribbonPageGroup2.ItemLinks.Add(this.cbxMusteriTipi);
            this.ribbonPageGroup2.ItemLinks.Add(this.cbxMusteriTemsilcisi);
            this.ribbonPageGroup2.ItemLinks.Add(this.cbxBorcAlacak);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnFiltrele);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnFiltreyiTemizle);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Filtrele";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2, true);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem3);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem4, true);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 741);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1124, 31);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbon;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1124, 598);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Ara...";
            this.gridView1.OptionsFind.SearchInPreview = true;
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cari Kodu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 188;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Müşteri Adı";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 188;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Yetkili";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 188;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Cari Tipi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 256;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "B/A/S";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 151;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 157;
            // 
            // CariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 772);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "CariListesi";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cari Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnYeniCari_ItemClick(object sender, ItemClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BtnYeniCari;
        private DevExpress.XtraBars.BarButtonItem BtnSeciliCariSil;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem3;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnPdfAktar;
        private DevExpress.XtraBars.BarButtonItem btnExcelAktar;
        private DevExpress.XtraBars.BarButtonItem btnHtmlAktar;
        private DevExpress.XtraBars.BarEditItem cbxMusteriGrubu;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarEditItem cbxSehir;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.BarEditItem cbxMusteriTipi;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraBars.BarEditItem cbxMusteriTemsilcisi;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraBars.BarEditItem cbxBorcAlacak;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraBars.BarButtonItem btnFiltrele;
        private DevExpress.XtraBars.BarButtonItem btnFiltreyiTemizle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}