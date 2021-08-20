using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PlayCards
{
	public class Hand
	{
		public static void Main()
		{
			DeckOfCards deck = new DeckOfCards();

			deck.shuffle(100);
            List<string>[] player = new List<string>[4];
            for (int h = 0; h < 4; h++)
                player[h] = new List<string>();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    player[j].Add(deck.deal().toString());
            for (int k = 0; k < 4; k++)
            {
                List<string> sortedList = player[k].OrderBy(x => PadNumbers(x)).OrderBy(g => FaceValue(g)).ToList();
                Console.WriteLine("Player " + (k+1) + ": " + string.Join("-", sortedList));
            }
        }

        public static string PadNumbers(string input)
        {
            return Regex.Replace(input, "[0-10]+", match => match.Value.PadLeft(2, '0'));
        }

        public static int FaceValue(string input)
        {
            return input.Substring(0, 1) == "A" ? 14 : input.Substring(0, 1) == "K" ? 13 : input.Substring(0, 1) == "Q" ? 12 : input.Substring(0, 1) == "J" ? 11 : 0;
        }
    }
    
	
}