namespace KMudharQGame
{
	partial class FormControlPanel
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
			btnDesign = new Button();
			btnPlay = new Button();
			btnExit = new Button();
			SuspendLayout();
			// 
			// btnDesign
			// 
			btnDesign.Location = new Point(187, 59);
			btnDesign.Name = "btnDesign";
			btnDesign.Size = new Size(94, 29);
			btnDesign.TabIndex = 0;
			btnDesign.Text = "Design";
			btnDesign.UseVisualStyleBackColor = true;
			btnDesign.Click += btnDesign_Click;
			// 
			// btnPlay
			// 
			btnPlay.Location = new Point(304, 59);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(94, 29);
			btnPlay.TabIndex = 1;
			btnPlay.Text = "Play";
			btnPlay.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			btnExit.Location = new Point(241, 94);
			btnExit.Name = "btnExit";
			btnExit.Size = new Size(94, 29);
			btnExit.TabIndex = 2;
			btnExit.Text = "Exit";
			btnExit.UseVisualStyleBackColor = true;
			btnExit.Click += btnExit_Click;
			// 
			// FormControlPanel
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnExit);
			Controls.Add(btnPlay);
			Controls.Add(btnDesign);
			Name = "FormControlPanel";
			Text = "QGame Control Panel";
			ResumeLayout(false);
		}

		#endregion

		private Button btnDesign;
		private Button btnPlay;
		private Button btnExit;
	}
}