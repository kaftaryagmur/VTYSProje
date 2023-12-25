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

namespace VTYSProje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port=5432; Database=Otel; user ID=postgres; password=Yagmur00");

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select \"adi\",\"soyadi\" from \"Musteri\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void MusteriAra_Click(object sender, EventArgs e)
        {
            string adi = TxtMusAdi.Text;
            string soyadi = TxtMusSoyadi.Text;
            DateTime dogumTarihi = dateTimePicker1.Value; // dateTimePicker1 kontrolünden seçilen tarih bilgisini al

            // Kullanıcıdan gelen veriyi SQL injection saldırılarına karşı korumak için parametre kullanımı
            string sorgu = "SELECT * FROM \"Musteri\" WHERE \"adi\" = @Adi OR \"soyadi\" = @Soyadi OR \"dogumTarihi\" = @DogumTarihi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);

            // Parametre ekleyerek güvenli bir şekilde veriyi sorguya dahil edin
            da.SelectCommand.Parameters.AddWithValue("@Adi", adi);
            da.SelectCommand.Parameters.AddWithValue("@Soyadi", soyadi);
            da.SelectCommand.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }

        private void MusteriEkle_Click(object sender, EventArgs e)
        {
            string adi = TxtMusAdi.Text;
            string soyadi = TxtMusSoyadi.Text;
            long iletisim;

            if (long.TryParse(TxtMusIletisim.Text, out iletisim))
            {
                DateTime dogumTarihi = dateTimePicker1.Value; // dateTimePicker1 kontrolünden seçilen tarih bilgisini al

                // INSERT INTO sorgusu
                string sorgu = "INSERT INTO \"Musteri\" (\"adi\", \"soyadi\", \"iletisim\", \"dogumTarihi\") " +
                               "VALUES (@Adi, @Soyadi, @Iletisim, @DogumTarihi)";

                baglanti.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                {
                    // Parametre ekleyerek güvenli bir şekilde veriyi sorguya dahil edin
                    command.Parameters.AddWithValue("@Adi", adi);
                    command.Parameters.AddWithValue("@Soyadi", soyadi);
                    command.Parameters.AddWithValue("@Iletisim", iletisim);
                    command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();

                    // Kullanıcıya başarı mesajını göster
                    MessageBox.Show("Müşteri başarıyla eklendi.");
                }

            }
            else
            {
                MessageBox.Show("Geçersiz telefon numarası formatı.");
            }

            baglanti.Close();


        }

        private void MusteriSil_Click(object sender, EventArgs e)
        {
            string adi = TxtMusAdi.Text;
            string soyadi = TxtMusSoyadi.Text;

            // DELETE sorgusu
            string sorgu = "DELETE FROM \"Musteri\" WHERE \"adi\" = @Adi AND \"soyadi\" = @Soyadi";


            baglanti.Open();

            using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
            {
                // Parametre ekleyerek güvenli bir şekilde veriyi sorguya dahil edin
                command.Parameters.AddWithValue("@Adi", adi);
                command.Parameters.AddWithValue("@Soyadi", soyadi);

                // Sorguyu çalıştır
                int affectedRows = command.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Müşteri başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silinecek müşteri bulunamadı.");
                }
            }
            baglanti.Close();
        }

        private void MusteriGüncelle_Click(object sender, EventArgs e)
        {
            string adi = TxtMusAdi.Text;

            // Yeni bilgileri al
            string yeniSoyadi = TxtMusSoyadi.Text;
            long yeniIletisim;
            if (long.TryParse(TxtMusIletisim.Text, out yeniIletisim))
            {
                // UPDATE sorgusu
                string sorgu = "UPDATE \"Musteri\" SET \"soyadi\" = @YeniSoyadi, \"iletisim\" = @YeniIletisim " +
                           "WHERE \"adi\" = @Adi";


                baglanti.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(sorgu, baglanti))
                {
                    // Parametre ekleyerek güvenli bir şekilde veriyi sorguya dahil edin
                    command.Parameters.AddWithValue("@YeniSoyadi", yeniSoyadi);
                    command.Parameters.AddWithValue("@YeniIletisim", yeniIletisim);
                    command.Parameters.AddWithValue("@Adi", adi);

                    // Sorguyu çalıştır
                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Güncellenecek müşteri bulunamadı.");
                    }
                }
                baglanti.Close();
            }


        }


    }
}
