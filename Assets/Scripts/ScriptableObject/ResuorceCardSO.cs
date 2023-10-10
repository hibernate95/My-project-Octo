using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ResourceCardData", menuName = "Card/ResourceCard", order = 3)]
public class ResourceCardSO : CardSO
{
    [Header("Resource Card Info")]
    public ResourceType resourceType; // 자원 카드의 자원 유형 (예: 금, 나무, 돌 등)
    public int resourceAmount; // 자원 카드의 양
}

public enum ResourceType
{
    Gold,
    Wood,
    Stone,
    // 추가 자원 유형을 여기에 추가할 수 있습니다.
}
