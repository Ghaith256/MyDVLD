using DVLD_Business;
using Microsoft.Win32;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace DVLD_Presentation.People
{
    public partial class frmAddUpdatePerson : Form
    {

        private clsPersonBusiness? _Person;

        private void _LoadData() {
            
            if (_Person == null)
                return;

            if (_Person.Mode == clsPersonBusiness.enMode.AddNew) {
                btnSave.Text = "Add";
                return;
            }

            btnSave.Text = "Update";

            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;

            txtNationalNo.Text = _Person.NationalNo;
            timeDateOfBirth.Value = _Person.DateOfBirth;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;

            if (_Person.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cmbCountry.SelectedValue = _Person.NationalityCountryID;

            if (!string.IsNullOrEmpty(_Person.ImagePath) &&
                File.Exists(_Person.ImagePath))
            {
                pbProfilePicture.Image = Image.FromFile(_Person.ImagePath);
                pbProfilePicture.Tag = _Person.ImagePath;
            }
        }
        
        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Person = new clsPersonBusiness();
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Person = clsPersonBusiness.Find(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because Person ID is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _FillCountriesInComboBox();
            clsFormatHelper.StyleButton(btnSave);
            clsFormatHelper.StyleDateTimePicker(timeDateOfBirth);
            _LoadData();
            timeDateOfBirth.MinDate = DateTime.Now.AddYears(-18);
            timeDateOfBirth.MaxDate = DateTime.Now.AddYears(100);

        }

        private void rbGender_CheckedChanged(object sender, EventArgs e)
        {
            if (pbProfilePicture.Tag == null)
                if (rbMale.Checked)
                    pbProfilePicture.Image = Properties.Resources.male;
                else if (rbFemale.Checked)
                    pbProfilePicture.Image = Properties.Resources.female;
        }

        private void pbProfilePicture_Click(object sender, EventArgs e) {
            
            OpenFileDialog MyFileDialog = new OpenFileDialog();

            MyFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
            MyFileDialog.Title = "Select Your Profile Picture";

            if (MyFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbProfilePicture.Image = Image.FromFile(MyFileDialog.FileName);
                pbProfilePicture.Tag = MyFileDialog.FileName;
            }
        }

        private void tsmRemovePicture_Click(object sender, EventArgs e)
        {
            pbProfilePicture.Tag = null;

            if (rbMale.Checked)
                pbProfilePicture.Image = Properties.Resources.male;
            else if (rbFemale.Checked)
                pbProfilePicture.Image = Properties.Resources.female;
            else
                pbProfilePicture.Image = null;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateRequiredFields()) {
                MessageBox.Show("Please fill all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_Person == null)
            {
                MessageBox.Show("Error: Person object is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid, please check the red error icons.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCountry.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid country.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_HandlePersonImage())
                return;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = string.IsNullOrWhiteSpace(txtThirdName.Text) ? null : txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();

            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.DateOfBirth = timeDateOfBirth.Value;
            _Person.Gendor = rbMale.Checked ? (byte)0 : (byte)1;
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();

            _Person.NationalityCountryID = Convert.ToInt32(cmbCountry.SelectedValue);
            _Person.Address = txtAddress.Text.Trim();

            _Person.ImagePath = pbProfilePicture.Tag?.ToString();

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Text = "Update";
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsPersonBusiness.GetAllCountries();

            try
            {

                if (dtCountries.Rows.Count > 0)
                {
                    cmbCountry.DataSource = dtCountries;
                    cmbCountry.DisplayMember = "CountryName";
                    cmbCountry.ValueMember = "CountryID";
                }
                else
                    MessageBox.Show("DataTable is null or empty. Check your database or business layer query.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Details: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbCountry.SelectedIndex = cmbCountry.FindString("Jordan");
        }

        private void grpGender_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            if (box == null) return;

            e.Graphics.Clear(box.BackColor);

            TextRenderer.DrawText(e.Graphics, box.Text, box.Font, new Point(0, 0), box.ForeColor);
        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            string EnteredNationalNo = txtNationalNo.Text.Trim();

            if (string.IsNullOrWhiteSpace(EnteredNationalNo))
            {
                e.Cancel = true; 
                errUniqueNationalNo.SetError(txtNationalNo, "This field is required!");
                return; 
            }

            if (_Person.Mode == clsPersonBusiness.enMode.Update && EnteredNationalNo == _Person.NationalNo)
            {
                e.Cancel = false;
                errUniqueNationalNo.SetError(txtNationalNo, "");
                return;
            }

            if (clsPersonBusiness.IsPersonExist(EnteredNationalNo))
            {
                e.Cancel = true; 
                errUniqueNationalNo.SetError(txtNationalNo, "This National Number is already in use!");
            }
            else
            {
                e.Cancel = false;
                errUniqueNationalNo.SetError(txtNationalNo, "");
            }
        }

        private void RequiredField_Validating(object sender, CancelEventArgs e) {
            UITextBox txt = (UITextBox)sender;

            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.RectColor = Color.Red; 
                errUniqueNationalNo.SetError(txt, "This field is required!"); 
            }
            else
            {
                e.Cancel = false;
                txt.RectColor = Color.FromArgb(80, 160, 255); 
                errUniqueNationalNo.SetError(txt, null); 
            }
        }

        private bool _ValidateRequiredFields() {
            
            bool IsValid = true;
            UITextBox FirstInvalidTxt = null;

            UITextBox[] RequiredFields = { txtFirstName, txtSecondName, txtLastName, txtPhone, txtAddress };

            foreach (UITextBox txt in RequiredFields) {
                if (string.IsNullOrWhiteSpace(txt.Text)) {
                    txt.RectColor = Color.Red;
                    IsValid = false;

                    if (FirstInvalidTxt == null)
                        FirstInvalidTxt = txt;
                }
                else
                    txt.RectColor = Color.FromArgb(80, 160, 255);
            }

            if (!IsValid && FirstInvalidTxt != null)
                FirstInvalidTxt.Focus();

            return IsValid;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e) {
           
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                txtEmail.RectColor = Color.FromArgb(80, 160, 255);
                return;
            }

            if (!DVLD.Classes.clsValidatoin.ValidateEmail(txtEmail.Text.Trim())) {
                e.Cancel = true;
                txtEmail.RectColor = Color.Red; 
            }
            else {
                e.Cancel = false;
                txtEmail.RectColor = Color.FromArgb(80, 160, 255);
            }
        }

        private bool _HandlePersonImage()
        {
            string CurrentTag = pbProfilePicture.Tag?.ToString() ?? "";
            string CurrentImagePath = _Person.ImagePath ?? "";

            if (CurrentImagePath == CurrentTag)
                return true;

            if (!string.IsNullOrEmpty(CurrentImagePath) && System.IO.File.Exists(CurrentImagePath))
            {
                try
                {
                    File.Delete(CurrentImagePath);
                }
                catch (IOException ex)
                {
                }
            }

            if (pbProfilePicture.Tag != null) {
                
                string? SourceImageFile = pbProfilePicture.Tag.ToString();

                if (DVLD.Classes.clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile)) {
                    pbProfilePicture.Tag = SourceImageFile;
                    return true;
                }
                else
                    return false;
                
            }

            return true;
        }
    }
}
