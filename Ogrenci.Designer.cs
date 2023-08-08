namespace e_okul_mssql
{
    partial class Ogrenci
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKulup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonKiz = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.txtBoxAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(560, 289);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(207, 43);
            this.btnGuncelle.TabIndex = 25;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(399, 338);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(208, 43);
            this.btnSil.TabIndex = 24;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(185, 338);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(208, 43);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(16, 289);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(208, 43);
            this.btnListele.TabIndex = 22;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(905, 297);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(236, 27);
            this.txtOgrAd.TabIndex = 21;
            // 
            // txtOgrID
            // 
            this.txtOgrID.Enabled = false;
            this.txtOgrID.Location = new System.Drawing.Point(905, 262);
            this.txtOgrID.Name = "txtOgrID";
            this.txtOgrID.Size = new System.Drawing.Size(236, 27);
            this.txtOgrID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(855, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(800, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Öğrenci ID :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 182);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(828, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Soyadı :";
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(905, 330);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(236, 27);
            this.txtOgrSoyad.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(830, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kulübü :";
            // 
            // cmbKulup
            // 
            this.cmbKulup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKulup.FormattingEnabled = true;
            this.cmbKulup.Location = new System.Drawing.Point(905, 365);
            this.cmbKulup.Name = "cmbKulup";
            this.cmbKulup.Size = new System.Drawing.Size(236, 27);
            this.cmbKulup.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(821, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cinsiyet :";
            // 
            // radioButtonKiz
            // 
            this.radioButtonKiz.AutoSize = true;
            this.radioButtonKiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonKiz.Location = new System.Drawing.Point(905, 398);
            this.radioButtonKiz.Name = "radioButtonKiz";
            this.radioButtonKiz.Size = new System.Drawing.Size(54, 23);
            this.radioButtonKiz.TabIndex = 27;
            this.radioButtonKiz.TabStop = true;
            this.radioButtonKiz.Text = "Kız";
            this.radioButtonKiz.UseVisualStyleBackColor = true;
            this.radioButtonKiz.CheckedChanged += new System.EventHandler(this.radioButtonKiz_CheckedChanged);
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonErkek.Location = new System.Drawing.Point(1069, 400);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(72, 23);
            this.radioButtonErkek.TabIndex = 28;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            this.radioButtonErkek.CheckedChanged += new System.EventHandler(this.radioButtonErkek_CheckedChanged);
            // 
            // txtBoxAra
            // 
            this.txtBoxAra.Location = new System.Drawing.Point(16, 398);
            this.txtBoxAra.Name = "txtBoxAra";
            this.txtBoxAra.Size = new System.Drawing.Size(591, 27);
            this.txtBoxAra.TabIndex = 29;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(614, 398);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(153, 27);
            this.btnAra.TabIndex = 30;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1155, 462);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtBoxAra);
            this.Controls.Add(this.radioButtonErkek);
            this.Controls.Add(this.radioButtonKiz);
            this.Controls.Add(this.cmbKulup);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Ogrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKulup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonKiz;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.TextBox txtBoxAra;
        private System.Windows.Forms.Button btnAra;
    }
}