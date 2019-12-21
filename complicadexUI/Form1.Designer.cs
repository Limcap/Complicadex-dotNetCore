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

		

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new MenuStrip();
			this.menu_Arquivo = new ToolStripMenuItem();
			this.menuItem_carregar = new ToolStripMenuItem();
			this.menu_Problemas = new ToolStripMenuItem();
			this.menu_Opcoes = new ToolStripMenuItem();
			this.menu_Resolver = new ToolStripMenuItem();
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
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new ToolStripItem[]
			{
            this.menu_Arquivo,
				this.menu_Problemas,
				this.menu_Opcoes,
				this.menu_Resolver
			});
			this.menuStrip1.Font = new Font("Segoe UI", 10);
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Size = new Size(624, 24);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menu1
			// 
			this.menu_Arquivo.Size = new Size(70, 20);
			this.menu_Arquivo.Text = "Arquivo";
			this.menu_Arquivo.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.menuItem_carregar
			});
			// 
			// menu_Problemas
			// 
			this.menu_Problemas.Size = new Size(70, 20);
			this.menu_Problemas.Text = "Problemas";
			this.menu_Problemas.DropDownItems.AddRange(new ToolStripItem[]
			{
			});
			// 
			// menu_Opcoes
			// 
			this.menu_Opcoes.Size = new Size(70, 20);
			this.menu_Opcoes.Text = "Opções";
			this.menu_Opcoes.DropDownItems.AddRange(new ToolStripItem[]
			{
			});
			// 
			// menu_Resolver
			// 
			this.menu_Resolver.Size = new Size(70, 20);
			this.menu_Resolver.Text = "Resolver";
			// 
			// carregarJSONToolStripMenuItem
			// 
			this.menuItem_carregar.Name = "carregarJSONToolStripMenuItem";
			this.menuItem_carregar.Size = new System.Drawing.Size(180, 24);
			this.menuItem_carregar.Text = "Abrir...";
			// 
			// panel1
			// 
			this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.tableLayoutPanel1);
			this.panel1.Location = new Point(0, 27);
			this.panel1.Size = new Size(624, 392);
			this.panel1.Margin = new Padding(0);
			this.panel1.Name = "panel1";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.Location = new Point(10, 3);
			this.tableLayoutPanel1.Size = new Size(604, 300);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.Controls.Add(this.lblDesc, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.txtDesc, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblInput, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtInput, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblOutput, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.txtOutput, 0, 5);
			// 
			// lblDesc
			// 
			this.lblDesc.Text = "Descrição do problema";
			this.lblDesc.Font = new Font("Noto Sans", 10);
			this.lblDesc.AutoSize = true;
			this.lblDesc.Margin = new Padding(0, 10, 0, 5);
			// 
			// txtDesc
			// 
			this.txtDesc.TabIndex = 1;
			this.txtDesc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.txtDesc.Font = new Font("Noto Mono", 10);
			this.txtDesc.Multiline = true;
			this.txtDesc.Margin = new Padding(0);
			this.txtDesc.TextChanged += new System.EventHandler(this.textbox_adjustHeight);
			// 
			// lblInput
			// 
			this.lblInput.Text = "Modelo linear";
			this.lblInput.Font = new Font("Noto Sans", 10);
			this.lblInput.AutoSize = true;
			this.lblInput.Margin = new Padding(0, 10, 0, 5);
			// 
			// txtInput
			// 
			this.txtInput.TabIndex = 2;
			this.txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.txtInput.Font = new Font("Noto Mono", 10);
			this.txtInput.Multiline = true;
			this.txtInput.Margin = new Padding(0);
			this.txtInput.TextChanged += new System.EventHandler(this.textbox_adjustHeight);
			// 
			// lblOutput
			// 
			this.lblOutput.Text = "Solução";
			this.lblOutput.Font = new Font("Noto Sans", 10);
			this.lblOutput.AutoSize = true;
			this.lblOutput.Margin = new Padding(0, 10, 0, 5);
			// 
			// txtOutput
			// 
			this.txtOutput.TabIndex = 3;
			this.txtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.txtOutput.Font = new Font("Noto Mono", 10);
			this.txtOutput.Multiline = true;
			this.txtOutput.Margin = new Padding(0);
			this.txtOutput.TextChanged += new System.EventHandler(this.textbox_adjustHeight);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 419);
			this.statusStrip1.Size = new System.Drawing.Size(624, 22);
			this.statusStrip1.Text = "statusStrip1";
			// 
			// Complicadex
			// 
			this.AutoScaleDimensions = new SizeF(6, 13);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(624, 441);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new Size(640, 480);
			this.Font = new Font("Segoe UI", 10);
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

		#region Windows Form Designer generated code
		#endregion
		
		private MenuStrip menuStrip1;
		private ToolStripMenuItem menu_Arquivo;
		private ToolStripMenuItem menuItem_carregar;
		private ToolStripMenuItem menu_Problemas;
		private ToolStripMenuItem menu_Opcoes;
		private ToolStripMenuItem menu_Resolver;
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

