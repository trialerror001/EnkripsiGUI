namespace EnkripsiGUI
{
	partial class EncryptToPlain
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
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtEncryptText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtKunci = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtPlainText
			// 
			this.txtPlainText.Location = new System.Drawing.Point(430, 118);
			this.txtPlainText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.txtPlainText.Multiline = true;
			this.txtPlainText.Name = "txtPlainText";
			this.txtPlainText.Size = new System.Drawing.Size(271, 157);
			this.txtPlainText.TabIndex = 9;
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(309, 169);
			this.btnDecrypt.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(93, 45);
			this.btnDecrypt.TabIndex = 8;
			this.btnDecrypt.Text = "Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 98);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Encrypted Text";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 24);
			this.label1.TabIndex = 6;
			this.label1.Text = "Encrypt > Plain Text";
			// 
			// txtEncryptText
			// 
			this.txtEncryptText.Location = new System.Drawing.Point(20, 118);
			this.txtEncryptText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.txtEncryptText.Multiline = true;
			this.txtEncryptText.Name = "txtEncryptText";
			this.txtEncryptText.Size = new System.Drawing.Size(271, 157);
			this.txtEncryptText.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(428, 98);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Plain Text";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 67);
			this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Key";
			// 
			// txtKunci
			// 
			this.txtKunci.Location = new System.Drawing.Point(50, 66);
			this.txtKunci.Margin = new System.Windows.Forms.Padding(1);
			this.txtKunci.Name = "txtKunci";
			this.txtKunci.Size = new System.Drawing.Size(140, 20);
			this.txtKunci.TabIndex = 12;
			// 
			// EncryptToPlain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 314);
			this.Controls.Add(this.txtKunci);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPlainText);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEncryptText);
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.Name = "EncryptToPlain";
			this.Text = "EncryptToPlain";
			this.Load += new System.EventHandler(this.EncryptToPlain_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPlainText;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEncryptText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtKunci;
	}
}