using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2Int currentPosition;

    private void Start()
    {
        // 초기 위치 설정
        currentPosition = new Vector2Int(0, 0);
    }

    public Vector2Int CurrentPosition
    {
        get { return currentPosition; }
    }

    public void MoveToPosition(Vector2Int newPosition)
    {
        // 플레이어를 새 위치로 이동
        // 여기에 이동에 관련된 로직을 추가
        // newPosition을 기준으로 플레이어의 위치를 업데이트
    }

    //public void UsingMana()
    //{
    //    if(GameManager.Instance.PlayerMana >= ManaCost)
    //    {
    //        GameManager.Instance.PlayerMana -= ManaCost;
    //    }
    //}
}
