using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardRenderer : MonoBehaviour
{
    public Image CSprite;
    public Card TRCard;

    private void Start()
    {
        CSprite.sprite = TRCard.ShownSide;
    }

    
}
