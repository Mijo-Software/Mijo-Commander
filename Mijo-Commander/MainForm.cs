using System;
using System.IO;
using System.Windows.Forms;
using MijoCommander;
using MijoCommander.Properties;

namespace Mijo_Commander
{
	public partial class MainForm : Form
  {
		private int splitterWidth = 0;
		private int splitterHeight = 0;

		public MainForm()
    {
			InitializeComponent();
    }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
    private void MainForm_Load(object sender, EventArgs e)
    {
			menuStrip.RenderMode = ToolStripRenderMode.System;

			try
			{
				if (Directory.Exists(Directory.GetCurrentDirectory()))
				{
					foreach (DirectoryInfo directory in new DirectoryInfo(Directory.GetCurrentDirectory()).GetDirectories())
					{
						listViewLeft.Items.Add(directory.Name);
					}
					foreach (FileInfo file in new DirectoryInfo(Directory.GetCurrentDirectory()).GetFiles())
					{
						listViewLeft.Items.Add(file.Name);
					}
					foreach (DirectoryInfo directory in new DirectoryInfo(Directory.GetCurrentDirectory()).GetDirectories())
					{
						listViewRight.Items.Add(directory.Name);
					}
					foreach (FileInfo file in new DirectoryInfo(Directory.GetCurrentDirectory()).GetFiles())
					{
						listViewRight.Items.Add(file.Name);
					}
				}
				else
				{
					MessageBox.Show(
						owner: this,
						text: Resources.msgFolderNotExist,
						caption: Resources.msgError,
						buttons: MessageBoxButtons.OK,
						icon: MessageBoxIcon.Error,
						defaultButton: MessageBoxDefaultButton.Button1);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(
					owner: this,
					text: ex.Message,
					caption: Resources.msgError,
					buttons: MessageBoxButtons.OK,
					icon: MessageBoxIcon.Error,
					defaultButton: MessageBoxDefaultButton.Button1);
			}
			splitterWidth = ClientSize.Width / 2;
			splitterHeight = ClientSize.Height / 2;
			splitContainer.SplitterDistance = ClientSize.Width / 2;
		}

		private void toolStripButtonOptions_Click(object sender, EventArgs e)
		{
			OptionsForm formOptions = new OptionsForm();
			formOptions.ShowDialog();
		}

		private void toolStripButtonSplitterViewBorder0_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitViewBorder0.Checked = true;
			toolStripButtonSplitViewBorder1.Checked = false;
			toolStripButtonSplitViewBorder2.Checked = false;
			toolStripMenuItemSplitViewBorder0.Checked = true;
			toolStripMenuItemSplitViewBorder1.Checked = false;
			toolStripMenuItemSplitViewBorder2.Checked = false;
			toolStripMenuItemViewBorder0.Checked = true;
			toolStripMenuItemViewBorder1.Checked = false;
			toolStripMenuItemViewBorder2.Checked = false;
			splitContainer.BorderStyle = BorderStyle.None;
		}

		private void toolStripButtonSplitterViewBorder1_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitViewBorder0.Checked = false;
			toolStripButtonSplitViewBorder1.Checked = true;
			toolStripButtonSplitViewBorder2.Checked = false;
			toolStripMenuItemViewBorder0.Checked = false;
			toolStripMenuItemViewBorder1.Checked = true;
			toolStripMenuItemViewBorder2.Checked = false;
			toolStripMenuItemSplitViewBorder0.Checked = false;
			toolStripMenuItemSplitViewBorder1.Checked = true;
			toolStripMenuItemSplitViewBorder2.Checked = false;
			splitContainer.BorderStyle = BorderStyle.FixedSingle;
		}

		private void toolStripButtonSplitterViewBorder2_Click(object sender, EventArgs e)
		{
			toolStripMenuItemSplitViewBorder0.Checked = false;
			toolStripMenuItemSplitViewBorder1.Checked = false;
			toolStripMenuItemSplitViewBorder2.Checked = true;
			toolStripMenuItemViewBorder0.Checked = false;
			toolStripMenuItemViewBorder1.Checked = false;
			toolStripMenuItemViewBorder2.Checked = true;
			toolStripButtonSplitViewBorder0.Checked = false;
			toolStripButtonSplitViewBorder1.Checked = false;
			toolStripButtonSplitViewBorder2.Checked = true;
			splitContainer.BorderStyle = BorderStyle.Fixed3D;
		}

		private void toolStripButtonSplitterViewLeftCollapse_Click(object sender, EventArgs e)
		{
			toolStripMenuItemViewLeftCollapse.Checked = true;
			toolStripMenuItemViewRightCollapse.Checked = false;
			toolStripMenuItemViewNoCollapse.Checked = false;
			toolStripMenuItemSplitViewLeftCollapse.Checked = true;
			toolStripMenuItemSplitViewRightCollapse.Checked = false;
			toolStripMenuItemSplitViewNoCollapse.Checked = false;
			toolStripButtonSplitViewLeftCollapse.Checked = true;
			toolStripButtonSplitViewRightCollapse.Checked = false;
			toolStripButtonSplitViewNoCollapse.Checked = false;
			splitContainer.Panel1Collapsed = true;
		}

		private void toolStripButtonSplitterViewRightCollapse_Click(object sender, EventArgs e)
		{
			toolStripMenuItemViewLeftCollapse.Checked = false;
			toolStripMenuItemViewRightCollapse.Checked = true;
			toolStripMenuItemViewNoCollapse.Checked = false;
			toolStripMenuItemSplitViewLeftCollapse.Checked = false;
			toolStripMenuItemSplitViewRightCollapse.Checked = true;
			toolStripMenuItemSplitViewNoCollapse.Checked = false;
			toolStripButtonSplitViewLeftCollapse.Checked = false;
			toolStripButtonSplitViewRightCollapse.Checked = true;
			toolStripButtonSplitViewNoCollapse.Checked = false;
			splitContainer.Panel2Collapsed = true;
		}

		private void toolStripButtonSplitterViewNoCollapse_Click(object sender, EventArgs e)
		{
			toolStripMenuItemViewLeftCollapse.Checked = false;
			toolStripMenuItemViewRightCollapse.Checked = false;
			toolStripMenuItemViewNoCollapse.Checked = true;
			toolStripMenuItemSplitViewLeftCollapse.Checked = false;
			toolStripMenuItemSplitViewRightCollapse.Checked = false;
			toolStripMenuItemSplitViewNoCollapse.Checked = true;
			toolStripButtonSplitViewLeftCollapse.Checked = false;
			toolStripButtonSplitViewRightCollapse.Checked = false;
			toolStripButtonSplitViewNoCollapse.Checked = true;
			splitContainer.Panel1Collapsed = false;
			splitContainer.Panel2Collapsed = false;
		}

		private void toolStripButtonSplitterViewHorizontal_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitViewHorizontal.Checked = true;
			toolStripButtonSplitViewVertical.Checked = false;
			toolStripMenuItemSplitViewHorizontal.Checked = true;
			toolStripMenuItemSplitViewVertical.Checked = false;
			splitContainer.Orientation = Orientation.Vertical;
			//splitContainer.SplitterDistance = ClientSize.Width / 2;
		}

		private void toolStripButtonSplitterViewVertical_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitViewHorizontal.Checked = false;
			toolStripButtonSplitViewVertical.Checked = true;
			toolStripMenuItemSplitViewHorizontal.Checked = false;
			toolStripMenuItemSplitViewVertical.Checked = true;
			splitContainer.Orientation = Orientation.Horizontal;
			//splitContainer.SplitterDistance = ClientSize.Height / 2;
		}

		private void toolStripMenuItemRemoveBar_Click(object sender, EventArgs e)
		{
			toolStripSplitView.Visible = false;
			toolStripMenuItemToolbarSplitView.Checked = false;
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void splitContainer_SplitterMoving(object sender, SplitterCancelEventArgs e)
		{
			if (splitContainer.Orientation == Orientation.Vertical)
			{
				splitContainer.Cursor = Cursors.VSplit;
			}
			else
			{
				splitContainer.Cursor = Cursors.HSplit;
			}
		}

		private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
		{
			splitContainer.Cursor = Cursors.Default;
		}

		private void listViewLeft_Enter(object sender, EventArgs e)
		{
			listViewLeft.BorderStyle = BorderStyle.FixedSingle;
		}

		private void listViewLeft_Leave(object sender, EventArgs e)
		{
			listViewLeft.BorderStyle = BorderStyle.Fixed3D;
		}

		private void listViewRight_Enter(object sender, EventArgs e)
		{
			listViewRight.BorderStyle = BorderStyle.FixedSingle;
		}

		private void listViewRight_Leave(object sender, EventArgs e)
		{
			listViewRight.BorderStyle = BorderStyle.Fixed3D;
		}

		private void toolStripMenuItemToolbarSplitView_Click(object sender, EventArgs e)
		{
			if (toolStripSplitView.Visible)
			{
				toolStripSplitView.Visible = false;
			}
			else
			{
				toolStripSplitView.Visible = true;
			}
		}

		private void toolStripButtonFileWindowGrid_Click(object sender, EventArgs e)
		{
			toolStripButtonFileWindowGrid.Checked = !toolStripButtonFileWindowGrid.Checked;
			toolStripMenuItemViewFileWindowGrid.Checked = !toolStripMenuItemViewFileWindowGrid.Checked;
			toolStripMenuItemFileWindowGrid.Checked = !toolStripMenuItemFileWindowGrid.Checked;
			if (toolStripButtonFileWindowGrid.Checked)
			{
				listViewLeft.GridLines = true;
				listViewRight.GridLines = true;
				toolStripButtonFileWindowGrid.Image = Resources.fatcow_border_inside;
				toolStripMenuItemViewFileWindowGrid.Image = Resources.fatcow_border_inside;
			}
			else
			{
				listViewLeft.GridLines = false;
				listViewRight.GridLines = false;
				toolStripButtonFileWindowGrid.Image = Resources.fatcow_border_0;
				toolStripMenuItemViewFileWindowGrid.Image = Resources.fatcow_border_0;
			}
		}

		private void toolStripButtonFileWindowHeader_Click(object sender, EventArgs e)
		{
			toolStripButtonFileWindowHeader.Checked = !toolStripButtonFileWindowHeader.Checked;
			toolStripMenuItemViewFileWindowHeader.Checked = !toolStripMenuItemViewFileWindowHeader.Checked;
			toolStripMenuItemFileWindowHeader.Checked = !toolStripMenuItemFileWindowHeader.Checked;
			if (toolStripButtonFileWindowHeader.Checked)
			{
				listViewLeft.HeaderStyle = ColumnHeaderStyle.Clickable;
				listViewRight.HeaderStyle = ColumnHeaderStyle.Clickable;
			}
			else
			{
				listViewLeft.HeaderStyle = ColumnHeaderStyle.None;
				listViewRight.HeaderStyle = ColumnHeaderStyle.None;
			}
		}

		private void toolStripButtonFileWindowFullRowSelect_Click(object sender, EventArgs e)
		{
			toolStripButtonFileWindowFullRowSelect.Checked = !toolStripButtonFileWindowFullRowSelect.Checked;
			toolStripMenuItemViewFileWindowFullRow.Checked = !toolStripMenuItemViewFileWindowFullRow.Checked;
			toolStripMenuItemFileWindowFullRow.Checked = !toolStripMenuItemFileWindowFullRow.Checked;
			if (toolStripButtonFileWindowFullRowSelect.Checked)
			{
				listViewLeft.FullRowSelect = true;
				listViewRight.FullRowSelect = true;
				toolStripButtonFileWindowFullRowSelect.Image = Resources.fatcow_table_select_row;
			}
			else
			{
				listViewLeft.FullRowSelect = false;
				listViewRight.FullRowSelect = false;
				toolStripButtonFileWindowFullRowSelect.Image = Resources.fatcow_table_select_cell;
			}
		}

		private void toolStripMenuItemFileWindow_Click(object sender, EventArgs e)
		{
			if (toolStripFileWindow.Visible)
			{
				toolStripFileWindow.Visible = false;
			}
			else
			{
				toolStripFileWindow.Visible = true;
			}
		}

		private void toolStripMenuItemFileWindowRemoveBar_Click(object sender, EventArgs e)
		{
			toolStripFileWindow.Visible = false;
			toolStripMenuItemFileWindow.Checked = false;
		}
  }
}
