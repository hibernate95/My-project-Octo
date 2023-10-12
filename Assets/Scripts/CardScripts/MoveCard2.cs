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
        // 플레이어의 이동 로직을 구현
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
        // 헥사타일 그리드에 따른 계산을 여기에 추가
    }

    private bool CanMoveToPosition(Vector2Int newPosition)
    {
        bool canMove = false;

        return canMove;
        // 이동 가능 여부를 검사하는 로직을 여기에 추가
    }
}