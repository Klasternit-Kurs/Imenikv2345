using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImenikXYZZZ
{
	class Program
	{
		//TODO Napraviti aplikaciju poput ove, samo za artikle.
		//Korisnik moze da unese artikal (ima sifru, naziv i cenu)
		//Stampaje i brisanje i sve to :) 
		//Za odvazne, artikal ima i kolicinu na stanju, koja moze da se doda
		//ili oduzme (ne sme da dodje ispod 0 :) )
		static void Main(string[] args)
		{
			List<string> Imena = new List<string>();
			List<string> BrTel = new List<string>();

			string unos ="";
			while (unos != "5")
			{
				Console.WriteLine("1 -- Unos");
				Console.WriteLine("2 -- Ispis");
				Console.WriteLine("3 -- Pretraga");
				Console.WriteLine("4 -- Brisanje");
				Console.WriteLine("5 -- Izlaz");
				Console.WriteLine("----------------");
				Console.Write("Izaberite: ");

				unos = Console.ReadKey().KeyChar.ToString();
				Console.WriteLine();

				switch(unos)
				{
					case "1":
						//TODO Popraviti stvar tako da korisnik ne sme da unese
						//nista za ime :) 
						//Ako imate string ime, ime.Length ce da vam da
						//broj karaktera. Pored toga, string.IsNullOrEmpty(ime)
						//kaze true ako je string prazan :) 
						Console.Write("Unesite ime i prezime: ");
						Imena.Add(Console.ReadLine());
						Console.Write("Unesite tel:  ");
						BrTel.Add(Console.ReadLine());
						break;
					case "2":
						for (int indeks = 0; indeks < Imena.Count; indeks++)
						{
							Console.WriteLine($"{indeks + 1}. {Imena[indeks]} ---- {BrTel[indeks]}");
						}
						break;
					case "3":
						Console.Write("Unesite ime: ");
						string ime = Console.ReadLine();
						for (int indeks = 0; indeks < Imena.Count; indeks++)
						{
							if (Imena[indeks].ToLower().Contains(ime.ToLower()))
							{
								Console.WriteLine($"{indeks + 1}. {Imena[indeks]} ---- {BrTel[indeks]}");
							}
						}
						break;
					case "4":
						//TODO Brisanje napraviti tako sto se unese ime a 
						// ne indeks. Obratiti paznju na to da opet
						//morate da nadjete indeks sami jer morate da
						//obrisete broj iz druge liste :)
						Console.Write("Unesite indeks: ");
						int ind = int.Parse(Console.ReadLine()) - 1;
						Imena.RemoveAt(ind);
						BrTel.RemoveAt(ind);
						break;
					case "5":
						Console.WriteLine("Bye :D");
						break;
				}
			}
			Console.ReadKey();

		}
	}
}
