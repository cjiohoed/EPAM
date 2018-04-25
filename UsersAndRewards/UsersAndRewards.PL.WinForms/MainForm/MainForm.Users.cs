using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsersAndRewards.PL.WinForms
{
    public partial class MainForm : Form
    {
        private void CreateUsers()
        {
            ctlUsersGrid.DataSource = data.InitUsers();
        }

        private void btnAddUserMain_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnEditUserMain_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void btnDeleteUserMain_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void btnAddUserContext_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnEditUserContext_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void btnDeleteUserContext_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void AddUser()
        {

        }

        private void EditUser()
        {

        }

        private void DeleteUser()
        {

        }

        private void RefreshUsersGrid()
        {
            ctlUsersGrid.DataSource = null;
            ctlUsersGrid.DataSource = data.GetUsersList();
        }

    }
}
