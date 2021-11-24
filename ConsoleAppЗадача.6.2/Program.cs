using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppЗадача._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
			string text = Console.ReadLine();
			text = text.ToLower();
			bool t = true;
			for (int i = 0, j = text.Length - 1; i < text.Length / 2 - 1; i++, j--)
			{
				if (text[i] == ' ')
				{
					i++;
				}
				if (text[j] == ' ')
				{
					j--;
				}
				if (text[i] != text[j])
				{
					t = false;
					break;
				}
			}
			if (t) Console.WriteLine("Предложение полнидром");
			else Console.WriteLine("Предложение не полнидром");
			Console.ReadKey();
		}
    }
}
