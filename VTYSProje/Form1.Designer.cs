namespace VTYSProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            BttnAra = new Button();
            label4 = new Label();
            ButtonRezOlustur = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(606, 514);
            dataGridView1.TabIndex = 0;
            // 
            // BttnAra
            // 
            BttnAra.Location = new Point(796, 192);
            BttnAra.Name = "BttnAra";
            BttnAra.Size = new Size(193, 38);
            BttnAra.TabIndex = 3;
            BttnAra.Text = "Ara";
            BttnAra.UseVisualStyleBackColor = true;
            BttnAra.Click += BttnAra_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(695, 100);
            label4.Name = "label4";
            label4.Size = new Size(206, 28);
            label4.TabIndex = 8;
            label4.Text = "Ne zaman gelebilirim?";
            // 
            // ButtonRezOlustur
            // 
            ButtonRezOlustur.Location = new Point(796, 260);
            ButtonRezOlustur.Name = "ButtonRezOlustur";
            ButtonRezOlustur.Size = new Size(193, 38);
            ButtonRezOlustur.TabIndex = 9;
            ButtonRezOlustur.Text = "Rezervasyon Oluştur";
            ButtonRezOlustur.UseVisualStyleBackColor = true;
            ButtonRezOlustur.Visible = false;
            ButtonRezOlustur.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 574);
            Controls.Add(ButtonRezOlustur);
            Controls.Add(label4);
            Controls.Add(BttnAra);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ara";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BttnAra;
        private Label label4;
        private Button ButtonRezOlustur;
    }
}