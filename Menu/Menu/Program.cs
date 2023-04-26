using System;
namespace Menu
{
    class Program
    {
		static void Main(string[] args)
		{
			double a, b;
			Console.WriteLine("Введите B: ");
			b = Convert.ToDouble(Console.ReadLine());
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(+)");
			Console.WriteLine("(-)");
			Console.WriteLine("(*)");
			znak = Convert.ToChar(Console.ReadLine());
		switch (znak)
			{

				case '+':
					Console.WriteLine("Результат:", a + b);
					break;


				case '-':
					Console.WriteLine("Результат:", a - b);

					break;

				case '*':
					Console.WriteLine("Результат: ", a * b);
					break;
			}

		}
	}

}