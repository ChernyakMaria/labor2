﻿using System;
namespace Menu
{
	class Program
	{
		static void Main(string[] args)
		{
			double a;
			Console.WriteLine("Введите А: ");
			a = Convert.ToDouble(Console.ReadLine());
			double b;
			Console.WriteLine("Введите B: ");
			b = Convert.ToDouble(Console.ReadLine());
			char znak;
			Console.WriteLine("Введите знак для реализации операции:");
			Console.WriteLine("(+)");
			Console.WriteLine("(-)");
			znak = Convert.ToChar(Console.ReadLine());
			switch (znak)
			{
				case '+':
					total = a + b;
					Console.WriteLine("Результат:" + total);
					break;

				case '-':
					total = a - b;
					Console.WriteLine("Результат:" + total);
					break;

			}

		}

	}		
}