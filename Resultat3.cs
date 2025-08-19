using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp2_SUppgift
{
    public partial class frmResultat : Form
    {
        public frmResultat()
        {
            InitializeComponent();
        }

        private void Resultat3_Load(object sender, EventArgs e)
        {
            //connectionstring, anslut till lagDB
            string connStr = @"Server=.\SQLEXPRESS;Database=LagDB;Trusted_Connection=True;";

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT DISTINCT SparaSom FROM Resultat ORDER BY SparaSom DESC";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbValjResultat.Items.Add(reader.GetInt32(0));
                    }
                }
            }

            if (cmbValjResultat.Items.Count > 0)
                cmbValjResultat.SelectedIndex = 0; // välj senaste om inget annat värde
        }
        private void btnVisaCmb_MouseClick(object sender, MouseEventArgs e)
        {

        
            //om tomt...
            if (cmbValjResultat.SelectedItem == null)
            {
                MessageBox.Show("Välj en säsong först!");
                return;
            }
            //Hämta värde från comboboxen
            int seasonId = (int)cmbValjResultat.SelectedItem;
            //Koppla upp igen
            string connStr = @"Server=.\SQLEXPRESS;Database=LagDB;Trusted_Connection=True;";
            var table = new DataTable();

            using (var conn = new SqlConnection(connStr))
            {
                //Hämta och lägg ut kolumner, värden som är == SparaSom
                conn.Open();
                string query = "SELECT Name AS Lagnamn, Ponts AS Poäng, TotSpel AS Spelade, Vinst AS Vinster, Oavgjord AS Oavgjorda, " +
                               "Forlust AS Förluster, GoalsFor AS GjordaMål, GoalsAgainst AS Insläppta, " +
                               "Difference AS Målskillnad " +
                               "FROM Resultat WHERE SparaSom = @SparaSom " +
                               "ORDER BY Ponts DESC, Difference DESC, GoalsFor DESC";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SparaSom", seasonId);

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            DGVVisaResultat.DataSource = null;
            DGVVisaResultat.DataSource = table;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Close();

            frmStart start = new frmStart();
            start.Show();
        }

        private void btnAvsl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
