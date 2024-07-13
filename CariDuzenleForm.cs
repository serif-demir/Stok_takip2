using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DembirStokTakip
{
    public partial class CariDuzenleForm : Form
    {
        private DataGridView dgvCariListesi;
        private void CariDuzenleForm_Load(object sender, EventArgs e)
        {
            
        }

        public CariDuzenleForm(string cariKod, string ad, string soyad, string telefon, string adres, string kimlikNo, DataGridView dgvCariListesi)
        {
            InitializeComponent();
            this.dgvCariListesi = dgvCariListesi;
            // Constructor içerisinde parametrelerle formun ilgili kontrollerini doldurabilirsiniz
            carikodutxt.Text = cariKod;
            aditxt.Text = ad;
            soyaditxt.Text = soyad;
            telefontxt.Text = telefon;
            adrestxt.Text = adres;
            kimliknotxt.Text = kimlikNo;
        }

        public void UpdateDataGridView(DataTable newData)
        {
            dgvCariListesi.DataSource = newData;
        }

        private DataTable GetCariListesiFromDatabase()
        {
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";
            string query = "SELECT carikodu, adi, soyadi, telefon, adres, kimlikno FROM cari";
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
            }

            return dt;
        }

        public void LoadCariListesi()
        {
            DataTable cariDataTable = GetCariListesiFromDatabase();
            UpdateDataGridView(cariDataTable);
        }

        private void UpdateCari(string cariKod, string yeniAd, string yeniSoyad, string yeniTelefon, string yeniAdres, string yeniKimlikNo)
        {
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE cari SET adi = @adi, soyadi = @soyadi, telefon = @telefon, adres = @adres, kimlikno = @kimlikno WHERE carikodu = @carikodu";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@carikodu", cariKod);
                    command.Parameters.AddWithValue("@adi", yeniAd);
                    command.Parameters.AddWithValue("@soyadi", yeniSoyad);
                    command.Parameters.AddWithValue("@telefon", yeniTelefon);
                    command.Parameters.AddWithValue("@adres", yeniAdres);
                    command.Parameters.AddWithValue("@kimlikno", yeniKimlikNo);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnCariKaydet_Click(object sender, EventArgs e)
        {
            string cariKod = carikodutxt.Text;
            string yeniAd = aditxt.Text;
            string yeniSoyad = soyaditxt.Text;
            string yeniTelefon = telefontxt.Text;
            string yeniAdres = adrestxt.Text;
            string yeniKimlikNo = kimliknotxt.Text;

            UpdateCari(cariKod, yeniAd, yeniSoyad, yeniTelefon, yeniAdres, yeniKimlikNo);
            MessageBox.Show("Cari bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ana form üzerindeki Cari Listesi datagridview'ini yeniden yükle
           // ((DembirStokTakip)this.Owner).LoadCariListesi();

            this.Close();
        }

        private void DeleteCari(string cariKod)
        {
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM cari WHERE carikodu = @cariKod";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cariKod", cariKod);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnCariSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu cariyi silmek istediğinizden emin misiniz?", "Cari Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string cariKod = carikodutxt.Text;
                DeleteCari(cariKod);
                MessageBox.Show("Cari başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana form üzerindeki Cari Listesi datagridview'ini yeniden yükle
                //((DembirStokTakip)this.Owner).LoadCariListesi();

                this.Close();
            }
        }

        private void btnCariVazgec_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Değişiklikleri iptal etmek istediğinizden emin misiniz?", "İptal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
