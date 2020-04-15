namespace Mijo_Commander
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemViewLeftCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemViewRightCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemViewNoCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorView1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemViewBorder0 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemViewBorder1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemViewBorder2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparatorView2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemViewHorizontal = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemViewVertical = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripOperations = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonOptions = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.listViewLeft = new System.Windows.Forms.ListView();
			this.listViewRight = new System.Windows.Forms.ListView();
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.toolStripSplitterView = new System.Windows.Forms.ToolStrip();
			this.contextMenuStripSplitterView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItemRemoveBar = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemSplitterViewLeftCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSplitterViewRightCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSplitterViewNoCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemSplitterViewBorder0 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSplitterViewBorder1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSplitterViewBorder2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemSplitterViewHorizontal = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemSplitterViewVertical = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButtonSplitterViewLeftCollapse = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSplitterViewRightCollapse = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSplitterViewNoCollapse = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorSplitterView1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonSplitterViewBorder0 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSplitterViewBorder1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSplitterViewBorder2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorSplitterView2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonSplitterViewHorizontal = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonSplitterViewVertical = new System.Windows.Forms.ToolStripButton();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.toolStripOperations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.TopToolStripPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.toolStripSplitterView.SuspendLayout();
			this.contextMenuStripSplitterView.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemView});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.ShowItemToolTips = true;
			this.menuStrip.Size = new System.Drawing.Size(649, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.TabStop = true;
			this.menuStrip.Text = "main menu";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.AutoToolTip = true;
			this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemExit});
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new System.Drawing.Size(35, 20);
			this.toolStripMenuItemFile.Text = "&File";
			// 
			// toolStripMenuItemExit
			// 
			this.toolStripMenuItemExit.AutoToolTip = true;
			this.toolStripMenuItemExit.Image = global::MijoCommander.Properties.Resources.fatcow_door;
			this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			this.toolStripMenuItemExit.Size = new System.Drawing.Size(92, 22);
			this.toolStripMenuItemExit.Text = "E&xit";
			this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
			// 
			// toolStripMenuItemView
			// 
			this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemViewLeftCollapse,
            this.toolStripMenuItemViewRightCollapse,
            this.toolStripMenuItemViewNoCollapse,
            this.toolStripSeparatorView1,
            this.toolStripMenuItemViewBorder0,
            this.toolStripMenuItemViewBorder1,
            this.toolStripMenuItemViewBorder2,
            this.toolStripSeparatorView2,
            this.toolStripMenuItemViewHorizontal,
            this.toolStripMenuItemViewVertical});
			this.toolStripMenuItemView.Name = "toolStripMenuItemView";
			this.toolStripMenuItemView.Size = new System.Drawing.Size(41, 20);
			this.toolStripMenuItemView.Text = "&View";
			// 
			// toolStripMenuItemViewLeftCollapse
			// 
			this.toolStripMenuItemViewLeftCollapse.AutoToolTip = true;
			this.toolStripMenuItemViewLeftCollapse.Name = "toolStripMenuItemViewLeftCollapse";
			this.toolStripMenuItemViewLeftCollapse.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewLeftCollapse.Text = "Left view collapse";
			this.toolStripMenuItemViewLeftCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewLeftCollapse_Click);
			// 
			// toolStripMenuItemViewRightCollapse
			// 
			this.toolStripMenuItemViewRightCollapse.AutoToolTip = true;
			this.toolStripMenuItemViewRightCollapse.Name = "toolStripMenuItemViewRightCollapse";
			this.toolStripMenuItemViewRightCollapse.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewRightCollapse.Text = "Right view collapse";
			this.toolStripMenuItemViewRightCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewRightCollapse_Click);
			// 
			// toolStripMenuItemViewNoCollapse
			// 
			this.toolStripMenuItemViewNoCollapse.AutoToolTip = true;
			this.toolStripMenuItemViewNoCollapse.Checked = true;
			this.toolStripMenuItemViewNoCollapse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemViewNoCollapse.Name = "toolStripMenuItemViewNoCollapse";
			this.toolStripMenuItemViewNoCollapse.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewNoCollapse.Text = "No collapse";
			this.toolStripMenuItemViewNoCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewNoCollapse_Click);
			// 
			// toolStripSeparatorView1
			// 
			this.toolStripSeparatorView1.Name = "toolStripSeparatorView1";
			this.toolStripSeparatorView1.Size = new System.Drawing.Size(162, 6);
			// 
			// toolStripMenuItemViewBorder0
			// 
			this.toolStripMenuItemViewBorder0.AutoToolTip = true;
			this.toolStripMenuItemViewBorder0.Checked = true;
			this.toolStripMenuItemViewBorder0.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemViewBorder0.Image = global::MijoCommander.Properties.Resources.fatcow_border_0;
			this.toolStripMenuItemViewBorder0.Name = "toolStripMenuItemViewBorder0";
			this.toolStripMenuItemViewBorder0.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewBorder0.Text = "No border";
			this.toolStripMenuItemViewBorder0.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder0_Click);
			// 
			// toolStripMenuItemViewBorder1
			// 
			this.toolStripMenuItemViewBorder1.AutoToolTip = true;
			this.toolStripMenuItemViewBorder1.Image = global::MijoCommander.Properties.Resources.fatcow_border_1;
			this.toolStripMenuItemViewBorder1.Name = "toolStripMenuItemViewBorder1";
			this.toolStripMenuItemViewBorder1.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewBorder1.Text = "Thin border";
			this.toolStripMenuItemViewBorder1.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder1_Click);
			// 
			// toolStripMenuItemViewBorder2
			// 
			this.toolStripMenuItemViewBorder2.AutoToolTip = true;
			this.toolStripMenuItemViewBorder2.Image = global::MijoCommander.Properties.Resources.fatcow_border_2;
			this.toolStripMenuItemViewBorder2.Name = "toolStripMenuItemViewBorder2";
			this.toolStripMenuItemViewBorder2.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewBorder2.Text = "3d border";
			this.toolStripMenuItemViewBorder2.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder2_Click);
			// 
			// toolStripSeparatorView2
			// 
			this.toolStripSeparatorView2.Name = "toolStripSeparatorView2";
			this.toolStripSeparatorView2.Size = new System.Drawing.Size(162, 6);
			// 
			// toolStripMenuItemViewHorizontal
			// 
			this.toolStripMenuItemViewHorizontal.AutoToolTip = true;
			this.toolStripMenuItemViewHorizontal.Checked = true;
			this.toolStripMenuItemViewHorizontal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemViewHorizontal.Image = global::MijoCommander.Properties.Resources.fatcow_split_panel;
			this.toolStripMenuItemViewHorizontal.Name = "toolStripMenuItemViewHorizontal";
			this.toolStripMenuItemViewHorizontal.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewHorizontal.Text = "View horizontal";
			this.toolStripMenuItemViewHorizontal.Click += new System.EventHandler(this.toolStripButtonSplitterViewHorizontal_Click);
			// 
			// toolStripMenuItemViewVertical
			// 
			this.toolStripMenuItemViewVertical.AutoToolTip = true;
			this.toolStripMenuItemViewVertical.Image = global::MijoCommander.Properties.Resources.fatcow_split_panel_vertical;
			this.toolStripMenuItemViewVertical.Name = "toolStripMenuItemViewVertical";
			this.toolStripMenuItemViewVertical.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemViewVertical.Text = "View vertical";
			this.toolStripMenuItemViewVertical.Click += new System.EventHandler(this.toolStripButtonSplitterViewVertical_Click);
			// 
			// toolStripOperations
			// 
			this.toolStripOperations.AllowItemReorder = true;
			this.toolStripOperations.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOptions});
			this.toolStripOperations.Location = new System.Drawing.Point(3, 0);
			this.toolStripOperations.Name = "toolStripOperations";
			this.toolStripOperations.Size = new System.Drawing.Size(76, 25);
			this.toolStripOperations.TabIndex = 1;
			this.toolStripOperations.TabStop = true;
			this.toolStripOperations.Text = "Operations";
			// 
			// toolStripButtonOptions
			// 
			this.toolStripButtonOptions.Image = global::MijoCommander.Properties.Resources.fatcow_gear;
			this.toolStripButtonOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonOptions.Name = "toolStripButtonOptions";
			this.toolStripButtonOptions.Size = new System.Drawing.Size(64, 22);
			this.toolStripButtonOptions.Text = "Options";
			this.toolStripButtonOptions.Click += new System.EventHandler(this.toolStripButtonOptions_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
			this.statusStrip.Size = new System.Drawing.Size(649, 22);
			this.statusStrip.TabIndex = 3;
			this.statusStrip.Text = "status bar";
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.listViewLeft);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.listViewRight);
			this.splitContainer.Size = new System.Drawing.Size(649, 428);
			this.splitContainer.SplitterDistance = 320;
			this.splitContainer.TabIndex = 0;
			// 
			// listViewLeft
			// 
			this.listViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewLeft.Location = new System.Drawing.Point(0, 0);
			this.listViewLeft.Name = "listViewLeft";
			this.listViewLeft.Size = new System.Drawing.Size(320, 428);
			this.listViewLeft.TabIndex = 1;
			this.listViewLeft.UseCompatibleStateImageBehavior = false;
			// 
			// listViewRight
			// 
			this.listViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewRight.Location = new System.Drawing.Point(0, 0);
			this.listViewRight.Name = "listViewRight";
			this.listViewRight.Size = new System.Drawing.Size(325, 428);
			this.listViewRight.TabIndex = 2;
			this.listViewRight.UseCompatibleStateImageBehavior = false;
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
			this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(649, 428);
			this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainer.Location = new System.Drawing.Point(0, 24);
			this.toolStripContainer.Name = "toolStripContainer";
			this.toolStripContainer.Size = new System.Drawing.Size(649, 475);
			this.toolStripContainer.TabIndex = 4;
			this.toolStripContainer.Text = "toolStripContainer1";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripOperations);
			this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStripSplitterView);
			// 
			// toolStripSplitterView
			// 
			this.toolStripSplitterView.AllowItemReorder = true;
			this.toolStripSplitterView.ContextMenuStrip = this.contextMenuStripSplitterView;
			this.toolStripSplitterView.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripSplitterView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSplitterViewLeftCollapse,
            this.toolStripButtonSplitterViewRightCollapse,
            this.toolStripButtonSplitterViewNoCollapse,
            this.toolStripSeparatorSplitterView1,
            this.toolStripButtonSplitterViewBorder0,
            this.toolStripButtonSplitterViewBorder1,
            this.toolStripButtonSplitterViewBorder2,
            this.toolStripSeparatorSplitterView2,
            this.toolStripButtonSplitterViewHorizontal,
            this.toolStripButtonSplitterViewVertical});
			this.toolStripSplitterView.Location = new System.Drawing.Point(79, 0);
			this.toolStripSplitterView.Name = "toolStripSplitterView";
			this.toolStripSplitterView.Size = new System.Drawing.Size(208, 25);
			this.toolStripSplitterView.TabIndex = 2;
			this.toolStripSplitterView.TabStop = true;
			// 
			// contextMenuStripSplitterView
			// 
			this.contextMenuStripSplitterView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRemoveBar,
            this.toolStripSeparator1,
            this.toolStripMenuItemSplitterViewLeftCollapse,
            this.toolStripMenuItemSplitterViewRightCollapse,
            this.toolStripMenuItemSplitterViewNoCollapse,
            this.toolStripSeparator2,
            this.toolStripMenuItemSplitterViewBorder0,
            this.toolStripMenuItemSplitterViewBorder1,
            this.toolStripMenuItemSplitterViewBorder2,
            this.toolStripSeparator3,
            this.toolStripMenuItemSplitterViewHorizontal,
            this.toolStripMenuItemSplitterViewVertical});
			this.contextMenuStripSplitterView.Name = "contextMenuStripSplitterView";
			this.contextMenuStripSplitterView.Size = new System.Drawing.Size(166, 220);
			this.contextMenuStripSplitterView.TabStop = true;
			this.contextMenuStripSplitterView.Text = "contextMenuStripSplitterView";
			// 
			// toolStripMenuItemRemoveBar
			// 
			this.toolStripMenuItemRemoveBar.Image = global::MijoCommander.Properties.Resources.fatcow_cancel;
			this.toolStripMenuItemRemoveBar.Name = "toolStripMenuItemRemoveBar";
			this.toolStripMenuItemRemoveBar.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemRemoveBar.Text = "Remove";
			this.toolStripMenuItemRemoveBar.Click += new System.EventHandler(this.toolStripMenuItemRemoveBar_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
			// 
			// toolStripMenuItemSplitterViewLeftCollapse
			// 
			this.toolStripMenuItemSplitterViewLeftCollapse.Name = "toolStripMenuItemSplitterViewLeftCollapse";
			this.toolStripMenuItemSplitterViewLeftCollapse.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewLeftCollapse.Text = "Left view collapse";
			this.toolStripMenuItemSplitterViewLeftCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewLeftCollapse_Click);
			// 
			// toolStripMenuItemSplitterViewRightCollapse
			// 
			this.toolStripMenuItemSplitterViewRightCollapse.Name = "toolStripMenuItemSplitterViewRightCollapse";
			this.toolStripMenuItemSplitterViewRightCollapse.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewRightCollapse.Text = "Right view collapse";
			this.toolStripMenuItemSplitterViewRightCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewRightCollapse_Click);
			// 
			// toolStripMenuItemSplitterViewNoCollapse
			// 
			this.toolStripMenuItemSplitterViewNoCollapse.Checked = true;
			this.toolStripMenuItemSplitterViewNoCollapse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemSplitterViewNoCollapse.Name = "toolStripMenuItemSplitterViewNoCollapse";
			this.toolStripMenuItemSplitterViewNoCollapse.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewNoCollapse.Text = "No collapse";
			this.toolStripMenuItemSplitterViewNoCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewNoCollapse_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(162, 6);
			// 
			// toolStripMenuItemSplitterViewBorder0
			// 
			this.toolStripMenuItemSplitterViewBorder0.Checked = true;
			this.toolStripMenuItemSplitterViewBorder0.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemSplitterViewBorder0.Image = global::MijoCommander.Properties.Resources.fatcow_border_0;
			this.toolStripMenuItemSplitterViewBorder0.Name = "toolStripMenuItemSplitterViewBorder0";
			this.toolStripMenuItemSplitterViewBorder0.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewBorder0.Text = "No border";
			this.toolStripMenuItemSplitterViewBorder0.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder0_Click);
			// 
			// toolStripMenuItemSplitterViewBorder1
			// 
			this.toolStripMenuItemSplitterViewBorder1.Image = global::MijoCommander.Properties.Resources.fatcow_border_1;
			this.toolStripMenuItemSplitterViewBorder1.Name = "toolStripMenuItemSplitterViewBorder1";
			this.toolStripMenuItemSplitterViewBorder1.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewBorder1.Text = "Thin border";
			this.toolStripMenuItemSplitterViewBorder1.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder1_Click);
			// 
			// toolStripMenuItemSplitterViewBorder2
			// 
			this.toolStripMenuItemSplitterViewBorder2.Image = global::MijoCommander.Properties.Resources.fatcow_border_2;
			this.toolStripMenuItemSplitterViewBorder2.Name = "toolStripMenuItemSplitterViewBorder2";
			this.toolStripMenuItemSplitterViewBorder2.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewBorder2.Text = "3d border";
			this.toolStripMenuItemSplitterViewBorder2.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder2_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
			// 
			// toolStripMenuItemSplitterViewHorizontal
			// 
			this.toolStripMenuItemSplitterViewHorizontal.Checked = true;
			this.toolStripMenuItemSplitterViewHorizontal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemSplitterViewHorizontal.Image = global::MijoCommander.Properties.Resources.fatcow_split_panel;
			this.toolStripMenuItemSplitterViewHorizontal.Name = "toolStripMenuItemSplitterViewHorizontal";
			this.toolStripMenuItemSplitterViewHorizontal.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewHorizontal.Text = "Horizontal";
			this.toolStripMenuItemSplitterViewHorizontal.Click += new System.EventHandler(this.toolStripButtonSplitterViewHorizontal_Click);
			// 
			// toolStripMenuItemSplitterViewVertical
			// 
			this.toolStripMenuItemSplitterViewVertical.Image = global::MijoCommander.Properties.Resources.fatcow_split_panel_vertical;
			this.toolStripMenuItemSplitterViewVertical.Name = "toolStripMenuItemSplitterViewVertical";
			this.toolStripMenuItemSplitterViewVertical.Size = new System.Drawing.Size(165, 22);
			this.toolStripMenuItemSplitterViewVertical.Text = "Vertical";
			this.toolStripMenuItemSplitterViewVertical.Click += new System.EventHandler(this.toolStripButtonSplitterViewVertical_Click);
			// 
			// toolStripButtonSplitterViewLeftCollapse
			// 
			this.toolStripButtonSplitterViewLeftCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonSplitterViewLeftCollapse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSplitterViewLeftCollapse.Image")));
			this.toolStripButtonSplitterViewLeftCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewLeftCollapse.Name = "toolStripButtonSplitterViewLeftCollapse";
			this.toolStripButtonSplitterViewLeftCollapse.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewLeftCollapse.Text = "1";
			this.toolStripButtonSplitterViewLeftCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewLeftCollapse_Click);
			// 
			// toolStripButtonSplitterViewRightCollapse
			// 
			this.toolStripButtonSplitterViewRightCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonSplitterViewRightCollapse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSplitterViewRightCollapse.Image")));
			this.toolStripButtonSplitterViewRightCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewRightCollapse.Name = "toolStripButtonSplitterViewRightCollapse";
			this.toolStripButtonSplitterViewRightCollapse.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewRightCollapse.Text = "2";
			this.toolStripButtonSplitterViewRightCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewRightCollapse_Click);
			// 
			// toolStripButtonSplitterViewNoCollapse
			// 
			this.toolStripButtonSplitterViewNoCollapse.Checked = true;
			this.toolStripButtonSplitterViewNoCollapse.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonSplitterViewNoCollapse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonSplitterViewNoCollapse.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSplitterViewNoCollapse.Image")));
			this.toolStripButtonSplitterViewNoCollapse.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewNoCollapse.Name = "toolStripButtonSplitterViewNoCollapse";
			this.toolStripButtonSplitterViewNoCollapse.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewNoCollapse.Text = "3";
			this.toolStripButtonSplitterViewNoCollapse.Click += new System.EventHandler(this.toolStripButtonSplitterViewNoCollapse_Click);
			// 
			// toolStripSeparatorSplitterView1
			// 
			this.toolStripSeparatorSplitterView1.Name = "toolStripSeparatorSplitterView1";
			this.toolStripSeparatorSplitterView1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonSplitterViewBorder0
			// 
			this.toolStripButtonSplitterViewBorder0.Checked = true;
			this.toolStripButtonSplitterViewBorder0.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonSplitterViewBorder0.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSplitterViewBorder0.Image = global::MijoCommander.Properties.Resources.fatcow_border_0;
			this.toolStripButtonSplitterViewBorder0.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewBorder0.Name = "toolStripButtonSplitterViewBorder0";
			this.toolStripButtonSplitterViewBorder0.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewBorder0.Text = "None border";
			this.toolStripButtonSplitterViewBorder0.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder0_Click);
			// 
			// toolStripButtonSplitterViewBorder1
			// 
			this.toolStripButtonSplitterViewBorder1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSplitterViewBorder1.Image = global::MijoCommander.Properties.Resources.fatcow_border_1;
			this.toolStripButtonSplitterViewBorder1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewBorder1.Name = "toolStripButtonSplitterViewBorder1";
			this.toolStripButtonSplitterViewBorder1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewBorder1.Text = "Thin border";
			this.toolStripButtonSplitterViewBorder1.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder1_Click);
			// 
			// toolStripButtonSplitterViewBorder2
			// 
			this.toolStripButtonSplitterViewBorder2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSplitterViewBorder2.Image = global::MijoCommander.Properties.Resources.fatcow_border_2;
			this.toolStripButtonSplitterViewBorder2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewBorder2.Name = "toolStripButtonSplitterViewBorder2";
			this.toolStripButtonSplitterViewBorder2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewBorder2.Text = "3d border";
			this.toolStripButtonSplitterViewBorder2.Click += new System.EventHandler(this.toolStripButtonSplitterViewBorder2_Click);
			// 
			// toolStripSeparatorSplitterView2
			// 
			this.toolStripSeparatorSplitterView2.Name = "toolStripSeparatorSplitterView2";
			this.toolStripSeparatorSplitterView2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButtonSplitterViewHorizontal
			// 
			this.toolStripButtonSplitterViewHorizontal.Checked = true;
			this.toolStripButtonSplitterViewHorizontal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonSplitterViewHorizontal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSplitterViewHorizontal.Image = global::MijoCommander.Properties.Resources.fatcow_split_panel;
			this.toolStripButtonSplitterViewHorizontal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewHorizontal.Name = "toolStripButtonSplitterViewHorizontal";
			this.toolStripButtonSplitterViewHorizontal.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewHorizontal.Text = "Horizontal";
			this.toolStripButtonSplitterViewHorizontal.Click += new System.EventHandler(this.toolStripButtonSplitterViewHorizontal_Click);
			// 
			// toolStripButtonSplitterViewVertical
			// 
			this.toolStripButtonSplitterViewVertical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSplitterViewVertical.Image = global::MijoCommander.Properties.Resources.fatcow_split_panel_vertical;
			this.toolStripButtonSplitterViewVertical.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSplitterViewVertical.Name = "toolStripButtonSplitterViewVertical";
			this.toolStripButtonSplitterViewVertical.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonSplitterViewVertical.Text = "Vertical";
			this.toolStripButtonSplitterViewVertical.Click += new System.EventHandler(this.toolStripButtonSplitterViewVertical_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 499);
			this.Controls.Add(this.toolStripContainer);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mijo Commander";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStripOperations.ResumeLayout(false);
			this.toolStripOperations.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.BottomToolStripPanel.PerformLayout();
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainer.TopToolStripPanel.PerformLayout();
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.toolStripSplitterView.ResumeLayout(false);
			this.toolStripSplitterView.PerformLayout();
			this.contextMenuStripSplitterView.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
				private System.Windows.Forms.ToolStrip toolStripOperations;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer;
				private System.Windows.Forms.ListView listViewLeft;
				private System.Windows.Forms.ListView listViewRight;
				private System.Windows.Forms.ToolStripButton toolStripButtonOptions;
				private System.Windows.Forms.ToolStripContainer toolStripContainer;
				private System.Windows.Forms.ToolStrip toolStripSplitterView;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewBorder0;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewBorder1;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewBorder2;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewLeftCollapse;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewRightCollapse;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewNoCollapse;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparatorSplitterView1;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparatorSplitterView2;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewHorizontal;
				private System.Windows.Forms.ToolStripButton toolStripButtonSplitterViewVertical;
				private System.Windows.Forms.ContextMenuStrip contextMenuStripSplitterView;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemoveBar;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewLeftCollapse;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewRightCollapse;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewNoCollapse;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewBorder0;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewBorder1;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewBorder2;
				private System.Windows.Forms.ToolTip toolTip;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewHorizontal;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSplitterViewVertical;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewLeftCollapse;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewRightCollapse;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewNoCollapse;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparatorView1;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewBorder0;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewBorder1;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewBorder2;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparatorView2;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewHorizontal;
				private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemViewVertical;
    }
}

