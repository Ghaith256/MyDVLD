namespace DVLD_Presentation.Tests
{
    partial class frmAddUpdateTest
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
            lblScheduleTest = new Sunny.UI.UILabel();
            ucShowTestInfo = new DVLD_Presentation.User_Controls.ucShowTestInfo();
            pnlRetakeTest = new Panel();
            lblAnswerTotalFees = new Sunny.UI.UILabel();
            lblAnswerRetakeTestApplicationID = new Sunny.UI.UILabel();
            lblAnswerRetakeApplicationFees = new Sunny.UI.UILabel();
            lblTotalFees = new Sunny.UI.UILabel();
            lblRetakeTestApplicationID = new Sunny.UI.UILabel();
            lblRetakeApplicationFees = new Sunny.UI.UILabel();
            btnAdd = new Button();
            pnlRetakeTest.SuspendLayout();
            // 
            // lblScheduleTest
            // 
            lblScheduleTest.BackColor = Color.FromArgb(47, 59, 73);
            lblScheduleTest.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScheduleTest.ForeColor = Color.White;
            lblScheduleTest.Location = new Point(-3, -3);
            lblScheduleTest.Name = "lblScheduleTest";
            lblScheduleTest.Size = new Size(166, 31);
            lblScheduleTest.TabIndex = 23;
            lblScheduleTest.Text = "Schedule Test";
            // 
            // ucShowTestInfo
            // 
            ucShowTestInfo.BackColor = Color.FromArgb(0, 15, 33);
            ucShowTestInfo.Location = new Point(29, 31);
            ucShowTestInfo.Name = "ucShowTestInfo";
            ucShowTestInfo.Size = new Size(428, 226);
            ucShowTestInfo.TabIndex = 24;
            ucShowTestInfo.Load += ucShowTestInfo_Load;
            // 
            // pnlRetakeTest
            // 
            pnlRetakeTest.Controls.Add(lblAnswerTotalFees);
            pnlRetakeTest.Controls.Add(lblAnswerRetakeTestApplicationID);
            pnlRetakeTest.Controls.Add(lblAnswerRetakeApplicationFees);
            pnlRetakeTest.Controls.Add(lblTotalFees);
            pnlRetakeTest.Controls.Add(lblRetakeTestApplicationID);
            pnlRetakeTest.Controls.Add(lblRetakeApplicationFees);
            pnlRetakeTest.Location = new Point(29, 274);
            pnlRetakeTest.Name = "pnlRetakeTest";
            pnlRetakeTest.Size = new Size(428, 87);
            pnlRetakeTest.TabIndex = 25;
            // 
            // lblAnswerTotalFees
            // 
            lblAnswerTotalFees.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerTotalFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerTotalFees.ForeColor = Color.White;
            lblAnswerTotalFees.Location = new Point(345, 10);
            lblAnswerTotalFees.Name = "lblAnswerTotalFees";
            lblAnswerTotalFees.Size = new Size(36, 23);
            lblAnswerTotalFees.TabIndex = 14;
            lblAnswerTotalFees.Text = "??";
            // 
            // lblAnswerRetakeTestApplicationID
            // 
            lblAnswerRetakeTestApplicationID.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerRetakeTestApplicationID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerRetakeTestApplicationID.ForeColor = Color.White;
            lblAnswerRetakeTestApplicationID.Location = new Point(165, 51);
            lblAnswerRetakeTestApplicationID.Name = "lblAnswerRetakeTestApplicationID";
            lblAnswerRetakeTestApplicationID.Size = new Size(36, 23);
            lblAnswerRetakeTestApplicationID.TabIndex = 13;
            lblAnswerRetakeTestApplicationID.Text = "??";
            // 
            // lblAnswerRetakeApplicationFees
            // 
            lblAnswerRetakeApplicationFees.BackColor = Color.FromArgb(47, 59, 73);
            lblAnswerRetakeApplicationFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnswerRetakeApplicationFees.ForeColor = Color.White;
            lblAnswerRetakeApplicationFees.Location = new Point(165, 10);
            lblAnswerRetakeApplicationFees.Name = "lblAnswerRetakeApplicationFees";
            lblAnswerRetakeApplicationFees.Size = new Size(36, 23);
            lblAnswerRetakeApplicationFees.TabIndex = 12;
            lblAnswerRetakeApplicationFees.Text = "??";
            // 
            // lblTotalFees
            // 
            lblTotalFees.BackColor = Color.FromArgb(47, 59, 73);
            lblTotalFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalFees.ForeColor = Color.White;
            lblTotalFees.Location = new Point(237, 10);
            lblTotalFees.Name = "lblTotalFees";
            lblTotalFees.Size = new Size(89, 23);
            lblTotalFees.TabIndex = 11;
            lblTotalFees.Text = "Total Fees";
            // 
            // lblRetakeTestApplicationID
            // 
            lblRetakeTestApplicationID.BackColor = Color.FromArgb(47, 59, 73);
            lblRetakeTestApplicationID.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRetakeTestApplicationID.ForeColor = Color.White;
            lblRetakeTestApplicationID.Location = new Point(31, 51);
            lblRetakeTestApplicationID.Name = "lblRetakeTestApplicationID";
            lblRetakeTestApplicationID.Size = new Size(114, 23);
            lblRetakeTestApplicationID.TabIndex = 10;
            lblRetakeTestApplicationID.Text = "R.Test.App ID";
            // 
            // lblRetakeApplicationFees
            // 
            lblRetakeApplicationFees.BackColor = Color.FromArgb(47, 59, 73);
            lblRetakeApplicationFees.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRetakeApplicationFees.ForeColor = Color.White;
            lblRetakeApplicationFees.Location = new Point(31, 10);
            lblRetakeApplicationFees.Name = "lblRetakeApplicationFees";
            lblRetakeApplicationFees.Size = new Size(114, 23);
            lblRetakeApplicationFees.TabIndex = 9;
            lblRetakeApplicationFees.Text = "R.App Fees";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(249, 115, 22);
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(353, 378);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 30);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddTest
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 15, 33);
            ClientSize = new Size(469, 420);
            Controls.Add(btnAdd);
            Controls.Add(pnlRetakeTest);
            Controls.Add(ucShowTestInfo);
            Controls.Add(lblScheduleTest);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmAddTest";
            Text = "frmAddTest";
            Load += frmAddTest_Load;
            pnlRetakeTest.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lblScheduleTest;
        private User_Controls.ucShowTestInfo ucShowTestInfo;
        private Panel pnlRetakeTest;
        private Sunny.UI.UILabel lblAnswerRetakeApplicationFees;
        private Sunny.UI.UILabel lblTotalFees;
        private Sunny.UI.UILabel lblRetakeTestApplicationID;
        private Sunny.UI.UILabel lblRetakeApplicationFees;
        private Sunny.UI.UILabel lblAnswerTotalFees;
        private Sunny.UI.UILabel lblAnswerRetakeTestApplicationID;
        private Button btnAdd;
    }
}