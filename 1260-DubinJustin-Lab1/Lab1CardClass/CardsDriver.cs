////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab 1 – Card Class
// File Name: CardsDriver.cs
// Description: Creates Default Card, then asks for integer to create card. Upon termination shows all cards in deck
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Justin Dubin
// Created: Wednesday, August 31, 2022
// Copyright: Katie Wilson, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
using Lab1CardClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CardClass
{
    internal class CardsDriver //MISSED COMMENT
    {
        
        //Main Method declares default card and asks user for input to display new card MISSED COMMENT
        public static void Main()
        {
            Card cardDefault = new Card();
            Console.WriteLine("The Default Card is " + cardDefault);
            Console.WriteLine();
            //do while
            int userInput;
            do
            {
                Console.WriteLine("Please type a non-negative integer below 52, or type -1 to terminate:");
                userInput = Convert.ToInt32(Console.ReadLine());
                if(userInput > 0)
                {
                    Card cards = new Card(userInput);
                    Console.WriteLine(cards.ToString());
                    
                }
                
            }
            while (userInput != -1);

            ShowDeck();


        } //MISSED COMMENT
        //Creates loop to show all 52 cards in deck
        private static void ShowDeck()
        {
            //for Loop
            for (int i = 0; i < 52; i++)
            {
                Card cards = new Card(i);
                Console.WriteLine(cards.ToString());

            }
        }
    }
}
