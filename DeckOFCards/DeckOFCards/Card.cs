using System;
using System.Collections.Generic;
using System.Text;
public class Card
{
	public static  String[] Rank = { "*", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
	private static String[] Suit = { "*", "D", "C", "H", "S" };
	private int cardSuit;
	private int cardRank;
	public Card(int suit, int rank)
	{
		if (rank == 1)
			cardRank = 14;
		else
			cardRank = (int)rank;
		cardSuit = (int)suit;
	}

	public int suit()
	{
		return (cardSuit);
	}

	public int rank()
	{
		return (cardRank);
	}

	public String toString()
	{
		return (Rank[cardRank] + Suit[cardSuit]);
	}
}

