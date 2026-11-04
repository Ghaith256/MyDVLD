using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.Application_Types
{
    public partial class frmUpdateApplicationType : Form
    {
        private int _ApplicationTypeID = -1;
        private clsApplicationTypeBusiness? _ApplicationType;

        public frmUpdateApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void _LoadData()
        {

            _ApplicationType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(_ApplicationTypeID);

            if (_ApplicationType == null) {
                MessageBox.Show("Application Type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblAnswerID.Text = Convert.ToString(_ApplicationType.ApplicationTypeID);
            txtTitle.Text = _ApplicationType.ApplicationTypeTitle;
            txtFees.Text = Convert.ToString(_ApplicationType.ApplicationFees);


        }

        private void frmUpdateApplicationType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e) {

            if(string.IsNullOrWhiteSpace(txtTitle.Text)) {
                MessageBox.Show("Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (!decimal.TryParse(txtFees.Text.Trim(), out decimal Fees) || Fees < 0) {
                MessageBox.Show("Please enter a valid positive number for fees.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFees.Focus();
                return;
            }

            _ApplicationType.ApplicationTypeTitle = txtTitle.Text.Trim();
            _ApplicationType.ApplicationFees = Fees;

            if(_ApplicationType.UpdateApplicationType()) {
                MessageBox.Show("Data Updated Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } 
            else
                MessageBox.Show("Error: Data was not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
