namespace ClickerHeroesCalc
{
	partial class frmMain
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
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.dgvHeroes = new System.Windows.Forms.DataGridView();
			this.txtDogcog = new System.Windows.Forms.TextBox();
			this.txtAgraiv = new System.Windows.Forms.TextBox();
			this.txtSensitivity = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtSteps = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.btnImport = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).BeginInit();
			this.SuspendLayout();
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(560, 12);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtOutput.Size = new System.Drawing.Size(529, 405);
			this.txtOutput.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(479, 397);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// dgvHeroes
			// 
			this.dgvHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHeroes.Location = new System.Drawing.Point(12, 12);
			this.dgvHeroes.MultiSelect = false;
			this.dgvHeroes.Name = "dgvHeroes";
			this.dgvHeroes.Size = new System.Drawing.Size(542, 293);
			this.dgvHeroes.TabIndex = 2;
			this.dgvHeroes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHeroes_CellValueChanged);
			// 
			// txtDogcog
			// 
			this.txtDogcog.Location = new System.Drawing.Point(79, 377);
			this.txtDogcog.Name = "txtDogcog";
			this.txtDogcog.Size = new System.Drawing.Size(100, 20);
			this.txtDogcog.TabIndex = 3;
			// 
			// txtAgraiv
			// 
			this.txtAgraiv.Location = new System.Drawing.Point(79, 403);
			this.txtAgraiv.Name = "txtAgraiv";
			this.txtAgraiv.Size = new System.Drawing.Size(100, 20);
			this.txtAgraiv.TabIndex = 4;
			// 
			// txtSensitivity
			// 
			this.txtSensitivity.Location = new System.Drawing.Point(318, 365);
			this.txtSensitivity.Name = "txtSensitivity";
			this.txtSensitivity.Size = new System.Drawing.Size(100, 20);
			this.txtSensitivity.TabIndex = 5;
			this.txtSensitivity.Text = "10000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 377);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Dogcog (-%)";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 403);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Argaiv";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(257, 365);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Sensitivity";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(257, 397);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Steps";
			// 
			// txtSteps
			// 
			this.txtSteps.Location = new System.Drawing.Point(318, 397);
			this.txtSteps.Name = "txtSteps";
			this.txtSteps.Size = new System.Drawing.Size(100, 20);
			this.txtSteps.TabIndex = 9;
			this.txtSteps.Text = "100";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 316);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Import code";
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(79, 311);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(394, 20);
			this.txtCode.TabIndex = 11;
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(479, 311);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(75, 23);
			this.btnImport.TabIndex = 13;
			this.btnImport.Text = "Import";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1101, 429);
			this.Controls.Add(this.btnImport);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSteps);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSensitivity);
			this.Controls.Add(this.txtAgraiv);
			this.Controls.Add(this.txtDogcog);
			this.Controls.Add(this.dgvHeroes);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtOutput);
			this.Name = "frmMain";
			this.Text = "Clicker Heroes Calculator";
			((System.ComponentModel.ISupportInitialize)(this.dgvHeroes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtDogcog;
		private System.Windows.Forms.TextBox txtAgraiv;
		private System.Windows.Forms.TextBox txtSensitivity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.DataGridView dgvHeroes;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtSteps;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnImport;
		public System.Windows.Forms.TextBox txtCode;
	}
}

