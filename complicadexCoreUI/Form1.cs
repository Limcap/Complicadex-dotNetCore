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
			txtInput_adjustHeight( 1 );
			repositionElements();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int pos = txtInput.Size.Height + txtInput.Location.Y;
			Console.WriteLine( "bottom Y of txtInput {0}", pos);
		}

		private int lines = 0;
		private void txtInput_TextChanged( object sender, EventArgs e )
		{
			txtInput_adjustHeight( -1 );
			repositionElements();
		}

		private void txtInput_adjustHeight( int lines )
		{
			// Count how many lines there is in the textbox
			lines = lines == -1 ? ( 1 + txtInput.Text.Count(f => f == '\n') ) :  lines;
			if( lines != this.lines )
			{
				this.lines = lines;
				lines = lines > 10 ? 10 : lines;
				// Defines the line height
				int lineHeight = TextRenderer.MeasureText("H", txtInput.Font).Height;
				// Defines the padding height
				int padding = 6;
				// Defines textbox height
				txtInput.Height = lineHeight * lines + padding;
			}
		}



		private void textBoxes_adjustWidth()
		{
			int scrollBarWidth = System.Windows.Forms.SystemInformation.VerticalScrollBarWidth;
			txtInput.Width = this.Width - (txtInput.Margin.All * 2) - (scrollBarWidth * 2);
			txtOutput.Width = this.Width - (txtInput.Margin.All * 2) - (scrollBarWidth * 2);
			//txtOutput.Text = txtInput.Width + " = " + this.Width + " - " + (txtInput.Margin.All * 2) + " - " + scrollBarWidth;
		}





		/// <summary>
		/// Recalculates the position and size of the controls in the form.
		/// </summary>
		private void repositionElements()
		{
			int spaceBetween = 5;
			int y = txtInput.Size.Height + txtInput.Location.Y;
			Console.WriteLine("bottom Y of txtInput {0}", y);
			System.Drawing.Point l = txtOutput.Location;
			l.Y = y + spaceBetween;
			txtOutput.Location = l;
		}

		private void form_sizeChanged(object sender, System.EventArgs e)
		{
			textBoxes_adjustWidth();
			repositionElements();
		}
	}
}
