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
    public partial class frmYeniCari : Form
    {
        public frmYeniCari()
        {
            InitializeComponent();
        }


        private string GetNextCariKod()
        {
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";
            string query = "SELECT MAX(carikodu) FROM cari";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        string resultString = result.ToString();
                        if (!string.IsNullOrEmpty(resultString))
                        {
                            int maxCariKod = Convert.ToInt32(resultString.Substring(2));
                            return "CR" + (maxCariKod + 1).ToString("D3");
                        }
                        else
                        {
                            // Sonuç null veya boşsa başlangıç kodu CR001 olacak
                            return "CR001";
                        }
                    }
                }
            }
            return "CR001";
        }



        private void btnCariKaydet_Click(object sender, EventArgs e)
        {
            // Yeni cari kodunu al
            string yeniCariKod = GetNextCariKod();

            // Veritabanına bağlanmak için gerekli bağlantı dizesi
            string connectionString = "Data Source=DESKTOP-DDDMD65\\SQLEXPRESS;Initial Catalog=StokTakipDatabase;Integrated Security=True";

            try
            {
                // Veritabanı bağlantısını oluşturun
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Veritabanı bağlantısını açın
                    connection.Open();

                    // Veritabanına eklenecek olan komut
                    string query = "INSERT INTO cari (carikodu, adi, soyadi, telefon, adres, kimlikno) VALUES (@carikodu, @adi, @soyadi, @telefon, @adres, @kimlikno)";

                    // SqlCommand nesnesi oluşturun
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekleyin
                        command.Parameters.AddWithValue("@carikodu", yeniCariKod); // Yeni cari kodunu ekleyin
                        command.Parameters.AddWithValue("@adi", aditxt.Text);
                        command.Parameters.AddWithValue("@soyadi", soyaditxt.Text);
                        command.Parameters.AddWithValue("@telefon", telefontxt.Text);
                        command.Parameters.AddWithValue("@adres", adrestxt.Text);
                        command.Parameters.AddWithValue("@kimlikno", kimliknotxt.Text);

                        // Komutu çalıştırın
                        command.ExecuteNonQuery();
                    }
                }

                // Kaydetme işlemi tamamlandı mesajını gösterin
                MessageBox.Show("Yeni cari başarıyla kaydedildi. Cari Kodu: " + yeniCariKod, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Formu kapatın
                this.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi verin
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCariSil_Click(object sender, EventArgs e)
        {
            // Silme işlemi için cari kodunu alın
            string cariKod = carikodutxt.Text;

            // Silme işlemi için gerekli sorguyu oluşturun
            string query = "DELETE FROM cari WHERE carikodu = @carikodu";

            // Veritabanı bağlantısını oluşturun
            using (SqlConnection connection = new SqlConnection())
            {
                // Veritabanı bağlantısını açın
                connection.Open();

                // SqlCommand nesnesi oluşturun
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parametreyi ekleyin
                    command.Parameters.AddWithValue("@carikodu", cariKod);

                    // Komutu çalıştırın
                    command.ExecuteNonQuery();
                }
            }

            // Silme işlemi tamamlandı mesajını gösterin
            MessageBox.Show("Cari başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu kapatın
            this.Close();
        }

        private void btnCariVazgec_Click(object sender, EventArgs e)
        {
            // Formu kapatın
            this.Close();
            // Eğer text kutuları boşsa, doğrudan formu kapat
            if (string.IsNullOrWhiteSpace(aditxt.Text) &&
                string.IsNullOrWhiteSpace(soyaditxt.Text) &&
                string.IsNullOrWhiteSpace(telefontxt.Text) &&
                string.IsNullOrWhiteSpace(adrestxt.Text) &&
                string.IsNullOrWhiteSpace(kimliknotxt.Text))
            {
                this.Close();
            }
            else
            {
                // Text kutuları doluysa kullanıcıya kaydetmeden çıkmak isteyip istemediğini sorsun
                DialogResult result = MessageBox.Show("Yaptığınız değişiklikleri kaydetmeden çıkmak istiyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Kullanıcı kaydetmeden çıkmak istiyorsa formu kapat
                    this.Close();
                }
            }
        }

        private void frmYeniCari_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde TextBox odak değiştirme olaylarına abone ol
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.GotFocus += TextBox_GotFocus;
                }
                else if (control.HasChildren)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is TextBox)
                        {
                            innerControl.GotFocus += TextBox_GotFocus;
                        }
                    }
                }
            }
        }

        private void aditxt_TextChanged(object sender, EventArgs e)
        {
            
           
                // TextBox'ta girilen metni al
                string text = aditxt.Text;

                // Metni baş harfleri büyük, diğer harfleri küçük yapacak şekilde düzenle
                string formattedText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

                // Düzenlenmiş metni TextBox'a geri yükle
                aditxt.Text = formattedText;

                // Cursor'ı metnin sonuna götür
                aditxt.SelectionStart = aditxt.Text.Length;
            

        }

        private void soyaditxt_TextChanged(object sender, EventArgs e)
        {
            
                // TextBox'ta girilen metni al
                string text = soyaditxt.Text;

                // Metni baş harfleri büyük, diğer harfleri küçük yapacak şekilde düzenle
                string formattedText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

                // Düzenlenmiş metni TextBox'a geri yükle
                soyaditxt.Text = formattedText;

                // Cursor'ı metnin sonuna götür
                soyaditxt.SelectionStart = soyaditxt.Text.Length;
            

        }

        private void adrestxt_TextChanged(object sender, EventArgs e)
        {
            // TextBox'ta girilen metni al
            string text = adrestxt.Text;

            // Metni baş harfleri büyük, diğer harfleri küçük yapacak şekilde düzenle
            string formattedText = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text.ToLower());

            // Düzenlenmiş metni TextBox'a geri yükle
            adrestxt.Text = formattedText;

            // Cursor'ı metnin sonuna götür
            adrestxt.SelectionStart = adrestxt.Text.Length;
        }

        private void frmYeniCari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2)
            {
                btnCariKaydet.PerformClick();
            }
            // ESC tuşuna basıldığında
            if (e.KeyCode == Keys.Escape)
            {
                // Vazgeç butonunun Click olayını çağır
                btnCariVazgec.PerformClick();
            }
        }

        private void HighlightCurrentTextBox(Control parentControl)
        {
            // Formdaki her bir kontrolü döngüyle kontrol et
            foreach (Control control in parentControl.Controls)
            {
                // Eğer kontrol bir TextBox ise ve odaklanılmışsa, arka plan rengini değiştir
                if (control is TextBox textBox && textBox.Focused)
                {
                    textBox.BackColor = Color.LightGreen;
                }
                // Eğer kontrol bir grup kutusu ya da başka bir konteyner ise, bu metodu tekrar çağırarak içerisindeki kontrolleri kontrol et
                else if (control.HasChildren)
                {
                    HighlightCurrentTextBox(control);
                }
                // Diğer türdeki kontrolleri (etiketler, düğmeler vb.) işleme dahil etme
            }
        }

        private void ResetTextBoxBackgroundColor(Control parentControl)
        {
            // Formdaki her bir kontrolü döngüyle kontrol et
            foreach (Control control in parentControl.Controls)
            {
                // Eğer kontrol bir TextBox ise arka plan rengini varsayılan değere dönüştür
                if (control is TextBox textBox)
                {
                    textBox.BackColor = SystemColors.Window;
                }
                // Eğer kontrol bir grup kutusu ya da başka bir konteyner ise, bu metodu tekrar çağırarak içerisindeki kontrolleri kontrol et
                else if (control.HasChildren)
                {
                    ResetTextBoxBackgroundColor(control);
                }
                // Diğer türdeki kontrolleri (etiketler, düğmeler vb.) işleme dahil etme
            }
        }

        // TextBox odak değiştirdiğinde arka plan rengini güncelle
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            ResetTextBoxBackgroundColor(this); // Önce tüm TextBoxların arka plan rengini sıfırla
            HighlightCurrentTextBox(this); // Ardından odaklanılan TextBox'ın arka plan rengini değiştir
        }

        // Form yüklendiğinde TextBox olaylarına abone ol
        

    }
}
