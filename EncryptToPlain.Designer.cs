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
			this.bynGenerate = new System.Windows.Forms.Button();
			this.txtKunci = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPlainText
			// 
			this.txtPlainText.Location = new System.Drawing.Point(1146, 281);
			this.txtPlainText.Multiline = true;
			this.txtPlainText.Name = "txtPlainText";
			this.txtPlainText.Size = new System.Drawing.Size(716, 370);
			this.txtPlainText.TabIndex = 9;
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(824, 403);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(248, 107);
			this.btnDecrypt.TabIndex = 8;
			this.btnDecrypt.Text = "Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 234);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(205, 32);
			this.label2.TabIndex = 7;
			this.label2.Text = "Encrypted Text";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(473, 55);
			this.label1.TabIndex = 6;
			this.label1.Text = "Encrypt > Plain Text";
			// 
			// txtEncryptText
			// 
			this.txtEncryptText.Location = new System.Drawing.Point(52, 281);
			this.txtEncryptText.Multiline = true;
			this.txtEncryptText.Name = "txtEncryptText";
			this.txtEncryptText.Size = new System.Drawing.Size(716, 370);
			this.txtEncryptText.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1140, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 32);
			this.label3.TabIndex = 10;
			this.label3.Text = "Plain Text";
			// 
			// bynGenerate
			// 
			this.bynGenerate.Location = new System.Drawing.Point(526, 149);
			this.bynGenerate.Name = "bynGenerate";
			this.bynGenerate.Size = new System.Drawing.Size(166, 53);
			this.bynGenerate.TabIndex = 13;
			this.bynGenerate.Text = "Generate";
			this.bynGenerate.UseVisualStyleBackColor = true;
			this.bynGenerate.Click += new System.EventHandler(this.bynGenerate_Click);
			// 
			// txtKunci
			// 
			this.txtKunci.Location = new System.Drawing.Point(134, 157);
			this.txtKunci.Name = "txtKunci";
			this.txtKunci.Size = new System.Drawing.Size(366, 38);
			this.txtKunci.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(49, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 32);
			this.label4.TabIndex = 11;
			this.label4.Text = "Key";
			// 
			// EncryptToPlain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2092, 809);
			this.Controls.Add(this.bynGenerate);
			this.Controls.Add(this.txtKunci);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPlainText);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEncryptText);
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
		private System.Windows.Forms.Button bynGenerate;
		private System.Windows.Forms.TextBox txtKunci;
		private System.Windows.Forms.Label label4;
	}
}