using System;
namespace Menu
{
    class Program
    {
		static void Main(string[] args)
		{
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(+)");
			znak = Convert.ToChar(Console.ReadLine());

			switch (znak)
			{
				case'+':
					Console.WriteLine("Результат:", a + b);
					break;
			
			}
	}	}
}