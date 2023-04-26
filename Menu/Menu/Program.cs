using System;
namespace Menu
{
    class Program
    {
		static void Main(string[] args)
		{
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(/)");
			znak = Convert.ToChar(Console.ReadLine());

			switch (znak)
			{
				case '/':
					if (a != 0 || b != 0)
					{

						Console.WriteLine("Результат: ", (float)a / b);
					}
					else if (a == 0 || b == 0)
					{
						Console.WriteLine("На ноль делить нельзя.");
					}
					break;

			}
		}	}
}