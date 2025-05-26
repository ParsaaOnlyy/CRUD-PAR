
namespace CRUD
{
    partial class Nilai
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.cbMapel = new System.Windows.Forms.ComboBox();
            this.dgNilai = new System.Windows.Forms.DataGridView();
            this.txtNilai = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSiswa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgNilai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(23, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 84);
            this.panel3.TabIndex = 55;
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
            // cbMapel
            // 
            this.cbMapel.FormattingEnabled = true;
            this.cbMapel.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbMapel.Location = new System.Drawing.Point(143, 478);
            this.cbMapel.Name = "cbMapel";
            this.cbMapel.Size = new System.Drawing.Size(248, 24);
            this.cbMapel.TabIndex = 53;
            // 
            // dgNilai
            // 
            this.dgNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNilai.Location = new System.Drawing.Point(20, 129);
            this.dgNilai.Name = "dgNilai";
            this.dgNilai.RowHeadersWidth = 51;
            this.dgNilai.RowTemplate.Height = 24;
            this.dgNilai.Size = new System.Drawing.Size(968, 272);
            this.dgNilai.TabIndex = 52;
            this.dgNilai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNilai_CellContentClick);
            // 
            // txtNilai
            // 
            this.txtNilai.Location = new System.Drawing.Point(143, 534);
            this.txtNilai.Name = "txtNilai";
            this.txtNilai.Size = new System.Drawing.Size(248, 22);
            this.txtNilai.TabIndex = 51;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(703, 82);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(229, 22);
            this.txtCari.TabIndex = 50;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(579, 572);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(178, 42);
            this.btCancel.TabIndex = 49;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(388, 572);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(178, 42);
            this.btDelete.TabIndex = 48;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(204, 572);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(178, 42);
            this.btUpdate.TabIndex = 47;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btInsert.ForeColor = System.Drawing.Color.White;
            this.btInsert.Location = new System.Drawing.Point(20, 572);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(178, 42);
            this.btInsert.TabIndex = 46;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(16, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(16, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mapel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(16, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Pilih Siswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(624, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cari";
            // 
            // cbSiswa
            // 
            this.cbSiswa.FormattingEnabled = true;
            this.cbSiswa.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbSiswa.Location = new System.Drawing.Point(143, 416);
            this.cbSiswa.Name = "cbSiswa";
            this.cbSiswa.Size = new System.Drawing.Size(248, 24);
            this.cbSiswa.TabIndex = 56;
            // 
            // Nilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 659);
            this.Controls.Add(this.cbSiswa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cbMapel);
            this.Controls.Add(this.dgNilai);
            this.Controls.Add(this.txtNilai);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nilai";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Nilai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNilai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.ComboBox cbMapel;
        private System.Windows.Forms.DataGridView dgNilai;
        private System.Windows.Forms.TextBox txtNilai;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSiswa;
    }
}