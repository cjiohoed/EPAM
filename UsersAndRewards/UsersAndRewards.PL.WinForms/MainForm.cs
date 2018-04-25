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
    public partial class MainForm : Form
    {
        private IDataBL data;

        public MainForm()
        {
            data = new DataBL();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateUsers();
            CreateRewards();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
