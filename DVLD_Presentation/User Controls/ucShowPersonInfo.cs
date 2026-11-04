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
    public partial class ucShowInfo : UserControl
    {

        public int PersonID { get; private set; } = -1;

        public ucShowInfo()
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

        public void LoadPersonInfo(string NationalNo) {
            clsPersonBusiness? PersonInfo = clsPersonBusiness.Find(NationalNo); ;

            if (PersonInfo != null)
            {
                this.PersonID = PersonInfo.PersonID;

                lblAnswerGender.Text = (PersonInfo.Gendor == 0 ? "Male" : "Female");
                lblAnswerEmail.Text = PersonInfo.Email;
                lblAnswerNationalNo.Text = PersonInfo.NationalNo;
                lblAnswerPhone.Text = PersonInfo.Phone;
                lblAnswerCountry.Text = clsPersonBusiness.GetCountryNameByID(PersonInfo.NationalityCountryID); ;
                lblAnswerDateOfBirth.Text = PersonInfo.DateOfBirth.ToShortDateString();
                lblName.Text = PersonInfo.FirstName + " " + PersonInfo.LastName;
                lblAnswerAddress.Text = PersonInfo.Address;

                if (!string.IsNullOrEmpty(PersonInfo.ImagePath) && System.IO.File.Exists(PersonInfo.ImagePath))
                    pbProfilePicture.ImageLocation = PersonInfo.ImagePath;
                else
                {
                    if (PersonInfo.Gendor == 0)
                        pbProfilePicture.Image = Properties.Resources.male;
                    else
                        pbProfilePicture.Image = Properties.Resources.female;
                }
            }
            else
                this.PersonID = -1;
        }


        public void LoadPersonInfo(int PersonID) {
            clsPersonBusiness? PersonInfo = clsPersonBusiness.Find(PersonID);

            if (PersonInfo != null)
            {
                this.PersonID = PersonInfo.PersonID;

                lblAnswerGender.Text = (PersonInfo.Gendor == 0 ? "Male" : "Female");
                lblAnswerEmail.Text = PersonInfo.Email;
                lblAnswerNationalNo.Text = PersonInfo.NationalNo;
                lblAnswerPhone.Text = PersonInfo.Phone;
                lblAnswerCountry.Text = clsPersonBusiness.GetCountryNameByID(PersonInfo.NationalityCountryID); ;
                lblAnswerDateOfBirth.Text = PersonInfo.DateOfBirth.ToShortDateString();
                lblName.Text = PersonInfo.FirstName + " " + PersonInfo.LastName;
                lblAnswerAddress.Text = PersonInfo.Address;

                if (!string.IsNullOrEmpty(PersonInfo.ImagePath) && System.IO.File.Exists(PersonInfo.ImagePath))
                    pbProfilePicture.ImageLocation = PersonInfo.ImagePath;
                else {
                    if (PersonInfo.Gendor == 0)
                        pbProfilePicture.Image = Properties.Resources.male;
                    else
                        pbProfilePicture.Image = Properties.Resources.female;
                }
            }
            else
                this.PersonID = -1;

        }

    }
}
