namespace MijoCommander
{
	partial class OptionsForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
			this.tabControlOptions = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.labelSplitterViewBorderStyle = new System.Windows.Forms.Label();
			this.comboBoxSplitterViewBorderStyle = new System.Windows.Forms.ComboBox();
			this.toolStripOptions = new System.Windows.Forms.ToolStrip();
			this.toolStripContainerOptions = new System.Windows.Forms.ToolStripContainer();
			this.labelLeftPanelMinSize = new System.Windows.Forms.Label();
			this.numericUpDownLeftPanelMinSize = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownRightPanelMinSize = new System.Windows.Forms.NumericUpDown();
			this.labelRightPanelMinSize = new System.Windows.Forms.Label();
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
			this.tabControlOptions.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.toolStripOptions.SuspendLayout();
			this.toolStripContainerOptions.ContentPanel.SuspendLayout();
			this.toolStripContainerOptions.TopToolStripPanel.SuspendLayout();
			this.toolStripContainerOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftPanelMinSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightPanelMinSize)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControlOptions
			// 
			this.tabControlOptions.Controls.Add(this.tabPage1);
			this.tabControlOptions.Controls.Add(this.tabPage2);
			this.tabControlOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlOptions.Location = new System.Drawing.Point(0, 0);
			this.tabControlOptions.Multiline = true;
			this.tabControlOptions.Name = "tabControlOptions";
			this.tabControlOptions.SelectedIndex = 0;
			this.tabControlOptions.ShowToolTips = true;
			this.tabControlOptions.Size = new System.Drawing.Size(506, 398);
			this.tabControlOptions.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.numericUpDownRightPanelMinSize);
			this.tabPage1.Controls.Add(this.labelRightPanelMinSize);
			this.tabPage1.Controls.Add(this.numericUpDownLeftPanelMinSize);
			this.tabPage1.Controls.Add(this.labelLeftPanelMinSize);
			this.tabPage1.Controls.Add(this.comboBoxSplitterViewBorderStyle);
			this.tabPage1.Controls.Add(this.labelSplitterViewBorderStyle);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(498, 372);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(580, 464);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Splitter view";
			// 
			// labelSplitterViewBorderStyle
			// 
			this.labelSplitterViewBorderStyle.AutoSize = true;
			this.labelSplitterViewBorderStyle.Location = new System.Drawing.Point(47, 115);
			this.labelSplitterViewBorderStyle.Name = "labelSplitterViewBorderStyle";
			this.labelSplitterViewBorderStyle.Size = new System.Drawing.Size(62, 13);
			this.labelSplitterViewBorderStyle.TabIndex = 1;
			this.labelSplitterViewBorderStyle.Text = "Border style";
			// 
			// comboBoxSplitterViewBorderStyle
			// 
			this.comboBoxSplitterViewBorderStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSplitterViewBorderStyle.FormattingEnabled = true;
			this.comboBoxSplitterViewBorderStyle.Items.AddRange(new object[] {
            "no border",
            "simple",
            "3d"});
			this.comboBoxSplitterViewBorderStyle.Location = new System.Drawing.Point(115, 112);
			this.comboBoxSplitterViewBorderStyle.Name = "comboBoxSplitterViewBorderStyle";
			this.comboBoxSplitterViewBorderStyle.Size = new System.Drawing.Size(121, 21);
			this.comboBoxSplitterViewBorderStyle.TabIndex = 2;
			// 
			// toolStripOptions
			// 
			this.toolStripOptions.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonCancel});
			this.toolStripOptions.Location = new System.Drawing.Point(0, 0);
			this.toolStripOptions.Name = "toolStripOptions";
			this.toolStripOptions.Size = new System.Drawing.Size(506, 25);
			this.toolStripOptions.Stretch = true;
			this.toolStripOptions.TabIndex = 1;
			this.toolStripOptions.TabStop = true;
			this.toolStripOptions.Text = "toolStripOtions";
			// 
			// toolStripContainerOptions
			// 
			// 
			// toolStripContainerOptions.ContentPanel
			// 
			this.toolStripContainerOptions.ContentPanel.Controls.Add(this.tabControlOptions);
			this.toolStripContainerOptions.ContentPanel.Size = new System.Drawing.Size(506, 398);
			this.toolStripContainerOptions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripContainerOptions.Location = new System.Drawing.Point(0, 0);
			this.toolStripContainerOptions.Name = "toolStripContainerOptions";
			this.toolStripContainerOptions.Size = new System.Drawing.Size(506, 423);
			this.toolStripContainerOptions.TabIndex = 2;
			this.toolStripContainerOptions.Text = "toolStripContainer1";
			// 
			// toolStripContainerOptions.TopToolStripPanel
			// 
			this.toolStripContainerOptions.TopToolStripPanel.Controls.Add(this.toolStripOptions);
			// 
			// labelLeftPanelMinSize
			// 
			this.labelLeftPanelMinSize.AutoSize = true;
			this.labelLeftPanelMinSize.Location = new System.Drawing.Point(56, 153);
			this.labelLeftPanelMinSize.Name = "labelLeftPanelMinSize";
			this.labelLeftPanelMinSize.Size = new System.Drawing.Size(94, 13);
			this.labelLeftPanelMinSize.TabIndex = 3;
			this.labelLeftPanelMinSize.Text = "Left panel min size";
			// 
			// numericUpDownLeftPanelMinSize
			// 
			this.numericUpDownLeftPanelMinSize.Location = new System.Drawing.Point(157, 151);
			this.numericUpDownLeftPanelMinSize.Name = "numericUpDownLeftPanelMinSize";
			this.numericUpDownLeftPanelMinSize.Size = new System.Drawing.Size(79, 20);
			this.numericUpDownLeftPanelMinSize.TabIndex = 4;
			this.numericUpDownLeftPanelMinSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// numericUpDownRightPanelMinSize
			// 
			this.numericUpDownRightPanelMinSize.Location = new System.Drawing.Point(157, 188);
			this.numericUpDownRightPanelMinSize.Name = "numericUpDownRightPanelMinSize";
			this.numericUpDownRightPanelMinSize.Size = new System.Drawing.Size(79, 20);
			this.numericUpDownRightPanelMinSize.TabIndex = 6;
			this.numericUpDownRightPanelMinSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelRightPanelMinSize
			// 
			this.labelRightPanelMinSize.AutoSize = true;
			this.labelRightPanelMinSize.Location = new System.Drawing.Point(56, 190);
			this.labelRightPanelMinSize.Name = "labelRightPanelMinSize";
			this.labelRightPanelMinSize.Size = new System.Drawing.Size(101, 13);
			this.labelRightPanelMinSize.TabIndex = 5;
			this.labelRightPanelMinSize.Text = "Right panel min size";
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(51, 22);
			this.toolStripButtonSave.Text = "Save";
			// 
			// toolStripButtonCancel
			// 
			this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
			this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCancel.Name = "toolStripButtonCancel";
			this.toolStripButtonCancel.Size = new System.Drawing.Size(59, 22);
			this.toolStripButtonCancel.Text = "Cancel";
			this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
			// 
			// OptionsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 423);
			this.Controls.Add(this.toolStripContainerOptions);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Options";
			this.Load += new System.EventHandler(this.OptionsForm_Load);
			this.tabControlOptions.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.toolStripOptions.ResumeLayout(false);
			this.toolStripOptions.PerformLayout();
			this.toolStripContainerOptions.ContentPanel.ResumeLayout(false);
			this.toolStripContainerOptions.TopToolStripPanel.ResumeLayout(false);
			this.toolStripContainerOptions.TopToolStripPanel.PerformLayout();
			this.toolStripContainerOptions.ResumeLayout(false);
			this.toolStripContainerOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeftPanelMinSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRightPanelMinSize)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControlOptions;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ComboBox comboBoxSplitterViewBorderStyle;
		private System.Windows.Forms.Label labelSplitterViewBorderStyle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStrip toolStripOptions;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
		private System.Windows.Forms.ToolStripContainer toolStripContainerOptions;
		private System.Windows.Forms.NumericUpDown numericUpDownRightPanelMinSize;
		private System.Windows.Forms.Label labelRightPanelMinSize;
		private System.Windows.Forms.NumericUpDown numericUpDownLeftPanelMinSize;
		private System.Windows.Forms.Label labelLeftPanelMinSize;
	}
}