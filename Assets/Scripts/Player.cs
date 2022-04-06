using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string Name;
    public List<CardRenderer> Hand;
    public int Score;
    public Transform[] Slots;

    public void Deal()
    {
        List<Player> Players = GameManager.Instance.Players;

        Deck ActiveDeck = GameManager.Instance.ActiveDeck;

        foreach(Player player in Players)
        {
            for(int i = 0; i<2; i++) 
            {
                CardRenderer currentCard = ActiveDeck.Cards[Mathf.RoundToInt(Random.Range(0, ActiveDeck.Cards.Count))];

                if (currentCard.TRCard.OutOfDeck)
                {
                    i--;
                }
                else
                {
                    player.Hand.Add(currentCard);
                    currentCard.transform.position = player.Slots[i].transform.position;
                    currentCard.transform.SetParent(player.Slots[i]);
                }
            }
        }
    }
}
