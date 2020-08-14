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
        string dosyaTarih;

        //string stdDetails = "{0, -26} {1, -25} {2, -17} {3, -18} {4, -21} {5, -26} {6, -24} {7, -31} {8, -22} {9, -22} {10, -25} {11, -43} {12, -20} {13, -41} {14, -20}";
        //string stdDetails2 = "{0, -20} {1, -20} {2, -20} {3, -20} {4, -20} {5, -20} {6, -20} {7, -20} {8, -20} {9, -20} {10, -20} {11, -35} {12, -20} {13, -28} {14, -20}";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dosyaTarihLabel.Text = "Kayıt Tarihi: " + sadece_tarih;
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
                        //tabloyu temizle ve yenile.
                        dataGridView1.Rows.Clear();
                        dataGridView1.Refresh();
                        //yükleme ekranını aç.
                        yuklemeForm yuklemefrm = new yuklemeForm();
                        yuklemefrm.Show();
                        yuklemebaslatTimer.Start();

                        //dosyanın dizinini evrensel bir değişkene ata
                        dosyaDizinEvrensel = openFileDialog.FileName;
                        //pencere başlığının adını değiştir.
                        this.Text = "mCTerminal Okuyucu -- " + dosyaDizinEvrensel;
                        //data değişkenine seçilen dosyadaki verileri yaz.
                        data = File.ReadAllText(openFileDialog.FileName);
                        string dosyaTarihAyiklama1 = openFileDialog.SafeFileName.Substring(openFileDialog.SafeFileName.IndexOf("-") + 1);
                        string dosyaTarihAyiklama2 = dosyaTarihAyiklama1.Substring(0, dosyaTarihAyiklama1.IndexOf("."));
                        dosyaTarih = dosyaTarihAyiklama2;

                        dosyaTarihLabel.Text = "Kayıt Tarihi: " + dosyaTarih;

                        dosyaTarihLabel.Focus();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Dosya açılırken bir hata oluştu!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
