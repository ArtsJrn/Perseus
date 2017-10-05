
namespace Perseus
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
		private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
		private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
			this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
			this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
			this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
			this.materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(505, 248);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(505, 248);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.ForeColor = System.Drawing.Color.YellowGreen;
			this.panel1.Location = new System.Drawing.Point(12, 233);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(378, 244);
			this.panel1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new System.Drawing.Font("Menlo", 11.25F);
			this.richTextBox1.ForeColor = System.Drawing.Color.DimGray;
			this.richTextBox1.Location = new System.Drawing.Point(0, 34);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBox1.Size = new System.Drawing.Size(378, 210);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
			this.label1.Font = new System.Drawing.Font("Menlo", 19.25F);
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(378, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "CONSOLE LOG";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// materialSingleLineTextField1
			// 
			this.materialSingleLineTextField1.Depth = 0;
			this.materialSingleLineTextField1.Font = new System.Drawing.Font("Menlo", 11.25F);
			this.materialSingleLineTextField1.ForeColor = System.Drawing.Color.White;
			this.materialSingleLineTextField1.Hint = "ENTER USERNAME HERE";
			this.materialSingleLineTextField1.Location = new System.Drawing.Point(9, 73);
			this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
			this.materialSingleLineTextField1.PasswordChar = '\0';
			this.materialSingleLineTextField1.SelectedText = "";
			this.materialSingleLineTextField1.SelectionLength = 0;
			this.materialSingleLineTextField1.SelectionStart = 0;
			this.materialSingleLineTextField1.Size = new System.Drawing.Size(381, 23);
			this.materialSingleLineTextField1.TabIndex = 2;
			this.materialSingleLineTextField1.UseSystemPasswordChar = false;
			// 
			// materialRadioButton1
			// 
			this.materialRadioButton1.Depth = 0;
			this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialRadioButton1.ForeColor = System.Drawing.Color.White;
			this.materialRadioButton1.Location = new System.Drawing.Point(9, 99);
			this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton1.MouseLocation = new System.Drawing.Point(0, 0);
			this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton1.Name = "materialRadioButton1";
			this.materialRadioButton1.Ripple = true;
			this.materialRadioButton1.Size = new System.Drawing.Size(381, 24);
			this.materialRadioButton1.TabIndex = 3;
			this.materialRadioButton1.Text = "CHECK IF USERNAME IS TAKEN";
			this.materialRadioButton1.UseVisualStyleBackColor = true;
			// 
			// materialRadioButton2
			// 
			this.materialRadioButton2.Depth = 0;
			this.materialRadioButton2.Enabled = false;
			this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialRadioButton2.ForeColor = System.Drawing.Color.White;
			this.materialRadioButton2.Location = new System.Drawing.Point(9, 147);
			this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton2.MouseLocation = new System.Drawing.Point(0, 0);
			this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton2.Name = "materialRadioButton2";
			this.materialRadioButton2.Ripple = true;
			this.materialRadioButton2.Size = new System.Drawing.Size(381, 24);
			this.materialRadioButton2.TabIndex = 4;
			this.materialRadioButton2.Text = "CHECK IF USER IS ONLINE [WORK IN PROCESS]";
			this.materialRadioButton2.UseVisualStyleBackColor = true;
			// 
			// materialRaisedButton1
			// 
			this.materialRaisedButton1.Depth = 0;
			this.materialRaisedButton1.FlatAppearance.BorderSize = 0;
			this.materialRaisedButton1.Font = new System.Drawing.Font("Menlo", 10F);
			this.materialRaisedButton1.ForeColor = System.Drawing.Color.White;
			this.materialRaisedButton1.Location = new System.Drawing.Point(12, 204);
			this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton1.Name = "materialRaisedButton1";
			this.materialRaisedButton1.Primary = true;
			this.materialRaisedButton1.Size = new System.Drawing.Size(213, 23);
			this.materialRaisedButton1.TabIndex = 5;
			this.materialRaisedButton1.Text = "CHECK ACCOUNT";
			this.materialRaisedButton1.UseVisualStyleBackColor = true;
			this.materialRaisedButton1.Click += new System.EventHandler(this.MaterialRaisedButton1Click);
			// 
			// materialRaisedButton2
			// 
			this.materialRaisedButton2.Depth = 0;
			this.materialRaisedButton2.FlatAppearance.BorderSize = 0;
			this.materialRaisedButton2.Font = new System.Drawing.Font("Menlo", 10F);
			this.materialRaisedButton2.ForeColor = System.Drawing.Color.White;
			this.materialRaisedButton2.Location = new System.Drawing.Point(231, 204);
			this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRaisedButton2.Name = "materialRaisedButton2";
			this.materialRaisedButton2.Primary = true;
			this.materialRaisedButton2.Size = new System.Drawing.Size(159, 23);
			this.materialRaisedButton2.TabIndex = 6;
			this.materialRaisedButton2.Text = "CLEAR CONSOLE";
			this.materialRaisedButton2.UseVisualStyleBackColor = true;
			this.materialRaisedButton2.Click += new System.EventHandler(this.MaterialRaisedButton2Click);
			// 
			// materialRadioButton3
			// 
			this.materialRadioButton3.Depth = 0;
			this.materialRadioButton3.Font = new System.Drawing.Font("Roboto", 10F);
			this.materialRadioButton3.ForeColor = System.Drawing.Color.White;
			this.materialRadioButton3.Location = new System.Drawing.Point(9, 123);
			this.materialRadioButton3.Margin = new System.Windows.Forms.Padding(0);
			this.materialRadioButton3.MouseLocation = new System.Drawing.Point(0, 0);
			this.materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialRadioButton3.Name = "materialRadioButton3";
			this.materialRadioButton3.Ripple = true;
			this.materialRadioButton3.Size = new System.Drawing.Size(381, 24);
			this.materialRadioButton3.TabIndex = 7;
			this.materialRadioButton3.Text = "CHECK STATS [YOUR ACCOUNT]";
			this.materialRadioButton3.UseVisualStyleBackColor = true;
			this.materialRadioButton3.CheckedChanged += new System.EventHandler(this.MaterialRadioButton3CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.ClientSize = new System.Drawing.Size(401, 489);
			this.Controls.Add(this.materialRadioButton3);
			this.Controls.Add(this.materialRaisedButton2);
			this.Controls.Add(this.materialRaisedButton1);
			this.Controls.Add(this.materialRadioButton2);
			this.Controls.Add(this.materialRadioButton1);
			this.Controls.Add(this.materialSingleLineTextField1);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Sizable = false;
			this.Text = "Perseus";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
