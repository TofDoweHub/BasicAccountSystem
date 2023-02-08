using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string userName = Console.ReadLine();
			string userInputPassword = Console.ReadLine();
			string userInputPasswordConfirmation = Console.ReadLine();

			bool ableToLogin = userInputPassword == userInputPasswordConfirmation;
			// Переменная сделана с учётом того, что эта программа типо будет потом развиваться, и её функционал понадобится ещё раз

			if (ableToLogin)
			{
				Console.WriteLine($"Добро пожаловать, {userName}!");
				Console.WriteLine("*Функционал приложения открыт*");
			}
			else
			{
				Console.WriteLine("Пароли не совпадают! Попробуйте ещё раз.");
				Console.WriteLine("*Вылезла ошибка, функционал приложения не открыт*");
			}

			Console.ReadLine();

		}
	}
}
