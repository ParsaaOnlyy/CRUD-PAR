
namespace CRUD
{
    partial class Mapel
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
            this.dgMapel = new System.Windows.Forms.DataGridView();
            this.txtMapel2 = new System.Windows.Forms.TextBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbnamaguru = new System.Windows.Forms.ComboBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.txtMapel1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMapel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMapel
            // 
            this.dgMapel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMapel.Location = new System.Drawing.Point(20, 95);
            this.dgMapel.Name = "dgMapel";
            this.dgMapel.RowHeadersWidth = 51;
            this.dgMapel.RowTemplate.Height = 24;
            this.dgMapel.Size = new System.Drawing.Size(968, 272);
            this.dgMapel.TabIndex = 38;
            this.dgMapel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMapel_CellContentClick);
            // 
            // txtMapel2
            // 
            this.txtMapel2.Location = new System.Drawing.Point(143, 444);
            this.txtMapel2.Name = "txtMapel2";
            this.txtMapel2.Size = new System.Drawing.Size(248, 22);
            this.txtMapel2.TabIndex = 32;
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
            this.btCancel.Location = new System.Drawing.Point(579, 538);
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
            this.btDelete.Location = new System.Drawing.Point(388, 538);
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
            this.btUpdate.Location = new System.Drawing.Point(204, 538);
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
            this.btInsert.Location = new System.Drawing.Point(20, 538);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(178, 42);
            this.btInsert.TabIndex = 27;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = false;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(16, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Nama Guru";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(16, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kode Mapel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(16, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nama Mapel";
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
            // cbnamaguru
            // 
            this.cbnamaguru.FormattingEnabled = true;
            this.cbnamaguru.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbnamaguru.Location = new System.Drawing.Point(143, 498);
            this.cbnamaguru.Name = "cbnamaguru";
            this.cbnamaguru.Size = new System.Drawing.Size(248, 24);
            this.cbnamaguru.TabIndex = 39;
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
            // txtMapel1
            // 
            this.txtMapel1.Location = new System.Drawing.Point(143, 382);
            this.txtMapel1.Name = "txtMapel1";
            this.txtMapel1.Size = new System.Drawing.Size(248, 22);
            this.txtMapel1.TabIndex = 40;
            // 
            // Mapel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 659);
            this.Controls.Add(this.txtMapel1);
            this.Controls.Add(this.cbnamaguru);
            this.Controls.Add(this.dgMapel);
            this.Controls.Add(this.txtMapel2);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mapel";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Mapel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMapel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMapel;
        private System.Windows.Forms.TextBox txtMapel2;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbnamaguru;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox txtMapel1;
    }
}