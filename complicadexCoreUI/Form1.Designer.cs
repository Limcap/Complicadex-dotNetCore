using System.Windows.Forms;
using System.Drawing;
namespace complicadexCoreUI
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		// private void InitializeComponent()
		// {
		// 	this.components = new System.ComponentModel.Container();
		// 	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		// 	this.ClientSize = new System.Drawing.Size(800, 450);
		// 	this.Text = "Form1";
		// }

		#endregion

		private void InitializeComponent()
		{
			this.lblModel = new Label();
			this.lblDescription = new Label();
			this.button1 = new Button();
			this.txtInput = new TextBox();
			this.txtOutput = new TextBox();
			this.menuStrip1 = new MenuStrip();
			this.menu1 = new ToolStripMenuItem();
			this.menu2 = new ToolStripMenuItem();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new Size(624, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Items.AddRange(new ToolStripItem[] {
				this.menu1, this.menu2
			});
			// 
			// menu1
			// 
			this.menu1.Size = new Size(70, 20);
			this.menu1.Text = "Arquivo";
			// 
			// menu2
			// 
			this.menu2.Size = new Size(70, 20);
			this.menu2.Text = "Problemas";
			// 
			// lblDescription
			// 
			this.lblDescription.AutoSize = true;
			this.lblDescription.Font = new Font("Noto Mono", 10, FontStyle.Regular, GraphicsUnit.Point);
			this.lblDescription.Location = new Point(10, 48);
			this.lblDescription.Margin = new Padding(5, 0, 5, 0);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new Size(127, 16);
			this.lblDescription.TabIndex = 4;
			this.lblDescription.Text = "Descrição do Problema";
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Font = new Font("Noto Mono", 10, FontStyle.Regular, GraphicsUnit.Point);
			this.lblModel.Location = new Point(10, 48);
			this.lblModel.Margin = new Padding(5, 0, 5, 0);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new Size(127, 16);
			this.lblModel.TabIndex = 4;
			this.lblModel.Text = "Funções de modelagem";
			// 
			// txtInput
			// 
			this.txtInput.Font = new Font("Noto Mono", 10, FontStyle.Regular, GraphicsUnit.Point);
			this.txtInput.Location = new Point(10, 70);
			this.txtInput.Margin = new Padding(10);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new Size(579, 88);
			this.txtInput.TabIndex = 2;
			this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
			// 
			// txtOutput
			// 
			this.txtOutput.Font = new Font("Noto Mono", 10, FontStyle.Regular, GraphicsUnit.Point);
			this.txtOutput.Location = new Point(10, 168);
			this.txtOutput.Margin = new Padding(10);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new Size(579, 113);
			this.txtOutput.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new Point(10, 450);
			this.button1.Margin = new Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new Size(175, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.AutoScroll = true;
			this.VScroll = true;
			this.ClientSize = new Size(624, 441);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.lblModel);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new Padding(4, 3, 4, 3);
			this.MinimumSize = new Size(640, 480);
			this.Name = "Form1";
			this.Text = "Complicadex";
			this.ResizeEnd += new System.EventHandler(this.form_sizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		private Button button1;
		private TextBox txtInput;
		private Label lblModel;
		private Label lblDescription;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem menu1;
		private ToolStripMenuItem menu2;
		private TextBox txtOutput;
	}
}

