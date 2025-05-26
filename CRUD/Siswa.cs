using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Siswa : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;

        public Siswa()
        {
            InitializeComponent();
        }

        private void Siswa_Load(object sender, EventArgs e)
        {
            Tampil();
            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String Queri = "INSERT INTO siswa (`nama`, `jenkel`, `alamat`, `nohp`, `jurusan`, `email`) VALUES ('" + txtNama.Text + "', '" + cbKelamin.Text + "', '" + txtAlamat.Text + "', '" + txtNohp.Text + "', '" + txtJurusan.Text + "', '" + txtEmail.Text + "')";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Siswa");
                Koneksi.conn.Close();

                Tampil();
                Clear(); // Memanggil method Clear
            }
            catch (Exception)
            {
                MessageBox.Show("Tambah Data Gagal");
            }
        }

        private void Clear()
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtJurusan.Text = "";
            txtNohp.Text = "";
            txtCari.Text = "";

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;
            btInsert.Enabled = true;
        }

        private void Tampil()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `data_siswa`.`siswa`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgSiswa.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();

                cmd = new MySqlCommand("DELETE FROM siswa WHERE  `id`= '" + id + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Hapus Data Siswa");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Hapus Data Gagal");
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String Queri = "UPDATE siswa SET `nama`='" + txtNama.Text + "', `jenkel`='" + cbKelamin.Text + "', `alamat`='" + txtAlamat.Text + "', `nohp`='" + txtNohp.Text + "', `jurusan`='" + txtJurusan.Text + "', `email`='" + txtEmail.Text + "' WHERE  `id`='" + id + "'";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Siswa");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `siswa` where nama LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgSiswa.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }

        }
    }
}
