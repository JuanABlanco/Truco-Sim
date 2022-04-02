using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Pintas
{
    Oros,
    Copas,
    Espadas,
    Bastos
}

[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ScriptableObjects/Cards/Default", order = 1)]
public class Card : ScriptableObject
{
    public Pintas Pinta;
    public string Scale;
    public bool OutOfDeck;
    public int OrderedPos;
    public Sprite Back;
    public Sprite Front;
    public Sprite ShownSide;

    private void Awake()
    {
        ShownSide = Back;
    }

    public void Turn()
    {
        ShownSide = ShownSide.Equals(Back) ? Front : Back;
    }

}
