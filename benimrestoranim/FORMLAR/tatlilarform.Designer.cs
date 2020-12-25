namespace restaurantyonetimiss.FORMLAR
{
    partial class tatlilarform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tatlilarform));
            this.cmb_serbetlitatli = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_anamenü = new System.Windows.Forms.Button();
            this.btn_tatlilistele = new System.Windows.Forms.Button();
            this.btn_tatlisil = new System.Windows.Forms.Button();
            this.dataGridtatli = new System.Windows.Forms.DataGridView();
            this.btn_tatlikaydet = new System.Windows.Forms.Button();
            this.cmb_sutlutatli = new System.Windows.Forms.ComboBox();
            this.txt_tatliadet = new System.Windows.Forms.TextBox();
            this.txt_tatlifiyat = new System.Windows.Forms.TextBox();
            this.txt_tatliisim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtatli)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_serbetlitatli
            // 
            this.cmb_serbetlitatli.FormattingEnabled = true;
            this.cmb_serbetlitatli.Items.AddRange(new object[] {
            "KÜNEFE",
            "KADAYIF",
            "REVANİ",
            "KALBURABASTI",
            "LOKMA ",
            "BAKLAVA",
            "BÜLBÜL YUVASI",
            "BOŞNAK TATLISI"});
            this.cmb_serbetlitatli.Location = new System.Drawing.Point(598, 78);
            this.cmb_serbetlitatli.Name = "cmb_serbetlitatli";
            this.cmb_serbetlitatli.Size = new System.Drawing.Size(121, 24);
            this.cmb_serbetlitatli.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(428, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "ŞERBETLİ TATLILAR";
            // 
            // btn_anamenü
            // 
            this.btn_anamenü.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anamenü.BackgroundImage")));
            this.btn_anamenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenü.Location = new System.Drawing.Point(668, 184);
            this.btn_anamenü.Name = "btn_anamenü";
            this.btn_anamenü.Size = new System.Drawing.Size(124, 57);
            this.btn_anamenü.TabIndex = 42;
            this.btn_anamenü.Text = "ANAMENÜ";
            this.btn_anamenü.UseVisualStyleBackColor = true;
            this.btn_anamenü.Click += new System.EventHandler(this.btn_anamenü_Click);
            // 
            // btn_tatlilistele
            // 
            this.btn_tatlilistele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tatlilistele.BackgroundImage")));
            this.btn_tatlilistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tatlilistele.Location = new System.Drawing.Point(477, 184);
            this.btn_tatlilistele.Name = "btn_tatlilistele";
            this.btn_tatlilistele.Size = new System.Drawing.Size(122, 57);
            this.btn_tatlilistele.TabIndex = 41;
            this.btn_tatlilistele.Text = "LİSTELE";
            this.btn_tatlilistele.UseVisualStyleBackColor = true;
            this.btn_tatlilistele.Click += new System.EventHandler(this.btn_tatlilistele_Click);
            // 
            // btn_tatlisil
            // 
            this.btn_tatlisil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tatlisil.BackgroundImage")));
            this.btn_tatlisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tatlisil.Location = new System.Drawing.Point(171, 182);
            this.btn_tatlisil.Name = "btn_tatlisil";
            this.btn_tatlisil.Size = new System.Drawing.Size(128, 57);
            this.btn_tatlisil.TabIndex = 40;
            this.btn_tatlisil.Text = "SİL";
            this.btn_tatlisil.UseVisualStyleBackColor = true;
            this.btn_tatlisil.Click += new System.EventHandler(this.btn_tatlisil_Click);
            // 
            // dataGridtatli
            // 
            this.dataGridtatli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridtatli.Location = new System.Drawing.Point(38, 279);
            this.dataGridtatli.Name = "dataGridtatli";
            this.dataGridtatli.RowTemplate.Height = 24;
            this.dataGridtatli.Size = new System.Drawing.Size(794, 340);
            this.dataGridtatli.TabIndex = 39;
            this.dataGridtatli.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridtatli_CellContentClick);
            // 
            // btn_tatlikaydet
            // 
            this.btn_tatlikaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tatlikaydet.BackgroundImage")));
            this.btn_tatlikaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tatlikaydet.Location = new System.Drawing.Point(22, 182);
            this.btn_tatlikaydet.Name = "btn_tatlikaydet";
            this.btn_tatlikaydet.Size = new System.Drawing.Size(123, 55);
            this.btn_tatlikaydet.TabIndex = 38;
            this.btn_tatlikaydet.Text = "KAYDET";
            this.btn_tatlikaydet.UseVisualStyleBackColor = true;
            this.btn_tatlikaydet.Click += new System.EventHandler(this.btn_tatlikaydet_Click);
            // 
            // cmb_sutlutatli
            // 
            this.cmb_sutlutatli.FormattingEnabled = true;
            this.cmb_sutlutatli.Items.AddRange(new object[] {
            "SÜTLAÇ",
            "KAZANDİBİ",
            "İRMİK TATLISI",
            "TAVUKGÖĞSÜ",
            "KEŞKÜL",
            "SÜT HELVASI",
            "SUPANGLE",
            "GÜLLAÇ"});
            this.cmb_sutlutatli.Location = new System.Drawing.Point(227, 78);
            this.cmb_sutlutatli.Name = "cmb_sutlutatli";
            this.cmb_sutlutatli.Size = new System.Drawing.Size(121, 24);
            this.cmb_sutlutatli.TabIndex = 37;
            // 
            // txt_tatliadet
            // 
            this.txt_tatliadet.Location = new System.Drawing.Point(619, 13);
            this.txt_tatliadet.Name = "txt_tatliadet";
            this.txt_tatliadet.Size = new System.Drawing.Size(100, 22);
            this.txt_tatliadet.TabIndex = 36;
            // 
            // txt_tatlifiyat
            // 
            this.txt_tatlifiyat.Location = new System.Drawing.Point(368, 13);
            this.txt_tatlifiyat.Name = "txt_tatlifiyat";
            this.txt_tatlifiyat.Size = new System.Drawing.Size(100, 22);
            this.txt_tatlifiyat.TabIndex = 35;
            // 
            // txt_tatliisim
            // 
            this.txt_tatliisim.Location = new System.Drawing.Point(120, 13);
            this.txt_tatliisim.Name = "txt_tatliisim";
            this.txt_tatliisim.Size = new System.Drawing.Size(100, 22);
            this.txt_tatliisim.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "SÜTLÜ TATLILAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(552, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 32;
            this.label3.Text = "ADET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(301, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "FİYAT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "İSİM";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guncelle.BackgroundImage")));
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guncelle.Location = new System.Drawing.Point(323, 184);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(110, 59);
            this.btn_guncelle.TabIndex = 46;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // tatlilarform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(867, 658);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.cmb_serbetlitatli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_anamenü);
            this.Controls.Add(this.btn_tatlilistele);
            this.Controls.Add(this.btn_tatlisil);
            this.Controls.Add(this.dataGridtatli);
            this.Controls.Add(this.btn_tatlikaydet);
            this.Controls.Add(this.cmb_sutlutatli);
            this.Controls.Add(this.txt_tatliadet);
            this.Controls.Add(this.txt_tatlifiyat);
            this.Controls.Add(this.txt_tatliisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "tatlilarform";
            this.Text = "tatlilarform";
            this.Load += new System.EventHandler(this.tatlilarform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridtatli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_serbetlitatli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_anamenü;
        private System.Windows.Forms.Button btn_tatlilistele;
        private System.Windows.Forms.Button btn_tatlisil;
        private System.Windows.Forms.DataGridView dataGridtatli;
        private System.Windows.Forms.Button btn_tatlikaydet;
        private System.Windows.Forms.ComboBox cmb_sutlutatli;
        private System.Windows.Forms.TextBox txt_tatliadet;
        private System.Windows.Forms.TextBox txt_tatlifiyat;
        private System.Windows.Forms.TextBox txt_tatliisim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_guncelle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}