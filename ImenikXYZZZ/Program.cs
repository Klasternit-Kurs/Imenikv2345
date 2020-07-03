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

		//TODO Artikal kao objekat :) sifru, naziv, ulaznu cenu i marzu 
		static void Main(string[] args)
		{
			List<Osoba> Imenik = new List<Osoba>();

			string unos ="";
			while (unos != "5")
			{
				PrikaziMeni();
				
				unos = Console.ReadKey().KeyChar.ToString();
				Console.WriteLine();

				switch (unos)
				{
					case "1":
						Unos(Imenik);
						break;
					case "2":
						Prikaz(Imenik);
						break;
					case "3":
						Pretraga(Imenik);
						break;
					case "4":
						Brisanje(Imenik);
						break;
					case "5":
						Console.WriteLine("Bye :D");
						break;
				}
			}
			Console.ReadKey();
		}

		static void Brisanje(List<Osoba> Imenik)
		{
			//TODO Brisanje napraviti tako sto se unese ime a 
			// ne indeks. Obratiti paznju na to da opet
			//morate da nadjete indeks sami jer morate da
			//obrisete broj iz druge liste :)

			Console.Write("Unesite indeks: ");

			Imenik.RemoveAt(int.Parse(Console.ReadLine()) - 1);
		}

		static void Pretraga(List<Osoba> Lista)
		{
			Console.Write("Pretraga: ");
			string ime = Console.ReadLine();

			foreach(Osoba o in Lista)
			{            
 				if (o.Ime.ToLower().Contains(ime.ToLower())  ||  o.Prezime.ToLower().Contains(ime.ToLower()))
				{
					Console.WriteLine($"{o.Ime} {o.Prezime} ---- {o.Telefon}");
				}
			}
		}

		static void Prikaz(List<Osoba> lista)
		{
			//for (int indeks = 0; indeks < lista.Count; indeks++)
			//{
			//	Console.WriteLine($"{indeks + 1}. {lista[indeks].Ime} {lista[indeks].Prezime} ---- {lista[indeks].Telefon}");
			//}

			foreach (Osoba o in lista)
			{
				Console.WriteLine($"{o.Ime} {o.Prezime} ---- {o.Telefon}");
			}
		}

		static void Unos(List<Osoba> osobe)
		{
			//TODO Popraviti stvar tako da korisnik ne sme da unese
			//nista za ime :) 
			//Ako imate string ime, ime.Length ce da vam da
			//broj karaktera. Pored toga, string.IsNullOrEmpty(ime)
			//kaze true ako je string prazan :)


			Osoba o = new Osoba();
			osobe.Add(o);

			Console.Write("Unesite ime: ");
			o.Ime = Console.ReadLine();
			Console.Write("Unesite prezime: ");
			o.Prezime = Console.ReadLine();
			Console.Write("Unesite tel:  ");
			o.Telefon = Console.ReadLine();
		}

		static void PrikaziMeni()
		{
			Console.WriteLine("1 -- Unos");
			Console.WriteLine("2 -- Ispis");
			Console.WriteLine("3 -- Pretraga");
			Console.WriteLine("4 -- Brisanje");
			Console.WriteLine("5 -- Izlaz");
			Console.WriteLine("----------------");
			Console.Write("Izaberite: ");
		}
	}

	class Osoba
	{
		public string Ime;
		public string Prezime;
		public string Telefon;
	}
}
