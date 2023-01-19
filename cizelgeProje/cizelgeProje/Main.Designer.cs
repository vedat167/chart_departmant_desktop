namespace cizelgeProje
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.dataGridCizelge = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kaydıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.lbl_Yapilan = new System.Windows.Forms.Label();
            this.lbl_Baslangic = new System.Windows.Forms.Label();
            this.lbl_Bitis = new System.Windows.Forms.Label();
            this.dateTimeTarih = new System.Windows.Forms.DateTimePicker();
            this.textBoxYapilan = new System.Windows.Forms.TextBox();
            this.comboBoxBaslangic = new System.Windows.Forms.ComboBox();
            this.comboBoxBitis = new System.Windows.Forms.ComboBox();
            this.comboPersonel = new System.Windows.Forms.ComboBox();
            this.lbl_Personel = new System.Windows.Forms.Label();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.lblHafta = new System.Windows.Forms.Label();
            this.lblHfta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusKayit = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCizelge)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCizelge
            // 
            this.dataGridCizelge.AllowUserToAddRows = false;
            this.dataGridCizelge.AllowUserToDeleteRows = false;
            this.dataGridCizelge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCizelge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCizelge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCizelge.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridCizelge.Location = new System.Drawing.Point(12, 247);
            this.dataGridCizelge.Name = "dataGridCizelge";
            this.dataGridCizelge.ReadOnly = true;
            this.dataGridCizelge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCizelge.Size = new System.Drawing.Size(1129, 202);
            this.dataGridCizelge.TabIndex = 0;
            this.dataGridCizelge.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridCizelge.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridCizelge.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydıGüncelleToolStripMenuItem,
            this.kaydıSilToolStripMenuItem,
            this.exceleAktarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // kaydıGüncelleToolStripMenuItem
            // 
            this.kaydıGüncelleToolStripMenuItem.Name = "kaydıGüncelleToolStripMenuItem";
            this.kaydıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydıGüncelleToolStripMenuItem.Text = "Kaydı Güncelle";
            this.kaydıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kaydıGüncelleToolStripMenuItem_Click);
            // 
            // kaydıSilToolStripMenuItem
            // 
            this.kaydıSilToolStripMenuItem.Name = "kaydıSilToolStripMenuItem";
            this.kaydıSilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kaydıSilToolStripMenuItem.Text = "Kaydı Sil";
            this.kaydıSilToolStripMenuItem.Click += new System.EventHandler(this.kaydıSilToolStripMenuItem_Click);
            // 
            // exceleAktarToolStripMenuItem
            // 
            this.exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            this.exceleAktarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exceleAktarToolStripMenuItem.Text = "Excele Aktar";
            this.exceleAktarToolStripMenuItem.Click += new System.EventHandler(this.exceleAktarToolStripMenuItem_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(171, 206);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(91, 35);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(290, 204);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(91, 35);
            this.buttonGuncelle.TabIndex = 7;
            this.buttonGuncelle.Text = "GÜNCELLE";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Visible = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(399, 206);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(91, 35);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Visible = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Location = new System.Drawing.Point(49, 68);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(40, 13);
            this.lbl_Tarih.TabIndex = 6;
            this.lbl_Tarih.Text = "TARİH";
            // 
            // lbl_Yapilan
            // 
            this.lbl_Yapilan.AutoSize = true;
            this.lbl_Yapilan.Location = new System.Drawing.Point(49, 155);
            this.lbl_Yapilan.Name = "lbl_Yapilan";
            this.lbl_Yapilan.Size = new System.Drawing.Size(65, 13);
            this.lbl_Yapilan.TabIndex = 6;
            this.lbl_Yapilan.Text = "YAPILAN İŞ";
            // 
            // lbl_Baslangic
            // 
            this.lbl_Baslangic.AutoSize = true;
            this.lbl_Baslangic.Location = new System.Drawing.Point(49, 96);
            this.lbl_Baslangic.Name = "lbl_Baslangic";
            this.lbl_Baslangic.Size = new System.Drawing.Size(101, 13);
            this.lbl_Baslangic.TabIndex = 6;
            this.lbl_Baslangic.Text = "BAŞLANGIÇ SAATİ";
            // 
            // lbl_Bitis
            // 
            this.lbl_Bitis.AutoSize = true;
            this.lbl_Bitis.Location = new System.Drawing.Point(49, 124);
            this.lbl_Bitis.Name = "lbl_Bitis";
            this.lbl_Bitis.Size = new System.Drawing.Size(68, 13);
            this.lbl_Bitis.TabIndex = 6;
            this.lbl_Bitis.Text = "BİTİŞ SAATİ";
            // 
            // dateTimeTarih
            // 
            this.dateTimeTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTarih.Location = new System.Drawing.Point(171, 65);
            this.dateTimeTarih.Name = "dateTimeTarih";
            this.dateTimeTarih.Size = new System.Drawing.Size(221, 20);
            this.dateTimeTarih.TabIndex = 2;
            this.dateTimeTarih.ValueChanged += new System.EventHandler(this.dateTimeTarih_ValueChanged);
            // 
            // textBoxYapilan
            // 
            this.textBoxYapilan.Location = new System.Drawing.Point(171, 147);
            this.textBoxYapilan.Multiline = true;
            this.textBoxYapilan.Name = "textBoxYapilan";
            this.textBoxYapilan.Size = new System.Drawing.Size(534, 53);
            this.textBoxYapilan.TabIndex = 5;
            // 
            // comboBoxBaslangic
            // 
            this.comboBoxBaslangic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBaslangic.FormattingEnabled = true;
            this.comboBoxBaslangic.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30"});
            this.comboBoxBaslangic.Location = new System.Drawing.Point(171, 88);
            this.comboBoxBaslangic.Name = "comboBoxBaslangic";
            this.comboBoxBaslangic.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBaslangic.TabIndex = 3;
            // 
            // comboBoxBitis
            // 
            this.comboBoxBitis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxBitis.FormattingEnabled = true;
            this.comboBoxBitis.Items.AddRange(new object[] {
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.comboBoxBitis.Location = new System.Drawing.Point(171, 116);
            this.comboBoxBitis.Name = "comboBoxBitis";
            this.comboBoxBitis.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBitis.TabIndex = 4;
            // 
            // comboPersonel
            // 
            this.comboPersonel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboPersonel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboPersonel.FormattingEnabled = true;
            this.comboPersonel.Location = new System.Drawing.Point(171, 33);
            this.comboPersonel.Name = "comboPersonel";
            this.comboPersonel.Size = new System.Drawing.Size(121, 26);
            this.comboPersonel.TabIndex = 1;
            this.comboPersonel.SelectedIndexChanged += new System.EventHandler(this.comboPersonel_SelectedIndexChanged);
            this.comboPersonel.SelectedValueChanged += new System.EventHandler(this.comboPersonel_SelectedValueChanged);
            // 
            // lbl_Personel
            // 
            this.lbl_Personel.AutoSize = true;
            this.lbl_Personel.Location = new System.Drawing.Point(49, 41);
            this.lbl_Personel.Name = "lbl_Personel";
            this.lbl_Personel.Size = new System.Drawing.Size(104, 13);
            this.lbl_Personel.TabIndex = 13;
            this.lbl_Personel.Text = "PERSONEL SEÇİMİ";
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(317, 31);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonGetir.TabIndex = 14;
            this.buttonGetir.Text = "GETİR";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // buttonIleri
            // 
            this.buttonIleri.Location = new System.Drawing.Point(155, 3);
            this.buttonIleri.Name = "buttonIleri";
            this.buttonIleri.Size = new System.Drawing.Size(42, 23);
            this.buttonIleri.TabIndex = 16;
            this.buttonIleri.Text = ">>";
            this.buttonIleri.UseVisualStyleBackColor = true;
            this.buttonIleri.Click += new System.EventHandler(this.buttonIleri_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Location = new System.Drawing.Point(38, 3);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(42, 23);
            this.buttonGeri.TabIndex = 17;
            this.buttonGeri.Text = "<<";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // lblHafta
            // 
            this.lblHafta.AutoSize = true;
            this.lblHafta.Location = new System.Drawing.Point(122, 8);
            this.lblHafta.Name = "lblHafta";
            this.lblHafta.Size = new System.Drawing.Size(0, 13);
            this.lblHafta.TabIndex = 18;
            // 
            // lblHfta
            // 
            this.lblHfta.AutoSize = true;
            this.lblHfta.Location = new System.Drawing.Point(86, 8);
            this.lblHfta.Name = "lblHfta";
            this.lblHfta.Size = new System.Drawing.Size(36, 13);
            this.lblHfta.TabIndex = 19;
            this.lblHfta.Text = "Hafta ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonIleri);
            this.panel1.Controls.Add(this.lblHfta);
            this.panel1.Controls.Add(this.buttonGeri);
            this.panel1.Controls.Add(this.lblHafta);
            this.panel1.Location = new System.Drawing.Point(943, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 33);
            this.panel1.TabIndex = 20;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusKayit});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1153, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusKayit
            // 
            this.toolStripStatusKayit.Name = "toolStripStatusKayit";
            this.toolStripStatusKayit.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusKayit.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Location = new System.Drawing.Point(20, 3);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(141, 35);
            this.buttonExcel.TabIndex = 22;
            this.buttonExcel.Text = "EXCEL E AKTAR";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Visible = false;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonExcel);
            this.panel2.Location = new System.Drawing.Point(977, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 49);
            this.panel2.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonGetir);
            this.Controls.Add(this.lbl_Personel);
            this.Controls.Add(this.comboPersonel);
            this.Controls.Add(this.comboBoxBitis);
            this.Controls.Add(this.comboBoxBaslangic);
            this.Controls.Add(this.textBoxYapilan);
            this.Controls.Add(this.dateTimeTarih);
            this.Controls.Add(this.lbl_Bitis);
            this.Controls.Add(this.lbl_Baslangic);
            this.Controls.Add(this.lbl_Yapilan);
            this.Controls.Add(this.lbl_Tarih);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.dataGridCizelge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCizelge)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCizelge;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Label lbl_Yapilan;
        private System.Windows.Forms.Label lbl_Baslangic;
        private System.Windows.Forms.Label lbl_Bitis;
        private System.Windows.Forms.DateTimePicker dateTimeTarih;
        private System.Windows.Forms.TextBox textBoxYapilan;
        private System.Windows.Forms.ComboBox comboBoxBaslangic;
        private System.Windows.Forms.ComboBox comboBoxBitis;
        private System.Windows.Forms.ComboBox comboPersonel;
        private System.Windows.Forms.Label lbl_Personel;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Label lblHafta;
        private System.Windows.Forms.Label lblHfta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusKayit;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydıSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exceleAktarToolStripMenuItem;
    }
}

