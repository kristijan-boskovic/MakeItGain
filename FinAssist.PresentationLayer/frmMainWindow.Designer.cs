namespace FinAssist.PresentationLayer
{
    partial class frmMainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDataStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultModelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addExpenditureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIncomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expenditureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showSummaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.expenditureToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToDataStoreToolStripMenuItem,
            this.loadDefaultModelToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // connectToDataStoreToolStripMenuItem
            // 
            this.connectToDataStoreToolStripMenuItem.Name = "connectToDataStoreToolStripMenuItem";
            this.connectToDataStoreToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.connectToDataStoreToolStripMenuItem.Text = "Connect to data store";
            // 
            // loadDefaultModelToolStripMenuItem
            // 
            this.loadDefaultModelToolStripMenuItem.Name = "loadDefaultModelToolStripMenuItem";
            this.loadDefaultModelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadDefaultModelToolStripMenuItem.Text = "Load default model";
            this.loadDefaultModelToolStripMenuItem.Click += new System.EventHandler(this.loadDefaultModelToolStripMenuItem_Click);
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAccountsToolStripMenuItem,
            this.addAccountToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.accountsToolStripMenuItem.Text = "Accounts";
            // 
            // viewAccountsToolStripMenuItem
            // 
            this.viewAccountsToolStripMenuItem.Name = "viewAccountsToolStripMenuItem";
            this.viewAccountsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewAccountsToolStripMenuItem.Text = "View accounts";
            this.viewAccountsToolStripMenuItem.Click += new System.EventHandler(this.viewAccountsToolStripMenuItem_Click);
            // 
            // addAccountToolStripMenuItem
            // 
            this.addAccountToolStripMenuItem.Name = "addAccountToolStripMenuItem";
            this.addAccountToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addAccountToolStripMenuItem.Text = "Add account";
            this.addAccountToolStripMenuItem.Click += new System.EventHandler(this.addAccountToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTransactionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.addExpenditureToolStripMenuItem,
            this.addIncomeToolStripMenuItem,
            this.addTransferToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // viewTransactionsToolStripMenuItem
            // 
            this.viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            this.viewTransactionsToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.viewTransactionsToolStripMenuItem.Text = "View transactions";
            this.viewTransactionsToolStripMenuItem.Click += new System.EventHandler(this.viewTransactionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // addExpenditureToolStripMenuItem
            // 
            this.addExpenditureToolStripMenuItem.Name = "addExpenditureToolStripMenuItem";
            this.addExpenditureToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addExpenditureToolStripMenuItem.Text = "Add expenditure";
            this.addExpenditureToolStripMenuItem.Click += new System.EventHandler(this.addExpenditureToolStripMenuItem_Click);
            // 
            // addIncomeToolStripMenuItem
            // 
            this.addIncomeToolStripMenuItem.Name = "addIncomeToolStripMenuItem";
            this.addIncomeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addIncomeToolStripMenuItem.Text = "Add income";
            this.addIncomeToolStripMenuItem.Click += new System.EventHandler(this.addIncomeToolStripMenuItem_Click);
            // 
            // addTransferToolStripMenuItem
            // 
            this.addTransferToolStripMenuItem.Name = "addTransferToolStripMenuItem";
            this.addTransferToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addTransferToolStripMenuItem.Text = "Add transfer";
            this.addTransferToolStripMenuItem.Click += new System.EventHandler(this.addTransferToolStripMenuItem_Click);
            // 
            // expenditureToolStripMenuItem
            // 
            this.expenditureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.placesToolStripMenuItem});
            this.expenditureToolStripMenuItem.Name = "expenditureToolStripMenuItem";
            this.expenditureToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.expenditureToolStripMenuItem.Text = "Expenditure";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // placesToolStripMenuItem
            // 
            this.placesToolStripMenuItem.Name = "placesToolStripMenuItem";
            this.placesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.placesToolStripMenuItem.Text = "Places";
            this.placesToolStripMenuItem.Click += new System.EventHandler(this.placesToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSummaryReportToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // showSummaryReportToolStripMenuItem
            // 
            this.showSummaryReportToolStripMenuItem.Name = "showSummaryReportToolStripMenuItem";
            this.showSummaryReportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.showSummaryReportToolStripMenuItem.Text = "Show summary report";
            this.showSummaryReportToolStripMenuItem.Click += new System.EventHandler(this.showSummaryReportToolStripMenuItem_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 415);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMainWindow";
            this.Text = "FinAssist";
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToDataStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenditureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIncomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultModelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showSummaryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem expenditureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placesToolStripMenuItem;
    }
}