namespace _10.C_sharp_Increase_Decrease
{
	partial class Form1
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.label3.Location = new System.Drawing.Point(830, 646);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 63);
			this.label3.TabIndex = 15;
			this.label3.Text = "++x";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.label2.Location = new System.Drawing.Point(133, 637);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 63);
			this.label2.TabIndex = 14;
			this.label2.Text = "x++";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.label1.Location = new System.Drawing.Point(415, 145);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 63);
			this.label1.TabIndex = 13;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.richTextBox2.Location = new System.Drawing.Point(680, 129);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(397, 504);
			this.richTextBox2.TabIndex = 12;
			this.richTextBox2.Text = "";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.richTextBox1.Location = new System.Drawing.Point(12, 130);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(397, 504);
			this.richTextBox1.TabIndex = 11;
			this.richTextBox1.Text = "";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.button3.Location = new System.Drawing.Point(680, 9);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(398, 114);
			this.button3.TabIndex = 10;
			this.button3.Text = "Increase,Show";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.button2.Location = new System.Drawing.Point(415, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(259, 114);
			this.button2.TabIndex = 9;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
			this.button1.Location = new System.Drawing.Point(11, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(398, 114);
			this.button1.TabIndex = 8;
			this.button1.Text = "Show,Increase";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1119, 749);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}

