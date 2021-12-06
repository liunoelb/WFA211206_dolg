
namespace WFA211206_dolg
{
    partial class FrmUjPalyazat
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
            this.tbAkat = new System.Windows.Forms.TextBox();
            this.tbCkat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btUjpalyazat = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "\"A\" kategória értékkeret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "\"C\" kategória értékkeret:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "HUF";
            // 
            // tbAkat
            // 
            this.tbAkat.Location = new System.Drawing.Point(15, 103);
            this.tbAkat.Name = "tbAkat";
            this.tbAkat.Size = new System.Drawing.Size(163, 20);
            this.tbAkat.TabIndex = 4;
            // 
            // tbCkat
            // 
            this.tbCkat.Location = new System.Drawing.Point(16, 172);
            this.tbCkat.Name = "tbCkat";
            this.tbCkat.Size = new System.Drawing.Size(163, 20);
            this.tbCkat.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "HUF";
            // 
            // btUjpalyazat
            // 
            this.btUjpalyazat.Location = new System.Drawing.Point(12, 213);
            this.btUjpalyazat.Name = "btUjpalyazat";
            this.btUjpalyazat.Size = new System.Drawing.Size(229, 39);
            this.btUjpalyazat.TabIndex = 7;
            this.btUjpalyazat.Text = "Új pályázat hirdetése";
            this.btUjpalyazat.UseVisualStyleBackColor = true;
            this.btUjpalyazat.Click += new System.EventHandler(this.btUjpalyazat_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(54, 23);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(27, 20);
            this.tbId.TabIndex = 8;
            // 
            // FrmUjPalyazat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 279);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btUjpalyazat);
            this.Controls.Add(this.tbCkat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAkat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUjPalyazat";
            this.Text = "FrmUjPalyazat";
            this.Load += new System.EventHandler(this.FrmUjPalyazat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAkat;
        private System.Windows.Forms.TextBox tbCkat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btUjpalyazat;
        private System.Windows.Forms.TextBox tbId;
    }
}