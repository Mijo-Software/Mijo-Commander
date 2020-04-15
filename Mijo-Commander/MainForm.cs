using System;
using System.Windows.Forms;
using MijoCommander;

namespace Mijo_Commander
{
	public partial class MainForm : Form
  {
		public MainForm()
    {
			InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
			splitContainer.SplitterDistance = ClientSize.Width / 2;
    }

		private void toolStripButtonOptions_Click(object sender, EventArgs e)
		{
			OptionsForm formOptions = new OptionsForm();
			formOptions.ShowDialog();
		}

		private void toolStripButtonSplitterViewBorder0_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitterViewBorder0.Checked = true;
			toolStripButtonSplitterViewBorder1.Checked = false;
			toolStripButtonSplitterViewBorder2.Checked = false;
			toolStripMenuItemSplitterViewBorder0.Checked = true;
			toolStripMenuItemSplitterViewBorder1.Checked = false;
			toolStripMenuItemSplitterViewBorder2.Checked = false;
			toolStripMenuItemViewBorder0.Checked = true;
			toolStripMenuItemViewBorder1.Checked = false;
			toolStripMenuItemViewBorder2.Checked = false;
			splitContainer.BorderStyle = BorderStyle.None;
		}

		private void toolStripButtonSplitterViewBorder1_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitterViewBorder0.Checked = false;
			toolStripButtonSplitterViewBorder1.Checked = true;
			toolStripButtonSplitterViewBorder2.Checked = false;
			toolStripMenuItemViewBorder0.Checked = false;
			toolStripMenuItemViewBorder1.Checked = true;
			toolStripMenuItemViewBorder2.Checked = false;
			toolStripMenuItemSplitterViewBorder0.Checked = false;
			toolStripMenuItemSplitterViewBorder1.Checked = true;
			toolStripMenuItemSplitterViewBorder2.Checked = false;
			splitContainer.BorderStyle = BorderStyle.FixedSingle;
		}

		private void toolStripButtonSplitterViewBorder2_Click(object sender, EventArgs e)
		{
			toolStripMenuItemSplitterViewBorder0.Checked = false;
			toolStripMenuItemSplitterViewBorder1.Checked = false;
			toolStripMenuItemSplitterViewBorder2.Checked = true;
			toolStripMenuItemViewBorder0.Checked = false;
			toolStripMenuItemViewBorder1.Checked = false;
			toolStripMenuItemViewBorder2.Checked = true;
			toolStripButtonSplitterViewBorder0.Checked = false;
			toolStripButtonSplitterViewBorder1.Checked = false;
			toolStripButtonSplitterViewBorder2.Checked = true;
			splitContainer.BorderStyle = BorderStyle.Fixed3D;
		}

		private void toolStripButtonSplitterViewLeftCollapse_Click(object sender, EventArgs e)
		{
			toolStripMenuItemViewLeftCollapse.Checked = true;
			toolStripMenuItemViewRightCollapse.Checked = false;
			toolStripMenuItemViewNoCollapse.Checked = false;
			toolStripMenuItemSplitterViewLeftCollapse.Checked = true;
			toolStripMenuItemSplitterViewRightCollapse.Checked = false;
			toolStripMenuItemSplitterViewNoCollapse.Checked = false;
			toolStripButtonSplitterViewLeftCollapse.Checked = true;
			toolStripButtonSplitterViewRightCollapse.Checked = false;
			toolStripButtonSplitterViewNoCollapse.Checked = false;
			splitContainer.Panel1Collapsed = true;
		}

		private void toolStripButtonSplitterViewRightCollapse_Click(object sender, EventArgs e)
		{
			toolStripMenuItemViewLeftCollapse.Checked = false;
			toolStripMenuItemViewRightCollapse.Checked = true;
			toolStripMenuItemViewNoCollapse.Checked = false;
			toolStripMenuItemSplitterViewLeftCollapse.Checked = false;
			toolStripMenuItemSplitterViewRightCollapse.Checked = true;
			toolStripMenuItemSplitterViewNoCollapse.Checked = false;
			toolStripButtonSplitterViewLeftCollapse.Checked = false;
			toolStripButtonSplitterViewRightCollapse.Checked = true;
			toolStripButtonSplitterViewNoCollapse.Checked = false;
			splitContainer.Panel2Collapsed = true;
		}

		private void toolStripButtonSplitterViewNoCollapse_Click(object sender, EventArgs e)
		{
			toolStripMenuItemViewLeftCollapse.Checked = false;
			toolStripMenuItemViewRightCollapse.Checked = false;
			toolStripMenuItemViewNoCollapse.Checked = true;
			toolStripMenuItemSplitterViewLeftCollapse.Checked = false;
			toolStripMenuItemSplitterViewRightCollapse.Checked = false;
			toolStripMenuItemSplitterViewNoCollapse.Checked = true;
			toolStripButtonSplitterViewLeftCollapse.Checked = false;
			toolStripButtonSplitterViewRightCollapse.Checked = false;
			toolStripButtonSplitterViewNoCollapse.Checked = true;
			splitContainer.Panel1Collapsed = false;
			splitContainer.Panel2Collapsed = false;
		}

		private void toolStripButtonSplitterViewHorizontal_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitterViewHorizontal.Checked = true;
			toolStripButtonSplitterViewVertical.Checked = false;
			toolStripMenuItemSplitterViewHorizontal.Checked = true;
			toolStripMenuItemSplitterViewVertical.Checked = false;
			splitContainer.Orientation = Orientation.Vertical;
		}

		private void toolStripButtonSplitterViewVertical_Click(object sender, EventArgs e)
		{
			toolStripButtonSplitterViewHorizontal.Checked = false;
			toolStripButtonSplitterViewVertical.Checked = true;
			toolStripMenuItemSplitterViewHorizontal.Checked = false;
			toolStripMenuItemSplitterViewVertical.Checked = true;
			splitContainer.Orientation = Orientation.Horizontal;
		}

		private void toolStripMenuItemRemoveBar_Click(object sender, EventArgs e)
		{
			toolStripSplitterView.Visible = false;
		}

		private void toolStripMenuItemExit_Click(object sender, EventArgs e)
		{
			Close();
		}
  }
}
