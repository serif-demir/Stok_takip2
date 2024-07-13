using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DembirStokTakip
{

    public partial class StokKarti : Form
    {
        // StokDuzeltMode adında bir bool özellik tanımlıyoruz
        public bool StokDuzeltMode { get; set; }
        private DataTable GetStokListesiFromDatabase()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";
            string query = "SELECT StokKodu, StokAdi FROM StokEkle";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
            }

            return dt;
        }
        // Parametresiz yapılandırıcı
        public StokKarti()
        {
            InitializeComponent();
            // StokDuzeltMode özelliğini varsayılan olarak false olarak ayarlıyoruz
            StokDuzeltMode = false;

            // Eğer düzenleme modunda ise, formun başlık metnini değiştir
            if (StokDuzeltMode)
            {
                this.Text = "Stok Düzenle"; // Form başlığını değiştir
                                            // Düzenleme modunda açıldığında, mevcut stok bilgilerini göstermek için gerekli kodlar buraya gelebilir
            }
            else
            {
                this.Text = "Yeni Stok Ekle"; // Varsayılan başlık
            }

            this.KeyPreview = true;

        }

        // Parametreli yapılandırıcı
        public StokKarti(string stokKodu, string stokAdi)
        {
            InitializeComponent();

            // Burada parametrelerle gelen değerleri kullanarak gerekli işlemleri yapabilirsiniz
            // Örneğin, parametrelerle gelen stok kodunu ve adını ilgili textbox'lara yerleştirebilirsiniz
            txtStokKodu.Text = stokKodu;
            txtStokAdi.Text = stokAdi;
        }
        private void YenileDataGridView()
        {
            // Veritabanından stok verilerini yeniden yükle
            DataTable dt = GetStokListesiFromDatabase();

            // DataGridView'in veri kaynağını güncelle
           // dataGridView1.DataSource = dt;
        }
        private void btnStokKaydet_Click(object sender, EventArgs e)
        {
            // StokForm formunu bul
            StokForm stokForm = Application.OpenForms["StokForm"] as StokForm;

            if (stokForm != null)
            {
                // StokForm formu bulunduğunda, DataGridView'i yenile
                stokForm.YenileDataGridView();
            }

            // Veritabanına stok ekleme veya güncelleme işlemi için SQL sorgusu
            string query = "";
            if (StokDuzeltMode)
            {
                // Düzenleme modunda ise, güncelleme sorgusu oluştur
                query = "UPDATE StokEkle SET StokAdi = @StokAdi WHERE StokKodu = @StokKodu";
            }
            else
            {
                // Yeni stok ekleme modunda ise, ekleme sorgusu oluştur
                query = "INSERT INTO StokEkle (StokKodu, StokAdi) VALUES (@StokKodu, @StokAdi)";
            }

            // SqlConnection oluştur
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SqlCommand oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreleri ekleyin
                    command.Parameters.AddWithValue("@StokKodu", txtStokKodu.Text);
                    command.Parameters.AddWithValue("@StokAdi", txtStokAdi.Text);

                    try
                    {
                        // Bağlantıyı açın
                        connection.Open();

                        // Komutu çalıştırın
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            if (StokDuzeltMode)
                            {
                                MessageBox.Show("Stok başarıyla güncellendi.");
                            }
                            else
                            {
                                MessageBox.Show("Stok başarıyla kaydedildi.");
                            }

                            // Formu kapatın veya istediğiniz işlemi yapın

                            // Textbox'ları temizle
                            txtStokAdi.Text = "";
                            txtStokKodu.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Stok kaydedilirken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
            // Formu kapat
            this.Close();
        }
        
        private void btnStokVazgec_Click(object sender, EventArgs e)
        {
            // Formu kapat
            this.Close();
        }

        private void StokKarti_Load(object sender, EventArgs e)
        {
            // Kaydet butonuna F2 tuşunu atan
            this.AcceptButton = btnStokKaydet;
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            // TextBox'ta girilen metni al
            string text = txtStokAdi.Text;

            // Metni baş harfleri büyük, diğer harfleri küçük yapacak şekilde düzenle
            string formattedText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

            // Düzenlenmiş metni TextBox'a geri yükle
            txtStokAdi.Text = formattedText;

            // Cursor'ı metnin sonuna götür
            txtStokAdi.SelectionStart = txtStokAdi.Text.Length;
        }

        private void btnStokKaydet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnStokKaydet.PerformClick();

            }
            // ESC tuşuna basıldığında
            if (e.KeyCode == Keys.Escape)
            {
                // Vazgeç butonunun Click olayını çağır
                btnStokVazgec.PerformClick();
            }
        }
        private void txtStokAdi_Enter(object sender, EventArgs e)
        {
            // Textbox'a odaklanıldığında arka plan rengini değiştir
            txtStokAdi.BackColor = Color.LightGreen;
        }
        private void txtStokAdi_Leave(object sender, EventArgs e)
        {
            // Textbox'tan çıkıldığında arka plan rengini eski haline getir
            txtStokAdi.BackColor = SystemColors.Window;
        }

        private void txtStokKodu_Enter(object sender, EventArgs e)
        {
            // Textbox'a odaklanıldığında arka plan rengini değiştir
            txtStokKodu.BackColor = Color.LightGreen;
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            // Textbox'tan çıkıldığında arka plan rengini eski haline getir
            txtStokKodu.BackColor = SystemColors.Window;
        }

        private void StokKarti_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnStokKaydet.PerformClick();

            }
            // ESC tuşuna basıldığında
            if (e.KeyCode == Keys.Escape)
            {
                // Vazgeç butonunun Click olayını çağır
                btnStokVazgec.PerformClick();
            }
        }
    }


}
