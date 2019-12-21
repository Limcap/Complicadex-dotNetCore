using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace complicadexCoreUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textbox_adjustHeight(txtDesc);
			textbox_adjustHeight(txtInput);
			textbox_adjustHeight(txtOutput);
		}

		private void textbox_adjustHeight(TextBox box)
		{
			// Count how many lines there is in the textbox
			int lines = box.Text.Count(f => f == '\n');
			lines = lines < 2 ? 2 : (lines + 1);
			// Defines the line height
			int lineHeight = TextRenderer.MeasureText("A", box.Font).Height;
			// Defines the padding height
			int padding = 6;
			// Defines textbox height
			box.Height = lineHeight * lines + padding;
		}

		private void textbox_adjustHeight(object sender, EventArgs e)
		{
			textbox_adjustHeight((TextBox)sender);
		}
	}
}
