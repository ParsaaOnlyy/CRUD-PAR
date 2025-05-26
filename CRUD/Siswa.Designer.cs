
namespace CRUD
{
    partial class Siswa
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNohp = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtJurusan = new System.Windows.Forms.TextBox();
            this.cbKelamin = new System.Windows.Forms.ComboBox();
            this.dgSiswa = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(640, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(32, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(32, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(32, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(454, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "No.  HP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(454, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(454, 517);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Jurusan";
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btInsert.ForeColor = System.Drawing.Color.White;
            this.btInsert.Location = new System.Drawing.Point(826, 387);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(178, 42);
            this.btInsert.TabIndex = 7;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(826, 448);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(178, 42);
            this.btUpdate.TabIndex = 8;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(826, 517);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(178, 42);
            this.btDelete.TabIndex = 9;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(826, 584);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(178, 42);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(719, 63);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(229, 22);
            this.txtCari.TabIndex = 11;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(157, 397);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(248, 22);
            this.txtNama.TabIndex = 12;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(157, 515);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(248, 22);
            this.txtAlamat.TabIndex = 14;
            // 
            // txtNohp
            // 
            this.txtNohp.Location = new System.Drawing.Point(542, 397);
            this.txtNohp.Name = "txtNohp";
            this.txtNohp.Size = new System.Drawing.Size(217, 22);
            this.txtNohp.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(542, 457);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // txtJurusan
            // 
            this.txtJurusan.Location = new System.Drawing.Point(542, 515);
            this.txtJurusan.Name = "txtJurusan";
            this.txtJurusan.Size = new System.Drawing.Size(217, 22);
            this.txtJurusan.TabIndex = 17;
            // 
            // cbKelamin
            // 
            this.cbKelamin.FormattingEnabled = true;
            this.cbKelamin.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbKelamin.Location = new System.Drawing.Point(157, 453);
            this.cbKelamin.Name = "cbKelamin";
            this.cbKelamin.Size = new System.Drawing.Size(248, 24);
            this.cbKelamin.TabIndex = 18;
            // 
            // dgSiswa
            // 
            this.dgSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiswa.Location = new System.Drawing.Point(36, 110);
            this.dgSiswa.Name = "dgSiswa";
            this.dgSiswa.RowHeadersWidth = 51;
            this.dgSiswa.RowTemplate.Height = 24;
            this.dgSiswa.Size = new System.Drawing.Size(968, 272);
            this.dgSiswa.TabIndex = 19;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Siswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 659);
            this.Controls.Add(this.dgSiswa);
            this.Controls.Add(this.cbKelamin);
            this.Controls.Add(this.txtJurusan);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNohp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Siswa";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Siswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNohp;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtJurusan;
        private System.Windows.Forms.ComboBox cbKelamin;
        private System.Windows.Forms.DataGridView dgSiswa;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}