using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETF_GetKeyCode
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			textBox1.Text = "";
			label1.Text = "";
			label2.Text = "";
			textBox1.Focus();
			MaximizeBox = false;
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (!checkBox1.Checked)
			{
				textBox1.Text = e.KeyCode.ToString();
				label1.Text = e.KeyValue.ToString();
				label2.Text = "0x" + e.KeyValue.ToString("X2");
				e.SuppressKeyPress = true;

			} 
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				textBox1.Text = e.KeyChar.ToString();
				label1.Text = Convert.ToInt32(e.KeyChar).ToString();
				label2.Text = "0x" + Convert.ToInt32(e.KeyChar).ToString("X2");
				e.Handled = true;

			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			textBox1.Text = "";
			label1.Text = "";
			label2.Text = "";
			textBox1.Focus();

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked)
			{
				this.TopMost = true;
			}else
			{
				this.TopMost = false;
			}
		}
	}
}
