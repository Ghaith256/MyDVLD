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

namespace DVLD_Presentation.User_Controls
{
    public partial class ucDetainInfo : UserControl
    {

        public decimal FineFees {
            get
            {
                decimal.TryParse(txtFineFees.Text.Trim(), out decimal Fees);
                return Fees;
            }
        }

        public ucDetainInfo() {
            InitializeComponent();
        }

        public void LoadData()
        {
            lblAnswerCreatedBy.Text = clsGlobal.CurrentUser.Username;

            clsApplicationTypeBusiness? AppType = clsApplicationTypeBusiness.GetApplicationTypeInfoByID(5);
            if (AppType != null)
                lblAnswerApplicationFees.Text = AppType.ApplicationFees.ToString();

            lblAnswerDetainID.Text = "[???]";
            lblAnswerDetainDate.Text = "[???]";
        }

        public void SetDetainResult(int DetainID, DateTime DetainDate)
        {
            lblAnswerDetainID.Text = DetainID.ToString();
            lblAnswerDetainDate.Text = DetainDate.ToString("dd/MMM/yyyy");
        }




    }
}
