using DVLD_Presentation.User_Controls;
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
    public partial class frmShowDriverLicenseInfo : Form
    {

        private int _LicenseID = -1;

        public frmShowDriverLicenseInfo(int LicenseID) {
            InitializeComponent();
            _LicenseID = LicenseID;
        }

        private void frmShowDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            ucDriverLicenseInfo.LoadInfo(_LicenseID);
        }



    }
}
