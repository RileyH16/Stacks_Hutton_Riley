// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using Stacks_Hutton_Riley;

//Card array with 9 different cards
Card[] myCardsArray = new Card[]
{
    //the cards
    new Card("Ace", "Spades"),
    new Card("Jack", "Clubs"),
    new Card("Queen", "Diamonds"),
    new Card("Queen", "Hearts"),
    new Card("10", "Hearts"),
    new Card("2", "Diamonds"),
    new Card("6", "Spades"),
    new Card("9", "Clubs"),
    new Card("Ace", "Diamonds"),
    //the cards
};

//stack of the cards
Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

//Prints "Cards in Deck" then prints each card in the deck
Console.WriteLine("Cards in Deck:");
foreach(Card card in startingDeck)
{
    Console.WriteLine($"The {card.Number} of {card.Suit}!");
}

//Prints the number of cards in the deck
Console.WriteLine($"Cards in the deck:{startingDeck.Count}");

//List called my hand with 3 new cards
List<Card> myHand = new List<Card>();
myHand.Add(new Card("Jack", "Diamonds"));
myHand.Add(new Card("8", "Hearts"));
myHand.Add(new Card("3", "Diamonds"));

//Asks "got any 8's"
Console.WriteLine("Got any 8's?");
//if the stack has the cards it will pop one into my hand
if(startingDeck.Count > 0)
{
    myHand.Add(startingDeck.Pop());
}

//Prints the number of cards in the deck
Console.WriteLine($"Cards in the deck:{startingDeck.Count}");

//Places one of my cards on the stack
startingDeck.Push(myHand[0]);
//Deletes that card
myHand.RemoveAt(0);

//Prints "Cards in Deck" then prints each card in the deck
Console.WriteLine("Cards in Deck:");
foreach (Card card in startingDeck)
{
    Console.WriteLine($"The {card.Number} of {card.Suit}!");
}