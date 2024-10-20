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
	public partial class FormDesignGame : Form
	{
		private Bitmap? SelectedImage { get; set; }
		private object? SelectedImageTag { get; set; }
		private bool gridGenerated = false;

		enum Pictures
		{
			Null,
			Wall,
			DoorGreen,
			DoorRed,
			BoxGreen,
			BoxRed
		}

		public FormDesignGame()
		{
			InitializeComponent();
		}

		private void GenerateBoxes(int rows, int columns)
		{
			if (gridGenerated) { grpbxGrid.Controls.Clear(); gridGenerated = false; }
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					PictureBox pictureBox = new PictureBox();
					pictureBox.Name = $"pb{i}{j}";
					pictureBox.Size = new Size(100, 100);
					pictureBox.Location = new Point(100 * j, 100 * i);
					pictureBox.BorderStyle = BorderStyle.FixedSingle;
					pictureBox.Click += SetImage;
					pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
					pictureBox.Image = null;
					grpbxGrid.Controls.Add(pictureBox);
				}
			}
			gridGenerated = true;
		}

		private void SetImage(object sender, EventArgs e)
		{
			PictureBox selectedBox = (PictureBox)sender;
			selectedBox.Image = SelectedImage;
			selectedBox.Tag = SelectedImageTag;
			lblMessage.Text = $"{selectedBox.Tag}";
		}

		private void SaveGame(object? sender = null, EventArgs? e = null)
		{
			MessageBox.Show("Game saved", "QGame");
			using (StreamWriter writer = new StreamWriter("../../../Resources/design.txt", append: false))
			{
				foreach (PictureBox pb in grpbxGrid.Controls)
				{
					writer.WriteLine($"{(int)(pb.Tag ?? Pictures.Null)}");
				}
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			if (gridGenerated)
			{
				DialogResult result = MessageBox.Show("Do you want to design a new level? \nYour current design would be lost.", "QGame Warnings", MessageBoxButtons.YesNo);
				if (result == DialogResult.No) return;
			}
			try
			{
				int rows = int.Parse(txtRows.Text);
				int columns = int.Parse(txtColumns.Text);

				if (rows + columns < Math.Max(rows, columns)) throw new Exception("Enter positive values for rows and columns.");
				if (Math.Max(rows, columns) > 10) throw new OverflowException("Maximum rows and columns must be 10.");
				GenerateBoxes(rows, columns);
			}
			catch (FormatException ex)
			{
				MessageBox.Show("Please provide valid data for rows and columns. (Both must be integers)" + ex.Message, "QGame Errors");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "QGame Errors");
			}
		}

		private void SelectImage(object sender, EventArgs e)
		{
			PictureBox selectedBox = (PictureBox)sender;
			SelectedImage = (Bitmap)selectedBox.Image;
			SelectedImageTag = selectedBox.Tag;
		}

		private void Close(object sender, EventArgs e)
		{
			if (gridGenerated)
			{
				DialogResult result = MessageBox.Show("Do you want to save this design?", "QGame Close", MessageBoxButtons.YesNo);
				if (result == DialogResult.Yes) SaveGame();
			}
			Application.Exit();
		}
	}
}

