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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port=5432; Database=Otel; user ID=postgres; password=Yagmur00");

        private void ButtonRezOlustur_Click_1(object sender, EventArgs e)
        {
            string rezAdi = TxtRezAdi.Text;
            string rezSoyadi = TxtRezSoyadi.Text;
            DateTime rezDogumTarihi = dateTimePicker1.Value;

            // Musteri tablosuna yeni kayıt eklemek için INSERT INTO sorgusu
            string musteriEkleSorgu = "INSERT INTO \"Musteri\" (\"adi\", \"soyadi\", \"dogumTarihi\") " +
                                      "VALUES (@RezAdi, @RezSoyadi, @RezDogumTarihi)";

            // NpgsqlCommand ve NpgsqlParameter kullanarak sorguyu çalıştırma
            using (NpgsqlCommand musteriEkleCommand = new NpgsqlCommand(musteriEkleSorgu, baglanti))
            {
                musteriEkleCommand.Parameters.AddWithValue("@RezAdi", rezAdi);
                musteriEkleCommand.Parameters.AddWithValue("@RezSoyadi", rezSoyadi);
                musteriEkleCommand.Parameters.AddWithValue("@RezDogumTarihi", rezDogumTarihi);

                try
                {
                    baglanti.Open();
                    musteriEkleCommand.ExecuteNonQuery();
                    MessageBox.Show("Başarıyla eklenmiştir.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            
        }

    }
}
