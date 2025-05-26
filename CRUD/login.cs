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
    public partial class login : Form
    {
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Cek apakah username dan password sesuai dengan admin default
                if (txtUser.Text == "Admin" && txtPassword.Text == "Admin")
                {
                    MessageBox.Show("Login berhasil sebagai Admin!");
                    Dashboard dashboard = new Dashboard(); // Ganti dengan form tujuan
                    dashboard.Show();
                    this.Hide(); // Menyembunyikan form login
                    return;
                }

                // Jika bukan admin, cek ke database
                Koneksi.conn.Open();
                String query = "SELECT * FROM `users` WHERE `email` = @email AND `password` = @password";
                cmd = new MySqlCommand(query, Koneksi.conn);
                cmd.Parameters.AddWithValue("@email", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Login berhasil!");
                    Dashboard dashboard = new Dashboard(); // Ganti dengan form tujuan
                    dashboard.Show();
                    this.Hide(); // Menyembunyikan form login
                }
                else
                {
                    MessageBox.Show("Ups! Username atau Password salah.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ups! Gagal Login");
            }
            finally
            {
                Koneksi.conn.Close();
            }
        }
        }
    }