using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveCardData", menuName = "Card/MoveCard", order = 2)]
public class MoveCardSO : CardSO
{
    [Header("Move Card Info")]
    public int movementDistance; // �̵� ī���� �̵� �Ÿ�
    public bool canFly; // �� �� �ִ� ī�� ����
}
