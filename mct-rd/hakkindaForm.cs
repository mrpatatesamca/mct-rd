using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mct_rd
{
    public partial class hakkindaForm : Form
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




        public hakkindaForm()
        {
            InitializeComponent();
        }

        private void hakkindaForm_Load(object sender, EventArgs e)
        {
            programYoluLabel.Text = "Program Dizini: " + programyolu;
            dosyaSatirSayisiLabel.Text = "Satır Sayısı: " + mct_rd.Properties.Settings.Default.dosyaSatirSayi;
            DosyaKaraterSayisi.Text = "Karakter Sayısı: " + mct_rd.Properties.Settings.Default.dosyaKarakterSayi;
            dosyaOlusturulmaLabel.Text = "Oluşturulma Tarihi:" + mct_rd.Properties.Settings.Default.dosyaOlusturulmaTarih;
            dosyaOlusturulmaSaatLabel.Text = "Saati: " + mct_rd.Properties.Settings.Default.dosyaOlusturulmaSaat;
            dosyaDegistirilmeLabel.Text = "Değiştirilme Tarihi: " + mct_rd.Properties.Settings.Default.dosyaDegistirilmeTarih;
            dosyaDegistirilmeSaatLabel.Text = "Saati: " + mct_rd.Properties.Settings.Default.dosyaDegistirilmeSaat;
            dosyaTuruLabel.Text = "Türü: " + mct_rd.Properties.Settings.Default.dosyaTuru;
            dosyaUzantısıLabel.Text = "Uzantısı: " + mct_rd.Properties.Settings.Default.dosyaUzanti;
            dosyaDizinLabel.Text = "Dizini: " + mct_rd.Properties.Settings.Default.dosyaDizin;
            dosyaAdıLabel.Text = "Adı: " + mct_rd.Properties.Settings.Default.dosyaAdi;

            tarihLabel.Text = "Tarih: " + sadece_tarih;





        }

        private void saatGuncellemeTimer_Tick(object sender, EventArgs e)
        {
            string sadece_saat_loop = DateTime.Now.ToString("HH:mm:ss");
            saatLabel.Text = "Saat: " + sadece_saat_loop;
        }
    }
}