namespace KMudharQGame
{
	partial class FormDesignGame
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
			menuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			saveToolStripMenuItem = new ToolStripMenuItem();
			closeToolStripMenuItem = new ToolStripMenuItem();
			grpBxGenerate = new GroupBox();
			lblRows = new Label();
			lblColumns = new Label();
			btnGenerate = new Button();
			txtColumns = new TextBox();
			txtRows = new TextBox();
			label1 = new Label();
			grpBxToolBox = new GroupBox();
			pbBoxGreen = new PictureBox();
			pbBoxRed = new PictureBox();
			pbDoorRed = new PictureBox();
			pbWall = new PictureBox();
			pbNone = new PictureBox();
			pbDoorGreen = new PictureBox();
			lblMessage = new Label();
			grpbxGrid = new GroupBox();
			menuStrip.SuspendLayout();
			grpBxGenerate.SuspendLayout();
			grpBxToolBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbBoxGreen).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbBoxRed).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbDoorRed).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbWall).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbNone).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbDoorGreen).BeginInit();
			SuspendLayout();
			// 
			// menuStrip
			// 
			menuStrip.ImageScalingSize = new Size(20, 20);
			menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(800, 28);
			menuStrip.TabIndex = 0;
			menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, closeToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			saveToolStripMenuItem.Size = new Size(224, 26);
			saveToolStripMenuItem.Text = "Save";
			saveToolStripMenuItem.Click += SaveGame;
			// 
			// closeToolStripMenuItem
			// 
			closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			closeToolStripMenuItem.Size = new Size(224, 26);
			closeToolStripMenuItem.Text = "Close";
			closeToolStripMenuItem.Click += Close;
			// 
			// grpBxGenerate
			// 
			grpBxGenerate.Controls.Add(lblRows);
			grpBxGenerate.Controls.Add(lblColumns);
			grpBxGenerate.Controls.Add(btnGenerate);
			grpBxGenerate.Controls.Add(txtColumns);
			grpBxGenerate.Controls.Add(txtRows);
			grpBxGenerate.Location = new Point(0, 31);
			grpBxGenerate.Name = "grpBxGenerate";
			grpBxGenerate.Size = new Size(800, 65);
			grpBxGenerate.TabIndex = 1;
			grpBxGenerate.TabStop = false;
			// 
			// lblRows
			// 
			lblRows.AutoSize = true;
			lblRows.Location = new Point(0, 38);
			lblRows.Name = "lblRows";
			lblRows.Size = new Size(44, 20);
			lblRows.TabIndex = 4;
			lblRows.Text = "Rows";
			// 
			// lblColumns
			// 
			lblColumns.AutoSize = true;
			lblColumns.Location = new Point(285, 20);
			lblColumns.Name = "lblColumns";
			lblColumns.Size = new Size(66, 20);
			lblColumns.TabIndex = 5;
			lblColumns.Text = "Columns";
			// 
			// btnGenerate
			// 
			btnGenerate.BackColor = SystemColors.Control;
			btnGenerate.Location = new Point(549, 15);
			btnGenerate.Name = "btnGenerate";
			btnGenerate.Size = new Size(94, 29);
			btnGenerate.TabIndex = 2;
			btnGenerate.Text = "Generate";
			btnGenerate.UseVisualStyleBackColor = false;
			btnGenerate.Click += btnGenerate_Click;
			// 
			// txtColumns
			// 
			txtColumns.Location = new Point(376, 17);
			txtColumns.Name = "txtColumns";
			txtColumns.Size = new Size(125, 27);
			txtColumns.TabIndex = 1;
			// 
			// txtRows
			// 
			txtRows.Location = new Point(78, 32);
			txtRows.Name = "txtRows";
			txtRows.Size = new Size(125, 27);
			txtRows.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(37, 23);
			label1.Name = "label1";
			label1.Size = new Size(67, 20);
			label1.TabIndex = 2;
			label1.Text = "Tool Box";
			// 
			// grpBxToolBox
			// 
			grpBxToolBox.Controls.Add(pbBoxGreen);
			grpBxToolBox.Controls.Add(pbBoxRed);
			grpBxToolBox.Controls.Add(pbDoorRed);
			grpBxToolBox.Controls.Add(pbWall);
			grpBxToolBox.Controls.Add(pbNone);
			grpBxToolBox.Controls.Add(label1);
			grpBxToolBox.Controls.Add(pbDoorGreen);
			grpBxToolBox.Location = new Point(12, 102);
			grpBxToolBox.Name = "grpBxToolBox";
			grpBxToolBox.Size = new Size(141, 496);
			grpBxToolBox.TabIndex = 3;
			grpBxToolBox.TabStop = false;
			// 
			// pbBoxGreen
			// 
			pbBoxGreen.Image = Properties.Resources.BoxGreen;
			pbBoxGreen.Location = new Point(37, 349);
			pbBoxGreen.Name = "pbBoxGreen";
			pbBoxGreen.Size = new Size(67, 67);
			pbBoxGreen.SizeMode = PictureBoxSizeMode.StretchImage;
			pbBoxGreen.TabIndex = 6;
			pbBoxGreen.TabStop = false;
			pbBoxGreen.Tag = Pictures.BoxGreen;
			pbBoxGreen.Click += SelectImage;
			// 
			// pbBoxRed
			// 
			pbBoxRed.Image = Properties.Resources.BoxRed;
			pbBoxRed.Location = new Point(37, 422);
			pbBoxRed.Name = "pbBoxRed";
			pbBoxRed.Size = new Size(67, 67);
			pbBoxRed.SizeMode = PictureBoxSizeMode.StretchImage;
			pbBoxRed.TabIndex = 7;
			pbBoxRed.TabStop = false;
			pbBoxRed.Tag = Pictures.BoxRed;
			pbBoxRed.Click += SelectImage;
			// 
			// pbDoorRed
			// 
			pbDoorRed.Image = Properties.Resources.DoorRed;
			pbDoorRed.Location = new Point(37, 276);
			pbDoorRed.Name = "pbDoorRed";
			pbDoorRed.Size = new Size(67, 67);
			pbDoorRed.SizeMode = PictureBoxSizeMode.StretchImage;
			pbDoorRed.TabIndex = 5;
			pbDoorRed.TabStop = false;
			pbDoorRed.Tag = Pictures.DoorRed;
			pbDoorRed.Click += SelectImage;
			// 
			// pbWall
			// 
			pbWall.Image = Properties.Resources.Wall;
			pbWall.Location = new Point(37, 130);
			pbWall.Name = "pbWall";
			pbWall.Size = new Size(67, 67);
			pbWall.SizeMode = PictureBoxSizeMode.StretchImage;
			pbWall.TabIndex = 4;
			pbWall.TabStop = false;
			pbWall.Tag = Pictures.Wall;
			pbWall.Click += SelectImage;
			// 
			// pbNone
			// 
			pbNone.BorderStyle = BorderStyle.FixedSingle;
			pbNone.Location = new Point(37, 57);
			pbNone.Name = "pbNone";
			pbNone.Size = new Size(67, 67);
			pbNone.TabIndex = 3;
			pbNone.TabStop = false;
			pbNone.Tag = Pictures.Null;
			pbNone.Click += SelectImage;
			// 
			// pbDoorGreen
			// 
			pbDoorGreen.Image = Properties.Resources.DoorGreen;
			pbDoorGreen.Location = new Point(37, 203);
			pbDoorGreen.Name = "pbDoorGreen";
			pbDoorGreen.Size = new Size(67, 67);
			pbDoorGreen.SizeMode = PictureBoxSizeMode.StretchImage;
			pbDoorGreen.TabIndex = 4;
			pbDoorGreen.TabStop = false;
			pbDoorGreen.Tag = Pictures.DoorGreen;
			pbDoorGreen.Click += SelectImage;
			// 
			// lblMessage
			// 
			lblMessage.AutoSize = true;
			lblMessage.Location = new Point(306, 554);
			lblMessage.Name = "lblMessage";
			lblMessage.Size = new Size(18, 20);
			lblMessage.TabIndex = 6;
			lblMessage.Text = "...";
			// 
			// grpbxGrid
			// 
			grpbxGrid.Location = new Point(187, 102);
			grpbxGrid.Name = "grpbxGrid";
			grpbxGrid.Size = new Size(400, 400);
			grpbxGrid.TabIndex = 7;
			grpbxGrid.TabStop = false;
			// 
			// FormDesignGame
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(800, 626);
			Controls.Add(grpbxGrid);
			Controls.Add(lblMessage);
			Controls.Add(grpBxToolBox);
			Controls.Add(grpBxGenerate);
			Controls.Add(menuStrip);
			ForeColor = SystemColors.ControlText;
			MainMenuStrip = menuStrip;
			Name = "FormDesignGame";
			Text = "QGame Designer";
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			grpBxGenerate.ResumeLayout(false);
			grpBxGenerate.PerformLayout();
			grpBxToolBox.ResumeLayout(false);
			grpBxToolBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbBoxGreen).EndInit();
			((System.ComponentModel.ISupportInitialize)pbBoxRed).EndInit();
			((System.ComponentModel.ISupportInitialize)pbDoorRed).EndInit();
			((System.ComponentModel.ISupportInitialize)pbWall).EndInit();
			((System.ComponentModel.ISupportInitialize)pbNone).EndInit();
			((System.ComponentModel.ISupportInitialize)pbDoorGreen).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem closeToolStripMenuItem;
		private GroupBox grpBxGenerate;
		private Button btnGenerate;
		private TextBox txtColumns;
		private TextBox txtRows;
		private Label label1;
		private GroupBox grpBxToolBox;
		private Label lblRows;
		private Label lblColumns;
		private PictureBox pbWall;
		private PictureBox pbNone;
		private PictureBox pbDoorGreen;
		private PictureBox pbDoorRed;
		private PictureBox pbBoxGreen;
		private PictureBox pbBoxRed;
		private Label lblMessage;
		private GroupBox grpbxGrid;
	}
}