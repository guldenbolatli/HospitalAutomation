namespace Hastane_Otomasyonu
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
            btnTest = new Button();
            lstbList = new ListView();
            btnListele = new Button();
            btnEkleme = new Button();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(24, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(524, 84);
            btnTest.TabIndex = 0;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lstbList
            // 
            lstbList.Location = new Point(24, 118);
            lstbList.Name = "lstbList";
            lstbList.Size = new Size(524, 196);
            lstbList.TabIndex = 1;
            lstbList.UseCompatibleStateImageBehavior = false;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(83, 337);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(178, 43);
            btnListele.TabIndex = 2;
            btnListele.Text = "Listele Formunu Aç";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnEkleme
            // 
            btnEkleme.Location = new Point(292, 337);
            btnEkleme.Name = "btnEkleme";
            btnEkleme.Size = new Size(193, 43);
            btnEkleme.TabIndex = 2;
            btnEkleme.Text = "Doktor Ekleme Sayfasını Aç";
            btnEkleme.UseVisualStyleBackColor = true;
            btnEkleme.Click += btnEkleme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 409);
            Controls.Add(btnEkleme);
            Controls.Add(btnListele);
            Controls.Add(lstbList);
            Controls.Add(btnTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private ListView lstbList;
        private Button btnListele;
        private Button btnEkleme;
    }
}