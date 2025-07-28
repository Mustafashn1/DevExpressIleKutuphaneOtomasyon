using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme12
{
    public partial class DüzenleFrm : Form
    {
        private Book _selectedBook;

        public DüzenleFrm(Book selectedBook)
        {
            InitializeComponent(); // İlk önce bileşenleri başlat

            if (selectedBook == null)
            {
                _selectedBook = new Book(); // Yeni bir kitap nesnesi oluştur
                this.Text = "Yeni Kitap Ekle"; // Form başlığını güncelle
            }
            else
            {
                _selectedBook = selectedBook; // Mevcut kitabı kullan
                this.Text = "Kitap Düzenle"; // Form başlığını güncelle

                // Kitap bilgilerini form üzerindeki alanlara doldur
                TxtAd.Text = _selectedBook.KitapAd;
                TxtYazar.Text = _selectedBook.Yazar;
                TxtSayfa.Text = _selectedBook.Sayfa.ToString();
                CmbTur.Text = _selectedBook.Tur; 
            }
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
        }

        private void BtnEkle_Click_1(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(TxtAd.Text) ||
                string.IsNullOrWhiteSpace(TxtYazar.Text) ||
                string.IsNullOrWhiteSpace(TxtSayfa.Text) ||
                string.IsNullOrWhiteSpace(CmbTur.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            // Sayfa sayısının doğru formatta olup olmadığını kontrol et
            if (!int.TryParse(TxtSayfa.Text, out int sayfaSayisi))
            {
                MessageBox.Show("Sayfa sayısı geçerli bir sayı olmalıdır.");
                return;
            }

            // Veritabanı bağlantısını aç ve SQL komutunu çalıştır
            using (var baglanti = new NpgsqlConnection("Host=195.142.235.185;Port=5432;Username=unvocalrage;Password=b9C4Zl5yaI2r0EaAF0oU;Database=MustafaLibraryApp"))
            {
                baglanti.Open();

                // Mevcut kitabı güncelle veya yeni kitap ekle
                NpgsqlCommand komut1;

                if (_selectedBook.Kitapid == 0) // Yeni kitap ekleniyorsa
                {
                    komut1 = new NpgsqlCommand("INSERT INTO \"Books\" (\"KitapAd\", \"Yazar\", \"Sayfa\", \"Tur\") VALUES (@p1, @p2, @p3, @p4)", baglanti);
                }
                else // Mevcut kitap güncelleniyorsa
                {
                    komut1 = new NpgsqlCommand("UPDATE \"Books\" SET \"KitapAd\" = @p1, \"Yazar\" = @p2, \"Sayfa\" = @p3, \"Tur\" = @p4 WHERE \"Kitapid\" = @p5", baglanti);
                    komut1.Parameters.AddWithValue("@p5", _selectedBook.Kitapid); // Güncellenecek kitabın ID'si
                }

                // Parametreleri ekle
                komut1.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut1.Parameters.AddWithValue("@p2", TxtYazar.Text);
                komut1.Parameters.AddWithValue("@p3", sayfaSayisi);
                komut1.Parameters.AddWithValue("@p4", CmbTur.Text);

                // Sorguyu çalıştır
                komut1.ExecuteNonQuery();

                // Mesaj göster
                MessageBox.Show(_selectedBook.Kitapid == 0 ? "Kitap başarıyla eklendi." : "Kitap başarıyla güncellendi.");
            }

            // Alanları temizle
            TxtAd.Text = string.Empty;
            TxtYazar.Text = string.Empty;
            TxtSayfa.Text = string.Empty;
            CmbTur.SelectedIndex = -1; // ComboBox'ta seçili olanı sıfırla

            // Listeyi güncelle
            Form1 mainForm = (Form1)this.Owner; // Ana formu al
            mainForm.ListeyiGuncelle(); // Kitaplar listesini güncelle

            this.Close(); // Formu kapat
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
