
namespace WFA211206_dolg
{
    partial class FrmMain
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btUjpalyazat = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Keretosszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SzamlakSzama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SzamlaOsszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.col_Keretosszeg,
            this.col_SzamlakSzama,
            this.col_SzamlaOsszeg});
            this.dgv.Location = new System.Drawing.Point(110, 46);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(576, 290);
            this.dgv.TabIndex = 0;
            // 
            // btUjpalyazat
            // 
            this.btUjpalyazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btUjpalyazat.Location = new System.Drawing.Point(110, 365);
            this.btUjpalyazat.Name = "btUjpalyazat";
            this.btUjpalyazat.Size = new System.Drawing.Size(279, 61);
            this.btUjpalyazat.TabIndex = 1;
            this.btUjpalyazat.Text = "Új pályázat";
            this.btUjpalyazat.UseVisualStyleBackColor = true;
            this.btUjpalyazat.Click += new System.EventHandler(this.btUjpalyazat_Click);
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btQuit.Location = new System.Drawing.Point(415, 365);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(271, 61);
            this.btQuit.TabIndex = 2;
            this.btQuit.Text = "Kilépés";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // col_id
            // 
            this.col_id.FillWeight = 20.30457F;
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_Keretosszeg
            // 
            this.col_Keretosszeg.FillWeight = 127.8727F;
            this.col_Keretosszeg.HeaderText = "Keretösszeg";
            this.col_Keretosszeg.Name = "col_Keretosszeg";
            // 
            // col_SzamlakSzama
            // 
            this.col_SzamlakSzama.FillWeight = 128.0554F;
            this.col_SzamlakSzama.HeaderText = "Számlák száma";
            this.col_SzamlakSzama.Name = "col_SzamlakSzama";
            // 
            // col_SzamlaOsszeg
            // 
            this.col_SzamlaOsszeg.FillWeight = 123.7673F;
            this.col_SzamlaOsszeg.HeaderText = "Számlák összege";
            this.col_SzamlaOsszeg.Name = "col_SzamlaOsszeg";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.btUjpalyazat);
            this.Controls.Add(this.dgv);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btUjpalyazat;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Keretosszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SzamlakSzama;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SzamlaOsszeg;
    }
}

