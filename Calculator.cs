using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Applikasi Kalkulator";
			
			// int a = 10; // deklarasi variabel a, dengan nilai awal 10;
			// int b = 6; // deklarasi variabel b, dengan nilai awal 6;
			
			Console.Write("Inputkan nilai a = ");
			int a = int.Parse(Console.ReadLine()); //Proses casting
			
			Console.Write("Inputkan nilai b = "); 
			int b = Convert.ToInt32(Console.ReadLine());//Proses casting
			
			Console.WriteLine(); //tambahan bari kosong
			
			Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
			Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
			Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
			Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
			
			Console.WriteLine("\nTekan sembarang key untuk keluar");
			Console.Readkey();
		}
		
		static int Penambahan(int a, int b)
		{
			return a + b;
		}
		
		static int Pengurangan (int a, int b)
		{
			return a + b;
		}
		
		static int Perkalian (int a, int b)
		{
			return a * b;
		}
		
		static Pembagian (int a, int b)
		{
			return a / b:
		}
	}
}