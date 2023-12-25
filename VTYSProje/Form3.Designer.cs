namespace VTYSProje
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PerEkle = new Button();
            PerAra = new Button();
            dataGridView1 = new DataGridView();
            PerSil = new Button();
            PerGüncelle = new Button();
            label1 = new Label();
            label5 = new Label();
            TxtPerSoyadi = new TextBox();
            label2 = new Label();
            TxtPerAdi = new TextBox();
            label4 = new Label();
            combobox = new ComboBox();
            BtnListele = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // PerEkle
            // 
            PerEkle.Location = new Point(580, 433);
            PerEkle.Name = "PerEkle";
            PerEkle.Size = new Size(193, 38);
            PerEkle.TabIndex = 19;
            PerEkle.Text = "Ekle";
            PerEkle.UseVisualStyleBackColor = true;
            PerEkle.Click += PerEkle_Click;
            // 
            // PerAra
            // 
            PerAra.Location = new Point(580, 376);
            PerAra.Name = "PerAra";
            PerAra.Size = new Size(193, 38);
            PerAra.TabIndex = 13;
            PerAra.Text = "Ara";
            PerAra.UseVisualStyleBackColor = true;
            PerAra.Click += PerAra_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(442, 514);
            dataGridView1.TabIndex = 10;
            // 
            // PerSil
            // 
            PerSil.Location = new Point(815, 377);
            PerSil.Name = "PerSil";
            PerSil.Size = new Size(193, 38);
            PerSil.TabIndex = 20;
            PerSil.Text = "Sil";
            PerSil.UseVisualStyleBackColor = true;
            PerSil.Click += PerSil_Click;
            // 
            // PerGüncelle
            // 
            PerGüncelle.Location = new Point(815, 433);
            PerGüncelle.Name = "PerGüncelle";
            PerGüncelle.Size = new Size(193, 38);
            PerGüncelle.TabIndex = 21;
            PerGüncelle.Text = "Güncelle";
            PerGüncelle.UseVisualStyleBackColor = true;
            PerGüncelle.Click += PerGüncelle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(698, 63);
            label1.Name = "label1";
            label1.Size = new Size(162, 28);
            label1.TabIndex = 22;
            label1.Text = "Personel İşlemleri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(601, 245);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 29;
            label5.Text = "Departmanı:";
            // 
            // TxtPerSoyadi
            // 
            TxtPerSoyadi.Location = new Point(696, 176);
            TxtPerSoyadi.Name = "TxtPerSoyadi";
            TxtPerSoyadi.Size = new Size(175, 27);
            TxtPerSoyadi.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(635, 176);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 25;
            label2.Text = "Soyadı:";
            // 
            // TxtPerAdi
            // 
            TxtPerAdi.Location = new Point(696, 111);
            TxtPerAdi.Name = "TxtPerAdi";
            TxtPerAdi.Size = new Size(175, 27);
            TxtPerAdi.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 111);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 23;
            label4.Text = "Adı:";
            // 
            // combobox
            // 
            combobox.FormattingEnabled = true;
            combobox.Items.AddRange(new object[] { "Bar", "Güvenlik", "İnsan Kaynakları", "Kat Hizmetleri", "Muhasebe", "Mutfak", "Oda Hizmetleri", "Organizasyon", "Restoran", "Teknik Destek" });
            combobox.Location = new Point(696, 245);
            combobox.Name = "combobox";
            combobox.Size = new Size(175, 28);
            combobox.TabIndex = 30;
            combobox.SelectedIndexChanged += combobox_SelectedIndexChanged;
            // 
            // BtnListele
            // 
            BtnListele.Location = new Point(698, 490);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(193, 38);
            BtnListele.TabIndex = 31;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = true;
            BtnListele.Click += BtnListele_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 574);
            Controls.Add(BtnListele);
            Controls.Add(combobox);
            Controls.Add(label5);
            Controls.Add(TxtPerSoyadi);
            Controls.Add(label2);
            Controls.Add(TxtPerAdi);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(PerGüncelle);
            Controls.Add(PerSil);
            Controls.Add(PerEkle);
            Controls.Add(PerAra);
            Controls.Add(dataGridView1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PerEkle;
        private Button PerAra;
        private DataGridView dataGridView1;
        private Button PerSil;
        private Button PerGüncelle;
        private Label label1;
        private Label label5;
        private TextBox TxtPerSoyadi;
        private Label label2;
        private TextBox TxtPerAdi;
        private Label label4;
        private ComboBox combobox;
        private Button BtnListele;
    }
}