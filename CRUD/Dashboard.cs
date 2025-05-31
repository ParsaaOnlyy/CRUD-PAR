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
    public partial class Dashboard : Form
    {
        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Panel panel2;
        private Button btLogout;
        private Button btNilai;
        private Button btMapel;
        private Button btGuru;
        private Button btSiswa;
        private Panel panel3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public String id;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btNilai = new System.Windows.Forms.Button();
            this.btMapel = new System.Windows.Forms.Button();
            this.btGuru = new System.Windows.Forms.Button();
            this.btSiswa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 128);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aplikasi Pendataan Nilai Siswa";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 128);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btLogout);
            this.panel2.Controls.Add(this.btNilai);
            this.panel2.Controls.Add(this.btMapel);
            this.panel2.Controls.Add(this.btGuru);
            this.panel2.Controls.Add(this.btSiswa);
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 529);
            this.panel2.TabIndex = 1;
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.Color.Red;
            this.btLogout.Location = new System.Drawing.Point(58, 385);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(150, 35);
            this.btLogout.TabIndex = 4;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btNilai
            // 
            this.btNilai.BackColor = System.Drawing.Color.Yellow;
            this.btNilai.Location = new System.Drawing.Point(58, 244);
            this.btNilai.Name = "btNilai";
            this.btNilai.Size = new System.Drawing.Size(150, 35);
            this.btNilai.TabIndex = 3;
            this.btNilai.Text = "Nilai";
            this.btNilai.UseVisualStyleBackColor = false;
            this.btNilai.Click += new System.EventHandler(this.btNilai_Click);
            // 
            // btMapel
            // 
            this.btMapel.BackColor = System.Drawing.Color.Green;
            this.btMapel.Location = new System.Drawing.Point(58, 179);
            this.btMapel.Name = "btMapel";
            this.btMapel.Size = new System.Drawing.Size(150, 35);
            this.btMapel.TabIndex = 2;
            this.btMapel.Text = "Mapel";
            this.btMapel.UseVisualStyleBackColor = false;
            this.btMapel.Click += new System.EventHandler(this.btMapel_Click);
            // 
            // btGuru
            // 
            this.btGuru.BackColor = System.Drawing.Color.LightBlue;
            this.btGuru.Location = new System.Drawing.Point(58, 113);
            this.btGuru.Name = "btGuru";
            this.btGuru.Size = new System.Drawing.Size(150, 35);
            this.btGuru.TabIndex = 1;
            this.btGuru.Text = "Guru";
            this.btGuru.UseVisualStyleBackColor = false;
            this.btGuru.Click += new System.EventHandler(this.btGuru_Click);
            // 
            // btSiswa
            // 
            this.btSiswa.BackColor = System.Drawing.Color.Blue;
            this.btSiswa.Location = new System.Drawing.Point(58, 51);
            this.btSiswa.Name = "btSiswa";
            this.btSiswa.Size = new System.Drawing.Size(150, 35);
            this.btSiswa.TabIndex = 0;
            this.btSiswa.Text = "Siswa";
            this.btSiswa.UseVisualStyleBackColor = false;
            this.btSiswa.Click += new System.EventHandler(this.btSiswa_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 659);
            this.panel3.TabIndex = 2;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1004, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btSiswa_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Siswa FormAktif = new Siswa();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Siswa";

        }

        private void btGuru_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Guru FormAktif = new Guru();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Guru";

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = true;
            label1.Text = "Aplikasi Pendataan Nilai";

        }

        private void btMapel_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Mapel FormAktif = new Mapel();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Mata Pelajaran";

        }

        private void btNilai_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            panel3.Visible = false;
            Nilai FormAktif = new Nilai();

            FormAktif.MdiParent = this;
            FormAktif.Show();
            label1.Text = "Kelola Data Nilai";

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();

        }
    }
}
