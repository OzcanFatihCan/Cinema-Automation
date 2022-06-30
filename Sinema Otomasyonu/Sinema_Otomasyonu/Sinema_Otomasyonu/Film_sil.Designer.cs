namespace Sinema_Otomasyonu
{
    partial class Film_sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Film_sil));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Film_Adi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Afis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fragman_link = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fotograf_1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fotograf_2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fotograf_3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Film_Turu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(332, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Film Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.Location = new System.Drawing.Point(672, 519);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Film_Adi,
            this.Film_Turu,
            this.Afis,
            this.Fragman_link,
            this.Fotograf_1,
            this.Fotograf_2,
            this.Fotograf_3});
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 155);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 150);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Film_Adi
            // 
            this.Film_Adi.Text = "Film Adı";
            this.Film_Adi.Width = 143;
            // 
            // Afis
            // 
            this.Afis.DisplayIndex = 1;
            this.Afis.Text = "Afiş";
            this.Afis.Width = 63;
            // 
            // Fragman_link
            // 
            this.Fragman_link.DisplayIndex = 2;
            this.Fragman_link.Text = "Fragman Link";
            this.Fragman_link.Width = 107;
            // 
            // Fotograf_1
            // 
            this.Fotograf_1.DisplayIndex = 3;
            this.Fotograf_1.Text = "Fotoğraf 1";
            this.Fotograf_1.Width = 72;
            // 
            // Fotograf_2
            // 
            this.Fotograf_2.DisplayIndex = 4;
            this.Fotograf_2.Text = "Fotoğraf 2";
            this.Fotograf_2.Width = 67;
            // 
            // Fotograf_3
            // 
            this.Fotograf_3.DisplayIndex = 5;
            this.Fotograf_3.Text = "Fotoğraf 3";
            this.Fotograf_3.Width = 68;
            // 
            // Film_Turu
            // 
            this.Film_Turu.DisplayIndex = 6;
            this.Film_Turu.Text = "Film Türü";
            this.Film_Turu.Width = 162;
            // 
            // Film_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sinema_Otomasyonu.Properties.Resources.Background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Film_sil";
            this.Text = "Film Sil";
            this.Load += new System.EventHandler(this.Film_sil_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Film_Adi;
        private System.Windows.Forms.ColumnHeader Afis;
        private System.Windows.Forms.ColumnHeader Fragman_link;
        private System.Windows.Forms.ColumnHeader Fotograf_1;
        private System.Windows.Forms.ColumnHeader Fotograf_2;
        private System.Windows.Forms.ColumnHeader Fotograf_3;
        private System.Windows.Forms.ColumnHeader Film_Turu;
    }
}