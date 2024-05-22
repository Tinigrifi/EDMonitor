namespace EDMonitor.UserInterfaces
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundWorkerFile = new System.ComponentModel.BackgroundWorker();
            this.OLVEvents = new BrightIdeasSoftware.ObjectListView();
            this.TLVMaterials = new BrightIdeasSoftware.TreeListView();
            this.OLVCargo = new BrightIdeasSoftware.ObjectListView();
            this.LabelCargo = new System.Windows.Forms.Label();
            this.LabelMaterials = new System.Windows.Forms.Label();
            this.LabelHistory = new System.Windows.Forms.Label();
            this.LabelSystem = new System.Windows.Forms.Label();
            this.LabelSystemName = new System.Windows.Forms.Label();
            this.LabelCurrentWealth = new System.Windows.Forms.Label();
            this.LabelCredits = new System.Windows.Forms.Label();
            this.PictureBoxStar = new System.Windows.Forms.PictureBox();
            this.PanelRoute = new System.Windows.Forms.Panel();
            this.FlowLayoutPanelRoute = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelMiningRefined = new System.Windows.Forms.Label();
            this.OLVMiningRefined = new BrightIdeasSoftware.ObjectListView();
            this.GroupBoxRoute = new System.Windows.Forms.GroupBox();
            this.LabelWallet = new System.Windows.Forms.Label();
            this.OLVWallet = new BrightIdeasSoftware.ObjectListView();
            this.LabelMessages = new System.Windows.Forms.Label();
            this.OLVMessages = new BrightIdeasSoftware.ObjectListView();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLVEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLVMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLVCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStar)).BeginInit();
            this.PanelRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLVMiningRefined)).BeginInit();
            this.GroupBoxRoute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLVWallet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLVMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1069, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            this.MenuStrip.Visible = false;
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.colorToolStripMenuItem.Text = "File";
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.GreenToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.OrangeToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolStripMenuItem_Click);
            // 
            // BackgroundWorkerFile
            // 
            this.BackgroundWorkerFile.WorkerReportsProgress = true;
            this.BackgroundWorkerFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerFile_DoWork);
            // 
            // OLVEvents
            // 
            this.OLVEvents.CellEditUseWholeCell = false;
            this.OLVEvents.Cursor = System.Windows.Forms.Cursors.Default;
            this.OLVEvents.HideSelection = false;
            this.OLVEvents.Location = new System.Drawing.Point(12, 43);
            this.OLVEvents.Name = "OLVEvents";
            this.OLVEvents.Size = new System.Drawing.Size(681, 150);
            this.OLVEvents.TabIndex = 6;
            this.OLVEvents.UseCompatibleStateImageBehavior = false;
            this.OLVEvents.View = System.Windows.Forms.View.Details;
            // 
            // TLVMaterials
            // 
            this.TLVMaterials.CellEditUseWholeCell = false;
            this.TLVMaterials.HideSelection = false;
            this.TLVMaterials.Location = new System.Drawing.Point(15, 379);
            this.TLVMaterials.Name = "TLVMaterials";
            this.TLVMaterials.ShowGroups = false;
            this.TLVMaterials.Size = new System.Drawing.Size(368, 148);
            this.TLVMaterials.TabIndex = 8;
            this.TLVMaterials.UseCompatibleStateImageBehavior = false;
            this.TLVMaterials.View = System.Windows.Forms.View.Details;
            this.TLVMaterials.VirtualMode = true;
            // 
            // OLVCargo
            // 
            this.OLVCargo.CellEditUseWholeCell = false;
            this.OLVCargo.Cursor = System.Windows.Forms.Cursors.Default;
            this.OLVCargo.HideSelection = false;
            this.OLVCargo.Location = new System.Drawing.Point(15, 212);
            this.OLVCargo.Name = "OLVCargo";
            this.OLVCargo.Size = new System.Drawing.Size(368, 148);
            this.OLVCargo.TabIndex = 10;
            this.OLVCargo.UseCompatibleStateImageBehavior = false;
            this.OLVCargo.View = System.Windows.Forms.View.Details;
            // 
            // LabelCargo
            // 
            this.LabelCargo.AutoSize = true;
            this.LabelCargo.Location = new System.Drawing.Point(12, 195);
            this.LabelCargo.Name = "LabelCargo";
            this.LabelCargo.Size = new System.Drawing.Size(61, 13);
            this.LabelCargo.TabIndex = 11;
            this.LabelCargo.Text = "LabelCargo";
            // 
            // LabelMaterials
            // 
            this.LabelMaterials.AutoSize = true;
            this.LabelMaterials.Location = new System.Drawing.Point(12, 362);
            this.LabelMaterials.Name = "LabelMaterials";
            this.LabelMaterials.Size = new System.Drawing.Size(49, 13);
            this.LabelMaterials.TabIndex = 12;
            this.LabelMaterials.Text = "Materials";
            // 
            // LabelHistory
            // 
            this.LabelHistory.AutoSize = true;
            this.LabelHistory.Location = new System.Drawing.Point(9, 26);
            this.LabelHistory.Name = "LabelHistory";
            this.LabelHistory.Size = new System.Drawing.Size(39, 13);
            this.LabelHistory.TabIndex = 13;
            this.LabelHistory.Text = "History";
            // 
            // LabelSystem
            // 
            this.LabelSystem.AutoSize = true;
            this.LabelSystem.Location = new System.Drawing.Point(699, 26);
            this.LabelSystem.Name = "LabelSystem";
            this.LabelSystem.Size = new System.Drawing.Size(47, 13);
            this.LabelSystem.TabIndex = 15;
            this.LabelSystem.Text = "System :";
            // 
            // LabelSystemName
            // 
            this.LabelSystemName.AutoSize = true;
            this.LabelSystemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSystemName.Location = new System.Drawing.Point(699, 196);
            this.LabelSystemName.Name = "LabelSystemName";
            this.LabelSystemName.Size = new System.Drawing.Size(168, 24);
            this.LabelSystemName.TabIndex = 16;
            this.LabelSystemName.Text = "LabelSystemName";
            // 
            // LabelCurrentWealth
            // 
            this.LabelCurrentWealth.AutoSize = true;
            this.LabelCurrentWealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentWealth.Location = new System.Drawing.Point(699, 236);
            this.LabelCurrentWealth.Name = "LabelCurrentWealth";
            this.LabelCurrentWealth.Size = new System.Drawing.Size(140, 24);
            this.LabelCurrentWealth.TabIndex = 17;
            this.LabelCurrentWealth.Text = "Current Wealth:";
            // 
            // LabelCredits
            // 
            this.LabelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCredits.Location = new System.Drawing.Point(699, 260);
            this.LabelCredits.Name = "LabelCredits";
            this.LabelCredits.Size = new System.Drawing.Size(358, 30);
            this.LabelCredits.TabIndex = 18;
            this.LabelCredits.Text = "LabelCredits";
            this.LabelCredits.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PictureBoxStar
            // 
            this.PictureBoxStar.Location = new System.Drawing.Point(728, 43);
            this.PictureBoxStar.Name = "PictureBoxStar";
            this.PictureBoxStar.Size = new System.Drawing.Size(300, 150);
            this.PictureBoxStar.TabIndex = 14;
            this.PictureBoxStar.TabStop = false;
            // 
            // PanelRoute
            // 
            this.PanelRoute.Controls.Add(this.FlowLayoutPanelRoute);
            this.PanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRoute.Location = new System.Drawing.Point(3, 16);
            this.PanelRoute.Margin = new System.Windows.Forms.Padding(0);
            this.PanelRoute.Name = "PanelRoute";
            this.PanelRoute.Size = new System.Drawing.Size(298, 309);
            this.PanelRoute.TabIndex = 19;
            // 
            // FlowLayoutPanelRoute
            // 
            this.FlowLayoutPanelRoute.AutoScroll = true;
            this.FlowLayoutPanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelRoute.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutPanelRoute.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelRoute.Name = "FlowLayoutPanelRoute";
            this.FlowLayoutPanelRoute.Size = new System.Drawing.Size(298, 309);
            this.FlowLayoutPanelRoute.TabIndex = 0;
            // 
            // LabelMiningRefined
            // 
            this.LabelMiningRefined.AutoSize = true;
            this.LabelMiningRefined.Location = new System.Drawing.Point(12, 529);
            this.LabelMiningRefined.Name = "LabelMiningRefined";
            this.LabelMiningRefined.Size = new System.Drawing.Size(101, 13);
            this.LabelMiningRefined.TabIndex = 21;
            this.LabelMiningRefined.Text = "LabelMiningRefined";
            // 
            // OLVMiningRefined
            // 
            this.OLVMiningRefined.CellEditUseWholeCell = false;
            this.OLVMiningRefined.Cursor = System.Windows.Forms.Cursors.Default;
            this.OLVMiningRefined.HideSelection = false;
            this.OLVMiningRefined.Location = new System.Drawing.Point(15, 546);
            this.OLVMiningRefined.Name = "OLVMiningRefined";
            this.OLVMiningRefined.Size = new System.Drawing.Size(368, 148);
            this.OLVMiningRefined.TabIndex = 22;
            this.OLVMiningRefined.UseCompatibleStateImageBehavior = false;
            this.OLVMiningRefined.View = System.Windows.Forms.View.Details;
            // 
            // GroupBoxRoute
            // 
            this.GroupBoxRoute.Controls.Add(this.PanelRoute);
            this.GroupBoxRoute.Location = new System.Drawing.Point(389, 199);
            this.GroupBoxRoute.Name = "GroupBoxRoute";
            this.GroupBoxRoute.Size = new System.Drawing.Size(304, 328);
            this.GroupBoxRoute.TabIndex = 23;
            this.GroupBoxRoute.TabStop = false;
            this.GroupBoxRoute.Text = "GroupBoxRoute";
            // 
            // LabelWallet
            // 
            this.LabelWallet.AutoSize = true;
            this.LabelWallet.Location = new System.Drawing.Point(696, 287);
            this.LabelWallet.Name = "LabelWallet";
            this.LabelWallet.Size = new System.Drawing.Size(63, 13);
            this.LabelWallet.TabIndex = 25;
            this.LabelWallet.Text = "LabelWallet";
            // 
            // OLVWallet
            // 
            this.OLVWallet.CellEditUseWholeCell = false;
            this.OLVWallet.Cursor = System.Windows.Forms.Cursors.Default;
            this.OLVWallet.HideSelection = false;
            this.OLVWallet.Location = new System.Drawing.Point(699, 304);
            this.OLVWallet.Name = "OLVWallet";
            this.OLVWallet.Size = new System.Drawing.Size(358, 223);
            this.OLVWallet.TabIndex = 26;
            this.OLVWallet.UseCompatibleStateImageBehavior = false;
            this.OLVWallet.View = System.Windows.Forms.View.Details;
            // 
            // LabelMessages
            // 
            this.LabelMessages.AutoSize = true;
            this.LabelMessages.Location = new System.Drawing.Point(389, 529);
            this.LabelMessages.Name = "LabelMessages";
            this.LabelMessages.Size = new System.Drawing.Size(81, 13);
            this.LabelMessages.TabIndex = 27;
            this.LabelMessages.Text = "LabelMessages";
            // 
            // OLVMessages
            // 
            this.OLVMessages.CellEditUseWholeCell = false;
            this.OLVMessages.Cursor = System.Windows.Forms.Cursors.Default;
            this.OLVMessages.HideSelection = false;
            this.OLVMessages.Location = new System.Drawing.Point(392, 546);
            this.OLVMessages.Name = "OLVMessages";
            this.OLVMessages.Size = new System.Drawing.Size(665, 148);
            this.OLVMessages.TabIndex = 28;
            this.OLVMessages.UseCompatibleStateImageBehavior = false;
            this.OLVMessages.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1069, 702);
            this.Controls.Add(this.OLVMessages);
            this.Controls.Add(this.LabelMessages);
            this.Controls.Add(this.OLVWallet);
            this.Controls.Add(this.LabelWallet);
            this.Controls.Add(this.GroupBoxRoute);
            this.Controls.Add(this.OLVMiningRefined);
            this.Controls.Add(this.LabelMiningRefined);
            this.Controls.Add(this.LabelCredits);
            this.Controls.Add(this.LabelCurrentWealth);
            this.Controls.Add(this.LabelSystemName);
            this.Controls.Add(this.LabelSystem);
            this.Controls.Add(this.PictureBoxStar);
            this.Controls.Add(this.LabelHistory);
            this.Controls.Add(this.LabelMaterials);
            this.Controls.Add(this.LabelCargo);
            this.Controls.Add(this.OLVCargo);
            this.Controls.Add(this.TLVMaterials);
            this.Controls.Add(this.OLVEvents);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(608, 395);
            this.Name = "MainForm";
            this.Text = "ED Monitor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OLVEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TLVMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLVCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxStar)).EndInit();
            this.PanelRoute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OLVMiningRefined)).EndInit();
            this.GroupBoxRoute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OLVWallet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OLVMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.ComponentModel.BackgroundWorker BackgroundWorkerFile;
        private BrightIdeasSoftware.ObjectListView OLVEvents;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private BrightIdeasSoftware.TreeListView TLVMaterials;
        private BrightIdeasSoftware.ObjectListView OLVCargo;
        private System.Windows.Forms.Label LabelCargo;
        private System.Windows.Forms.Label LabelMaterials;
        private System.Windows.Forms.Label LabelHistory;
        private System.Windows.Forms.PictureBox PictureBoxStar;
        private System.Windows.Forms.Label LabelSystem;
        private System.Windows.Forms.Label LabelSystemName;
        private System.Windows.Forms.Label LabelCurrentWealth;
        private System.Windows.Forms.Label LabelCredits;
        private System.Windows.Forms.Panel PanelRoute;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelRoute;
        private System.Windows.Forms.Label LabelMiningRefined;
        private BrightIdeasSoftware.ObjectListView OLVMiningRefined;
        private System.Windows.Forms.GroupBox GroupBoxRoute;
        private System.Windows.Forms.Label LabelWallet;
        private BrightIdeasSoftware.ObjectListView OLVWallet;
        private System.Windows.Forms.Label LabelMessages;
        private BrightIdeasSoftware.ObjectListView OLVMessages;
    }
}