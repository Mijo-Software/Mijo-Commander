using System;
using System.Windows.Forms;

namespace MijoCommander
{
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();
		}

		private void OptionsForm_Load(object sender, EventArgs e)
		{
			comboBoxSplitterViewBorderStyle.SelectedIndex = 0;
		}

		private void toolStripButtonCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
