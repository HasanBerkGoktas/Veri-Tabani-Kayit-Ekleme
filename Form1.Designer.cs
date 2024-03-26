namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ogrenciBindingSource = new BindingSource(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            comboBoxSirala = new ComboBox();
            tabPage2 = new TabPage();
            txtOkulNo = new MaskedTextBox();
            btnGuncelle = new Button();
            dataGridView2 = new DataGridView();
            btnSil = new Button();
            comboBoxYeniOgr = new ComboBox();
            btnEkle = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSoyad = new TextBox();
            label1 = new Label();
            txtAd = new TextBox();
            tabPage3 = new TabPage();
            comboBox1 = new ComboBox();
            btnSinifSil = new Button();
            comboBoxSiniflar = new ComboBox();
            label7 = new Label();
            txtSube = new TextBox();
            button1 = new Button();
            label6 = new Label();
            txtSeviye = new TextBox();
            menuStrip1 = new MenuStrip();
            menuTema = new ToolStripMenuItem();
            textFontToolStripMenuItem = new ToolStripMenuItem();
            foreColorToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ogrenciBindingSource
            // 
            ogrenciBindingSource.DataSource = typeof(Modeller.Ogrenci);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(183, 37);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(641, 345);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(comboBoxSirala);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(633, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Öğrenci Listesi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 9);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 3;
            label5.Text = "Kategori -";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 42);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(617, 193);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // comboBoxSirala
            // 
            comboBoxSirala.FormattingEnabled = true;
            comboBoxSirala.Location = new Point(91, 11);
            comboBoxSirala.Name = "comboBoxSirala";
            comboBoxSirala.Size = new Size(121, 23);
            comboBoxSirala.TabIndex = 1;
            comboBoxSirala.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtOkulNo);
            tabPage2.Controls.Add(btnGuncelle);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(btnSil);
            tabPage2.Controls.Add(comboBoxYeniOgr);
            tabPage2.Controls.Add(btnEkle);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtSoyad);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtAd);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(633, 317);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Öğrenci Düzenleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtOkulNo
            // 
            txtOkulNo.Location = new Point(109, 67);
            txtOkulNo.Mask = "0000";
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(136, 23);
            txtOkulNo.TabIndex = 4;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(6, 165);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(239, 31);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Seçilen Öğrenciyi Düzenle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(251, 9);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(372, 223);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(6, 202);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(239, 30);
            btnSil.TabIndex = 13;
            btnSil.Text = "Seçilen Öğrenciyi Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil2_Click;
            // 
            // comboBoxYeniOgr
            // 
            comboBoxYeniOgr.FormattingEnabled = true;
            comboBoxYeniOgr.Location = new Point(109, 99);
            comboBoxYeniOgr.Name = "comboBoxYeniOgr";
            comboBoxYeniOgr.Size = new Size(136, 23);
            comboBoxYeniOgr.TabIndex = 11;
            comboBoxYeniOgr.SelectedIndexChanged += comboBoxYeniOgr_SelectedIndexChanged;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(6, 128);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(239, 31);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Yeni Öğrenci Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(94, 19);
            label4.TabIndex = 7;
            label4.Text = "Seviye / Şube -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 5;
            label3.Text = "Okul No -";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 3;
            label2.Text = "Soyad -";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(109, 38);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(136, 23);
            txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(42, 23);
            label1.TabIndex = 1;
            label1.Text = "Ad -";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(109, 9);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(136, 23);
            txtAd.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(btnSinifSil);
            tabPage3.Controls.Add(comboBoxSiniflar);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(txtSube);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(txtSeviye);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(633, 317);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Sınıf Düzenleme";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(442, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            // 
            // btnSinifSil
            // 
            btnSinifSil.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSinifSil.Location = new Point(15, 151);
            btnSinifSil.Name = "btnSinifSil";
            btnSinifSil.Size = new Size(206, 31);
            btnSinifSil.TabIndex = 17;
            btnSinifSil.Text = "Seçili Sınıfı Sil";
            btnSinifSil.UseVisualStyleBackColor = true;
            btnSinifSil.Click += btnSinifSil_Click;
            // 
            // comboBoxSiniflar
            // 
            comboBoxSiniflar.FormattingEnabled = true;
            comboBoxSiniflar.Location = new Point(15, 122);
            comboBoxSiniflar.Name = "comboBoxSiniflar";
            comboBoxSiniflar.Size = new Size(206, 23);
            comboBoxSiniflar.TabIndex = 16;
            comboBoxSiniflar.SelectedIndexChanged += comboBoxSiniflar_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(15, 45);
            label7.Name = "label7";
            label7.Size = new Size(54, 23);
            label7.TabIndex = 15;
            label7.Text = "Şube -";
            // 
            // txtSube
            // 
            txtSube.Location = new Point(85, 47);
            txtSube.Name = "txtSube";
            txtSube.Size = new Size(136, 23);
            txtSube.TabIndex = 14;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(15, 76);
            button1.Name = "button1";
            button1.Size = new Size(206, 31);
            button1.TabIndex = 13;
            button1.Text = "Yeni Sınıf Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(15, 13);
            label6.Name = "label6";
            label6.Size = new Size(64, 23);
            label6.TabIndex = 12;
            label6.Text = "Seviye -";
            // 
            // txtSeviye
            // 
            txtSeviye.Location = new Point(85, 15);
            txtSeviye.Name = "txtSeviye";
            txtSeviye.Size = new Size(136, 23);
            txtSeviye.TabIndex = 11;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuTema });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(833, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuTema
            // 
            menuTema.DropDownItems.AddRange(new ToolStripItem[] { textFontToolStripMenuItem, foreColorToolStripMenuItem });
            menuTema.Name = "menuTema";
            menuTema.Size = new Size(47, 20);
            menuTema.Text = "Tema";
            // 
            // textFontToolStripMenuItem
            // 
            textFontToolStripMenuItem.Name = "textFontToolStripMenuItem";
            textFontToolStripMenuItem.Size = new Size(129, 22);
            textFontToolStripMenuItem.Text = "Text Font ";
            textFontToolStripMenuItem.Click += textFontToolStripMenuItem_Click;
            // 
            // foreColorToolStripMenuItem
            // 
            foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            foreColorToolStripMenuItem.Size = new Size(129, 22);
            foreColorToolStripMenuItem.Text = "Fore Color";
            foreColorToolStripMenuItem.Click += foreColorToolStripMenuItem_Click;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "bilgilendirme";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 394);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ogrenciBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource ogrenciBindingSource;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private ComboBox comboBoxSirala;
        private TabPage tabPage2;
        private Label label1;
        private TextBox txtAd;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSoyad;
        private Button btnEkle;
        private ComboBox comboBoxYeniOgr;
        private Label label5;
        private Button btnSil;
        private DataGridView dataGridView2;
        private Button btnGuncelle;
        private TabPage tabPage3;
        private Label label7;
        private TextBox txtSube;
        private Button button1;
        private Label label6;
        private TextBox txtSeviye;
        private ComboBox comboBoxSiniflar;
        private Button btnSinifSil;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuTema;
        private ToolStripMenuItem textFontToolStripMenuItem;
        private ToolStripMenuItem foreColorToolStripMenuItem;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private MaskedTextBox txtOkulNo;
        private ToolTip toolTip1;
    }
}
