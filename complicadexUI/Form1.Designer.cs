using System.Windows.Forms;
using System.Drawing;

namespace simplexUI
{
	partial class Complicadex
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new MenuStrip();
			this.menu1 = new ToolStripMenuItem();
			this.panel1 = new Panel();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.lblDesc = new Label();
			this.txtDesc = new TextBox();
			this.lblInput = new Label();
			this.txtInput = new TextBox();
			this.lblOutput = new Label();
			this.txtOutput = new TextBox();
			this.statusStrip1 = new StatusStrip();
			this.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.lblDesc, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtDesc, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblInput, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblOutput, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtOutput, 0, 5);
			this.tableLayoutPanel1.Location = new Point(12, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.Size = new Size(600, 300);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.menu1});
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(624, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menu
			// 
			this.menu1.Size = new Size(70, 20);
			this.menu1.Text = "Arquivo";
			// 
			// panel1
			// 
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Location = new Point(0, 24);
			this.panel1.Margin = new Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(624, 395);
			this.panel1.TabIndex = 8;
			// 
			// lblDesc
			// 
			this.lblDesc.AutoSize = true;
			this.lblDesc.Font = new Font("Noto Sans", 10);
			this.lblDesc.Location = new Point(3, 0);
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.Size = new Size(65, 18);
			this.lblDesc.Text = "Descrição";
			// 
			// txtDesc
			// 
			this.txtDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.txtDesc.Font = new Font("Noto Mono", 10, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.txtDesc.Multiline = true;
			this.txtDesc.TextChanged += new System.EventHandler(this.textbox_adjustHeight);
			this.txtDesc.TabIndex = 1;
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Font = new Font("Noto Sans", 10, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.lblInput.Margin = new Padding(0, 10, 0, 0);
			this.lblInput.Text = "Funções de modelagem";
			// 
			// txtInput
			// 
			this.txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.txtInput.Font = new Font("Noto Mono", 10, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.txtInput.Multiline = true;
			this.txtInput.TextChanged += new System.EventHandler(this.textbox_adjustHeight);
			this.txtInput.TabIndex = 2;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Font = new Font("Noto Sans", 10, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.lblOutput.Margin = new Padding(0, 10, 0, 0);
			this.lblOutput.Text = "Solução";
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.txtOutput.Font = new Font("Noto Mono", 10, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
			this.txtOutput.Multiline = true;
			this.txtOutput.TextChanged += new System.EventHandler(this.textbox_adjustHeight);
			this.txtOutput.TabIndex = 3;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(624, 22);
			this.statusStrip1.TabIndex = 9;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Complicadex
			// 
			this.AutoScaleDimensions = new SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(624, 441);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new Size(640, 480);
			this.Name = "Complicadex";
			this.Text = "Complicadex";
			
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);

			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem menu1;

		private Panel panel1;
		private TableLayoutPanel tableLayoutPanel1;
		
		private Label lblDesc;
		private TextBox txtDesc;
		private Label lblInput;
		private TextBox txtInput;
		private Label lblOutput;
		private TextBox txtOutput;
		
		private StatusStrip statusStrip1;
	}
}

