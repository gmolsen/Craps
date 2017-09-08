using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craps {
	class Program {
		Random rnd = new Random();
		int DiceRoll() {
			var DiceOne = rnd.Next(6) + 1;
			var DiceTwo = rnd.Next(6) + 1;
			var Roll = DiceOne + DiceTwo;
			Debug($"You rolled {Roll}");
			return Roll;
		}
		int Game(y
			) {
			//First Roll
			int Dice = DiceRoll();
			if (Dice == 7 || Dice == 11) {
				Debug("You Win!");
				return Dice;
			} else if (Dice == 2 || Dice == 3 || Dice == 12) {
				Debug("You Lose!");
				return Dice;
			}        // Second Roll and so on and so forth
			int Point = Dice;
			while (true) {
				Dice = DiceRoll();
				if (Dice == Point) {
					Debug($"You Won! You rolled {Point}");
					return Dice;
				} else if (Dice == 7) {
					Debug($"You Lose. You rolled {Dice}");
					return Dice;
				}
			}

		}

		void Debug(string msg) {
			Console.WriteLine(msg);
		}

		static void Main(string[] args) {
			new Program().Run();
		}
		void Run() {
			bool PlayAgain = true;
			while (PlayAgain == true) {
				Game();
				Console.Write($"Do you want to play again? Y/N : ");
				//var answer = Console.ReadLine();
				//if(answer == "Y" || answer == "y") {
				//	PlayAgain = true;
				//} else {
				//	PlayAgain = false;
				//}
				PlayAgain = Console.ReadLine().ToUpper().StartsWith("Y");
			}
		}
	}
}