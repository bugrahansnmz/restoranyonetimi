namespace restaurantyonetimiss
{
    partial class garsonform
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_masabilgileri = new System.Windows.Forms.Button();
            this.btn_masahesabi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // btn_masabilgileri
            // 
            this.btn_masabilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_masabilgileri.Location = new System.Drawing.Point(182, 243);
            this.btn_masabilgileri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_masabilgileri.Name = "btn_masabilgileri";
            this.btn_masabilgileri.Size = new System.Drawing.Size(147, 74);
            this.btn_masabilgileri.TabIndex = 12;
            this.btn_masabilgileri.Text = "MASA BİLGİLERİ";
            this.btn_masabilgileri.UseVisualStyleBackColor = true;
            this.btn_masabilgileri.Click += new System.EventHandler(this.btn_masabilgileri_Click);
            // 
            // btn_masahesabi
            // 
            this.btn_masahesabi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_masahesabi.Location = new System.Drawing.Point(182, 115);
            this.btn_masahesabi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_masahesabi.Name = "btn_masahesabi";
            this.btn_masahesabi.Size = new System.Drawing.Size(147, 74);
            this.btn_masahesabi.TabIndex = 11;
            this.btn_masahesabi.Text = "MASA HESABI";
            this.btn_masahesabi.UseVisualStyleBackColor = true;
            this.btn_masahesabi.Click += new System.EventHandler(this.btn_masahesabi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(104, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "SATIŞ VE MÜŞTERİ İŞLEMLERİ";
            // 
            // garsonform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(578, 421);
            this.Controls.Add(this.btn_masabilgileri);
            this.Controls.Add(this.btn_masahesabi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "garsonform";
            this.Text = "garsonform";
            this.Load += new System.EventHandler(this.garsonform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_masabilgileri;
        private System.Windows.Forms.Button btn_masahesabi;
        private System.Windows.Forms.Label label2;
    }
}