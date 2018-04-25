namespace UsersAndRewards.PL.WinForms
{
    partial class RewardForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnCancelRewardForm = new System.Windows.Forms.Button();
            this.btnOkRewardForm = new System.Windows.Forms.Button();
            this.ctlTitleError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlDescriptionError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ctlTitleError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDescriptionError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 46);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 43);
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(288, 20);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            this.txtDescription.Validated += new System.EventHandler(this.txtDescription_Validated);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(96, 6);
            this.txtTitle.MaxLength = 50;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(288, 20);
            this.txtTitle.TabIndex = 3;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            this.txtTitle.Validated += new System.EventHandler(this.txtTitle_Validated);
            // 
            // btnCancelRewardForm
            // 
            this.btnCancelRewardForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelRewardForm.Location = new System.Drawing.Point(309, 78);
            this.btnCancelRewardForm.Name = "btnCancelRewardForm";
            this.btnCancelRewardForm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRewardForm.TabIndex = 4;
            this.btnCancelRewardForm.Text = "Cancel";
            this.btnCancelRewardForm.UseVisualStyleBackColor = true;
            // 
            // btnOkRewardForm
            // 
            this.btnOkRewardForm.Location = new System.Drawing.Point(228, 78);
            this.btnOkRewardForm.Name = "btnOkRewardForm";
            this.btnOkRewardForm.Size = new System.Drawing.Size(75, 23);
            this.btnOkRewardForm.TabIndex = 5;
            this.btnOkRewardForm.Text = "OK";
            this.btnOkRewardForm.UseVisualStyleBackColor = true;
            this.btnOkRewardForm.Click += new System.EventHandler(this.btnOkRewardForm_Click);
            // 
            // ctlTitleError
            // 
            this.ctlTitleError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlTitleError.ContainerControl = this;
            // 
            // ctlDescriptionError
            // 
            this.ctlDescriptionError.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ctlDescriptionError.ContainerControl = this;
            // 
            // RewardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(427, 113);
            this.Controls.Add(this.btnOkRewardForm);
            this.Controls.Add(this.btnCancelRewardForm);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RewardForm";
            this.Text = "Reward Form";
            this.Load += new System.EventHandler(this.RewardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctlTitleError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlDescriptionError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnCancelRewardForm;
        private System.Windows.Forms.Button btnOkRewardForm;
        private System.Windows.Forms.ErrorProvider ctlTitleError;
        private System.Windows.Forms.ErrorProvider ctlDescriptionError;
    }
}