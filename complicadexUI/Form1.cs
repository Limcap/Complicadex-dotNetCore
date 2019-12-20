using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using complicadexLib;

namespace simplexUI
{
	public partial class Complicadex : Form
	{
		public Complicadex()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Teste t = new Teste();
			txtInput.Text = t.say();
			t.nome = "s";
			int pos = txtInput.Size.Height + txtInput.Location.Y;
			Console.WriteLine( "bottom Y of txtInput {0}", pos);
		}

		private void txtInput_TextChanged( object sender, EventArgs e )
		{
			// Count how many lines there is in the textbox
			int lines = 1 + txtInput.Text.Count( f => f == '\n' );
			lines = lines > 10 ? 10 : lines;
			// Defines the line height
			int lineHeight = TextRenderer.MeasureText( "H", txtInput.Font ).Height;
			// Defines the padding height
			int padding = 6;
			// Defines textbox height
			txtInput.Height = lineHeight * lines + padding;
			repositionElements();			
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
	}
}
