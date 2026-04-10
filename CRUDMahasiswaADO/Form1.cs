using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDMahasiswaADO
{
    public partial class FormMahasiswa : Form
    {
        private readonly SqlConnection conn;
        private readonly string connectionString = "Data Source=LAPTOP-6B5BO8RM\\SA;Initial Catalog=DBAkademikADO;Integrated Security=True";

        public FormMahasiswa()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        // Test Koneksi data
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    MessageBox.Show("Koneksi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load Data
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("NIM", "NIM");
                dataGridView1.Columns.Add("Nama", "Nama");
                dataGridView1.Columns.Add("JenisKelamin", "Jenis Kelamin");
                dataGridView1.Columns.Add("TanggalLahir", "Tanggal Lahir");
                dataGridView1.Columns.Add("Alamat", "Alamat");
                dataGridView1.Columns.Add("KodeProdi", "Kode Prodi");

                string query = "SELECT * FROM Mahasiswa";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["NIM"].ToString(),
                        reader["Nama"].ToString(),
                        reader["JenisKelamin"].ToString(),
                        Convert.ToDateTime(reader["TanggalLahir"]).ToShortDateString(),
                        reader["Alamat"].ToString(),
                        reader["KodeProdi"].ToString()
                    );
                }

                reader.Close();
                MessageBox.Show($"Data berhasil dimuat! ({dataGridView1.Rows.Count} record)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Insert Data
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNIM.Text))
                {
                    MessageBox.Show("NIM harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNIM.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNama.Text))
                {
                    MessageBox.Show("Nama harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNama.Focus();
                    return;
                }

                if (cmbJK.SelectedItem == null)
                {
                    MessageBox.Show("Jenis Kelamin harus dipilih", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbJK.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtKodeProdi.Text))
                {
                    MessageBox.Show("Kode Prodi harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtKodeProdi.Focus();
                    return;
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"INSERT INTO Mahasiswa
                (NIM, Nama, JenisKelamin, TanggalLahir, Alamat, KodeProdi, TanggalDaftar)
                VALUES (@NIM, @Nama, @JK, @TanggalLahir, @Alamat, @KodeProdi, @TanggalDaftar)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@JK", cmbJK.Text);
                cmd.Parameters.AddWithValue("@TanggalLahir", dtpTanggalLahir.Value.Date);
                cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("@KodeProdi", txtKodeProdi.Text);
                cmd.Parameters.AddWithValue("@TanggalDaftar", DateTime.Now);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    BtnLoad_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Update Data 
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNIM.Text))
                {
                    MessageBox.Show("Pilih data yang akan diupdate", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"UPDATE Mahasiswa SET
                    Nama = @Nama,
                    JenisKelamin = @JK,
                    TanggalLahir = @TanggalLahir,
                    Alamat = @Alamat,
                    KodeProdi = @KodeProdi
                    WHERE NIM = @NIM";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);
                cmd.Parameters.AddWithValue("@Nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@JK", cmbJK.Text);
                cmd.Parameters.AddWithValue("@TanggalLahir", dtpTanggalLahir.Value.Date);
                cmd.Parameters.AddWithValue("@Alamat", txtAlamat.Text);
                cmd.Parameters.AddWithValue("@KodeProdi", txtKodeProdi.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Data berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    BtnLoad_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Data dengan NIM " + txtNIM.Text + " tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Delete Data
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNIM.Text))
                {
                    MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultConfirm = MessageBox.Show(
                    $"Yakin ingin menghapus data dengan NIM {txtNIM.Text}?",
                    "Konfirmasi Hapus",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultConfirm == DialogResult.Yes)
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    string query = "DELETE FROM Mahasiswa WHERE NIM = @NIM";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@NIM", txtNIM.Text);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        BtnLoad_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Clear Form
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            cmbJK.SelectedIndex = -1;
            txtAlamat.Clear();
            txtKodeProdi.Clear();
            dtpTanggalLahir.Value = DateTime.Now;
            txtNIM.Focus();
        }

        // Cell Click - mengisi form saat baris diklik
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNIM.Text = row.Cells["NIM"].Value?.ToString() ?? "";
                txtNama.Text = row.Cells["Nama"].Value?.ToString() ?? "";
                cmbJK.SelectedItem = row.Cells["JenisKelamin"].Value?.ToString();

                if (row.Cells["TanggalLahir"].Value != null)
                {
                    dtpTanggalLahir.Value = Convert.ToDateTime(row.Cells["TanggalLahir"].Value);
                }

                txtAlamat.Text = row.Cells["Alamat"].Value?.ToString() ?? "";
                txtKodeProdi.Text = row.Cells["KodeProdi"].Value?.ToString() ?? "";
            }
        }
        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Set ComboBox untuk Jenis Kelamin
            cmbJK.Items.Clear();
            cmbJK.Items.Add("L");
            cmbJK.Items.Add("P");
            cmbJK.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Event CellClick
            dataGridView1.CellClick += DataGridView1_CellClick;
        }
    }
}