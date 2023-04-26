using System;
namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
			double a, b;
			Console.WriteLine("Введите А: ");
			 a = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Введите В: ");
			b = Convert.ToDouble(Console.ReadLine());
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(-)");
			Console.WriteLine("(+)");
			Console.WriteLine("(*)");
			Console.WriteLine("(/)");
			znak = Convert.ToChar(Console.ReadLine());
		}
    }
}