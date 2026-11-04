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

namespace DVLD_Presentation.Users
{
    public partial class frmShowUserInfo : Form
    {
        private int _UserID = -1;

        public frmShowUserInfo(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void _LoadData()
        {

            if (_UserID == -1)
                return;

            clsUserBusiness? user = clsUserBusiness.FindByUserID(_UserID);

            if (user == null) {
                MessageBox.Show("No User with UserID = " + _UserID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            ucShowAllInfo.LoadUserInfo(user);
        }

        private void frmShowUserInfo_Load(object sender, EventArgs e) {
            _LoadData();
        }
    }
}
