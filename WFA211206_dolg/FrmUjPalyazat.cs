using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA211206_dolg
{
    public partial class FrmUjPalyazat : Form
    {
        public string ConnectionString { get; set; }
        public FrmUjPalyazat(string connectionstring)
        {
            ConnectionString = connectionstring;
            InitializeComponent();
        }

        private void FrmUjPalyazat_Load(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT BOTTOM 1 id+1 FROM palyazat " +
                    "ORDER BY id;", c).ExecuteReader();
                r.Read();
                tbId.Text = $"{r.GetInt32(0) + 1}";
                
            }
        }

        private void btUjpalyazat_Click(object sender, EventArgs e)
        {
            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                string Akat = tbAkat.Text;
                string Ckat = tbCkat.Text;
                try
                {
                    string errorMessage = "";
                    int kat;
                    if (!int.TryParse(Akat, out kat))
                        errorMessage += "A kategóriának számnak kell lennie!\n";
                    if (!int.TryParse(Ckat, out kat))
                        errorMessage += "A kategóriának számnak kell lennie!\n";
                    if (kat <= 0)
                        errorMessage += "A kategória nem lehet nulla, vagy negatív!\n";
                    if (!string.IsNullOrEmpty(errorMessage))
                        throw new Exception(errorMessage);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
    }
}
