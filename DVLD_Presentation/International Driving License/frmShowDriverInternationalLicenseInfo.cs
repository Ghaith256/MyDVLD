using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presentation.International_Driving_License
{
    public partial class frmShowDriverInternationalLicenseInfo : Form
    {
        private int _InternationalLicenseID;

        public frmShowDriverInternationalLicenseInfo(int InternationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = InternationalLicenseID;
        }

        private void frmShowDriverInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ucDriverInternationalLicenseInfo.LoadInfo(_InternationalLicenseID);
        }
    }
}