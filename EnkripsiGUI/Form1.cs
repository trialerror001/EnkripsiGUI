using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnkripsiGUI
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnEnkripsi_Click(object sender, EventArgs e)
		{
			PlainToEncrypt pte = new PlainToEncrypt();
			pte.Show();
		}

		private void btnDekripsi_Click(object sender, EventArgs e)
		{
			EncryptToPlain etp = new EncryptToPlain();
			etp.Show();
		}
	}
}
