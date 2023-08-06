namespace Form_Minimal_Height_Is_Greater_Than_Zero
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(0, 0);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 24);
			textBox1.TabIndex = 0;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 17F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(302, 10);
			Controls.Add(textBox1);
			Font = new Font("Courier New", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
	}
}