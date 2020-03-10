using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnkripsiGUI
{
	class Enkripsi
	{
		char[] alphabet = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
		'M', 'N','O', 'P','Q', 'R','S', 'T','U', 'V', 'W', 'X','Y', 'Z'};
		int[] angka = new int[100];

		public int[] generateAngka(string kata) {
			char[] arrayKata = kata.ToUpper().ToCharArray();
			for (int i = 0; i < arrayKata.Length; i++)
			{
				for (int j = 0; j < alphabet.Length; j++)
				{
					if (arrayKata[i] == alphabet[j])
						angka[i] = j;
				}
			}
			
			return angka;
		}

		public int[] generateKunci(string kunci) {
			char[] arrayKunci = kunci.ToUpper().ToCharArray();
			for (int i = 0; i < arrayKunci.Length; i++)
			{
				for (int j = 0; j < alphabet.Length; j++)
				{
					if (arrayKunci[i] == alphabet[j])
						angka[i] = j;
				}
			}

			return angka;
		}

		public char generateHuruf(int gabungan) {
			return alphabet[gabungan];
		}
	}
}
