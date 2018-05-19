using Entities;
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
            UserForm form = new UserForm(data);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                User user = new User(form.FirstName, form.LastName, form.BirthDate, form.Rewards);
                data.AddUser(user);
                RefreshUsersGrid();
            }
        }

        private void EditUser()
        {
            if (ctlUsersGrid.SelectedCells.Count > 0)
            {
                int row = ctlUsersGrid.SelectedCells[0].RowIndex;
                int id = (int)ctlUsersGrid.Rows[row].Cells[0].Value;
                User user = data.FindUserById(id);
                UserForm form = new UserForm(data, user);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    user.FirstName = form.FirstName;
                    user.LastName = form.LastName;
                    user.BirthDate = form.BirthDate;

                    user.Rewards = form.Rewards;

                    data.EditUser(user);
                }
                RefreshUsersGrid();

            }

        }

        private void DeleteUser()
        {
            if (ctlUsersGrid.SelectedCells.Count > 0)
            {
                List<int> rows = new List<int>();
                for (int i = 0; i < ctlUsersGrid.SelectedCells.Count; i++)
                {
                    rows.Add(ctlUsersGrid.SelectedCells[i].RowIndex);
                }
                List<int> ids = new List<int>();
                foreach (var i in rows)
                {
                    int id = (int)ctlUsersGrid.Rows[i].Cells[0].Value;
                    ids.Add(id);
                }
                string msg = "Are you sure?";
                string caption = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                if (MessageBox.Show(msg, caption, buttons) == DialogResult.Yes)
                {
                    foreach (var id in ids)
                    {
                        data.DeleteUser(id);
                    }
                }
                RefreshUsersGrid();
            }
        }

        private void RefreshUsersGrid()
        {
            ctlUsersGrid.DataSource = null;
            ctlUsersGrid.DataSource = data.GetUsersViewModel();
        }

    }
}
