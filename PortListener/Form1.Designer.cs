namespace PortListener
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnExceleAktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnDurdur = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaslat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.seCalismaAraligi = new DevExpress.XtraEditors.SpinEdit();
            this.seCalismaSuresi = new DevExpress.XtraEditors.SpinEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSicaklik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.btnIstatistikAktar = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seCalismaAraligi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCalismaSuresi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnIstatistikAktar);
            this.panelControl1.Controls.Add(this.btnExceleAktar);
            this.panelControl1.Controls.Add(this.btnDurdur);
            this.panelControl1.Controls.Add(this.btnKapat);
            this.panelControl1.Controls.Add(this.btnTemizle);
            this.panelControl1.Controls.Add(this.btnBaslat);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.seCalismaAraligi);
            this.panelControl1.Controls.Add(this.seCalismaSuresi);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(708, 69);
            this.panelControl1.TabIndex = 0;
            // 
            // btnExceleAktar
            // 
            this.btnExceleAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExceleAktar.ImageOptions.Image")));
            this.btnExceleAktar.Location = new System.Drawing.Point(357, 9);
            this.btnExceleAktar.Name = "btnExceleAktar";
            this.btnExceleAktar.Size = new System.Drawing.Size(108, 22);
            this.btnExceleAktar.TabIndex = 2;
            this.btnExceleAktar.Text = "Excel\'e Aktar";
            this.btnExceleAktar.Click += new System.EventHandler(this.btnExceleAktar_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDurdur.ImageOptions.Image")));
            this.btnDurdur.Location = new System.Drawing.Point(243, 34);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(108, 22);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBaslat.ImageOptions.Image")));
            this.btnBaslat.Location = new System.Drawing.Point(243, 8);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(108, 22);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 39);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(118, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Çalışma Aralığı (Saniye) :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Çalışma Süresi (Dakika) :";
            // 
            // seCalismaAraligi
            // 
            this.seCalismaAraligi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seCalismaAraligi.Location = new System.Drawing.Point(150, 36);
            this.seCalismaAraligi.Name = "seCalismaAraligi";
            this.seCalismaAraligi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seCalismaAraligi.Properties.Mask.EditMask = "f0";
            this.seCalismaAraligi.Size = new System.Drawing.Size(68, 20);
            this.seCalismaAraligi.TabIndex = 0;
            // 
            // seCalismaSuresi
            // 
            this.seCalismaSuresi.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seCalismaSuresi.Location = new System.Drawing.Point(150, 10);
            this.seCalismaSuresi.Name = "seCalismaSuresi";
            this.seCalismaSuresi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seCalismaSuresi.Properties.Mask.EditMask = "f0";
            this.seCalismaSuresi.Size = new System.Drawing.Size(68, 20);
            this.seCalismaSuresi.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.Location = new System.Drawing.Point(0, 75);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(204, 463);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSaat,
            this.colSicaklik});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "hh:mm:ss";
            this.colSaat.FieldName = "Tarih";
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 0;
            // 
            // colSicaklik
            // 
            this.colSicaklik.Caption = "Sıcaklık";
            this.colSicaklik.DisplayFormat.FormatString = "N2";
            this.colSicaklik.FieldName = "Sicaklik";
            this.colSicaklik.Name = "colSicaklik";
            this.colSicaklik.OptionsColumn.AllowEdit = false;
            this.colSicaklik.Visible = true;
            this.colSicaklik.VisibleIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.DataBindings = null;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(210, 75);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(498, 463);
            this.chartControl1.TabIndex = 2;
            // 
            // btnIstatistikAktar
            // 
            this.btnIstatistikAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnIstatistikAktar.Location = new System.Drawing.Point(357, 35);
            this.btnIstatistikAktar.Name = "btnIstatistikAktar";
            this.btnIstatistikAktar.Size = new System.Drawing.Size(108, 22);
            this.btnIstatistikAktar.TabIndex = 3;
            this.btnIstatistikAktar.Text = "Istatistik Aktar";
            this.btnIstatistikAktar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image1")));
            this.btnTemizle.Location = new System.Drawing.Point(471, 8);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(108, 22);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(471, 34);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(108, 22);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 541);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SedBim Serial Port Listener";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seCalismaAraligi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seCalismaSuresi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SimpleButton btnExceleAktar;
        private DevExpress.XtraEditors.SimpleButton btnDurdur;
        private DevExpress.XtraEditors.SimpleButton btnBaslat;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seCalismaAraligi;
        private DevExpress.XtraEditors.SpinEdit seCalismaSuresi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colSicaklik;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraEditors.SimpleButton btnIstatistikAktar;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}

