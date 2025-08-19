using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp2_SUppgift
{
    public partial class frmNyttLag : Form
    {
        public frmNyttLag()
        {
            InitializeComponent();
        }

        private void frmNyttLag_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lagDBDataSet.tblLag' table. You can move, or remove it, as needed.
            this.tblLagTableAdapter.Fill(this.lagDBDataSet.tblLag);

        }

        private void btnTillStart_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frmStart StartMeny = new frmStart();
            StartMeny.Show();
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            this.tblLagTableAdapter.Update(this.lagDBDataSet.tblLag);
        }
    }
}
