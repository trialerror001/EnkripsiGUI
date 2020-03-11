namespace EnkripsiGUI
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
			this.btnEnkripsi = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDekripsi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEnkripsi
			// 
			this.btnEnkripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEnkripsi.Location = new System.Drawing.Point(9, 96);
			this.btnEnkripsi.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.btnEnkripsi.Name = "btnEnkripsi";
			this.btnEnkripsi.Size = new System.Drawing.Size(231, 114);
			this.btnEnkripsi.TabIndex = 0;
			this.btnEnkripsi.Text = "Enkripsi";
			this.btnEnkripsi.UseVisualStyleBackColor = true;
			this.btnEnkripsi.Click += new System.EventHandler(this.btnEnkripsi_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(4, 17);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Selamat Datang";
			// 
			// btnDekripsi
			// 
			this.btnDekripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDekripsi.Location = new System.Drawing.Point(286, 96);
			this.btnDekripsi.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.btnDekripsi.Name = "btnDekripsi";
			this.btnDekripsi.Size = new System.Drawing.Size(231, 114);
			this.btnDekripsi.TabIndex = 2;
			this.btnDekripsi.Text = "Dekripsi";
			this.btnDekripsi.UseVisualStyleBackColor = true;
			this.btnDekripsi.Click += new System.EventHandler(this.btnDekripsi_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 297);
			this.Controls.Add(this.btnDekripsi);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEnkripsi);
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEnkripsi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDekripsi;
	}
}

