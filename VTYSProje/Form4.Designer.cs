namespace VTYSProje
{
    partial class Form4
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
            TxtMusIletisim = new TextBox();
            label3 = new Label();
            TxtMusSoyadi = new TextBox();
            label2 = new Label();
            TxtMusAdi = new TextBox();
            label4 = new Label();
            label1 = new Label();
            MusteriGüncelle = new Button();
            MusteriSil = new Button();
            MusteriEkle = new Button();
            MusteriAra = new Button();
            dataGridView1 = new DataGridView();
            BtnListele = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TxtMusIletisim
            // 
            TxtMusIletisim.Location = new Point(475, 384);
            TxtMusIletisim.Name = "TxtMusIletisim";
            TxtMusIletisim.Size = new Size(175, 27);
            TxtMusIletisim.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 391);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 41;
            label3.Text = "İletişim Numarası:";
            // 
            // TxtMusSoyadi
            // 
            TxtMusSoyadi.Location = new Point(107, 388);
            TxtMusSoyadi.Name = "TxtMusSoyadi";
            TxtMusSoyadi.Size = new Size(175, 27);
            TxtMusSoyadi.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 388);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 39;
            label2.Text = "Soyadı:";
            // 
            // TxtMusAdi
            // 
            TxtMusAdi.Location = new Point(107, 345);
            TxtMusAdi.Name = "TxtMusAdi";
            TxtMusAdi.Size = new Size(175, 27);
            TxtMusAdi.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 345);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 37;
            label4.Text = "Adı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 281);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 36;
            label1.Text = "Müşteri İşlemleri";
            // 
            // MusteriGüncelle
            // 
            MusteriGüncelle.Location = new Point(801, 500);
            MusteriGüncelle.Name = "MusteriGüncelle";
            MusteriGüncelle.Size = new Size(193, 38);
            MusteriGüncelle.TabIndex = 35;
            MusteriGüncelle.Text = "Güncelle";
            MusteriGüncelle.UseVisualStyleBackColor = true;
            MusteriGüncelle.Click += MusteriGüncelle_Click;
            // 
            // MusteriSil
            // 
            MusteriSil.Location = new Point(532, 500);
            MusteriSil.Name = "MusteriSil";
            MusteriSil.Size = new Size(193, 38);
            MusteriSil.TabIndex = 34;
            MusteriSil.Text = "Sil";
            MusteriSil.UseVisualStyleBackColor = true;
            MusteriSil.Click += MusteriSil_Click;
            // 
            // MusteriEkle
            // 
            MusteriEkle.Location = new Point(285, 500);
            MusteriEkle.Name = "MusteriEkle";
            MusteriEkle.Size = new Size(193, 38);
            MusteriEkle.TabIndex = 33;
            MusteriEkle.Text = "Ekle";
            MusteriEkle.UseVisualStyleBackColor = true;
            MusteriEkle.Click += MusteriEkle_Click;
            // 
            // MusteriAra
            // 
            MusteriAra.Location = new Point(47, 500);
            MusteriAra.Name = "MusteriAra";
            MusteriAra.Size = new Size(193, 38);
            MusteriAra.TabIndex = 32;
            MusteriAra.Text = "Ara";
            MusteriAra.UseVisualStyleBackColor = true;
            MusteriAra.Click += MusteriAra_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(98, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(851, 157);
            dataGridView1.TabIndex = 31;
            // 
            // BtnListele
            // 
            BtnListele.Location = new Point(801, 370);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(193, 38);
            BtnListele.TabIndex = 47;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = true;
            BtnListele.Click += BtnListele_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(449, 338);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 27);
            dateTimePicker1.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 338);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 48;
            label5.Text = "Doğum Tarihi:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 574);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(BtnListele);
            Controls.Add(TxtMusIletisim);
            Controls.Add(label3);
            Controls.Add(TxtMusSoyadi);
            Controls.Add(label2);
            Controls.Add(TxtMusAdi);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(MusteriGüncelle);
            Controls.Add(MusteriSil);
            Controls.Add(MusteriEkle);
            Controls.Add(MusteriAra);
            Controls.Add(dataGridView1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtMusIletisim;
        private Label label3;
        private TextBox TxtMusSoyadi;
        private Label label2;
        private TextBox TxtMusAdi;
        private Label label4;
        private Label label1;
        private Button MusteriGüncelle;
        private Button MusteriSil;
        private Button MusteriEkle;
        private Button MusteriAra;
        private DataGridView dataGridView1;
        private Button BtnListele;
        private DateTimePicker dateTimePicker1;
        private Label label5;
    }
}