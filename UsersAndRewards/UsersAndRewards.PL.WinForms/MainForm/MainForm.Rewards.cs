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
        private void btnAddRewardMain_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void btnEditRewardMain_Click(object sender, EventArgs e)
        {
            EditReward();
        }

        private void btnDeleteRewardMain_Click(object sender, EventArgs e)
        {
            DeleteReward();
        }

        private void btnAddRewardContext_Click(object sender, EventArgs e)
        {
            AddReward();
        }

        private void btnEditRewardContext_Click(object sender, EventArgs e)
        {
            EditReward();
        }

        private void btnDeleteRewardContext_Click(object sender, EventArgs e)
        {
            DeleteReward();
        }

        private void AddReward()
        {
            RewardForm form = new RewardForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                Reward reward = new Reward(form.Title, form.Description);
                data.AddReward(reward);
                RefreshRewardsGrid();
            }
        }

        private void EditReward()
        {
            if (ctlRewardsGrid.SelectedCells.Count > 0)
            {
                int row = ctlRewardsGrid.SelectedCells[0].RowIndex;
                int id = (int)ctlRewardsGrid.Rows[row].Cells[0].Value;
                Reward reward = data.FindRewardById(id);
                RewardForm form = new RewardForm(reward);
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    reward.Title = form.Title;
                    reward.Description = form.Description;
                    data.EditReward(reward);
                }
                RefreshRewardsGrid();
                RefreshUsersGrid();

            }
        }

        private void DeleteReward()
        {
            if (ctlRewardsGrid.SelectedCells.Count > 0)
            {
                List<int> rows = new List<int>();
                for (int i = 0; i < ctlRewardsGrid.SelectedCells.Count; i++)
                {
                    rows.Add(ctlRewardsGrid.SelectedCells[i].RowIndex);
                }
                List<Reward> rewsforDelete = new List<Reward>();
                foreach (var i in rows)
                {
                    int id = (int)ctlRewardsGrid.Rows[i].Cells[0].Value;
                    rewsforDelete.Add(data.FindRewardById(id));
                }
                string msg = "Are you sure?";
                string caption = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                if (MessageBox.Show(msg, caption, buttons) == DialogResult.Yes)
                {
                    foreach (var r in rewsforDelete)
                    {
                        foreach (User user in data.GetUsersList())
                        {
                            if (user.Rewards.Contains(r))
                            {
                                user.Rewards.Remove(r);
                            }
                        }
                        data.DeleteReward(r.ID);
                    }
                }
                RefreshRewardsGrid();
                RefreshUsersGrid();
            }
        }

        private void RefreshRewardsGrid()
        {
            ctlRewardsGrid.DataSource = null;
            ctlRewardsGrid.DataSource = data.GetRewardsList();
        }

    }
}
