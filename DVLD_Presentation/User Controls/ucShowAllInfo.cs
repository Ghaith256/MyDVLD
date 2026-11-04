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

namespace DVLD_Presentation
{
    public partial class ucShowAllInfo : UserControl
    {
        public ucShowAllInfo()
        {
            InitializeComponent();
        }

        private void pnlTextBorder_Paint(object sender, PaintEventArgs e)
        {
            Panel pnl = (Panel)sender;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(ColorTranslator.FromHtml("#f97316"), 2))
            {
                Rectangle rect = new Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1);
                using (System.Drawing.Drawing2D.GraphicsPath path = clsFormatHelper.GetRoundedRectanglePath(rect, 15))
                {

                    using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#1f2937")))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private void ucShowInfo_Load(object sender, EventArgs e)
        {
            clsFormatHelper.MakePictureBoxCircular(pbProfilePicture);
        }

        public void LoadUserInfo(clsUserBusiness user) {

            lblAnswerUserID.Text = user.UserID.ToString();
            lblAnswerPersonID.Text = user.PersonID.ToString();
            lblAnswerUsername.Text = user.Username;
            lblAnswerIsActive.Text = user.IsActive ? "Yes" : "No";

            clsPersonBusiness? person = clsPersonBusiness.Find(user.PersonID);

            if (person != null) {
                lblName.Text = person.FirstName + " " + person.SecondName + " " + person.ThirdName + " " + person.LastName;
                lblAnswerNationalNo.Text = person.NationalNo;
                lblAnswerDateOfBirth.Text = person.DateOfBirth.ToShortDateString();
                lblAnswerGender.Text = (person.Gendor == 0) ? "Male" : "Female";
                lblAnswerCountry.Text = clsPersonBusiness.GetCountryNameByID(person.NationalityCountryID);

                lblAnswerPhone.Text = person.Phone;
                lblAnswerEmail.Text = string.IsNullOrWhiteSpace(person.Email) ? "N/A" : person.Email;
                lblAnswerAddress.Text = person.Address;

                if (!string.IsNullOrWhiteSpace(person.ImagePath) && System.IO.File.Exists(person.ImagePath))
                    pbProfilePicture.Load(person.ImagePath);
                else {
                    if (person.Gendor == 0)
                        pbProfilePicture.Image = Properties.Resources.male; 
                    else
                        pbProfilePicture.Image = Properties.Resources.female; 
                }


            }
        }


    }
}
