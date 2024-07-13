using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DembirStokTakip
{
    public partial class DembirStokTakip : Form
    {
        public DembirStokTakip()
        {
            InitializeComponent();
        }


        public void UpdateDataGridView(DataTable newData)
        {
            dgvCariListesi.DataSource = newData;
        }

        public void LoadCariListesi()
        {
            DataTable dt = GetCariListesiFromDatabase();
            dgvCariListesi.DataSource = dt;

            dgvCariListesi.Columns["carikodu"].DataPropertyName = "carikodu";
            dgvCariListesi.Columns["adi"].DataPropertyName = "adi";
            dgvCariListesi.Columns["soyadi"].DataPropertyName = "soyadi";
            dgvCariListesi.Columns["telefon"].DataPropertyName = "telefon";
            dgvCariListesi.Columns["adres"].DataPropertyName = "adres";
            dgvCariListesi.Columns["kimlikNo"].DataPropertyName = "kimlikNo";
        }

        private void DembirStokTakip_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakipDatabaseDataSet1.cari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
 //           this.cariTableAdapter.Fill(this.stokTakipDatabaseDataSet1.cari);
            // TODO: Bu kod satırı 'stokTakipDatabaseDataSet.cari' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //            this.cariTableAdapter.Fill(this.stokTakipDatabaseDataSet.cari);
            tabControl1.Visible = false;
            LoadCariListesi();
        }

        private void btnYeniCari_Click(object sender, EventArgs e)
        {
            frmYeniCari yeniCariForm = new frmYeniCari();
            yeniCariForm.ShowDialog();
            LoadCariListesi();
        }

        private void btnCariSil_Click(object sender, EventArgs e)
        {
            if (dgvCariListesi.SelectedRows == null || dgvCariListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz cariyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvCariListesi.SelectedRows[0];
            string cariKod = selectedRow.Cells["carikodu"].Value.ToString();

            DialogResult result = MessageBox.Show("Seçili cariyi silmek istediğinizden emin misiniz?", "Cari Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DeleteCariFromDatabase(cariKod);
                LoadCariListesi();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            // DataGridView'de seçili cariyi al
            DataGridViewRow selectedRow = dgvCariListesi.SelectedRows[0];

            // Eğer bir satır seçilmemişse, uyarı ver ve metodu sonlandır
            if (dgvCariListesi.SelectedRows == null || dgvCariListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz cariyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Seçilen carinin bilgilerini al
            string cariKod = selectedRow.Cells["carikodu"].Value.ToString();
            string ad = selectedRow.Cells["adi"].Value.ToString();
            string soyad = selectedRow.Cells["soyadi"].Value.ToString();
            string telefon = selectedRow.Cells["telefon"].Value.ToString();
            string adres = selectedRow.Cells["adres"].Value.ToString();
            string kimlikNo = selectedRow.Cells["kimlikno"].Value.ToString();

            // CariDuzenle formunu oluştur ve aç
            CariDuzenleForm cariDuzenleForm = new CariDuzenleForm(cariKod, ad, soyad, telefon, adres, kimlikNo, dgvCariListesi);
            cariDuzenleForm.ShowDialog();

            // DataGridView'i yenile
            LoadCariListesi(); // Önceki örnekte DataGridView'i yenilemek için kullanılan metot
        }

        private void DeleteCariFromDatabase(string cariKod)
        {
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";
            string query = "DELETE FROM cari WHERE carikodu = @carikodu";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carikodu", cariKod);
                    command.ExecuteNonQuery();
                }
            }
        }

        private DataTable GetCariListesiFromDatabase()
        {
            DataTable dt = new DataTable();
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";
            string query = "SELECT carikodu, adi, soyadi, telefon, adres, kimlikNo FROM cari";

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

        private void btnCari_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 0;
        }

        private void dgvCariListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCloseTabControl_Click(object sender, EventArgs e)
        {
            // TabControl'u gizle
            tabControl1.Visible = false;

            // Ana ekranın diğer kontrollerini göster
            // Örnek olarak DataGridView'i göstermek istediğinizde:
            // dgvCariListesi.Visible = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim(); // TextBox'tan arama metnini al
            DataTable sonuclar = AramaYap(aramaMetni); // Veritabanında arama yap

            dgvCariListesi.DataSource = sonuclar; // DataGridView'e sonuçları yükle
        }

        private DataTable AramaYap(string aramaMetni)
        {
            // Veritabanında arama sorgusu
            string query = "SELECT * FROM cari WHERE adi LIKE @aramaMetni OR soyadi LIKE @aramaMetni";

            // SqlConnection ve SqlCommand oluştur
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Bağlantıyı aç
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametre ekle
                    command.Parameters.AddWithValue("@aramaMetni", "%" + aramaMetni + "%");

                    // SqlDataAdapter ve DataTable oluştur
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    // Verileri doldur
                    adapter.Fill(dataTable);

                    return dataTable; // DataTable döndür
                }
            }
        }
        /*private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text;
            DataTable sonuclar = AramaYap(aramaMetni);
            UpdateDataGridView(sonuclar);
        }*/

        private void txtArama_TextChanged_1(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text;
            DataTable sonuclar = AramaYap(aramaMetni);
            UpdateDataGridView(sonuclar);
        }

        private void btnStok_Click(object sender, EventArgs e)
        {


            StokForm stokForm = new StokForm();
            stokForm.ShowDialog();
            LoadCariListesi(); // Cari listesini güncelle

        }

        private void stokGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Stok Girişi formunu aç
            //StokGirisiForm stokGirisiForm = new StokGirisiForm();
            //stokGirisiForm.ShowDialog();
        }

        

        private void dgvCariListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Çift tıklama olayı ile çalışacak kod
            if (e.RowIndex >= 0) // Geçerli bir satır seçilmiş mi kontrolü
            {
                DataGridViewRow row = this.dgvCariListesi.Rows[e.RowIndex];
                string selectedCariAd = row.Cells["adi"].Value.ToString() +" "+ row.Cells["soyadi"].Value.ToString(); // Seçilen carinin adını alıyoruz

                // Seçilen carinin adını göstereceğimiz etiketi güncelle
                lblSelectedCariAd.Text = "" + selectedCariAd;

                // Cari detaylarını göstereceğimiz kontrolü güncelle
               // ShowCariDetails(selectedCariKod);
            }
            // DataGridView'de bir hücreye tıklandığında çalışacak kod
            if (e.RowIndex >= 0) // Geçerli bir satır seçilmiş mi kontrolü
            {
                DataGridViewRow row = this.dgvCariListesi.Rows[e.RowIndex];
                string selectedCariKod = row.Cells["carikodu"].Value.ToString(); // Seçilen carinin kodunu alıyoruz

                // Cari hesap içeriği sekmesine geçiş yap
                tabControl1.SelectedIndex = 1;

                // Burada seçilen carinin hesap içeriğini göstermek için gerekli işlemleri yapabilirsiniz
                // Örneğin, seçilen carinin hesap içeriğini yeni bir formda gösterebilirsiniz
                // veya mevcut formda bir panel oluşturup hesap içeriğini gösterebilirsiniz
            }
        }
    }
}
