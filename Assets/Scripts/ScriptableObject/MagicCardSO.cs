using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "MagicCardData", menuName = "Card/MagicCard", order = 1)]
public class MagicCardSO : CardSO
{
    [Header("Magic Card Info")]
    //public string spellEffect; // 마법 카드의 특수 효과
    public int damage; // 마법 카드의 공격력
}

