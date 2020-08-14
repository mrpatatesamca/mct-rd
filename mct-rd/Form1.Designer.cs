namespace mct_rd
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tabloÇizgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bütünÇizgileriGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadeceDikeyÇizgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadeceYatayÇizgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsuydusayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enlem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boylam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anlikirtifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsirtifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpsmaksirtifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baroirtifamaks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yatayhiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gkuvvet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kameradurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.konidurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ortagovdedurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yuklemebaslatTimer = new System.Windows.Forms.Timer(this.components);
            this.dosyaTarihLabel = new System.Windows.Forms.Label();
            this.dosyaturuLabel = new System.Windows.Forms.Label();
            this.karakterSayiLabel = new System.Windows.Forms.Label();
            this.satirSayiLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dosyaAcLabel = new System.Windows.Forms.Label();
            this.dosyaAcPictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosyaAcPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Tomato;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton4,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton1.Image = global::mct_rd.Properties.Resources.folder;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripDropDownButton1.Text = "Dosya Aç";
            this.toolStripDropDownButton1.ToolTipText = "Okumak için bir dosya açar";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton3.Image = global::mct_rd.Properties.Resources.new_file;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.ShowDropDownArrow = false;
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(161, 22);
            this.toolStripDropDownButton3.Text = "Yeni Okuma Penceresi Aç";
            this.toolStripDropDownButton3.ToolTipText = "Yeni bir pencere açar";
            this.toolStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabloÇizgileriToolStripMenuItem});
            this.toolStripDropDownButton5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton5.Image = global::mct_rd.Properties.Resources.window;
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.ShowDropDownArrow = false;
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(78, 22);
            this.toolStripDropDownButton5.Text = "Görünüm";
            this.toolStripDropDownButton5.ToolTipText = "Görünüm seçeneklerini ayarlayın";
            // 
            // tabloÇizgileriToolStripMenuItem
            // 
            this.tabloÇizgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bütünÇizgileriGösterToolStripMenuItem,
            this.sadeceDikeyÇizgilerToolStripMenuItem,
            this.sadeceYatayÇizgilerToolStripMenuItem});
            this.tabloÇizgileriToolStripMenuItem.Image = global::mct_rd.Properties.Resources.rows;
            this.tabloÇizgileriToolStripMenuItem.Name = "tabloÇizgileriToolStripMenuItem";
            this.tabloÇizgileriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tabloÇizgileriToolStripMenuItem.Text = "Tablo Çizgileri";
            // 
            // bütünÇizgileriGösterToolStripMenuItem
            // 
            this.bütünÇizgileriGösterToolStripMenuItem.Image = global::mct_rd.Properties.Resources.sidebar;
            this.bütünÇizgileriGösterToolStripMenuItem.Name = "bütünÇizgileriGösterToolStripMenuItem";
            this.bütünÇizgileriGösterToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bütünÇizgileriGösterToolStripMenuItem.Text = "Bütün Çizgileri Göster";
            this.bütünÇizgileriGösterToolStripMenuItem.Click += new System.EventHandler(this.bütünÇizgileriGösterToolStripMenuItem_Click);
            // 
            // sadeceDikeyÇizgilerToolStripMenuItem
            // 
            this.sadeceDikeyÇizgilerToolStripMenuItem.Image = global::mct_rd.Properties.Resources.vertical_align;
            this.sadeceDikeyÇizgilerToolStripMenuItem.Name = "sadeceDikeyÇizgilerToolStripMenuItem";
            this.sadeceDikeyÇizgilerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sadeceDikeyÇizgilerToolStripMenuItem.Text = "Sadece Dikey Çizgiler";
            this.sadeceDikeyÇizgilerToolStripMenuItem.Click += new System.EventHandler(this.sadeceDikeyÇizgilerToolStripMenuItem_Click);
            // 
            // sadeceYatayÇizgilerToolStripMenuItem
            // 
            this.sadeceYatayÇizgilerToolStripMenuItem.Image = global::mct_rd.Properties.Resources.horizontal_align;
            this.sadeceYatayÇizgilerToolStripMenuItem.Name = "sadeceYatayÇizgilerToolStripMenuItem";
            this.sadeceYatayÇizgilerToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.sadeceYatayÇizgilerToolStripMenuItem.Text = "Sadece Yatay Çizgiler";
            this.sadeceYatayÇizgilerToolStripMenuItem.Click += new System.EventHandler(this.sadeceYatayÇizgilerToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton4.Image = global::mct_rd.Properties.Resources.brush;
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.ShowDropDownArrow = false;
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(66, 22);
            this.toolStripDropDownButton4.Text = "Temizle";
            this.toolStripDropDownButton4.ToolTipText = "Şu anki penceredeki verileri temizler";
            this.toolStripDropDownButton4.Click += new System.EventHandler(this.toolStripDropDownButton4_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoToolTip = false;
            this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripDropDownButton2.Image = global::mct_rd.Properties.Resources.info;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(77, 22);
            this.toolStripDropDownButton2.Text = "Hakkında";
            this.toolStripDropDownButton2.ToolTipText = "Program ve açılan dosya hakkında bilgileri gösterir";
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.saat,
            this.gpsuydusayi,
            this.hdop,
            this.enlem,
            this.boylam,
            this.anlikirtifa,
            this.gpsirtifa,
            this.gpsmaksirtifa,
            this.baroirtifamaks,
            this.yatayhiz,
            this.acix,
            this.aciy,
            this.gkuvvet,
            this.kameradurum,
            this.konidurum,
            this.ortagovdedurum});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(784, 375);
            this.dataGridView1.TabIndex = 1;
            // 
            // saat
            // 
            this.saat.FillWeight = 70F;
            this.saat.HeaderText = "Saat";
            this.saat.Name = "saat";
            this.saat.ReadOnly = true;
            this.saat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gpsuydusayi
            // 
            this.gpsuydusayi.FillWeight = 50F;
            this.gpsuydusayi.HeaderText = "Uydu Sayısı";
            this.gpsuydusayi.Name = "gpsuydusayi";
            this.gpsuydusayi.ReadOnly = true;
            this.gpsuydusayi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // hdop
            // 
            this.hdop.FillWeight = 40F;
            this.hdop.HeaderText = "HDOP";
            this.hdop.Name = "hdop";
            this.hdop.ReadOnly = true;
            this.hdop.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // enlem
            // 
            this.enlem.FillWeight = 150F;
            this.enlem.HeaderText = "Enlem";
            this.enlem.Name = "enlem";
            this.enlem.ReadOnly = true;
            this.enlem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // boylam
            // 
            this.boylam.FillWeight = 150F;
            this.boylam.HeaderText = "Boylam";
            this.boylam.Name = "boylam";
            this.boylam.ReadOnly = true;
            this.boylam.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // anlikirtifa
            // 
            this.anlikirtifa.FillWeight = 60F;
            this.anlikirtifa.HeaderText = "Anlık İrtifa";
            this.anlikirtifa.Name = "anlikirtifa";
            this.anlikirtifa.ReadOnly = true;
            this.anlikirtifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gpsirtifa
            // 
            this.gpsirtifa.FillWeight = 60F;
            this.gpsirtifa.HeaderText = "İrtifa (GPS)";
            this.gpsirtifa.Name = "gpsirtifa";
            this.gpsirtifa.ReadOnly = true;
            this.gpsirtifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gpsmaksirtifa
            // 
            this.gpsmaksirtifa.FillWeight = 60F;
            this.gpsmaksirtifa.HeaderText = "Maks İrtifa (GPS)";
            this.gpsmaksirtifa.Name = "gpsmaksirtifa";
            this.gpsmaksirtifa.ReadOnly = true;
            this.gpsmaksirtifa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // baroirtifamaks
            // 
            this.baroirtifamaks.FillWeight = 60F;
            this.baroirtifamaks.HeaderText = "Maks İrtifa (Barometrik)";
            this.baroirtifamaks.Name = "baroirtifamaks";
            this.baroirtifamaks.ReadOnly = true;
            this.baroirtifamaks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yatayhiz
            // 
            this.yatayhiz.FillWeight = 70F;
            this.yatayhiz.HeaderText = "Yatay Hız";
            this.yatayhiz.Name = "yatayhiz";
            this.yatayhiz.ReadOnly = true;
            this.yatayhiz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // acix
            // 
            this.acix.FillWeight = 45F;
            this.acix.HeaderText = "X Açısı";
            this.acix.Name = "acix";
            this.acix.ReadOnly = true;
            this.acix.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // aciy
            // 
            this.aciy.FillWeight = 45F;
            this.aciy.HeaderText = "Y Açısı";
            this.aciy.Name = "aciy";
            this.aciy.ReadOnly = true;
            this.aciy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // gkuvvet
            // 
            this.gkuvvet.FillWeight = 45F;
            this.gkuvvet.HeaderText = "G Kuvveti";
            this.gkuvvet.Name = "gkuvvet";
            this.gkuvvet.ReadOnly = true;
            this.gkuvvet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kameradurum
            // 
            this.kameradurum.FillWeight = 65F;
            this.kameradurum.HeaderText = "Kamera Durumu";
            this.kameradurum.Name = "kameradurum";
            this.kameradurum.ReadOnly = true;
            this.kameradurum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // konidurum
            // 
            this.konidurum.FillWeight = 65F;
            this.konidurum.HeaderText = "Koni Durumu";
            this.konidurum.Name = "konidurum";
            this.konidurum.ReadOnly = true;
            this.konidurum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ortagovdedurum
            // 
            this.ortagovdedurum.FillWeight = 65F;
            this.ortagovdedurum.HeaderText = "Orta Gövde Durumu";
            this.ortagovdedurum.Name = "ortagovdedurum";
            this.ortagovdedurum.ReadOnly = true;
            this.ortagovdedurum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // yuklemebaslatTimer
            // 
            this.yuklemebaslatTimer.Interval = 1453;
            this.yuklemebaslatTimer.Tick += new System.EventHandler(this.yuklemebaslatTimer_Tick);
            // 
            // dosyaTarihLabel
            // 
            this.dosyaTarihLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dosyaTarihLabel.BackColor = System.Drawing.Color.Tomato;
            this.dosyaTarihLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaTarihLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dosyaTarihLabel.Location = new System.Drawing.Point(563, 0);
            this.dosyaTarihLabel.Name = "dosyaTarihLabel";
            this.dosyaTarihLabel.Size = new System.Drawing.Size(213, 23);
            this.dosyaTarihLabel.TabIndex = 2;
            this.dosyaTarihLabel.Text = "Kayıt Zamanı: 99-99-9999 | 99:99:99";
            this.dosyaTarihLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dosyaturuLabel
            // 
            this.dosyaturuLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dosyaturuLabel.BackColor = System.Drawing.Color.Transparent;
            this.dosyaturuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dosyaturuLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dosyaturuLabel.Location = new System.Drawing.Point(467, 0);
            this.dosyaturuLabel.Name = "dosyaturuLabel";
            this.dosyaturuLabel.Size = new System.Drawing.Size(230, 23);
            this.dosyaturuLabel.TabIndex = 3;
            this.dosyaturuLabel.Text = "Dosya Türü: Metin Belgesi | *.txt";
            this.dosyaturuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // karakterSayiLabel
            // 
            this.karakterSayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.karakterSayiLabel.BackColor = System.Drawing.Color.Transparent;
            this.karakterSayiLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.karakterSayiLabel.Location = new System.Drawing.Point(1, 0);
            this.karakterSayiLabel.Name = "karakterSayiLabel";
            this.karakterSayiLabel.Size = new System.Drawing.Size(230, 23);
            this.karakterSayiLabel.TabIndex = 4;
            this.karakterSayiLabel.Text = "Karakter Sayısı: 0";
            this.karakterSayiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // satirSayiLabel
            // 
            this.satirSayiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.satirSayiLabel.BackColor = System.Drawing.Color.Transparent;
            this.satirSayiLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.satirSayiLabel.Location = new System.Drawing.Point(231, 0);
            this.satirSayiLabel.Name = "satirSayiLabel";
            this.satirSayiLabel.Size = new System.Drawing.Size(230, 23);
            this.satirSayiLabel.TabIndex = 5;
            this.satirSayiLabel.Text = "Satır Sayısı: 0";
            this.satirSayiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.satirSayiLabel);
            this.panel1.Controls.Add(this.karakterSayiLabel);
            this.panel1.Controls.Add(this.dosyaturuLabel);
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 23);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::mct_rd.Properties.Resources.COSMOSLogoYUV;
            this.pictureBox1.Location = new System.Drawing.Point(765, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // dosyaAcLabel
            // 
            this.dosyaAcLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosyaAcLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dosyaAcLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dosyaAcLabel.Location = new System.Drawing.Point(290, 237);
            this.dosyaAcLabel.Name = "dosyaAcLabel";
            this.dosyaAcLabel.Size = new System.Drawing.Size(204, 37);
            this.dosyaAcLabel.TabIndex = 8;
            this.dosyaAcLabel.Text = "Başlamak için buraya ya da sol yukarıdaki \"Dosya Aç\" butonuna basın.";
            this.dosyaAcLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dosyaAcLabel.Click += new System.EventHandler(this.dosyaAcLabel_Click);
            // 
            // dosyaAcPictureBox
            // 
            this.dosyaAcPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dosyaAcPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dosyaAcPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dosyaAcPictureBox.Image = global::mct_rd.Properties.Resources.open_folder;
            this.dosyaAcPictureBox.Location = new System.Drawing.Point(356, 162);
            this.dosyaAcPictureBox.Name = "dosyaAcPictureBox";
            this.dosyaAcPictureBox.Size = new System.Drawing.Size(72, 72);
            this.dosyaAcPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dosyaAcPictureBox.TabIndex = 7;
            this.dosyaAcPictureBox.TabStop = false;
            this.dosyaAcPictureBox.Click += new System.EventHandler(this.dosyaAcPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.dosyaAcLabel);
            this.Controls.Add(this.dosyaAcPictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dosyaTarihLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 460);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mCTerminal Okuyucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dosyaAcPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer yuklemebaslatTimer;
        private System.Windows.Forms.Label dosyaTarihLabel;
        private System.Windows.Forms.Label dosyaturuLabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.Label karakterSayiLabel;
        private System.Windows.Forms.Label satirSayiLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saat;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsuydusayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn hdop;
        private System.Windows.Forms.DataGridViewTextBoxColumn enlem;
        private System.Windows.Forms.DataGridViewTextBoxColumn boylam;
        private System.Windows.Forms.DataGridViewTextBoxColumn anlikirtifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsirtifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpsmaksirtifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn baroirtifamaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn yatayhiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn acix;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciy;
        private System.Windows.Forms.DataGridViewTextBoxColumn gkuvvet;
        private System.Windows.Forms.DataGridViewTextBoxColumn kameradurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn konidurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortagovdedurum;
        private System.Windows.Forms.PictureBox dosyaAcPictureBox;
        private System.Windows.Forms.Label dosyaAcLabel;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripMenuItem tabloÇizgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bütünÇizgileriGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadeceDikeyÇizgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadeceYatayÇizgilerToolStripMenuItem;
    }
}

