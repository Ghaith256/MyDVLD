using DVLD_Business;
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

namespace DVLD_Presentation.Local_Driving_License_Applications
{
    public partial class frmLocalDrivingLicenseApplicationInfo : Form
    {
        private int _LocalAppID;

        public frmLocalDrivingLicenseApplicationInfo(int LocalAppID)
        {
            InitializeComponent();
            _LocalAppID = LocalAppID;
        }

        private void frmLocalDrivingLicenseApplicationInfo_Load(object sender, EventArgs e) {

            clsLocalDrivingLicenseApplicationBusiness? LocalApp = clsLocalDrivingLicenseApplicationBusiness.GetLocalDrivingLicenseApplicationInfoByID(_LocalAppID);

            ucLocalDrivingLicenseApplicationInfo.LoadLocalApplicationData(_LocalAppID);

            if (LocalApp != null) 
                ucApplicationBasicInfo.LoadApplicationData(LocalApp.ApplicationID);
            


        }
    }
}
