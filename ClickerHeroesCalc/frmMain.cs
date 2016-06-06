using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickerHeroesCalc
{
	public partial class frmMain : Form
	{
		public Position Pos = new Position();

		public int Steps;
		public double Sensitivity;

		public frmMain()
		{
			InitializeComponent();
			dgvHeroes.DataSource = Pos.Heroes;
			dgvHeroes.Columns[0].Width = 50;
			dgvHeroes.Columns[4].Visible = false;
		}


		private void btnStart_Click(object sender, EventArgs e)
		{
			txtOutput.Text = "";
			if (!(int.TryParse(txtSteps.Text, out Steps)))
				Steps = 3000;
			if (!(double.TryParse(txtSensitivity.Text, out Sensitivity)))
				Sensitivity = 10000;
			Position PosTmp = new Position(Pos);
			for (int i = 1; i <= Steps; i++)
			{
				int ID;
				int Type;
				double Cost;
				double DPSIncrease;
				PosTmp.NextStep(out ID, out Type, out DPSIncrease, out Cost);

				int hInd = PosTmp.Heroes.FindIndex(x => x.ID == ID);
				if (Type == 1)
				{
					PosTmp.Heroes[hInd].CurrentLevel++;
				}
				if (Type == 2)
				{
					PosTmp.Heroes[hInd].CurrentLevel = PosTmp.Heroes[hInd].NextCheckpoint();
				}
				if (Type == 3)
				{
					PosTmp.Heroes[hInd].CurrentLevel = PosTmp.Heroes[hInd].NextCheckpoint1K();
				}
				if (DPSIncrease * Sensitivity > PosTmp.GlobalDPS)
				{
					txtOutput.Text += string.Format("{0} - Lvl {1} - {2:e4} - {3:e4} (Ratio {4:e4}) {5}", PosTmp.Heroes[hInd].Name, PosTmp.Heroes[hInd].CurrentLevel, DPSIncrease, Cost, DPSIncrease / Cost, Environment.NewLine);
				}


			}
		}
	}
}
