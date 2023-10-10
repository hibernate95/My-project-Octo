using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveCardData", menuName = "Card/MoveCard", order = 2)]
public class MoveCardSO : CardSO
{
    [Header("Move Card Info")]
    public int movementDistance; // 이동 카드의 이동 거리
    public bool canFly; // 날 수 있는 카드 여부
}
