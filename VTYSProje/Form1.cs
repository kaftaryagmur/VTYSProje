using Npgsql;
using System.Data;

namespace VTYSProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server= localHost; port=5432; Database=Otel; user ID=postgres; password=Yagmur00");

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void BttnAra_Click(object sender, EventArgs e)
        {
            ButtonRezOlustur.Visible = true;
            string sorgu = "SELECT \"OdaYapisi\".\"odaNo\", \"YatakTip\".\"durum\", \"OdaYapisi\".\"odaSayisi\", \"YatakTip\".\"adi\"\r\nFROM \"YatakTip\"\r\nLEFT OUTER JOIN \"OdaYapisi\" ON \"OdaYapisi\".\"odaNo\" = \"YatakTip\".\"odaNo\"";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}