namespace BookManageSystem
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsMenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改口令ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemBookInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.客房信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemReader = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemLend = new System.Windows.Forms.ToolStripMenuItem();
            this.入住客房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退还客房ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.客房信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客房入住查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemPurview = new System.Windows.Forms.ToolStripMenuItem();
            this.用户权限管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.formStatus1 = new BookManageSystem.FormStatus();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemSystem,
            this.tsMenuItemBookInfo,
            this.tsMenuItemReader,
            this.tsMenuItemLend,
            this.tsMenuItemSearch,
            this.tsMenuItemPurview,
            this.tsMenuItemWindow});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1028, 25);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tsMenuItemSystem
            // 
            this.tsMenuItemSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注销用户ToolStripMenuItem,
            this.修改口令ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.tsMenuItemSystem.Name = "tsMenuItemSystem";
            this.tsMenuItemSystem.Size = new System.Drawing.Size(59, 21);
            this.tsMenuItemSystem.Text = "系统(&S)";
            // 
            // 注销用户ToolStripMenuItem
            // 
            this.注销用户ToolStripMenuItem.Name = "注销用户ToolStripMenuItem";
            this.注销用户ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.注销用户ToolStripMenuItem.Text = "注销用户";
            this.注销用户ToolStripMenuItem.Click += new System.EventHandler(this.注销用户ToolStripMenuItem_Click);
            // 
            // 修改口令ToolStripMenuItem
            // 
            this.修改口令ToolStripMenuItem.Name = "修改口令ToolStripMenuItem";
            this.修改口令ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改口令ToolStripMenuItem.Text = "修改口令";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // tsMenuItemBookInfo
            // 
            this.tsMenuItemBookInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房信息管理ToolStripMenuItem});
            this.tsMenuItemBookInfo.Name = "tsMenuItemBookInfo";
            this.tsMenuItemBookInfo.Size = new System.Drawing.Size(84, 21);
            this.tsMenuItemBookInfo.Text = "客房管理(&C)";
            this.tsMenuItemBookInfo.Click += new System.EventHandler(this.tsMenuItemBookInfo_Click);
            // 
            // 客房信息管理ToolStripMenuItem
            // 
            this.客房信息管理ToolStripMenuItem.Name = "客房信息管理ToolStripMenuItem";
            this.客房信息管理ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.客房信息管理ToolStripMenuItem.Text = "客房信息管理";
            this.客房信息管理ToolStripMenuItem.Click += new System.EventHandler(this.客房信息管理ToolStripMenuItem_Click_1);
            // 
            // tsMenuItemReader
            // 
            this.tsMenuItemReader.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户信息维护ToolStripMenuItem});
            this.tsMenuItemReader.Name = "tsMenuItemReader";
            this.tsMenuItemReader.Size = new System.Drawing.Size(108, 21);
            this.tsMenuItemReader.Text = "客户信息维护(&R)";
            // 
            // 客户信息维护ToolStripMenuItem
            // 
            this.客户信息维护ToolStripMenuItem.Name = "客户信息维护ToolStripMenuItem";
            this.客户信息维护ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.客户信息维护ToolStripMenuItem.Text = "客户信息维护";
            this.客户信息维护ToolStripMenuItem.Click += new System.EventHandler(this.客户信息维护ToolStripMenuItem_Click);
            // 
            // tsMenuItemLend
            // 
            this.tsMenuItemLend.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入住客房ToolStripMenuItem,
            this.退还客房ToolStripMenuItem});
            this.tsMenuItemLend.Name = "tsMenuItemLend";
            this.tsMenuItemLend.Size = new System.Drawing.Size(106, 21);
            this.tsMenuItemLend.Text = "客房入住管理(&L)";
            // 
            // 入住客房ToolStripMenuItem
            // 
            this.入住客房ToolStripMenuItem.Name = "入住客房ToolStripMenuItem";
            this.入住客房ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.入住客房ToolStripMenuItem.Text = "入住客房";
            this.入住客房ToolStripMenuItem.Click += new System.EventHandler(this.入住客房ToolStripMenuItem_Click);
            // 
            // 退还客房ToolStripMenuItem
            // 
            this.退还客房ToolStripMenuItem.Name = "退还客房ToolStripMenuItem";
            this.退还客房ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退还客房ToolStripMenuItem.Text = "退还客房";
            this.退还客房ToolStripMenuItem.Click += new System.EventHandler(this.退还客房ToolStripMenuItem_Click);
            // 
            // tsMenuItemSearch
            // 
            this.tsMenuItemSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房信息查询ToolStripMenuItem,
            this.客户信息查询ToolStripMenuItem,
            this.客房入住查询ToolStripMenuItem});
            this.tsMenuItemSearch.Name = "tsMenuItemSearch";
            this.tsMenuItemSearch.Size = new System.Drawing.Size(104, 21);
            this.tsMenuItemSearch.Text = "系统信息查询(&I)";
            // 
            // 客房信息查询ToolStripMenuItem
            // 
            this.客房信息查询ToolStripMenuItem.Name = "客房信息查询ToolStripMenuItem";
            this.客房信息查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.客房信息查询ToolStripMenuItem.Text = "客房信息查询";
            this.客房信息查询ToolStripMenuItem.Click += new System.EventHandler(this.客房信息查询ToolStripMenuItem_Click);
            // 
            // 客户信息查询ToolStripMenuItem
            // 
            this.客户信息查询ToolStripMenuItem.Name = "客户信息查询ToolStripMenuItem";
            this.客户信息查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.客户信息查询ToolStripMenuItem.Text = "客户信息查询";
            this.客户信息查询ToolStripMenuItem.Click += new System.EventHandler(this.客户信息查询ToolStripMenuItem_Click);
            // 
            // 客房入住查询ToolStripMenuItem
            // 
            this.客房入住查询ToolStripMenuItem.Name = "客房入住查询ToolStripMenuItem";
            this.客房入住查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.客房入住查询ToolStripMenuItem.Text = "客房入住查询";
            this.客房入住查询ToolStripMenuItem.Click += new System.EventHandler(this.客房入住查询ToolStripMenuItem_Click);
            // 
            // tsMenuItemPurview
            // 
            this.tsMenuItemPurview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户权限管理ToolStripMenuItem});
            this.tsMenuItemPurview.Name = "tsMenuItemPurview";
            this.tsMenuItemPurview.Size = new System.Drawing.Size(107, 21);
            this.tsMenuItemPurview.Text = "用户权限管理(&P)";
            // 
            // 用户权限管理ToolStripMenuItem
            // 
            this.用户权限管理ToolStripMenuItem.Name = "用户权限管理ToolStripMenuItem";
            this.用户权限管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.用户权限管理ToolStripMenuItem.Text = "用户权限管理";
            this.用户权限管理ToolStripMenuItem.Click += new System.EventHandler(this.用户权限管理ToolStripMenuItem_Click);
            // 
            // tsMenuItemWindow
            // 
            this.tsMenuItemWindow.Name = "tsMenuItemWindow";
            this.tsMenuItemWindow.Size = new System.Drawing.Size(44, 21);
            this.tsMenuItemWindow.Text = "窗口";
            this.tsMenuItemWindow.DropDownOpening += new System.EventHandler(this.tsMenuItemWindow_DropDownOpening);
            // 
            // formStatus1
            // 
            this.formStatus1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formStatus1.Location = new System.Drawing.Point(0, 516);
            this.formStatus1.Name = "formStatus1";
            this.formStatus1.Size = new System.Drawing.Size(1028, 26);
            this.formStatus1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 542);
            this.Controls.Add(this.formStatus1);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "酒店入住自助终端";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSystem;
        private System.Windows.Forms.ToolStripMenuItem 注销用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改口令ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemBookInfo;
        private System.Windows.Forms.ToolStripMenuItem 客房信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemReader;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemLend;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSearch;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPurview;
        private System.Windows.Forms.ToolStripMenuItem 客户信息维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 入住客房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退还客房ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客房信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客房入住查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户权限管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemWindow;
        private FormStatus formStatus1;
    }
}

