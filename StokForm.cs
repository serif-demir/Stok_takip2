using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DembirStokTakip
{

    public partial class StokForm : Form
    {
        string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";

        public StokForm()
        {
            InitializeComponent();
        }
        // YenileDataGridView metodu StokForm sınıfında tanımlanıyor
        public void YenileDataGridView()
        {
            // Veritabanından stok verilerini yeniden yükle
            DataTable dt = GetStokListesiFromDatabase();

            // DataGridView'in veri kaynağını güncelle
            dataGridView1.DataSource = dt;
        }
        // Veritabanından stok listesini çeken metot
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

        private void StokForm_Load(object sender, EventArgs e)
        {
            StoklariGetirVeGoster();
        }

        private void StoklariGetirVeGoster()
        {
            DataTable stoklar = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT StokKodu, StokAdi FROM StokEkle";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    stoklar.Load(reader);
                }
            }

            dataGridView1.DataSource = stoklar;
        }

        private void btnStokYeni_Click(object sender, EventArgs e)
        {
            StokKarti stokForm = new StokKarti();
            stokForm.ShowDialog();
            YenileDataGridView();
        }

        private void btnStokDuzelt_Click(object sender, EventArgs e)
        {
            // Seçilen satırı kontrol et
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz stoku seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen satırın StokKodu ve StokAdi değerlerini al
            string stokKodu = dataGridView1.SelectedRows[0].Cells["StokKodu"].Value.ToString();
            string stokAdi = dataGridView1.SelectedRows[0].Cells["StokAdi"].Value.ToString();

            // Düzenleme formunu oluştur ve seçilen stokun bilgileriyle birlikte aç
            StokKarti stokKartiForm = new StokKarti(stokKodu, stokAdi);
            stokKartiForm.StokDuzeltMode = true; // Düzenleme modunu belirtmek için bir özellik ekleyin
            stokKartiForm.ShowDialog();

            // DataGridView'i yenile
            YenileDataGridView();
        }

        private void btnStokSil_Click(object sender, EventArgs e)
        {
            // Seçilen satırı kontrol et
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz stoku seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcıya silme işlemini onayla
            DialogResult result = MessageBox.Show("Seçili stoku silmek istediğinizden emin misiniz?", "Stok Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Seçilen satırın StokKodu değerini al
                string stokKodu = dataGridView1.SelectedRows[0].Cells["StokKodu"].Value.ToString();

                // Stok satırını veritabanından sil
                SilStok(stokKodu);

                // DataGridView'i yenile
                StoklariGetirVeGoster();
            }
        }
        private void SilStok(string stokKodu)
        {
            // Veritabanından stok satırını silme işlemi için SQL sorgusu
            string query = "DELETE FROM StokEkle WHERE StokKodu = @StokKodu";

            // SqlConnection oluştur
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SqlCommand oluştur
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreyi ekle
                    command.Parameters.AddWithValue("@StokKodu", stokKodu);

                    try
                    {
                        // Bağlantıyı aç
                        connection.Open();

                        // Komutu çalıştır
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Stok başarıyla silindi.");
                        }
                        else
                        {
                            MessageBox.Show("Stok silinirken bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }
    }
}
