namespace VTYSProje
{
    partial class Form2
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
            TxtRezOdaNo = new TextBox();
            label3 = new Label();
            TxtRezSoyadi = new TextBox();
            label2 = new Label();
            ButtonRezOlustur = new Button();
            TxtRezAdi = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            SuspendLayout();
            // 
            // TxtRezOdaNo
            // 
            TxtRezOdaNo.Location = new Point(182, 317);
            TxtRezOdaNo.Name = "TxtRezOdaNo";
            TxtRezOdaNo.Size = new Size(218, 27);
            TxtRezOdaNo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 320);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 14;
            label3.Text = "Oda Numarası:";
            // 
            // TxtRezSoyadi
            // 
            TxtRezSoyadi.Location = new Point(180, 177);
            TxtRezSoyadi.Name = "TxtRezSoyadi";
            TxtRezSoyadi.Size = new Size(218, 27);
            TxtRezSoyadi.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 180);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 12;
            label2.Text = "Soyadı:";
            // 
            // ButtonRezOlustur
            // 
            ButtonRezOlustur.Location = new Point(253, 504);
            ButtonRezOlustur.Name = "ButtonRezOlustur";
            ButtonRezOlustur.Size = new Size(147, 38);
            ButtonRezOlustur.TabIndex = 11;
            ButtonRezOlustur.Text = "Oluştur";
            ButtonRezOlustur.UseVisualStyleBackColor = true;
            ButtonRezOlustur.Click += ButtonRezOlustur_Click_1;
            // 
            // TxtRezAdi
            // 
            TxtRezAdi.Location = new Point(180, 112);
            TxtRezAdi.Name = "TxtRezAdi";
            TxtRezAdi.Size = new Size(218, 27);
            TxtRezAdi.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 115);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 9;
            label1.Text = "Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(98, 38);
            label4.Name = "label4";
            label4.Size = new Size(300, 28);
            label4.TabIndex = 16;
            label4.Text = "Rezervasyonu oluşturacak kişinin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 249);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 17;
            label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 385);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 19;
            label6.Text = "Giriş Tarihi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(93, 449);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 21;
            label7.Text = "Çıkış Tarihi:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(180, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(220, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(178, 385);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(220, 27);
            dateTimePicker2.TabIndex = 24;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(178, 449);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(220, 27);
            dateTimePicker3.TabIndex = 25;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 574);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtRezOdaNo);
            Controls.Add(label3);
            Controls.Add(TxtRezSoyadi);
            Controls.Add(label2);
            Controls.Add(ButtonRezOlustur);
            Controls.Add(TxtRezAdi);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rezervasyon Oluştur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtRezOdaNo;
        private Label label3;
        private TextBox TxtRezSoyadi;
        private Label label2;
        private Button ButtonRezOlustur;
        private TextBox TxtRezAdi;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
    }
}