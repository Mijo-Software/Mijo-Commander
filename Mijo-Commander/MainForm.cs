using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using MijoCommander.Properties;

namespace MijoCommander
{
	public partial class MainForm : Form
  {
		private int splitterWidth = 0;
		private int splitterHeight = 0;
		private string fullPathLeft;
		private string fullPathRight;

		#region own methods

		[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
		public static extern uint GetShortPathName(string lpszLongPath, StringBuilder lpszShortPath, uint cchBuffer);

		private static string GetShortPath(string longPath)
		{
			StringBuilder shortPath = new StringBuilder(255);
			GetShortPathName(longPath, shortPath, 255);
			return shortPath.ToString();
		}

		private void UpdateListLeftView()
		{
			if (Directory.Exists(".."))
			{
				listViewLeft.Items.Add("..");
			}
			try
			{
				if (Directory.Exists(fullPathLeft))
				{
					foreach (DirectoryInfo directory in new DirectoryInfo(fullPathLeft).GetDirectories())
					{
						listViewLeft.Items.Add(directory.Name);
					}
					foreach (FileInfo file in new DirectoryInfo(fullPathLeft).GetFiles())
					{
						listViewLeft.Items.Add(file.Name);
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
		}

		private void UpdateListRightView()
		{
			if (Directory.Exists(".."))
			{
				listViewRight.Items.Add("..");
			}
			try
			{
				if (Directory.Exists(fullPathRight))
				{
					foreach (DirectoryInfo directory in new DirectoryInfo(fullPathRight).GetDirectories())
					{
						listViewRight.Items.Add(directory.Name);
					}
					foreach (FileInfo file in new DirectoryInfo(fullPathRight).GetFiles())
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
		}

		#endregion

		#region Constructor

		public MainForm()
    {
			InitializeComponent();
    }

		#endregion

		#region MainForm* event handlers

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions")]
    private void MainForm_Load(object sender, EventArgs e)
    {
			toolStripStatusLabelInfo.Text = "";
			// avoid flicking on listviews
			listViewLeft
				.GetType()
				.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
				.SetValue(listViewLeft, true, null);
			listViewRight
				.GetType()
				.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
				.SetValue(listViewRight, true, null);
			// get current directory
			fullPathLeft = Directory.GetCurrentDirectory();
			fullPathRight = Directory.GetCurrentDirectory();

			UpdateListLeftView();
			UpdateListRightView();

			splitterWidth = ClientSize.Width / 2;
			splitterHeight = ClientSize.Height / 2;
			splitContainer.SplitterDistance = ClientSize.Width / 2;
		}

		#endregion

		#region Click event handlers

		private void Options_Click(object sender, EventArgs e)
		{
			OptionsForm formOptions = new OptionsForm();
			formOptions.ShowDialog();
		}

		private void SplitterViewBorder0_Click(object sender, EventArgs e)
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

		private void SplitterViewBorder1_Click(object sender, EventArgs e)
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

		private void SplitterViewBorder2_Click(object sender, EventArgs e)
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

		private void SplitterViewLeftCollapse_Click(object sender, EventArgs e)
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

		private void SplitterViewRightCollapse_Click(object sender, EventArgs e)
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

		private void SplitterViewNoCollapse_Click(object sender, EventArgs e)
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

		private void SplitterViewHorizontal_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitViewHorizontal.Checked = true;
			toolStripButtonSplitViewVertical.Checked = false;
			toolStripMenuItemSplitViewHorizontal.Checked = true;
			toolStripMenuItemSplitViewVertical.Checked = false;
			splitContainer.Orientation = Orientation.Vertical;
			//splitContainer.SplitterDistance = ClientSize.Width / 2;
		}

		private void SplitterViewVertical_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitViewHorizontal.Checked = false;
			toolStripButtonSplitViewVertical.Checked = true;
			toolStripMenuItemSplitViewHorizontal.Checked = false;
			toolStripMenuItemSplitViewVertical.Checked = true;
			splitContainer.Orientation = Orientation.Horizontal;
			//splitContainer.SplitterDistance = ClientSize.Height / 2;
		}

		private void RemoveBarSplitView_Click(object sender, EventArgs e)
		{
			toolStripSplitView.Visible = false;
			toolStripMenuItemToolbarSplitView.Checked = false;
		}

		private void ToolbarSplitView_Click(object sender, EventArgs e)
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

		private void FileWindowGrid_Click(object sender, EventArgs e)
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

		private void FileWindowHeader_Click(object sender, EventArgs e)
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

		private void FileWindowFullRowSelect_Click(object sender, EventArgs e)
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

		private void FileWindow_Click(object sender, EventArgs e)
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

		private void RemoveBarFileWindow_Click(object sender, EventArgs e)
		{
			toolStripFileWindow.Visible = false;
			toolStripMenuItemFileWindow.Checked = false;
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion

		#region DoubleClick event handlers

		private void ListViewLeft_DoubleClick(object sender, EventArgs e)
		{
			if (listViewLeft.SelectedIndices.Count > 0)
			{
				int selectedIndex = listViewLeft.SelectedIndices[0];
				if (listViewLeft.SelectedItems[0].Text == "..")
				{
					fullPathLeft = Directory.GetParent(fullPathLeft).ToString();
					listViewLeft.Items.Clear();
					UpdateListLeftView();
				}
				else if (Directory.Exists(Path.Combine(fullPathLeft, listViewLeft.SelectedItems[0].Text)))
				{
					fullPathLeft = Path.Combine(fullPathLeft, listViewLeft.SelectedItems[0].Text);
					listViewLeft.Items.Clear();
					UpdateListLeftView();
				}
				else
				{
					System.Diagnostics.Process.Start(Path.Combine(fullPathLeft, listViewLeft.SelectedItems[0].Text));
				}
			}
		}

		private void ListViewRight_DoubleClick(object sender, EventArgs e)
		{
			if (listViewRight.SelectedIndices.Count > 0)
			{
				int selectedIndex = listViewRight.SelectedIndices[0];
				if (listViewRight.SelectedItems[0].Text == "..")
				{
					fullPathRight = Directory.GetParent(fullPathRight).ToString();
					listViewRight.Items.Clear();
					UpdateListRightView();
				}
				else if (Directory.Exists(Path.Combine(fullPathRight, listViewRight.SelectedItems[0].Text)))
				{
					fullPathRight = Path.Combine(fullPathRight, listViewRight.SelectedItems[0].Text);
					listViewRight.Items.Clear();
					UpdateListRightView();
				}
				else
				{
					System.Diagnostics.Process.Start(Path.Combine(fullPathRight, listViewRight.SelectedItems[0].Text));
				}
			}
		}

		#endregion

		#region Splitter event handlers

		private void SplitContainer_SplitterMoving(object sender, SplitterCancelEventArgs e)
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

		private void SplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
		{
			splitContainer.Cursor = Cursors.Default;
		}

		#endregion

		#region Enter event handlers

		private void ListViewLeft_Enter(object sender, EventArgs e)
		{
		}

		private void ListViewRight_Enter(object sender, EventArgs e)
		{
		}

		#endregion

		#region Leave event handlers

		private void ListViewLeft_Leave(object sender, EventArgs e)
		{
		}

		private void ListViewRight_Leave(object sender, EventArgs e)
		{
		}

		#endregion

		#region SelectedIndexChanged even handlers

		private void ListViewLeft_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewLeft.SelectedIndices.Count > 0)
			{
				int selectedIndex = listViewLeft.SelectedIndices[0];
				toolStripStatusLabelInfo.Text = GetShortPath(fullPathLeft) + Path.DirectorySeparatorChar + listViewLeft.Items[selectedIndex].Text;
			}
		}

		private void ListViewRight_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewRight.SelectedIndices.Count > 0)
			{
				int selectedIndex = listViewRight.SelectedIndices[0];
				toolStripStatusLabelInfo.Text = GetShortPath(fullPathRight) + Path.DirectorySeparatorChar + listViewRight.Items[selectedIndex].Text;
			}
		}

		#endregion
  }
}
