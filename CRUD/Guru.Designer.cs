
namespace CRUD
{
    partial class Guru
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
            this.txtNip = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgGuru = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dgGuru)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNip
            // 
            this.txtNip.Location = new System.Drawing.Point(141, 444);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(248, 22);
            this.txtNip.TabIndex = 33;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(141, 382);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(248, 22);
            this.txtNama.TabIndex = 32;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(703, 48);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(229, 22);
            this.txtCari.TabIndex = 31;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btCancel.ForeColor = System.Drawing.Color.White;
            this.btCancel.Location = new System.Drawing.Point(588, 519);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(178, 42);
            this.btCancel.TabIndex = 30;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(395, 519);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(178, 42);
            this.btDelete.TabIndex = 29;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btUpdate.ForeColor = System.Drawing.Color.White;
            this.btUpdate.Location = new System.Drawing.Point(211, 519);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(178, 42);
            this.btUpdate.TabIndex = 28;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btInsert
            // 
            this.btInsert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btInsert.ForeColor = System.Drawing.Color.White;
            this.btInsert.Location = new System.Drawing.Point(20, 519);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(178, 42);
            this.btInsert.TabIndex = 27;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(53, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "NIP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(53, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(624, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cari";
            // 
            // dgGuru
            // 
            this.dgGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGuru.Location = new System.Drawing.Point(20, 95);
            this.dgGuru.Name = "dgGuru";
            this.dgGuru.RowHeadersWidth = 51;
            this.dgGuru.RowTemplate.Height = 24;
            this.dgGuru.Size = new System.Drawing.Size(968, 272);
            this.dgGuru.TabIndex = 38;
            this.dgGuru.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGuru_CellContentClick);
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
            // Guru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 659);
            this.Controls.Add(this.dgGuru);
            this.Controls.Add(this.txtNip);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Guru";
            this.Text = "Guru";
            this.Load += new System.EventHandler(this.Guru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGuru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNip;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgGuru;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}