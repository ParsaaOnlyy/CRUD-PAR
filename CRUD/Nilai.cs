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
    public partial class Nilai : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;

        private void Tampil()
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai`", Koneksi.conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgNilai.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }

        public Nilai()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            cbMapel.Text = "";
            cbSiswa.Text = "";
            txtNilai.Text = "";
            txtCari.Text = "";

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;
            btInsert.Enabled = true;
        }

        private void Nilai_Load(object sender, EventArgs e)
        {
            Tampil();

            MySqlDataAdapter adp = new MySqlDataAdapter("select * from mapel", Koneksi.conn);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            cbMapel.DataSource = dt;
            cbMapel.DisplayMember = "nama_mapel";
            cbMapel.ValueMember = "id";

            MySqlDataAdapter adp2 = new MySqlDataAdapter("select * from siswa", Koneksi.conn);
            DataTable dt2 = new DataTable();
            adp2.Fill(dt2);

            cbSiswa.DataSource = dt2;
            cbSiswa.DisplayMember = "nama";
            cbSiswa.ValueMember = "id";

            btDelete.Enabled = false;
            btUpdate.Enabled = false;
            btCancel.Enabled = false;

        }
    private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();
                String Queri = "INSERT INTO nilai (`siswa_id`, `mapel_id`, `nilai`) VALUES ('" + cbSiswa.SelectedValue + "','" + cbMapel.SelectedValue + "', '" + txtNilai.Text + "')";
                cmd = new MySqlCommand(Queri, Koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Nilai Siswa");
                Koneksi.conn.Close();

                Tampil();
                Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Tambah Data Gagal");
            }            
        }

        private void dgNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btDelete.Enabled = true;
            btUpdate.Enabled = true;
            btCancel.Enabled = true;
            btInsert.Enabled = false;

            int baris = dgNilai.CurrentCell.RowIndex;
            id = dgNilai.Rows[baris].Cells[0].Value.ToString();
            cbSiswa.Text = dgNilai.Rows[baris].Cells[1].Value.ToString();
            cbMapel.Text = dgNilai.Rows[baris].Cells[3].Value.ToString();
            txtNilai.Text = dgNilai.Rows[baris].Cells[5].Value.ToString();


        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();

                String Queri = "UPDATE `nilai` SET `siswa_id`='" + cbSiswa.SelectedValue + "', `mapel_id`='" + cbMapel.SelectedValue + "', `nilai`='" + txtNilai.Text + "' WHERE  `id`='" + id + "'";
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

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi.conn.Open();


                cmd = new MySqlCommand("DELETE FROM nilai WHERE  `id`= '" + id + "'", Koneksi.conn);
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

        private void btCancel_Click(object sender, EventArgs e)
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai` where nama LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgNilai.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {

                Koneksi.conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `vnilai` where nama LIKE '%" + txtCari.Text + "%'", Koneksi.conn);
                DataSet ds = new DataSet();

                da.Fill(ds);
                dgNilai.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }

        }
    }
    }
