namespace restaurantyonetimiss
{
    partial class yiyecekform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yiyecekform));
            this.btn_anamenü = new System.Windows.Forms.Button();
            this.btn_yiyecekliste = new System.Windows.Forms.Button();
            this.btn_yiyeceksil = new System.Windows.Forms.Button();
            this.dataGridyiyecek = new System.Windows.Forms.DataGridView();
            this.btn_yiyecekaydet = new System.Windows.Forms.Button();
            this.cmb_vejyiyecek = new System.Windows.Forms.ComboBox();
            this.txt_yiyecekadet = new System.Windows.Forms.TextBox();
            this.txt_yiyecekfiyat = new System.Windows.Forms.TextBox();
            this.txt_yiyecekisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_evyemek = new System.Windows.Forms.ComboBox();
            this.btn_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridyiyecek)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_anamenü
            // 
            this.btn_anamenü.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anamenü.BackgroundImage")));
            this.btn_anamenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenü.Location = new System.Drawing.Point(672, 192);
            this.btn_anamenü.Name = "btn_anamenü";
            this.btn_anamenü.Size = new System.Drawing.Size(126, 55);
            this.btn_anamenü.TabIndex = 26;
            this.btn_anamenü.Text = "ANAMENÜ";
            this.btn_anamenü.UseVisualStyleBackColor = true;
            this.btn_anamenü.Click += new System.EventHandler(this.btn_anamenü_Click);
            // 
            // btn_yiyecekliste
            // 
            this.btn_yiyecekliste.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yiyecekliste.BackgroundImage")));
            this.btn_yiyecekliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yiyecekliste.Location = new System.Drawing.Point(517, 194);
            this.btn_yiyecekliste.Name = "btn_yiyecekliste";
            this.btn_yiyecekliste.Size = new System.Drawing.Size(122, 55);
            this.btn_yiyecekliste.TabIndex = 25;
            this.btn_yiyecekliste.Text = "LİSTELE";
            this.btn_yiyecekliste.UseVisualStyleBackColor = true;
            this.btn_yiyecekliste.Click += new System.EventHandler(this.btn_yiyecekliste_Click);
            // 
            // btn_yiyeceksil
            // 
            this.btn_yiyeceksil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yiyeceksil.BackgroundImage")));
            this.btn_yiyeceksil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yiyeceksil.Location = new System.Drawing.Point(206, 193);
            this.btn_yiyeceksil.Name = "btn_yiyeceksil";
            this.btn_yiyeceksil.Size = new System.Drawing.Size(128, 55);
            this.btn_yiyeceksil.TabIndex = 24;
            this.btn_yiyeceksil.Text = "SİL";
            this.btn_yiyeceksil.UseVisualStyleBackColor = true;
            this.btn_yiyeceksil.Click += new System.EventHandler(this.btn_yiyeceksil_Click);
            // 
            // dataGridyiyecek
            // 
            this.dataGridyiyecek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridyiyecek.Location = new System.Drawing.Point(30, 298);
            this.dataGridyiyecek.Name = "dataGridyiyecek";
            this.dataGridyiyecek.RowTemplate.Height = 24;
            this.dataGridyiyecek.Size = new System.Drawing.Size(803, 345);
            this.dataGridyiyecek.TabIndex = 23;
            this.dataGridyiyecek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridyiyecek_CellContentClick);
            // 
            // btn_yiyecekaydet
            // 
            this.btn_yiyecekaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yiyecekaydet.BackgroundImage")));
            this.btn_yiyecekaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yiyecekaydet.Location = new System.Drawing.Point(40, 194);
            this.btn_yiyecekaydet.Name = "btn_yiyecekaydet";
            this.btn_yiyecekaydet.Size = new System.Drawing.Size(127, 53);
            this.btn_yiyecekaydet.TabIndex = 22;
            this.btn_yiyecekaydet.Text = "KAYDET";
            this.btn_yiyecekaydet.UseVisualStyleBackColor = true;
            this.btn_yiyecekaydet.Click += new System.EventHandler(this.btn_yiyecekaydet_Click);
            // 
            // cmb_vejyiyecek
            // 
            this.cmb_vejyiyecek.FormattingEnabled = true;
            this.cmb_vejyiyecek.Items.AddRange(new object[] {
            "BROKOLİ",
            "SALATA",
            "MÜCVER",
            "MERCİMEK KÖFTESİ",
            "ZEYTİNYAĞLI BAMYA",
            "KARNIBAHAR",
            "KEREVİZ SALATASI",
            "MANTAR YEMEĞİ",
            "ACUKA",
            "PATATES SALATASI"});
            this.cmb_vejyiyecek.Location = new System.Drawing.Point(249, 93);
            this.cmb_vejyiyecek.Name = "cmb_vejyiyecek";
            this.cmb_vejyiyecek.Size = new System.Drawing.Size(121, 24);
            this.cmb_vejyiyecek.TabIndex = 21;
            // 
            // txt_yiyecekadet
            // 
            this.txt_yiyecekadet.Location = new System.Drawing.Point(579, 22);
            this.txt_yiyecekadet.Name = "txt_yiyecekadet";
            this.txt_yiyecekadet.Size = new System.Drawing.Size(100, 22);
            this.txt_yiyecekadet.TabIndex = 20;
            // 
            // txt_yiyecekfiyat
            // 
            this.txt_yiyecekfiyat.Location = new System.Drawing.Point(341, 22);
            this.txt_yiyecekfiyat.Name = "txt_yiyecekfiyat";
            this.txt_yiyecekfiyat.Size = new System.Drawing.Size(100, 22);
            this.txt_yiyecekfiyat.TabIndex = 19;
            // 
            // txt_yiyecekisim
            // 
            this.txt_yiyecekisim.Location = new System.Drawing.Point(95, 22);
            this.txt_yiyecekisim.Name = "txt_yiyecekisim";
            this.txt_yiyecekisim.Size = new System.Drawing.Size(100, 22);
            this.txt_yiyecekisim.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "VEJETERYAN YİYECEKLER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(503, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "ADET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(273, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "FİYAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "İSİM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(451, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "EV YEMEKLERİ";
            // 
            // cmb_evyemek
            // 
            this.cmb_evyemek.FormattingEnabled = true;
            this.cmb_evyemek.Items.AddRange(new object[] {
            "PORTAKAL SOSLU PEKİN ÖRDEĞİ",
            "İÇLİKÖFTE",
            "GÜVEÇ",
            "KARNIYARIK",
            "İMAMBAYILDI",
            "MANTI",
            "ANALIKIZLI",
            "KEŞKEK",
            "TAVUK SOTE",
            "SARMA",
            "SULU NOHUT YEMEĞİ",
            ""});
            this.cmb_evyemek.Location = new System.Drawing.Point(610, 93);
            this.cmb_evyemek.Name = "cmb_evyemek";
            this.cmb_evyemek.Size = new System.Drawing.Size(121, 24);
            this.cmb_evyemek.TabIndex = 29;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(367, 194);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(110, 59);
            this.btn_guncelle.TabIndex = 30;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // yiyecekform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(867, 655);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cmb_evyemek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_anamenü);
            this.Controls.Add(this.btn_yiyecekliste);
            this.Controls.Add(this.btn_yiyeceksil);
            this.Controls.Add(this.dataGridyiyecek);
            this.Controls.Add(this.btn_yiyecekaydet);
            this.Controls.Add(this.cmb_vejyiyecek);
            this.Controls.Add(this.txt_yiyecekadet);
            this.Controls.Add(this.txt_yiyecekfiyat);
            this.Controls.Add(this.txt_yiyecekisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "yiyecekform";
            this.Text = "yiyecekform";
            this.Load += new System.EventHandler(this.yiyecekform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridyiyecek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_anamenü;
        private System.Windows.Forms.Button btn_yiyecekliste;
        private System.Windows.Forms.Button btn_yiyeceksil;
        private System.Windows.Forms.DataGridView dataGridyiyecek;
        private System.Windows.Forms.Button btn_yiyecekaydet;
        private System.Windows.Forms.ComboBox cmb_vejyiyecek;
        private System.Windows.Forms.TextBox txt_yiyecekadet;
        private System.Windows.Forms.TextBox txt_yiyecekfiyat;
        private System.Windows.Forms.TextBox txt_yiyecekisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_evyemek;
        private System.Windows.Forms.Button btn_guncelle;
    }
}