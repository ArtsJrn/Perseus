using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MaterialSkin;
using System.Net;
using Newtonsoft.Json;

namespace Perseus
{
	public partial class MainForm : MaterialSkin.Controls.MaterialForm
	{
		public MainForm()
		{
			InitializeComponent();
				Components();
					//Created by 0x999 @v3rmillion.net
		}
		
		private void Components()
		{
			MaterialSkinManager expr_11 = MaterialSkinManager.Instance;
				expr_11.AddFormToManage(this);
					expr_11.Theme = MaterialSkinManager.Themes.DARK;
						expr_11.ColorScheme = new ColorScheme(Primary.Grey900, Primary.Grey900, Primary.Grey500, Accent.LightGreen700, TextShade.WHITE);
			
		}
		
		void MaterialRaisedButton1Click(object sender, EventArgs e)
		{
			if (materialRadioButton1.Checked == false && materialRadioButton2.Checked == false)
			{
				richTextBox1.Text += "ERROR: CHOOSE ONE OF THE GIVEN OPTIONS\n";
			}
			
			if (materialRadioButton1.Checked == true)
			{
				Taken();
			}
		}
		void MaterialRaisedButton2Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
		
		private void Taken()
		{
			var x = "https://www.roblox.com/UserCheck/DoesUsernameExist?username=";
				var i = materialSingleLineTextField1.Text;
					new WebClient().Headers[HttpRequestHeader.ContentType] = "application/json";
						richTextBox1.Text += new WebClient().DownloadString(x+i)
							.Replace("{\"success\":false}", "Username is available")
								.Replace("{\"success\":true}", "Username is not available");
									richTextBox1.Text += "\n";
				
								
		}
		
		private void Stats()
		{
			
		}
	}
}