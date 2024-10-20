using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMudharQGame
{
	public partial class FormControlPanel : Form
	{
		public FormControlPanel()
		{
			InitializeComponent();
		}

		private void btnDesign_Click(object sender, EventArgs e)
		{
			FormDesignGame formDesignGame = new FormDesignGame();
			formDesignGame.Show();

		}

		private void btnExit_Click(object sender, EventArgs e) => Application.Exit();
	}
}
