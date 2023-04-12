////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab 1 – Card Class
// File Name: Card.cs
// Description: Creates Default Card, then asks for integer to create card. Upon termination shows all cards in deck
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Wednesday, August 31, 2022
// Copyright: Katie Wilson, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CardClass
{
    // <summary>
    //This class models one single card out of an ordinary deck of playing cards.
    //It should have two properties
    // <summary>
    public class Card
    {
        //Attributes
        public Face Face { get; set; }
        public Suit Suit { get; set; }
        //Default Constructor MISSED COMMENT      
        public Card()
        {
            Face = Face.Ace;
            Suit = Suit.Diamonds; //Default card is Ace of Diamonds
        }
        //Parameterized Constructor MISSED COMMENT
        public Card(int n)
        {
            Face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
            Suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);
        }
        //Copy Constructor MISSED COMMENT
        public Card(Card existingCard)
        {
            Face = existingCard.Face;
            Suit = existingCard.Suit;
        }
       //Creates wording for the face and suit that makes sense. EX: MISSED COMMENT
       //The Ace of Diamonds / The Four of Clubs MISSED COMMENT
        public override string ToString() 
        {
            string cardStr = "The " + Face.ToString() + " of " + Suit.ToString();
            return cardStr;

        }
    }
}
