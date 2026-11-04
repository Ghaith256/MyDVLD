namespace DVLD_Presentation.Application_Types
{
    partial class frmUpdateApplicationType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Sunny.UI.UILabel();
            txtTitle = new Sunny.UI.UITextBox();
            lblFees = new Sunny.UI.UILabel();
            lblUpdateApplicationTypes = new Sunny.UI.UILabel();
            txtFees = new Sunny.UI.UITextBox();
            btnSave = new Button();
            lblID = new Sunny.UI.UILabel();
            lblAnswerID = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(47, 59, 73);
            lblTitle.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(42, 94);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 23);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.FillColor = Color.FromArgb(55, 65, 81);
            txtTitle.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.ForeColor = Color.White;
            txtTitle.Location = new Point(99, 94);
            txtTitle.Margin = new Padding(4, 5, 4, 5);
            txtTitle.MinimumSize = new Size(1, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Padding = new Padding(5);
            txtTitle.RectColor = Color.FromArgb(47, 59, 73);
            txtTitle.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtTitle.ScrollBarStyleInherited = false;
            txtTitle.ShowText = false;
            txtTitle.Size = new Size(171, 24);
            txtTitle.TabIndex = 14;
            txtTitle.TextAlignment = ContentAlignment.MiddleLeft;
            txtTitle.Watermark = "";
            // 
            // lblFees
            // 
            lblFees.BackColor = Color.FromArgb(47, 59, 73);
            lblFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFees.ForeColor = Color.White;
            lblFees.Location = new Point(42, 135);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(50, 23);
            lblFees.TabIndex = 16;
            lblFees.Text = "Fees";
            // 
            // lblUpdateApplicationTypes
            // 
            lblUpdateApplicationTypes.BackColor = Color.FromArgb(47, 59, 73);
            lblUpdateApplicationTypes.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUpdateApplicationTypes.ForeColor = Color.White;
            lblUpdateApplicationTypes.Location = new Point(-4, 0);
            lblUpdateApplicationTypes.Name = "lblUpdateApplicationTypes";
            lblUpdateApplicationTypes.Size = new Size(295, 28);
            lblUpdateApplicationTypes.TabIndex = 17;
            lblUpdateApplicationTypes.Text = "Update Application Type";
            // 
            // txtFees
            // 
            txtFees.FillColor = Color.FromArgb(55, 65, 81);
            txtFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFees.ForeColor = Color.White;
            txtFees.Location = new Point(99, 135);
            txtFees.Margin = new Padding(4, 5, 4, 5);
            txtFees.MinimumSize = new Size(1, 16);
            txtFees.Name = "txtFees";
            txtFees.Padding = new Padding(5);
            txtFees.RectColor = Color.FromArgb(47, 59, 73);
            txtFees.ScrollBarColor = Color.FromArgb(47, 59, 73);
            txtFees.ScrollBarStyleInherited = false;
            txtFees.ShowText = false;
            txtFees.Size = new Size(171, 24);
            txtFees.TabIndex = 15;
            txtFees.TextAlignment = ContentAlignment.MiddleLeft;
            txtFees.Watermark = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(249, 115, 22);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(86, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 30);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblID
            // 
            lblID.BackColor = Color.FromArgb(47, 59, 73);
            lblID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(42, 44);
            lblID.Name = "lblID";
            lblID.Size = new Size(50, 23);
            lblID.TabIndex = 23;
            lblID.Text = "Title";
            // 
            // lblAnswerID
            // 
            lblAnswerID.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerID.ForeColor = Color.White;
            lblAnswerID.Location = new Point(86, 44);
            lblAnswerID.Name = "lblAnswerID";
            lblAnswerID.Size = new Size(36, 23);
            lblAnswerID.TabIndex = 24;
            lblAnswerID.Text = "??";
            // 
            // frmUpdateApplicationType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(291, 248);
            Controls.Add(lblAnswerID);
            Controls.Add(lblID);
            Controls.Add(btnSave);
            Controls.Add(txtFees);
            Controls.Add(lblUpdateApplicationTypes);
            Controls.Add(lblFees);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Name = "frmUpdateApplicationType";
            Text = "frmAddApplicationType";
            Load += frmUpdateApplicationType_Load;
            ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel lblTitle;
        private Sunny.UI.UITextBox txtTitle;
        private Sunny.UI.UILabel lblFees;
        private Sunny.UI.UILabel lblUpdateApplicationTypes;
        private Sunny.UI.UITextBox txtFees;
        private Button btnSave;
        private Sunny.UI.UILabel lblID;
        private Sunny.UI.UILabel lblAnswerID;
    }
}