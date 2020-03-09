namespace EnkripsiGUI
{
	partial class PlainToEncrypt
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
			this.txtPlainText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtEncryptText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPlainText
			// 
			this.txtPlainText.Location = new System.Drawing.Point(55, 192);
			this.txtPlainText.Multiline = true;
			this.txtPlainText.Name = "txtPlainText";
			this.txtPlainText.Size = new System.Drawing.Size(716, 370);
			this.txtPlainText.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(473, 55);
			this.label1.TabIndex = 1;
			this.label1.Text = "Plain > Encrypt Text";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(142, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Plain Text";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(827, 314);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(248, 107);
			this.button1.TabIndex = 3;
			this.button1.Text = "Encrypt";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtEncryptText
			// 
			this.txtEncryptText.Location = new System.Drawing.Point(1149, 192);
			this.txtEncryptText.Multiline = true;
			this.txtEncryptText.Name = "txtEncryptText";
			this.txtEncryptText.Size = new System.Drawing.Size(716, 370);
			this.txtEncryptText.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1143, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(205, 32);
			this.label3.TabIndex = 5;
			this.label3.Text = "Encrypted Text";
			// 
			// PlainToEncrypt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2092, 717);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEncryptText);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPlainText);
			this.Name = "PlainToEncrypt";
			this.Text = "PlainToEncrypt";
			this.Load += new System.EventHandler(this.btnEncrypt_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPlainText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtEncryptText;
		private System.Windows.Forms.Label label3;
	}
}