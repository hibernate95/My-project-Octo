using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ResourceCardData", menuName = "Card/ResourceCard", order = 3)]
public class ResourceCardSO : CardSO
{
    [Header("Resource Card Info")]
    public ResourceType resourceType; // �ڿ� ī���� �ڿ� ���� (��: ��, ����, �� ��)
    public int resourceAmount; // �ڿ� ī���� ��
}

public enum ResourceType
{
    Gold,
    Wood,
    Stone,
    // �߰� �ڿ� ������ ���⿡ �߰��� �� �ֽ��ϴ�.
}
