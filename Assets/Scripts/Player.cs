using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2Int currentPosition;

    private void Start()
    {
        // �ʱ� ��ġ ����
        currentPosition = new Vector2Int(0, 0);
    }

    public Vector2Int CurrentPosition
    {
        get { return currentPosition; }
    }

    public void MoveToPosition(Vector2Int newPosition)
    {
        // �÷��̾ �� ��ġ�� �̵�
        // ���⿡ �̵��� ���õ� ������ �߰�
        // newPosition�� �������� �÷��̾��� ��ġ�� ������Ʈ
    }

    //public void UsingMana()
    //{
    //    if(GameManager.Instance.PlayerMana >= ManaCost)
    //    {
    //        GameManager.Instance.PlayerMana -= ManaCost;
    //    }
    //}
}
