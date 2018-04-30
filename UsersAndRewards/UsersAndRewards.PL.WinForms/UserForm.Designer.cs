namespace UsersAndRewards.PL.WinForms
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.ctlBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctlUserRewardsList = new System.Windows.Forms.CheckedListBox();
            this.ctlFirstNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlLastNameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlBirthDateError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctlFirstNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlLastNameError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlBirthDateError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(12, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(12, 46);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(12, 79);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(54, 13);
            this.lblBirthDate.TabIndex = 2;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(75, 10);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            this.txtFirstName.Validated += new System.EventHandler(this.txtFirstName_Validated);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(76, 43);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 20);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            this.txtLastName.Validated += new System.EventHandler(this.txtLastName_Validated);
            // 
            // ctlBirthDate
            // 
            this.ctlBirthDate.Location = new System.Drawing.Point(75, 73);
            this.ctlBirthDate.Name = "ctlBirthDate";
            this.ctlBirthDate.Size = new System.Drawing.Size(200, 20);
            this.ctlBirthDate.TabIndex = 6;
            this.ctlBirthDate.Validating += new System.ComponentModel.CancelEventHandler(this.ctlBirthDate_Validating);
            this.ctlBirthDate.Validated += new System.EventHandler(this.ctlBirthDate_Validated);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(123, 286);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(204, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ctlUserRewardsList
            // 
            this.ctlUserRewardsList.FormattingEnabled = true;
            this.ctlUserRewardsList.Location = new System.Drawing.Point(15, 99);
            this.ctlUserRewardsList.Name = "ctlUserRewardsList";
            this.ctlUserRewardsList.Size = new System.Drawing.Size(260, 184);
            this.ctlUserRewardsList.TabIndex = 9;
            this.ctlUserRewardsList.Validated += new System.EventHandler(this.ctlUserRewardsList_Validated);
            // 
            // ctlFirstNameError
            // 
            this.ctlFirstNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlFirstNameError.ContainerControl = this;
            // 
            // ctlLastNameError
            // 
            this.ctlLastNameError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlLastNameError.ContainerControl = this;
            // 
            // ctlBirthDateError
            // 
            this.ctlBirthDateError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlBirthDateError.ContainerControl = this;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(309, 321);
            this.Controls.Add(this.ctlUserRewardsList);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctlBirthDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlFirstNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlLastNameError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlBirthDateError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker ctlBirthDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckedListBox ctlUserRewardsList;
        private System.Windows.Forms.ErrorProvider ctlFirstNameError;
        private System.Windows.Forms.ErrorProvider ctlLastNameError;
        private System.Windows.Forms.ErrorProvider ctlBirthDateError;
    }
}