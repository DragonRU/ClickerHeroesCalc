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

		public double Dogcog;
		public double Agraiv;

		public frmMain()
		{
			InitializeComponent();
			dgvHeroes.DataSource = Pos.Heroes;
			dgvHeroes.Columns[0].Width = 50;
			dgvHeroes.Columns[4].Visible = false;
			dgvHeroes.Columns[5].Visible = false;
			txtCode.Text = Pos.SaveCode();
		}


		private void btnStart_Click(object sender, EventArgs e)
		{
			txtOutput.Text = "";
			int TotalSteps = 5000;
			if (!(int.TryParse(txtSteps.Text, out Steps)))
				Steps = 100;
			if (!(double.TryParse(txtSensitivity.Text, out Sensitivity)))
				Sensitivity = 10000;
			if (!(double.TryParse(txtDogcog.Text, out Dogcog)))
				Dogcog = 0;
			if (!(double.TryParse(txtAgraiv.Text, out Agraiv)))
				Agraiv = 0;

			Pos.Heroes.ForEach(x => x.SetAncientLevels(Agraiv, Dogcog));

			Position PosTmp = new Position(Pos);
			for (int i = 1; i <= TotalSteps; i++)
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
					Steps--;
					txtOutput.Text += string.Format("{0} - Lvl {1} - {2:e4} - {3:e4} (Ratio {4:e4}) {5}", 
						PosTmp.Heroes[hInd].Name, PosTmp.Heroes[hInd].CurrentLevel, DPSIncrease, Cost, DPSIncrease * Pos.GlobalDPSMult / Cost, Environment.NewLine);
					if (Steps == 0)
						return;
				}
			}
		}

		private void dgvHeroes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			txtCode.Text = Pos.SaveCode();
		}

		private void btnImport_Click(object sender, EventArgs e)
		{
			Pos.LoadCode(txtCode.Text);
			dgvHeroes.Refresh();
		}
	}
}
