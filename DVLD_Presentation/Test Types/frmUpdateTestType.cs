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

namespace DVLD_Presentation.Test_Types
{
    public partial class frmUpdateTestType : Form
    {
        private int _TestTypeID = -1;
        private clsTestTypeBusiness? _TestType;
        public frmUpdateTestType(int TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
        }

        private void _LoadData()
        {
            _TestType = clsTestTypeBusiness.GetTestTypeInfoByID(_TestTypeID);

            if (_TestType == null)
            {
                MessageBox.Show("Test Type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblAnswerID.Text = Convert.ToString(_TestType.TestTypeID);
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = Convert.ToString(_TestType.TestTypeFees);

        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) {
                MessageBox.Show("Title cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text)) {
                MessageBox.Show("Description cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return;
            }

            if (!decimal.TryParse(txtFees.Text.Trim(), out decimal Fees) || Fees < 0) {
                MessageBox.Show("Please enter a valid positive number for fees.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFees.Focus();
                return;
            }

            _TestType.TestTypeTitle = txtTitle.Text.Trim();
            _TestType.TestTypeDescription = txtDescription.Text.Trim();
            _TestType.TestTypeFees = Fees;
            
            if(_TestType.UpdateTestType()) {
                MessageBox.Show("Data Updated Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Error: Data was not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
