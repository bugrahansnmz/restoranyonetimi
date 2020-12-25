namespace restaurantyonetimiss
{
    partial class masabilgileriform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masabilgileriform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kisisayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_masakonum = new System.Windows.Forms.ComboBox();
            this.btn_msac = new System.Windows.Forms.Button();
            this.btn_masakapat = new System.Windows.Forms.Button();
            this.dataGridView_masaac_kapat = new System.Windows.Forms.DataGridView();
            this.btn_anamenü = new System.Windows.Forms.Button();
            this.btn_listelemasa = new System.Windows.Forms.Button();
            this.cmb_masano = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_toplamfiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masaac_kapat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "MASA NO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(279, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "KİŞİ SAYISI";
            // 
            // txt_kisisayisi
            // 
            this.txt_kisisayisi.Location = new System.Drawing.Point(376, 36);
            this.txt_kisisayisi.Name = "txt_kisisayisi";
            this.txt_kisisayisi.Size = new System.Drawing.Size(100, 22);
            this.txt_kisisayisi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(528, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "MASA KONUMU";
            // 
            // cmb_masakonum
            // 
            this.cmb_masakonum.FormattingEnabled = true;
            this.cmb_masakonum.Items.AddRange(new object[] {
            "BAHÇE - ANTRE",
            "İÇERİ"});
            this.cmb_masakonum.Location = new System.Drawing.Point(662, 34);
            this.cmb_masakonum.Name = "cmb_masakonum";
            this.cmb_masakonum.Size = new System.Drawing.Size(121, 24);
            this.cmb_masakonum.TabIndex = 9;
            // 
            // btn_msac
            // 
            this.btn_msac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_msac.BackgroundImage")));
            this.btn_msac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_msac.Location = new System.Drawing.Point(29, 192);
            this.btn_msac.Name = "btn_msac";
            this.btn_msac.Size = new System.Drawing.Size(171, 58);
            this.btn_msac.TabIndex = 10;
            this.btn_msac.Text = "MASAYI AÇ";
            this.btn_msac.UseVisualStyleBackColor = true;
            this.btn_msac.Click += new System.EventHandler(this.btn_msac_Click);
            // 
            // btn_masakapat
            // 
            this.btn_masakapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_masakapat.BackgroundImage")));
            this.btn_masakapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_masakapat.Location = new System.Drawing.Point(238, 192);
            this.btn_masakapat.Name = "btn_masakapat";
            this.btn_masakapat.Size = new System.Drawing.Size(157, 58);
            this.btn_masakapat.TabIndex = 12;
            this.btn_masakapat.Text = "MASA KAPAT";
            this.btn_masakapat.UseVisualStyleBackColor = true;
            this.btn_masakapat.Click += new System.EventHandler(this.btn_masakapat_Click);
            // 
            // dataGridView_masaac_kapat
            // 
            this.dataGridView_masaac_kapat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_masaac_kapat.Location = new System.Drawing.Point(12, 298);
            this.dataGridView_masaac_kapat.Name = "dataGridView_masaac_kapat";
            this.dataGridView_masaac_kapat.RowTemplate.Height = 24;
            this.dataGridView_masaac_kapat.Size = new System.Drawing.Size(820, 362);
            this.dataGridView_masaac_kapat.TabIndex = 23;
            this.dataGridView_masaac_kapat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_masaac_kapat_CellContentClick);
            // 
            // btn_anamenü
            // 
            this.btn_anamenü.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anamenü.BackgroundImage")));
            this.btn_anamenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenü.Location = new System.Drawing.Point(662, 192);
            this.btn_anamenü.Name = "btn_anamenü";
            this.btn_anamenü.Size = new System.Drawing.Size(142, 58);
            this.btn_anamenü.TabIndex = 24;
            this.btn_anamenü.Text = "ANAMENÜ";
            this.btn_anamenü.UseVisualStyleBackColor = true;
            this.btn_anamenü.Click += new System.EventHandler(this.btn_anamenü_Click);
            // 
            // btn_listelemasa
            // 
            this.btn_listelemasa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_listelemasa.BackgroundImage")));
            this.btn_listelemasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listelemasa.Location = new System.Drawing.Point(452, 192);
            this.btn_listelemasa.Name = "btn_listelemasa";
            this.btn_listelemasa.Size = new System.Drawing.Size(137, 58);
            this.btn_listelemasa.TabIndex = 25;
            this.btn_listelemasa.Text = "LİSTELE";
            this.btn_listelemasa.UseVisualStyleBackColor = true;
            this.btn_listelemasa.Click += new System.EventHandler(this.btn_listelemasa_Click);
            // 
            // cmb_masano
            // 
            this.cmb_masano.FormattingEnabled = true;
            this.cmb_masano.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_masano.Location = new System.Drawing.Point(112, 34);
            this.cmb_masano.Name = "cmb_masano";
            this.cmb_masano.Size = new System.Drawing.Size(121, 24);
            this.cmb_masano.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "TOPLAM TUTAR";
            // 
            // txt_toplamfiyat
            // 
            this.txt_toplamfiyat.Location = new System.Drawing.Point(169, 116);
            this.txt_toplamfiyat.Name = "txt_toplamfiyat";
            this.txt_toplamfiyat.Size = new System.Drawing.Size(100, 22);
            this.txt_toplamfiyat.TabIndex = 31;
            // 
            // masabilgileriform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(867, 708);
            this.Controls.Add(this.txt_toplamfiyat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_masano);
            this.Controls.Add(this.btn_listelemasa);
            this.Controls.Add(this.btn_anamenü);
            this.Controls.Add(this.dataGridView_masaac_kapat);
            this.Controls.Add(this.btn_masakapat);
            this.Controls.Add(this.btn_msac);
            this.Controls.Add(this.cmb_masakonum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_kisisayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "masabilgileriform";
            this.Text = "masabilgileriform";
            this.Load += new System.EventHandler(this.masaacform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_masaac_kapat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kisisayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_masakonum;
        private System.Windows.Forms.Button btn_msac;
        private System.Windows.Forms.Button btn_masakapat;
        private System.Windows.Forms.DataGridView dataGridView_masaac_kapat;
        private System.Windows.Forms.Button btn_anamenü;
        private System.Windows.Forms.Button btn_listelemasa;
        private System.Windows.Forms.ComboBox cmb_masano;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_toplamfiyat;
    }
}