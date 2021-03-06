﻿namespace EnkripsiGUI
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
			this.label4 = new System.Windows.Forms.Label();
			this.txtKunci = new System.Windows.Forms.TextBox();
			this.bynGenerate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPlainText
			// 
			this.txtPlainText.Location = new System.Drawing.Point(16, 130);
			this.txtPlainText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.txtPlainText.Multiline = true;
			this.txtPlainText.Name = "txtPlainText";
			this.txtPlainText.Size = new System.Drawing.Size(271, 157);
			this.txtPlainText.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Plain > Encrypt Text";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 111);
			this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Plain Text";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(306, 182);
			this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 45);
			this.button1.TabIndex = 3;
			this.button1.Text = "Encrypt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtEncryptText
			// 
			this.txtEncryptText.Location = new System.Drawing.Point(426, 130);
			this.txtEncryptText.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.txtEncryptText.Multiline = true;
			this.txtEncryptText.Name = "txtEncryptText";
			this.txtEncryptText.Size = new System.Drawing.Size(271, 157);
			this.txtEncryptText.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(424, 111);
			this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Encrypted Text";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 69);
			this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Key";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// txtKunci
			// 
			this.txtKunci.Location = new System.Drawing.Point(46, 68);
			this.txtKunci.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.txtKunci.Name = "txtKunci";
			this.txtKunci.Size = new System.Drawing.Size(140, 20);
			this.txtKunci.TabIndex = 7;
			// 
			// bynGenerate
			// 
			this.bynGenerate.Location = new System.Drawing.Point(190, 65);
			this.bynGenerate.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
			this.bynGenerate.Name = "bynGenerate";
			this.bynGenerate.Size = new System.Drawing.Size(62, 22);
			this.bynGenerate.TabIndex = 8;
			this.bynGenerate.Text = "Generate";
			this.bynGenerate.UseVisualStyleBackColor = true;
			this.bynGenerate.Click += new System.EventHandler(this.bynGenerate_Click);
			// 
			// PlainToEncrypt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 314);
			this.Controls.Add(this.bynGenerate);
			this.Controls.Add(this.txtKunci);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEncryptText);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPlainText);
			this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtKunci;
		private System.Windows.Forms.Button bynGenerate;
	}
}