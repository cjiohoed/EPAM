using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndRewards.PL.WinForms
{
    public partial class RewardForm : Form
    {
        private bool isNew = true;
        public string Title { get; set; }
        public string Description { get; set; }

        public RewardForm()
        {
            InitializeComponent();
        }

        public RewardForm(Reward reward)
        {
            InitializeComponent();
            Title = reward.Title;
            Description = reward.Description;
            isNew = false;
        }

        private void txtTitle_Validated(object sender, EventArgs e)
        {
            Title = txtTitle.Text.Trim();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            string input = txtTitle.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                ctlTitleError.SetError(txtTitle, "Enter title");
                e.Cancel = true;
            }
            else
            {
                ctlTitleError.SetError(txtTitle, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtDescription_Validated(object sender, EventArgs e)
        {
            Description = txtDescription.Text.Trim();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            string input = txtDescription.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                ctlTitleError.SetError(txtDescription, "Enter description");
                e.Cancel = true;
            }
            else
            {
                ctlTitleError.SetError(txtDescription, String.Empty);
                e.Cancel = false;
            }
        }

        private void RewardForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = Title;
            txtDescription.Text = Description;
            if (isNew)
            {
                Text = "Add reward";
                btnOkRewardForm.Text = "Add";
            }
            else
            {
                Text = "Edit reward";
                btnOkRewardForm.Text = "Edit";
            }
            txtTitle.Focus();
        }

        private void btnOkRewardForm_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }
    }
}
