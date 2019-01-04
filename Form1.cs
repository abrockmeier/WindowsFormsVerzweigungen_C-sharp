using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsVerzweigungen_C_sharp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Nud_x.Minimum = -1000;
			Nud_x.Maximum = 1000;
			Nud_y.Minimum = -1000;
			Nud_y.Maximum = 1000;
		}

		private void B_if_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			LBL_result.Text = "";
			if (x > 0)
			{
				LBL_result.Text = "x ist größer als 0";
				Nud_x.BackColor = Color.LightSeaGreen;
			}
		}
		private void Nud_x_ValueChanged(object sender, EventArgs e)
		{
		}
		private void Nud_y_ValueChanged(object sender, EventArgs e)
		{
		}

		private void B_if_else_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			if (x > 0)
			{
				LBL_result.Text = "x ist größer als 0";
				Nud_x.BackColor = Color.LightGreen;
			}
			else
			{
				LBL_result.Text = "x ist kleiner als 0 oder gleich 0";
				Nud_x.BackColor = Color.LightBlue;
			}
		}

		private void B_tern_Op_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			LBL_result.Text = x > 0 ? "x > 0" : "x <= 0";
			Nud_x.BackColor = x > 0 ? Color.LightGreen : Color.LightBlue;
		}

		private void B_if_else_if_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			if (x >0)
			{
				LBL_result.Text = "x ist größer als 0";
				Nud_x.BackColor = Color.LightGreen;
			}
			else
			{
				Nud_x.BackColor = Color.LightBlue;
			}
			if (x < 0)
			LBL_result.Text = "x ist kleier als 0";
			else
			LBL_result.Text = "x ist gleich 0";
		}

		private void B_log_AND_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			int y = (int)Nud_y.Value;
			Nud_x.BackColor = Color.White;
			if (x > 0 && y > 0)
			LBL_result.Text = "x und y sind größer als 0";
			else
			LBL_result.Text = "Min. eine der beiden Zahlen ist größer als 0";
		}

		private void B_log_OR_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			int y = (int)Nud_y.Value;
			Nud_x.BackColor = Color.White;
			if (x > 0 || y > 0)
			LBL_result.Text = "x, y oder beide sind größer als 0";
			else
			LBL_result.Text = "Beide Zahlen sind kleiner als 1";
		}

		private void B_log_xOR_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			int y = (int)Nud_y.Value;
			LBL_result.Text = "";
			if (x > 0 ^ y > 0)
				LBL_result.Text = "Nur x oder y ist größer als 0";
		}

		private void B_switch_Click(object sender, EventArgs e)
		{
			int x = (int)Nud_x.Value;
			switch (x)
			{
				case 1:
				case 3:
				case 5:
				case 7:
				case 9:
					LBL_result.Text = "einstellig, ungrade";
					break;
				case 2:
				case 4:
				case 6:
				case 8:
					LBL_result.Text = "einstellig, grade";
					break;
				default:
					LBL_result.Text = "zweistellig (grade und/oder ungrade)";
					break;
			}
		}

		public string s = "";

		private void B_switch2_Click(object sender, EventArgs e)
		{
			s = Convert.ToString(domainUpDown1.SelectedItem);
			Switch_Case(s);

		}

		private string Switch_Case(string s)
		{
			switch (s)
			{
				case "Bordeaux":
					
					LBL_result.Text = s + "Liegt (in Italien) am Mittelmeer";
					return Convert.ToString(LBL_result);
				case "Nizza":
					LBL_result.Text = s + "Liegt (in Italien) am Mittelmeer";
					return Convert.ToString(LBL_result);
				case "Berlin":
					LBL_result.Text = s + "Liegt (in Deutschlang) an der Spree";
					return Convert.ToString(LBL_result);
				default:
					LBL_result.Text = "Keine Stadt ausgewählt!";
					return LBL_result.Text;
			}
		}

		private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
		{
			//LBL_result.Text = Convert.ToString(domainUpDown1.SelectedItem);
		}
	}
}
