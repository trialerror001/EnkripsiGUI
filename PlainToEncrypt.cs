using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnkripsiGUI
{
	public partial class PlainToEncrypt : Form
	{
		public PlainToEncrypt()
		{
			InitializeComponent();
		}

		private void btnEncrypt_Load(object sender, EventArgs e)
		{
			txtKunci.Enabled = false;
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void bynGenerate_Click(object sender, EventArgs e)
		{
			int length = 4;
			StringBuilder builder = new StringBuilder();
			Random random = new Random();

			char letter;

			for (int i = 0; i < length; i++)
			{
				double flt = random.NextDouble();
				int shift = Convert.ToInt32(Math.Floor(25 * flt));
				letter = Convert.ToChar(shift + 65);
				builder.Append(letter);
			}
			txtKunci.Text = builder.ToString();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string kata = txtPlainText.Text.Replace(" ", "");
			string kunci = txtKunci.Text;
			int gabungan;
			int indeks = 0;
			Enkripsi en = new Enkripsi();

			for (int i = 0; i < kata.Length; i++)
			{
				gabungan = en.generateAngka(kata)[i] + en.generateKunci(kunci)[indeks];
				if (gabungan > 25)
					gabungan -= 26;

				//txtEncryptText.AppendText(gabungan.ToString() + " ");
				txtEncryptText.AppendText(en.generateHuruf(gabungan).ToString()+ " ");

				//Selalu dipaling bawah
				indeks++;
				if (indeks >= kunci.Length)
					indeks = 0;
			}
		}
	}
}
