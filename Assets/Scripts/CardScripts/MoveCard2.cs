using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCard2
{
    private int movementDistance;
    //private bool canFly;

    public MoveCard2(MoveCardSO moveCardData)
    {
        movementDistance = moveCardData.movementDistance;
        //canFly = moveCardData.canFly;
    }

    public void Use(Player player)
    {
        // �÷��̾��� �̵� ������ ����
        Vector2Int newPosition = CalculateNewPosition(player.CurrentPosition);
        if (CanMoveToPosition(newPosition))
        {
            player.MoveToPosition(newPosition);
        }
    }

    private Vector2Int CalculateNewPosition(Vector2Int currentPosition)
    {
       
        Vector2Int newPosition = new Vector2Int(0 ,0);

        return newPosition;
        // ���Ÿ�� �׸��忡 ���� ����� ���⿡ �߰�
    }

    private bool CanMoveToPosition(Vector2Int newPosition)
    {
        bool canMove = false;

        return canMove;
        // �̵� ���� ���θ� �˻��ϴ� ������ ���⿡ �߰�
    }
}