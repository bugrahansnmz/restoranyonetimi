namespace restaurantyonetimiss.FORMLAR
{
    partial class urunlistesiform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunlistesiform));
            this.btn_anamenü = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbtnara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbmasanosec = new System.Windows.Forms.ComboBox();
            this.btn_masabilgilerinitemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_anamenü
            // 
            this.btn_anamenü.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anamenü.BackgroundImage")));
            this.btn_anamenü.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_anamenü.Location = new System.Drawing.Point(496, 322);
            this.btn_anamenü.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_anamenü.Name = "btn_anamenü";
            this.btn_anamenü.Size = new System.Drawing.Size(104, 50);
            this.btn_anamenü.TabIndex = 61;
            this.btn_anamenü.Text = "ANAMENÜ";
            this.btn_anamenü.UseVisualStyleBackColor = true;
            this.btn_anamenü.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 86);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 218);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtbtnara
            // 
            this.txtbtnara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtbtnara.BackgroundImage")));
            this.txtbtnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbtnara.Location = new System.Drawing.Point(295, 10);
            this.txtbtnara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbtnara.Name = "txtbtnara";
            this.txtbtnara.Size = new System.Drawing.Size(103, 41);
            this.txtbtnara.TabIndex = 64;
            this.txtbtnara.Text = "ARA";
            this.txtbtnara.UseVisualStyleBackColor = true;
            this.txtbtnara.Click += new System.EventHandler(this.txtbtnara_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "MASA NUMARASI SEÇİN";
            // 
            // cmbmasanosec
            // 
            this.cmbmasanosec.FormattingEnabled = true;
            this.cmbmasanosec.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbmasanosec.Location = new System.Drawing.Point(160, 22);
            this.cmbmasanosec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbmasanosec.Name = "cmbmasanosec";
            this.cmbmasanosec.Size = new System.Drawing.Size(92, 21);
            this.cmbmasanosec.TabIndex = 66;
            this.cmbmasanosec.SelectedIndexChanged += new System.EventHandler(this.cmbmasanosec_SelectedIndexChanged);
            // 
            // btn_masabilgilerinitemizle
            // 
            this.btn_masabilgilerinitemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_masabilgilerinitemizle.BackgroundImage")));
            this.btn_masabilgilerinitemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_masabilgilerinitemizle.Location = new System.Drawing.Point(350, 323);
            this.btn_masabilgilerinitemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_masabilgilerinitemizle.Name = "btn_masabilgilerinitemizle";
            this.btn_masabilgilerinitemizle.Size = new System.Drawing.Size(100, 50);
            this.btn_masabilgilerinitemizle.TabIndex = 67;
            this.btn_masabilgilerinitemizle.Text = "MASA BİLGİLERİNİ TEMİZLE";
            this.btn_masabilgilerinitemizle.UseVisualStyleBackColor = true;
            this.btn_masabilgilerinitemizle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // urunlistesiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(632, 405);
            this.Controls.Add(this.btn_masabilgilerinitemizle);
            this.Controls.Add(this.cmbmasanosec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbtnara);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_anamenü);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "urunlistesiform";
            this.Text = "urunlistesiform";
            this.Load += new System.EventHandler(this.urunlistesiform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_anamenü;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtbtnara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbmasanosec;
        private System.Windows.Forms.Button btn_masabilgilerinitemizle;
    }
}