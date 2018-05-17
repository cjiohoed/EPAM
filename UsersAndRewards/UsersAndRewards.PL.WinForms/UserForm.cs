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
using UsersAndRewards.BLL;

namespace UsersAndRewards.PL.WinForms
{
    public partial class UserForm : Form
    {
        private bool isNew = true;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        private List<Reward> AllRewards;
        public List<Reward> Rewards { get; set; }

        public UserForm(IDataBL data)
        {
            InitializeComponent();
            AllRewards = data.GetRewardsList();
            foreach (var rew in AllRewards)
            {
                ctlUserRewardsList.Items.Add(rew.Title, false);
            }
            
        }

        public UserForm(IDataBL data, User user)
        {
            InitializeComponent();
            AllRewards = data.GetRewardsList();
            isNew = false;
            FirstName = user.FirstName;
            LastName = user.LastName;
            BirthDate = user.BirthDate;
            foreach (var rew in AllRewards)
            {
                ctlUserRewardsList.Items.Add(rew.Title, user.Rewards.Exists(e => e.ID == rew.ID));
            }

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = FirstName;
            txtLastName.Text = LastName;
            if (isNew)
            {
                ctlBirthDate.Value = DateTime.Now;
                Text = "Add user";
                btnOK.Text = "Add";
            }
            else
            {
                ctlBirthDate.Value = BirthDate;
                Text = "Edit user";
                btnOK.Text = "Edit";
            }
            txtFirstName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void txtFirstName_Validated(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text.Trim();
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtFirstName.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                ctlFirstNameError.SetError(txtFirstName, "Enter First name");
                e.Cancel = true;
            }
            else
            {
                ctlFirstNameError.SetError(txtFirstName, String.Empty);
                e.Cancel = false;
            }
        }

        private void txtLastName_Validated(object sender, EventArgs e)
        {
            LastName = txtLastName.Text.Trim();
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            string input = txtLastName.Text.Trim();
            if (String.IsNullOrEmpty(input))
            {
                ctlLastNameError.SetError(txtLastName, "Enter First name");
                e.Cancel = true;
            }
            else
            {
                ctlLastNameError.SetError(txtLastName, String.Empty);
                e.Cancel = false;
            }
        }

        private void ctlBirthDate_Validated(object sender, EventArgs e)
        {
            BirthDate = ctlBirthDate.Value.Date;
        }

        private void ctlBirthDate_Validating(object sender, CancelEventArgs e)
        {
            if (ctlBirthDate.Value > DateTime.Now || ctlBirthDate.Value.Year + 150 < DateTime.Now.Year)
            {
                ctlBirthDateError.SetError(ctlBirthDate, "Impossible Birth date");
                e.Cancel = true;
            }
            else
            {
                ctlBirthDateError.SetError(ctlBirthDate, String.Empty);
                e.Cancel = false;
            }
        }

        private void ctlUserRewardsList_Validated(object sender, EventArgs e)
        {
            Rewards = new List<Reward>();
            foreach (string title in ctlUserRewardsList.CheckedItems)
            {
                Rewards.Add(AllRewards.FirstOrDefault(r => r.Title == title));
            }
            //foreach (string title in ctlUserRewardsList.CheckedItems)
            //{
            //    Rewards.Add(AllRewards.FirstOrDefault(r => r.Title == title));
            //}

        }
    }
}
