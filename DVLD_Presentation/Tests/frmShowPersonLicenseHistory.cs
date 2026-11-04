using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Tests
{
    public partial class frmShowPersonLicenseHistory : Form
    {
        private int _PersonID = -1;

        public frmShowPersonLicenseHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowPersonLicenseHistory_Load(object sender, EventArgs e) {

            if (_PersonID == -1) {
                MessageBox.Show("Error: Invalid Person ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ucShowInfo.LoadPersonInfo(_PersonID);

            ucShowDriverLicensesHistory.LoadInfoByPersonID(_PersonID);



        }
    }
}
