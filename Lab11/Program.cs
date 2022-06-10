using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
		static void Main(string[] args)
		{
			//string s = Console.ReadLine(); // расскоментировать эту строку и закоментировать строку, находящуюся через 2 строки после этой, если необходимо ввести другой текст
			Console.WriteLine();
			//исходный текст
			string s = "У меня 10 долларов и 3 яблока. У меня 9 долларов и 2 яблока.";
			string so;
			Console.WriteLine(s);
			Regex r = new Regex(@"\d+");
			Console.WriteLine("-----------------------");
			//замена текста:
			MatchEvaluator ma = new MatchEvaluator(myReplace);
			so = r.Replace(s, ma);
			Console.WriteLine(so);
            Console.ReadLine();
		}

		static string myReplace(Match m)
		{
			int number;
			int.TryParse(m.Value, out number);
			number--;
			return number.ToString();
		}
    }
}
