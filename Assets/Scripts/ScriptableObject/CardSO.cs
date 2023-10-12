using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "DefaultCardData", menuName = "Card/Default", order = 0)]


public class CardSO : ScriptableObject
{
    [Header("Card Info")]

    public CardType CardType;
    public string spellName;
    public string spellDescription;
    public int manaCost;
    
}

public enum CardType
{
    Resource,
    Move,
    Magic
}
