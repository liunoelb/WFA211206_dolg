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
    public partial class FrmMain : Form
    {
        public string ConnectionString { get; private set; }
        public FrmMain()
        {
            ConnectionString =
                "Server=(localdb)\\MSSQLLocalDB;" +
                "Database=palyazatok;";
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            dgv.Rows.Clear();

            using (var c = new SqlConnection(ConnectionString))
            {
                c.Open();
                var r = new SqlCommand(
                    "SELECT palyazat.id, sum(palyazat.tervezetA + palyazat.tervezetC), COUNT(szamla.szamlaszam), sum(szamla.ertek) " +
                    "FROM szamla, palyazat " +
                    "WHERE palyazat.id = szamla.palyazatId " +
                    "GROUP BY palyazat.Id " +
                    "ORDER BY palyazat.id;", c).ExecuteReader();

                while (r.Read())
                {
                    dgv.Rows.Add(
                        r[0],
                        r[1] + " Ft",
                        r[2] + " db",
                        r[3] + " Ft");
                }
            }
        }

        private void btQuit_Click(object sender, EventArgs e)
            => Application.Exit();

        private void btUjpalyazat_Click(object sender, EventArgs e)
            => new FrmUjPalyazat(ConnectionString).ShowDialog();
    }
}
