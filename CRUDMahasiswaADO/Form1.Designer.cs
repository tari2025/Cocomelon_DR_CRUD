namespace CRUDMahasiswaADO
{
    partial class FormMahasiswa
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
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cmbJK = new System.Windows.Forms.ComboBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtKodeProdi = new System.Windows.Forms.TextBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNIM = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelJK = new System.Windows.Forms.Label();
            this.labelTanggalLahir = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelKodeProdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(150, 77);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(200, 26);
            this.txtNIM.TabIndex = 1;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(150, 117);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 26);
            this.txtNama.TabIndex = 3;
            // 
            // cmbJK
            // 
            this.cmbJK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJK.FormattingEnabled = true;
            this.cmbJK.Items.AddRange(new object[] {
            "L",
            "P"});
            this.cmbJK.Location = new System.Drawing.Point(150, 157);
            this.cmbJK.Name = "cmbJK";
            this.cmbJK.Size = new System.Drawing.Size(200, 28);
            this.cmbJK.TabIndex = 5;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(150, 237);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(200, 26);
            this.txtAlamat.TabIndex = 9;
            // 
            // txtKodeProdi
            // 
            this.txtKodeProdi.Location = new System.Drawing.Point(150, 277);
            this.txtKodeProdi.Name = "txtKodeProdi";
            this.txtKodeProdi.Size = new System.Drawing.Size(200, 26);
            this.txtKodeProdi.TabIndex = 11;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(150, 197);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(200, 26);
            this.dtpTanggalLahir.TabIndex = 7;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(400, 77);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 30);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "Membuka Koneksi";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(400, 117);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(150, 30);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Menampilkan";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(400, 157);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 30);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Menambah Data";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(400, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 30);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Mmemperbarui Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(400, 237);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Menghapus Data";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 200);
            this.dataGridView1.TabIndex = 17;
            // 
            // labelNIM
            // 
            this.labelNIM.AutoSize = true;
            this.labelNIM.Location = new System.Drawing.Point(12, 80);
            this.labelNIM.Name = "labelNIM";
            this.labelNIM.Size = new System.Drawing.Size(38, 20);
            this.labelNIM.TabIndex = 0;
            this.labelNIM.Text = "NIM";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Location = new System.Drawing.Point(12, 120);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(51, 20);
            this.labelNama.TabIndex = 2;
            this.labelNama.Text = "Nama";
            // 
            // labelJK
            // 
            this.labelJK.AutoSize = true;
            this.labelJK.Location = new System.Drawing.Point(12, 160);
            this.labelJK.Name = "labelJK";
            this.labelJK.Size = new System.Drawing.Size(106, 20);
            this.labelJK.TabIndex = 4;
            this.labelJK.Text = "Jenis Kelamin";
            // 
            // labelTanggalLahir
            // 
            this.labelTanggalLahir.AutoSize = true;
            this.labelTanggalLahir.Location = new System.Drawing.Point(12, 200);
            this.labelTanggalLahir.Name = "labelTanggalLahir";
            this.labelTanggalLahir.Size = new System.Drawing.Size(105, 20);
            this.labelTanggalLahir.TabIndex = 6;
            this.labelTanggalLahir.Text = "Tanggal Lahir";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(12, 240);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(59, 20);
            this.labelAlamat.TabIndex = 8;
            this.labelAlamat.Text = "Alamat";
            // 
            // labelKodeProdi
            // 
            this.labelKodeProdi.AutoSize = true;
            this.labelKodeProdi.Location = new System.Drawing.Point(12, 280);
            this.labelKodeProdi.Name = "labelKodeProdi";
            this.labelKodeProdi.Size = new System.Drawing.Size(86, 20);
            this.labelKodeProdi.TabIndex = 10;
            this.labelKodeProdi.Text = "Kode Prodi";
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtKodeProdi);
            this.Controls.Add(this.labelKodeProdi);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.labelTanggalLahir);
            this.Controls.Add(this.cmbJK);
            this.Controls.Add(this.labelJK);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.labelNIM);
            this.Name = "FormMahasiswa";
            this.Text = "Aplikasi CRUD Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Control untuk input data
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cmbJK;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtKodeProdi;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;

        // Label-label untuk keterangan
        private System.Windows.Forms.Label labelNIM;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelJK;
        private System.Windows.Forms.Label labelTanggalLahir;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelKodeProdi;

        // Button-button
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        // DataGridView
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}