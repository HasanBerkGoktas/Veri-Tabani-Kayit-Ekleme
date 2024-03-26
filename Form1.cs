using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms;
using WinFormsApp3.Modeller;
using static Azure.Core.HttpHeader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.Intrinsics.X86;
using Microsoft.EntityFrameworkCore.Internal;
using ToolTip = System.Windows.Forms.ToolTip;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        Veritabani vt = new Veritabani();

        public int secilenIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "")
            {
                if (txtSoyad.Text != "")
                {
                    if (txtOkulNo.Text != "")
                    {
                        if (comboBoxYeniOgr.SelectedIndex != -1)
                        {

                            Ogrenci yeniOgrenci = new Ogrenci();

                            yeniOgrenci.Ad = txtAd.Text;
                            yeniOgrenci.Soyad = txtSoyad.Text;
                            yeniOgrenci.OkulNo = Convert.ToInt32(txtOkulNo.Text);
                            yeniOgrenci.Sinif = (Sinif)comboBoxYeniOgr.SelectedItem;

                            MessageBox.Show("kayýt eklendi");
                            vt.Ogrenciler.Add(yeniOgrenci);
                            vt.SaveChanges();
                            MessageBox.Show("YENÝ ÖÐRENCÝ EKLENDÝ");

                        }
                        else
                        {
                            MessageBox.Show("SUBE YÝ DOLDURUNUZ");

                        }
                    }
                    else
                    {
                        MessageBox.Show("ADI DOLDURUNUZ ");
                    }
                }
                else
                {
                    MessageBox.Show("SOYADI DOLDURUNUZ");
                }
            }
            else
            {
                MessageBox.Show("BOÞLUKLARI DOLDURUN");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vt.Ogrenciler.Load();
            vt.Siniflar.Load();

            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxSiniflar.Items.Add(item);
            }
            comboBoxSiniflar.DisplayMember = "SinifAd";

            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxYeniOgr.Items.Add(item);
            }

            comboBoxYeniOgr.DisplayMember = "SinifAd";

            Sinif tumList = new Sinif();
            tumList.Sube = "Tüm Öðrenciler";
            tumList.Seviye = 0;
            tumList.Id = 0;
            comboBoxSirala.Items.Add(tumList);
            comboBoxSirala.SelectedIndex = 0;
            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxSirala.Items.Add(item);
            }

            comboBoxSirala.DisplayMember = "SinifAd";

            dataGridView1.DataSource = vt.Ogrenciler.Local.ToBindingList();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;

            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();

            foreach (var item in vt.Siniflar.Local)
            {
                combo.Items.Add(item);
            }

            combo.ReadOnly = true;

            combo.HeaderText = "Sýnýf";
            combo.DataPropertyName = "Sinif";
            combo.DisplayMember = "SinifAd";
            combo.ValueMember = "Kendisi";

            dataGridView1.Columns.Add(combo);

            //--

            dataGridView2.DataSource = vt.Ogrenciler.Local.ToBindingList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[4].Visible = false;

            dataGridView2.ColumnHeadersVisible = true;

            DataGridViewComboBoxColumn combo2 = new DataGridViewComboBoxColumn();

            foreach (var item in vt.Siniflar.Local)
            {
                combo2.Items.Add(item);
            }

            combo2.ReadOnly = true;

            combo2.HeaderText = "Sýnýf";
            combo2.DataPropertyName = "Sinif";
            combo2.DisplayMember = "SinifAd";
            combo2.ValueMember = "Kendisi";

            dataGridView2.Columns.Add(combo2);

            ToolTip tt = new ToolTip();
            tt.SetToolTip(txtAd,"Adýný yaz");
            tt.SetToolTip(txtSoyad, "Soyadýný yaz");
            tt.SetToolTip(txtOkulNo, "Okul no yaz");
            tt.SetToolTip(txtSube, "Þubeni yaz");
            tt.SetToolTip(btnEkle, " Yeni ögrenci ekle");
            tt.SetToolTip(btnGuncelle, "Öðrenci güncelleme");
            tt.SetToolTip(btnSil, "Öðrenciyi sil");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vt.Ogrenciler.Load();
            Sinif secilenSinif = (Sinif)comboBoxSirala.SelectedItem;
            if (comboBoxSirala.SelectedIndex != 0)
            {
                dataGridView1.DataSource = vt.Ogrenciler.Local.Where(x => x.Sinif.SinifAd == secilenSinif.SinifAd).ToList();
            }
            if (comboBoxSirala.SelectedIndex == 0)
            {
                dataGridView1.DataSource = vt.Ogrenciler.Local.ToBindingList();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            vt.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnKayitEkle_Click(sender, e);//datagride öðrenci kayýt eder

        }

        private void btnSil2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);//datagrid deki seçilen satýrý siler
            }
            MessageBox.Show("silindi");
            vt.SaveChanges();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)//seçilen satýr 0 dan büyük ise datagridview 2 ye yazdýr
            {
                dataGridView1.Rows[secilenIndex].Cells[2].Value = txtAd.Text;//datagrid deki seçilen satýrý ve hücreyi günceller
                dataGridView1.Rows[secilenIndex].Cells[3].Value = txtSoyad.Text;//datagrid deki seçilen satýrý ve hücreyi günceller
                dataGridView1.Rows[secilenIndex].Cells[1].Value = Convert.ToInt32(txtOkulNo.Text);//datagrid deki okul no yu sayýsal deðere çevirir ve günceller
                dataGridView1.Rows[secilenIndex].Cells[4].Value = (Sinif)comboBoxYeniOgr.SelectedItem;//datagrid deki seçilen combobox daki öðrenciyi günceller
            }
            MessageBox.Show("güncellendi");
            vt.SaveChanges();
            dataGridView2.Refresh();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenIndex = e.RowIndex;//secilen satýrý güncelleme yapmak için 2 kere týklandðýnda textbox a doldurur

            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();//secilen satýrdaki hücreyi sütunu belirtilen textboxa yazar
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();//secilen satýrdaki hücreyi sütunu belirtilen textboxa yazar
            txtOkulNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();//secilen satýrdaki hücreyi sütunu belirtilen textboxa yazar
            comboBoxYeniOgr.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        //yeni sýnýf, öðrenci, þube, seviye oluþturma ve ekleme
        {
            Sinif yeniSinif = new Sinif();

            yeniSinif.Seviye = Convert.ToInt32(txtSeviye.Text);//yeni sýnýftaki seviyeyi sayýsal deðere döndürür ve yazar
            yeniSinif.Sube = txtSube.Text;//yeni sýnýftaki þubeyi yazar

            vt.Siniflar.Add(yeniSinif);
            vt.SaveChanges();

            comboBoxYeniOgr.Items.Clear();// yeni ögrenci ekleme 
            comboBoxSirala.Items.Clear();//katogeri 
            comboBoxSiniflar.Items.Clear();// silme 

            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxYeniOgr.Items.Add(item);
            }
            comboBoxYeniOgr.DisplayMember = "SinifAd";

            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxSiniflar.Items.Add(item);
            }
            comboBoxSiniflar.DisplayMember = "SinifAd";

            Sinif tumList = new Sinif();
            tumList.Sube = "Tüm Öðrenciler";
            tumList.Seviye = 0;
            tumList.Id = 0;
            comboBoxSirala.Items.Add(tumList);
            comboBoxSirala.SelectedIndex = 0;
            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxSirala.Items.Add(item);
            }
            MessageBox.Show("yeni sýnýf oluþturuldu");
            vt.SaveChanges();
        }

        private void btnSinifSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                vt.Siniflar.Remove((Sinif)comboBoxSiniflar.SelectedItem);
            }

            vt.SaveChanges();

            comboBoxYeniOgr.Items.Clear();// yeni ögrenci ekleme
            comboBoxSirala.Items.Clear();//katogeri
            comboBoxSiniflar.Items.Clear();//silme

            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxYeniOgr.Items.Add(item);
            }
            comboBoxYeniOgr.DisplayMember = "SinifAd";

            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxSiniflar.Items.Add(item);
            }
            comboBoxSiniflar.DisplayMember = "SinifAd";

            Sinif tumList = new Sinif();
            tumList.Sube = "Tüm Öðrenciler";
            tumList.Seviye = 0;
            tumList.Id = 0;
            comboBoxSirala.Items.Add(tumList);
            comboBoxSirala.SelectedIndex = 0;
            foreach (var item in vt.Siniflar.Local)
            {
                comboBoxSirala.Items.Add(item);
            }

            vt.SaveChanges();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSiniflar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxYeniOgr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            this.Font = fontDialog1.Font;
            Font = fontDialog1.Font;

        }

        private void foreColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
            tabPage1.BackColor = colorDialog1.Color;
            tabPage2.BackColor = colorDialog1.Color;
            tabPage3.BackColor = colorDialog1.Color;

        }
    }


}

