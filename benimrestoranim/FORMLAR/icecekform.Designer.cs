namespace restaurantyonetimiss
{
    partial class icecekform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(icecekform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_icecekisim = new System.Windows.Forms.TextBox();
            this.txt_icecekfiyat = new System.Windows.Forms.TextBox();
            this.txt_icecekadet = new System.Windows.Forms.TextBox();
            this.cmb_sikma = new System.Windows.Forms.ComboBox();
            this.btn_icecekaydet = new System.Windows.Forms.Button();
            this.dataGridIcecek = new System.Windows.Forms.DataGridView();
            this.btn_iceceksil = new System.Windows.Forms.Button();
            this.btn_icecekliste = new System.Windows.Forms.Button();
            this.btn_anamenü = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_sogukicecekler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_sicakicecekler = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIcecek)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(161, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "FİYAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(314, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(464, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "SIKMA İÇECEKLER";
            // 
            // txt_icecekisim
            // 
            this.txt_icecekisim.Location = new System.Drawing.Point(62, 10);
            this.txt_icecekisim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_icecekisim.Name = "txt_icecekisim";
            this.txt_icecekisim.Size = new System.Drawing.Size(76, 20);
            this.txt_icecekisim.TabIndex = 4;
            // 
            // txt_icecekfiyat
            // 
            this.txt_icecekfiyat.Location = new System.Drawing.Point(212, 10);
            this.txt_icecekfiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_icecekfiyat.Name = "txt_icecekfiyat";
            this.txt_icecekfiyat.Size = new System.Drawing.Size(76, 20);
            this.txt_icecekfiyat.TabIndex = 5;
            // 
            // txt_icecekadet
            // 
            this.txt_icecekadet.Location = new System.Drawing.Point(363, 10);
            this.txt_icecekadet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_icecekadet.Name = "txt_icecekadet";
            this.txt_icecekadet.Size = new System.Drawing.Size(76, 20);
            this.txt_icecekadet.TabIndex = 6;
            // 
            // cmb_sikma
            // 
            this.cmb_sikma.FormattingEnabled = true;
            this.cmb_sikma.Items.AddRange(new object[] {
            "PORTAKAL SUYU",
            "VİŞNE SUYU",
            "LİMONATA",
            "ELMA SUYU",
            "NAR SUYU",
            "SIKMA KARIŞIK MEYVE SUYU"});
            this.cmb_sikma.Location = new System.Drawing.Point(598, 13);
            this.cmb_sikma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_sikma.Name = "cmb_sikma";
            this.cmb_sikma.Size = new System.Drawing.Size(92, 21);
            this.cmb_sikma.TabIndex = 7;
            // 
            // btn_icecekaydet
            // 
            this.btn_icecekaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_icecekaydet.BackgroundImage")));
            this.btn_icecekaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_icecekaydet.Image = ((System.Drawing.Image)(resources.GetObject("btn_icecekaydet.Image")));
            this.btn_icecekaydet.Location = new System.Drawing.Point(30, 150);
            this.btn_icecekaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_icecekaydet.Name = "btn_icecekaydet";
            this.btn_icecekaydet.Size = new System.Drawing.Size(88, 48);
            this.btn_icecekaydet.TabIndex = 8;
            this.btn_icecekaydet.Text = "KAYDET";
            this.btn_icecekaydet.UseVisualStyleBackColor = true;
            this.btn_icecekaydet.Click += new System.EventHandler(this.btn_icecekaydet_Click);
            // 
            // dataGridIcecek
            // 
            this.dataGridIcecek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIcecek.Location = new System.Drawing.Point(9, 228);
            this.dataGridIcecek.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridIcecek.Name = "dataGridIcecek";
            this.dataGridIcecek.RowTemplate.Height = 24;
            this.dataGridIcecek.Size = new System.Drawing.Size(691, 296);
            this.dataGridIcecek.TabIndex = 9;
            this.dataGridIcecek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIcecek_CellContentClick);
            // 
            // btn_iceceksil
            // 
            this.btn_iceceksil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_iceceksil.BackgroundImage")));
            this.btn_iceceksil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_iceceksil.Location = new System.Drawing.Point(164, 150);
            this.btn_iceceksil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_iceceksil.Name = "btn_iceceksil";
            this.btn_iceceksil.Size = new System.Drawing.Size(87, 48);
            this.btn_iceceksil.TabIndex = 10;
            this.btn_iceceksil.Text = "SİL";
            this.btn_iceceksil.UseVisualStyleBackColor = true;
            this.btn_iceceksil.Click += new System.EventHandler(this.btn_iceceksil_Click);
            // 
            // btn_icecekliste
            // 
            this.btn_icecekliste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_icecekliste.BackgroundImage")));
            this.btn_icecekliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_icecekliste.Location = new System.Drawing.Point(428, 150);
            this.btn_icecekliste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_icecekliste.Name = "btn_icecekliste";
            this.btn_icecekliste.Size = new System.Drawing.Size(92, 48);
            this.btn_icecekliste.TabIndex = 11;
            this.btn_icecekliste.Text = "LİSTELE";
            this.btn_icecekliste.UseVisualStyleBackColor = true;
            this.btn_icecekliste.Click += new System.EventHandler(this.btn_icecekliste_Click);
            // 
            // btn_anamenü
            // 
            this.btn_anamenü.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anamenü.BackgroundImage")));
            this.btn_anamenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenü.Location = new System.Drawing.Point(566, 150);
            this.btn_anamenü.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_anamenü.Name = "btn_anamenü";
            this.btn_anamenü.Size = new System.Drawing.Size(97, 48);
            this.btn_anamenü.TabIndex = 12;
            this.btn_anamenü.Text = "ANAMENÜ";
            this.btn_anamenü.UseVisualStyleBackColor = true;
            this.btn_anamenü.Click += new System.EventHandler(this.btn_anamenü_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(292, 150);
            this.btn_guncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(82, 48);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "SOĞUK İÇECEKLER";
            // 
            // cmb_sogukicecekler
            // 
            this.cmb_sogukicecekler.FormattingEnabled = true;
            this.cmb_sogukicecekler.Items.AddRange(new object[] {
            "COLA",
            "AYRAN",
            "MEYVE SUYU",
            "SU",
            "GAZOZ",
            "MADEN SUYU",
            "MEYVELİ SUYU",
            "FANTA",
            "MİLKSHAKE"});
            this.cmb_sogukicecekler.Location = new System.Drawing.Point(140, 64);
            this.cmb_sogukicecekler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_sogukicecekler.Name = "cmb_sogukicecekler";
            this.cmb_sogukicecekler.Size = new System.Drawing.Size(92, 21);
            this.cmb_sogukicecekler.TabIndex = 15;
            this.cmb_sogukicecekler.SelectedIndexChanged += new System.EventHandler(this.cmb_sogukicecekler_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(260, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "SICAK İÇECEKLER";
            // 
            // cmb_sicakicecekler
            // 
            this.cmb_sicakicecekler.FormattingEnabled = true;
            this.cmb_sicakicecekler.Items.AddRange(new object[] {
            "SAHLEP",
            "NESCAFE",
            "ÇAY",
            "FİLTRE KAHVE",
            "SICAK ÇİKOLATA",
            "CAPPUCİNO",
            "MACCHİATO",
            "TÜRK KAHVESİ",
            "ESPRESSO"});
            this.cmb_sicakicecekler.Location = new System.Drawing.Point(393, 64);
            this.cmb_sicakicecekler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_sicakicecekler.Name = "cmb_sicakicecekler";
            this.cmb_sicakicecekler.Size = new System.Drawing.Size(92, 21);
            this.cmb_sicakicecekler.TabIndex = 17;
            // 
            // icecekform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 566);
            this.Controls.Add(this.cmb_sicakicecekler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_sogukicecekler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_anamenü);
            this.Controls.Add(this.btn_icecekliste);
            this.Controls.Add(this.btn_iceceksil);
            this.Controls.Add(this.dataGridIcecek);
            this.Controls.Add(this.btn_icecekaydet);
            this.Controls.Add(this.cmb_sikma);
            this.Controls.Add(this.txt_icecekadet);
            this.Controls.Add(this.txt_icecekfiyat);
            this.Controls.Add(this.txt_icecekisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "icecekform";
            this.Text = "icecek";
            this.Load += new System.EventHandler(this.icecekform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIcecek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_icecekisim;
        private System.Windows.Forms.TextBox txt_icecekfiyat;
        private System.Windows.Forms.TextBox txt_icecekadet;
        private System.Windows.Forms.ComboBox cmb_sikma;
        private System.Windows.Forms.Button btn_icecekaydet;
        private System.Windows.Forms.DataGridView dataGridIcecek;
        private System.Windows.Forms.Button btn_iceceksil;
        private System.Windows.Forms.Button btn_icecekliste;
        private System.Windows.Forms.Button btn_anamenü;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_sogukicecekler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_sicakicecekler;
    }
}