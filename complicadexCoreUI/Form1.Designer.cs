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
			this.button1 = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lblModel = new System.Windows.Forms.Label();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(624, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.menu1
			});
			// 
			// exemplosToolStripMenuItem
			// 
			this.menu1.Name = "exemplosToolStripMenuItem";
			this.menu1.Size = new System.Drawing.Size(70, 20);
			this.menu1.Text = "Exemplos";
			// 
			// lblModel
			// 
			this.lblModel.AutoSize = true;
			this.lblModel.Font = new System.Drawing.Font("Noto Mono", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblModel.Location = new System.Drawing.Point(10, 48);
			this.lblModel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblModel.Name = "lblModel";
			this.lblModel.Size = new System.Drawing.Size(127, 16);
			this.lblModel.TabIndex = 4;
			this.lblModel.Text = "Função Objetivo";
			// 
			// txtInput
			// 
			this.txtInput.Font = new System.Drawing.Font("Noto Mono", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtInput.Location = new System.Drawing.Point(10, 70);
			this.txtInput.Margin = new System.Windows.Forms.Padding(10);
			this.txtInput.Multiline = true;
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(579, 88);
			this.txtInput.TabIndex = 2;
			this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
			// 
			// txtOutput
			// 
			this.txtOutput.Font = new System.Drawing.Font("Noto Mono", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtOutput.Location = new System.Drawing.Point(10, 168);
			this.txtOutput.Margin = new System.Windows.Forms.Padding(10);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(579, 113);
			this.txtOutput.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(10, 450);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(175, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.VScroll = true;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.lblModel);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "Form1";
			this.Text = "Complicadex";
			this.ResizeEnd += new System.EventHandler(this.form_sizeChanged);
			this.ResumeLayout(false);
			this.PerformLayout();

		}


		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Label lblModel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menu1;
		private System.Windows.Forms.TextBox txtOutput;
	}
}

