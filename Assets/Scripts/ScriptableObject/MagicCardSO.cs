using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "MagicCardData", menuName = "Card/MagicCard", order = 1)]
public class MagicCardSO : CardSO
{
    [Header("Magic Card Info")]
    //public string spellEffect; // ���� ī���� Ư�� ȿ��
    public int damage; // ���� ī���� ���ݷ�
}

