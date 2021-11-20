using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class WinForm : Form
	{
		private string path = FileAssembly.File.ExcelFile();

		public WinForm()
		{
			InitializeComponent();
			textBox.ScrollBars = ScrollBars.Vertical;
			textBox.Text = path;
		}

		private void openFileButton_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(path);
			}
			catch (Win32Exception w)
			{
				MessageBox.Show(w.Message, Text);
			}
		}

		private void openFolderButton_Click(object sender, EventArgs e)
		{
			try
			{
				System.Diagnostics.Process.Start(path.Remove(path.Length - 20, 20));
			}
			catch (Win32Exception w)
			{
				MessageBox.Show(w.Message, Text);
			}			
		}

		private void copyButton_Click(object sender, EventArgs e)
		{
			System.Windows.Forms.Clipboard.SetText(path);
		}
	}
}
