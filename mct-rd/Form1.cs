using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mct_rd
{
    public partial class Form1 : Form
    {
        

        public string data;
        public string[] splitted_data;
        public string[] splitted_saat_data;
        public string line;
        public string dosyaDizinEvrensel;
        public string dosyauzanti;
        public int lineCount;
        static string programyolu = System.AppDomain.CurrentDomain.BaseDirectory;
        string sadece_tarih = DateTime.Now.ToString("dd-MM-yyyy");
        string sadece_saat = DateTime.Now.ToString("HH:mm:ss");
        string dosyaTarih;
        DateTime modification;
        DateTime creation;
        DateTime elapsedtime;

        //string stdDetails = "{0, -26} {1, -25} {2, -17} {3, -18} {4, -21} {5, -26} {6, -24} {7, -31} {8, -22} {9, -22} {10, -25} {11, -43} {12, -20} {13, -41} {14, -20}";
        //string stdDetails2 = "{0, -20} {1, -20} {2, -20} {3, -20} {4, -20} {5, -20} {6, -20} {7, -20} {8, -20} {9, -20} {10, -20} {11, -35} {12, -20} {13, -28} {14, -20}";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dosyaTarihLabel.Text = "Kayıt Zamanı: " + sadece_tarih + " | " + sadece_saat;
        }

        public void editorDosyaYukle()
        {
            try
            {
                splitted_data = data.Split('*');
                splitted_saat_data = data.Split('-');
                splitted_data[0] = splitted_data[0].Substring(splitted_data[0].IndexOf(">"));
                string gpssayi_sonhali = splitted_data[0].Substring(2);
                int rowId = dataGridView1.Rows.Add();

                // Grab the new row!
                DataGridViewRow row = dataGridView1.Rows[rowId];

                // Add the data
                row.Cells["saat"].Value = splitted_saat_data[0];
                row.Cells["gpsuydusayi"].Value = gpssayi_sonhali;
                row.Cells["hdop"].Value = splitted_data[1];
                row.Cells["enlem"].Value = splitted_data[2] + "°";
                row.Cells["boylam"].Value = splitted_data[3] + "°";
                row.Cells["gpsirtifa"].Value = splitted_data[4] + "m";
                row.Cells["gpsmaksirtifa"].Value = splitted_data[5] + "m";
                row.Cells["yatayhiz"].Value = splitted_data[6] + "km/s";
                row.Cells["kameradurum"].Value = splitted_data[7];
                row.Cells["acix"].Value = splitted_data[8] + "°";
                row.Cells["aciy"].Value = splitted_data[9] + "°";
                row.Cells["gkuvvet"].Value = splitted_data[10] + "g";
                row.Cells["baroirtifamaks"].Value = splitted_data[11] + "m";
                row.Cells["anlikirtifa"].Value = splitted_data[12] + "m";
                row.Cells["konidurum"].Value = splitted_data[13];
                row.Cells["ortagovdedurum"].Value = splitted_data[14];

            }
            catch
            {

            }
        }

        //Dosya seçme ekranını açar ve sonrasında seçilen dosyayı uygulamaya aktarır.
        public void editorDosyaAc()
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Bir Belge Aç";
                    openFileDialog.InitialDirectory = programyolu + "logs";
                    openFileDialog.Filter = "Tüm Dosyalar (*.*)|*.*|mCTerminal Veri Formatları|*.txt;*.log;*.vs;*.xml";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //ortadaki resimi ve yazıyı gizle.
                        dosyaAcLabel.Visible = false;
                        dosyaAcPictureBox.Visible = false;

                        //tabloyu temizle ve yenile.
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        //yükleme ekranını aç.
                        yuklemeForm yuklemefrm = new yuklemeForm();
                        yuklemefrm.Show();
                        yuklemefrm.Focus();
                        yuklemebaslatTimer.Start();

                        //dosyanın dizinini evrensel bir değişkene ata.
                        dosyaDizinEvrensel = openFileDialog.FileName;
                        //dosyanın uzantısını al. (örn: .txt | .xml)
                        dosyauzanti = Path.GetExtension(openFileDialog.FileName); 
                        //pencere başlığının adını değiştir.
                        this.Text = "mCTerminal Okuyucu -- " + dosyaDizinEvrensel;
                        //satır sayısını al.
                        var lineCount = File.ReadLines(openFileDialog.FileName).Count();
                        //data değişkenine seçilen dosyadaki verileri yaz.
                        data = File.ReadAllText(openFileDialog.FileName);
                        creation = File.GetCreationTime(dosyaDizinEvrensel); //dosya oluşturulma tarihi
                        modification = File.GetLastWriteTime(dosyaDizinEvrensel); //dosya değiştirilme tarihi
                        //karakter sayısını al.
                        var numberOfCharacters = File.ReadAllLines(openFileDialog.FileName).Sum(s => s.Length);

                        //dosya bilgilerini globalde olabilmesi için ayar kısmına yaz.
                        mct_rd.Properties.Settings.Default.dosyaOlusturulmaSaat = creation.Hour + ":" + creation.Minute + ":" + creation.Second;
                        mct_rd.Properties.Settings.Default.dosyaOlusturulmaTarih = creation.Day + "-" + creation.Month.ToString("00") + "-" + creation.Year;
                        mct_rd.Properties.Settings.Default.dosyaDegistirilmeTarih = modification.Day + "-" + modification.Month.ToString("00") + "-" + modification.Year;
                        mct_rd.Properties.Settings.Default.dosyaDegistirilmeSaat = modification.Hour + ":" + modification.Minute + ":" + modification.Second;
                        mct_rd.Properties.Settings.Default.dosyaDizin = openFileDialog.FileName;
                        mct_rd.Properties.Settings.Default.dosyaUzanti = dosyauzanti;
                        mct_rd.Properties.Settings.Default.dosyaKarakterSayi = numberOfCharacters.ToString();
                        mct_rd.Properties.Settings.Default.dosyaSatirSayi = lineCount.ToString();
                        mct_rd.Properties.Settings.Default.dosyaAdi = openFileDialog.SafeFileName;

                        //bilgileri doldur.
                        karakterSayiLabel.Text = "Karakter Sayısı: " + numberOfCharacters.ToString();
                        satirSayiLabel.Text = "Satır Sayısı: " + lineCount.ToString();
                        
                        dosyaTarihLabel.Text = "Kayıt Zamanı: " + creation.Day + "-" + creation.Month.ToString("00") + "-" + creation.Year + " | " + creation.Hour + ":" + creation.Minute + ":" + creation.Second;
                        dosyaTarihLabel.Focus();
                        editorDosyaTurBelirle();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dosya açılırken bir hata oluştu!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editorDosyaTurBelirle()
        {
            if (dosyauzanti == ".xml") //eğer dosya Extensible Markup belgesi ise
            {
                dosyaturuLabel.Text = "Extensible Markup Belgesi | *.xml";
                mct_rd.Properties.Settings.Default.dosyaTuru = "Extensible Markup Belgesi";
            }

            if (dosyauzanti == ".log") //eğer dosya Batch belgesi ise.
            {
                dosyaturuLabel.Text = "Log Belgesi | *.log";
                mct_rd.Properties.Settings.Default.dosyaTuru = "Log Belgesi";
            }

            if (dosyauzanti == ".txt") //eğer dosya düz metin belgesi ise.
            {
                dosyaturuLabel.Text = "Metin Belgesi | *.txt";
                mct_rd.Properties.Settings.Default.dosyaTuru = "Metin Belgesi";
            }

            if (dosyauzanti == ".vs") //eğer dosya verilog belgesi ise.
            {
                dosyaturuLabel.Text = "Verilog Dosyası | *.vs";
                mct_rd.Properties.Settings.Default.dosyaTuru = "Verilog Dosyası";
            }
        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mct-rd.exe");
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            editorDosyaAc();
        }

        private void yuklemebaslatTimer_Tick(object sender, EventArgs e)
        {
            yuklemebaslatTimer.Stop();

            using (StreamReader reader = new StreamReader(dosyaDizinEvrensel))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    data = line;
                    editorDosyaYukle();
                }
            }

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            //hakkında ekranını aç.
            hakkindaForm hakkindafrm = new hakkindaForm();
            hakkindafrm.Show();
        }

        private void dosyaAcPictureBox_Click(object sender, EventArgs e)
        {
            editorDosyaAc();
        }

        private void dosyaAcLabel_Click(object sender, EventArgs e)
        {
            editorDosyaAc();
        }

        private void toolStripDropDownButton4_Click(object sender, EventArgs e)
        {
            //tabloyu temizle ve yenile.
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //ortadaki resimi ve yazıyı göster.
            dosyaAcLabel.Visible = true;
            dosyaAcPictureBox.Visible = true;

            //verileri sıfırla
            dosyaTarihLabel.Text = "Kayıt Zamanı: " + sadece_tarih + " | " + sadece_saat;
            satirSayiLabel.Text = "Satır Sayısı: 0";
            karakterSayiLabel.Text = "Karakter Sayısı: 0";
            this.Text = "mCTerminal Okuyucu";
            dosyaturuLabel.Text = "Dosya Türü: Metin Belgesi | *.txt";
            Properties.Settings.Default.Reset();
        }

        private void bütünÇizgileriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        }

        private void sadeceDikeyÇizgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
        }

        private void sadeceYatayÇizgilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }
    }
}
