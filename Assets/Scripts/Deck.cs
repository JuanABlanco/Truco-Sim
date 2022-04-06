using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<CardRenderer> Cards;

    public void Shuffle() 
    { 
        System.Random rng = new System.Random(); 
        int n = Cards.Count; 
        while (n > 1) 
        { 
            n--; 
            int k = rng.Next(n + 1);
            CardRenderer value = Cards[k];
            Cards[k] = Cards[n];
            Cards[n] = value; 
        } 
    }

    public void Order()
    {
        List<CardRenderer> aulx = new List<CardRenderer>();

        for(int i = 0; i<Cards.Count; i++)
        {

            CardRenderer card = Cards.Find(a => a.TRCard.OrderedPos == i);
            aulx.Add(card);
        }
    }
}
