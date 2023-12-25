using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VTYSProje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port=5432; Database=Otel; user ID=postgres; password=Yagmur00");
        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select \"adi\",\"soyadi\",\"depID\" from \"Personel\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        
        }

        private void PerAra_Click(object sender, EventArgs e)
        {
            string adi = TxtPerAdi.Text;
            string soyadi = TxtPerSoyadi.Text;
            string selectedDepartman = combobox.SelectedItem?.ToString();

            // Kullanıcıdan gelen veriyi SQL injection saldırılarına karşı korumak için parametre kullanımı
            string sorgu = "SELECT * FROM \"Personel\" WHERE adi = @Adi OR soyadi = @Soyadi OR \"depID\" = @Departman";

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti))
            {
                da.SelectCommand.Parameters.AddWithValue("@Adi", adi);
                da.SelectCommand.Parameters.AddWithValue("@Soyadi", soyadi);
                da.SelectCommand.Parameters.AddWithValue("@Departman", selectedDepartman);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void PerEkle_Click(object sender, EventArgs e)
        {
            string adi = TxtPerAdi.Text;
            string soyadi = TxtPerSoyadi.Text;
            string selectedDepartman = combobox.SelectedItem?.ToString();

            // Kullanıcıdan gelen veriyi SQL injection saldırılarına karşı korumak için parametre kullanımı
            string sorgu = "INSERT INTO \"Personel\" (\"adi\", \"soyadi\", \"depID\") VALUES (@Adi, @Soyadi, @Departman)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
            {
                cmd.Parameters.AddWithValue("@Adi", adi);
                cmd.Parameters.AddWithValue("@Soyadi", soyadi);
                cmd.Parameters.AddWithValue("@Departman", selectedDepartman);

                try
                {
                    baglanti.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Personel başarıyla eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Eklemeye çalıştığınız kayıt zaten var.");
                    }
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

        private void PerSil_Click(object sender, EventArgs e)
        {
            string adi = TxtPerAdi.Text;
            string soyadi = TxtPerSoyadi.Text;

            // Kullanıcıdan gelen veriyi SQL injection saldırılarına karşı korumak için parametre kullanımı
            string sorgu = "DELETE FROM \"Personel\" WHERE \"adi\" = @Adi AND \"soyadi\" = @Soyadi";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
            {
                cmd.Parameters.AddWithValue("@Adi", adi);
                cmd.Parameters.AddWithValue("@Soyadi", soyadi);


                try
                {
                    baglanti.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Personel başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen kriterlere uygun personel bulunamadı.");
                    }
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

        private void PerGüncelle_Click(object sender, EventArgs e)
        {
            string adi = TxtPerAdi.Text;
            string soyadi = TxtPerSoyadi.Text;
            string selectedDepartman = combobox.SelectedItem?.ToString();

            // Kullanıcıdan gelen veriyi SQL injection saldırılarına karşı korumak için parametre kullanımı
            string sorgu = "UPDATE \"Personel\" SET \"depID\" = @Departman WHERE \"adi\" = @Adi AND \"soyadi\" = @Soyadi";

            using (NpgsqlCommand cmd = new NpgsqlCommand(sorgu, baglanti))
            {
                cmd.Parameters.AddWithValue("@Departman", selectedDepartman);
                cmd.Parameters.AddWithValue("@Adi", adi);
                cmd.Parameters.AddWithValue("@Soyadi", soyadi);

                try
                {
                    baglanti.Open();
                    int affectedRows = cmd.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Personel başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen kriterlere uygun personel bulunamadı.");
                    }
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

        private void combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // ComboBox'tan seçili değeri al
                string selectedDepartman = combobox.SelectedItem?.ToString();

                // ComboBox'tan seçim yapılmışsa Personel tablosunu filtrele ve DataGridView'de göster
                if (!string.IsNullOrEmpty(selectedDepartman))
                {
                    
                        baglanti.Open();

                        using (NpgsqlCommand command = new NpgsqlCommand("public.FiltrelePersonel", baglanti))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // ComboBoxDepartman'dan seçilen değeri parametre olarak ekle
                            command.Parameters.AddWithValue("p_departman", selectedDepartman);

                            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                            {
                                DataSet ds = new DataSet();
                                adapter.Fill(ds);

                                // DataGridView'e sadece seçilen departmana ait sonuçları göster
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                        }
                         baglanti.Close();
                    
                }
                else
                {
                    // ComboBox'tan seçim yapılmamışsa DataGridView'i temizle
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
