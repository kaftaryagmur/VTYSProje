namespace VTYSProje
{
    partial class MainForm
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
            BtnMusteri = new Button();
            BtnRez = new Button();
            BtnPersonel = new Button();
            SuspendLayout();
            // 
            // BtnMusteri
            // 
            BtnMusteri.Location = new Point(69, 376);
            BtnMusteri.Name = "BtnMusteri";
            BtnMusteri.Size = new Size(267, 70);
            BtnMusteri.TabIndex = 0;
            BtnMusteri.Text = "Müşteri İşlemleri";
            BtnMusteri.UseVisualStyleBackColor = true;
            BtnMusteri.Click += button1_Click;
            // 
            // BtnRez
            // 
            BtnRez.Location = new Point(708, 376);
            BtnRez.Name = "BtnRez";
            BtnRez.Size = new Size(267, 70);
            BtnRez.TabIndex = 1;
            BtnRez.Text = "Rezervasyon İşlemleri";
            BtnRez.UseVisualStyleBackColor = true;
            BtnRez.Click += button2_Click;
            // 
            // BtnPersonel
            // 
            BtnPersonel.Location = new Point(386, 376);
            BtnPersonel.Name = "BtnPersonel";
            BtnPersonel.Size = new Size(267, 70);
            BtnPersonel.TabIndex = 2;
            BtnPersonel.Text = "Personel İşlemleri";
            BtnPersonel.UseVisualStyleBackColor = true;
            BtnPersonel.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 574);
            Controls.Add(BtnPersonel);
            Controls.Add(BtnRez);
            Controls.Add(BtnMusteri);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Otel";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnMusteri;
        private Button BtnRez;
        private Button BtnPersonel;
    }
}