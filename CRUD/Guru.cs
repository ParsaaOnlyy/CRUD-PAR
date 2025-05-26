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

    public partial class Guru : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;
        public Guru()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            txtNama.Text = "";
            txtNip.Text = "";

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;
            btInsert.Enabled = true;
        }


        private void Guru_Load(object sender, EventArgs e)
        {

        }
        private void Tampil()
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `guru`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dgGuru.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String Queri = "INSERT INTO guru (`nama`, `nip`) VALUES ('" + txtNama.Text + "', '" + txtNip.Text + "')";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Guru");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Tambah Data Gagal");
            }

        }

        private void dgGuru_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btDelete.Enabled = true;
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;

            int baris = dgGuru.CurrentCell.RowIndex;
            id = dgGuru.Rows[baris].Cells[0].Value.ToString();
            txtNama.Text = dgGuru.Rows[baris].Cells[1].Value.ToString();
            txtNip.Text = dgGuru.Rows[baris].Cells[2].Value.ToString();

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String Queri = "UPDATE guru SET `nama`='" + txtNama.Text + "', `nip`='" + txtNip.Text + "' WHERE  `id`='" + id + "'";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data Guru");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Update Gagal");
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                cmd = new MySqlCommand("DELETE FROM guru WHERE  `id`= '" + id + "'", Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Hapus Data Guru");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Hapus Data Gagal");
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `guru` where nama LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgGuru.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }

        }
    }
}
