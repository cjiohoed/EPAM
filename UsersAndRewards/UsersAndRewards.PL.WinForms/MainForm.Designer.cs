namespace UsersAndRewards.PL.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctlMainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddUserMain = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditUserMain = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUserMain = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRewardMain = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditRewardMain = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteRewardMain = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTabPanel = new System.Windows.Forms.TabControl();
            this.ctlUsersTab = new System.Windows.Forms.TabPage();
            this.ctlUsersGrid = new System.Windows.Forms.DataGridView();
            this.ctlUsersContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddUserContext = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditUserContext = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteUserContext = new System.Windows.Forms.ToolStripMenuItem();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctlRewardsTab = new System.Windows.Forms.TabPage();
            this.ctlRewardsGrid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlRewardsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddRewardContext = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditRewardContext = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteRewardContext = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myRewardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rewardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rewards = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctlMainMenu.SuspendLayout();
            this.ctlTabPanel.SuspendLayout();
            this.ctlUsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsersGrid)).BeginInit();
            this.ctlUsersContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.ctlRewardsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewardsGrid)).BeginInit();
            this.ctlRewardsContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rewardBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myRewardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlMainMenu
            // 
            this.ctlMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.rewardsToolStripMenuItem});
            this.ctlMainMenu.Location = new System.Drawing.Point(0, 0);
            this.ctlMainMenu.Name = "ctlMainMenu";
            this.ctlMainMenu.Size = new System.Drawing.Size(800, 24);
            this.ctlMainMenu.TabIndex = 0;
            this.ctlMainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUserMain,
            this.btnEditUserMain,
            this.btnDeleteUserMain});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // btnAddUserMain
            // 
            this.btnAddUserMain.Name = "btnAddUserMain";
            this.btnAddUserMain.Size = new System.Drawing.Size(116, 22);
            this.btnAddUserMain.Text = "Add...";
            this.btnAddUserMain.Click += new System.EventHandler(this.btnAddUserMain_Click);
            // 
            // btnEditUserMain
            // 
            this.btnEditUserMain.Name = "btnEditUserMain";
            this.btnEditUserMain.Size = new System.Drawing.Size(116, 22);
            this.btnEditUserMain.Text = "Edit...";
            this.btnEditUserMain.Click += new System.EventHandler(this.btnEditUserMain_Click);
            // 
            // btnDeleteUserMain
            // 
            this.btnDeleteUserMain.Name = "btnDeleteUserMain";
            this.btnDeleteUserMain.Size = new System.Drawing.Size(116, 22);
            this.btnDeleteUserMain.Text = "Delete...";
            this.btnDeleteUserMain.Click += new System.EventHandler(this.btnDeleteUserMain_Click);
            // 
            // rewardsToolStripMenuItem
            // 
            this.rewardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRewardMain,
            this.btnEditRewardMain,
            this.btnDeleteRewardMain});
            this.rewardsToolStripMenuItem.Name = "rewardsToolStripMenuItem";
            this.rewardsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.rewardsToolStripMenuItem.Text = "Rewards";
            // 
            // btnAddRewardMain
            // 
            this.btnAddRewardMain.Name = "btnAddRewardMain";
            this.btnAddRewardMain.Size = new System.Drawing.Size(116, 22);
            this.btnAddRewardMain.Text = "Add...";
            this.btnAddRewardMain.Click += new System.EventHandler(this.btnAddRewardMain_Click);
            // 
            // btnEditRewardMain
            // 
            this.btnEditRewardMain.Name = "btnEditRewardMain";
            this.btnEditRewardMain.Size = new System.Drawing.Size(116, 22);
            this.btnEditRewardMain.Text = "Edit...";
            this.btnEditRewardMain.Click += new System.EventHandler(this.btnEditRewardMain_Click);
            // 
            // btnDeleteRewardMain
            // 
            this.btnDeleteRewardMain.Name = "btnDeleteRewardMain";
            this.btnDeleteRewardMain.Size = new System.Drawing.Size(116, 22);
            this.btnDeleteRewardMain.Text = "Delete...";
            this.btnDeleteRewardMain.Click += new System.EventHandler(this.btnDeleteRewardMain_Click);
            // 
            // ctlTabPanel
            // 
            this.ctlTabPanel.Controls.Add(this.ctlUsersTab);
            this.ctlTabPanel.Controls.Add(this.ctlRewardsTab);
            this.ctlTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTabPanel.Location = new System.Drawing.Point(0, 24);
            this.ctlTabPanel.Name = "ctlTabPanel";
            this.ctlTabPanel.SelectedIndex = 0;
            this.ctlTabPanel.Size = new System.Drawing.Size(800, 426);
            this.ctlTabPanel.TabIndex = 1;
            // 
            // ctlUsersTab
            // 
            this.ctlUsersTab.Controls.Add(this.ctlUsersGrid);
            this.ctlUsersTab.Location = new System.Drawing.Point(4, 22);
            this.ctlUsersTab.Name = "ctlUsersTab";
            this.ctlUsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ctlUsersTab.Size = new System.Drawing.Size(792, 400);
            this.ctlUsersTab.TabIndex = 0;
            this.ctlUsersTab.Text = "Users";
            this.ctlUsersTab.UseVisualStyleBackColor = true;
            // 
            // ctlUsersGrid
            // 
            this.ctlUsersGrid.AllowUserToAddRows = false;
            this.ctlUsersGrid.AllowUserToDeleteRows = false;
            this.ctlUsersGrid.AllowUserToResizeColumns = false;
            this.ctlUsersGrid.AllowUserToResizeRows = false;
            this.ctlUsersGrid.AutoGenerateColumns = false;
            this.ctlUsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.Rewards});
            this.ctlUsersGrid.ContextMenuStrip = this.ctlUsersContextMenu;
            this.ctlUsersGrid.DataSource = this.userBindingSource;
            this.ctlUsersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUsersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ctlUsersGrid.Location = new System.Drawing.Point(3, 3);
            this.ctlUsersGrid.Name = "ctlUsersGrid";
            this.ctlUsersGrid.RowHeadersVisible = false;
            this.ctlUsersGrid.Size = new System.Drawing.Size(786, 394);
            this.ctlUsersGrid.TabIndex = 0;
            // 
            // ctlUsersContextMenu
            // 
            this.ctlUsersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddUserContext,
            this.btnEditUserContext,
            this.btnDeleteUserContext});
            this.ctlUsersContextMenu.Name = "ctlUsersContextMenu";
            this.ctlUsersContextMenu.Size = new System.Drawing.Size(117, 70);
            // 
            // btnAddUserContext
            // 
            this.btnAddUserContext.Name = "btnAddUserContext";
            this.btnAddUserContext.Size = new System.Drawing.Size(116, 22);
            this.btnAddUserContext.Text = "Add...";
            this.btnAddUserContext.Click += new System.EventHandler(this.btnAddUserContext_Click);
            // 
            // btnEditUserContext
            // 
            this.btnEditUserContext.Name = "btnEditUserContext";
            this.btnEditUserContext.Size = new System.Drawing.Size(116, 22);
            this.btnEditUserContext.Text = "Edit...";
            this.btnEditUserContext.Click += new System.EventHandler(this.btnEditUserContext_Click);
            // 
            // btnDeleteUserContext
            // 
            this.btnDeleteUserContext.Name = "btnDeleteUserContext";
            this.btnDeleteUserContext.Size = new System.Drawing.Size(116, 22);
            this.btnDeleteUserContext.Text = "Delete...";
            this.btnDeleteUserContext.Click += new System.EventHandler(this.btnDeleteUserContext_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Entities.User);
            // 
            // ctlRewardsTab
            // 
            this.ctlRewardsTab.Controls.Add(this.ctlRewardsGrid);
            this.ctlRewardsTab.Location = new System.Drawing.Point(4, 22);
            this.ctlRewardsTab.Name = "ctlRewardsTab";
            this.ctlRewardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ctlRewardsTab.Size = new System.Drawing.Size(792, 400);
            this.ctlRewardsTab.TabIndex = 1;
            this.ctlRewardsTab.Text = "Rewards";
            this.ctlRewardsTab.UseVisualStyleBackColor = true;
            // 
            // ctlRewardsGrid
            // 
            this.ctlRewardsGrid.AllowUserToAddRows = false;
            this.ctlRewardsGrid.AllowUserToDeleteRows = false;
            this.ctlRewardsGrid.AllowUserToResizeColumns = false;
            this.ctlRewardsGrid.AllowUserToResizeRows = false;
            this.ctlRewardsGrid.AutoGenerateColumns = false;
            this.ctlRewardsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlRewardsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.ctlRewardsGrid.ContextMenuStrip = this.ctlRewardsContextMenu;
            this.ctlRewardsGrid.DataSource = this.rewardBindingSource1;
            this.ctlRewardsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRewardsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ctlRewardsGrid.Location = new System.Drawing.Point(3, 3);
            this.ctlRewardsGrid.Name = "ctlRewardsGrid";
            this.ctlRewardsGrid.RowHeadersVisible = false;
            this.ctlRewardsGrid.Size = new System.Drawing.Size(786, 394);
            this.ctlRewardsGrid.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // ctlRewardsContextMenu
            // 
            this.ctlRewardsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRewardContext,
            this.btnEditRewardContext,
            this.btnDeleteRewardContext});
            this.ctlRewardsContextMenu.Name = "ctlRewardsContextMenu";
            this.ctlRewardsContextMenu.Size = new System.Drawing.Size(117, 70);
            // 
            // btnAddRewardContext
            // 
            this.btnAddRewardContext.Name = "btnAddRewardContext";
            this.btnAddRewardContext.Size = new System.Drawing.Size(116, 22);
            this.btnAddRewardContext.Text = "Add...";
            this.btnAddRewardContext.Click += new System.EventHandler(this.btnAddRewardContext_Click);
            // 
            // btnEditRewardContext
            // 
            this.btnEditRewardContext.Name = "btnEditRewardContext";
            this.btnEditRewardContext.Size = new System.Drawing.Size(116, 22);
            this.btnEditRewardContext.Text = "Edit...";
            this.btnEditRewardContext.Click += new System.EventHandler(this.btnEditRewardContext_Click);
            // 
            // btnDeleteRewardContext
            // 
            this.btnDeleteRewardContext.Name = "btnDeleteRewardContext";
            this.btnDeleteRewardContext.Size = new System.Drawing.Size(116, 22);
            this.btnDeleteRewardContext.Text = "Delete...";
            this.btnDeleteRewardContext.Click += new System.EventHandler(this.btnDeleteRewardContext_Click);
            // 
            // rewardBindingSource1
            // 
            this.rewardBindingSource1.DataSource = typeof(Entities.Reward);
            // 
            // myRewardsBindingSource
            // 
            this.myRewardsBindingSource.DataMember = "MyRewards";
            this.myRewardsBindingSource.DataSource = this.userBindingSource;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(Entities.User);
            // 
            // rewardBindingSource
            // 
            this.rewardBindingSource.DataSource = typeof(Entities.Reward);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Rewards
            // 
            this.Rewards.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rewards.DataPropertyName = "Rewards";
            this.Rewards.HeaderText = "Rewards";
            this.Rewards.Name = "Rewards";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctlTabPanel);
            this.Controls.Add(this.ctlMainMenu);
            this.MainMenuStrip = this.ctlMainMenu;
            this.Name = "MainForm";
            this.Text = "Users and Rewards";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ctlMainMenu.ResumeLayout(false);
            this.ctlMainMenu.PerformLayout();
            this.ctlTabPanel.ResumeLayout(false);
            this.ctlUsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsersGrid)).EndInit();
            this.ctlUsersContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ctlRewardsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewardsGrid)).EndInit();
            this.ctlRewardsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ctlMainMenu;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddUserMain;
        private System.Windows.Forms.ToolStripMenuItem btnEditUserMain;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUserMain;
        private System.Windows.Forms.ToolStripMenuItem rewardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnAddRewardMain;
        private System.Windows.Forms.ToolStripMenuItem btnEditRewardMain;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteRewardMain;
        private System.Windows.Forms.TabControl ctlTabPanel;
        private System.Windows.Forms.TabPage ctlUsersTab;
        private System.Windows.Forms.TabPage ctlRewardsTab;
        private System.Windows.Forms.DataGridView ctlUsersGrid;
        private System.Windows.Forms.ContextMenuStrip ctlUsersContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddUserContext;
        private System.Windows.Forms.ToolStripMenuItem btnEditUserContext;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteUserContext;
        private System.Windows.Forms.DataGridView ctlRewardsGrid;
        private System.Windows.Forms.ContextMenuStrip ctlRewardsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAddRewardContext;
        private System.Windows.Forms.ToolStripMenuItem btnEditRewardContext;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteRewardContext;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource myRewardsBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource rewardBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rewardsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rewardBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rewards;
    }
}

