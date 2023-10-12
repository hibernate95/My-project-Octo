using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : DraggableImage
{
    private MagicCardSO fireBallCardData;

    int playermana = GameManager.Instance.PlayerMana;


    protected virtual void Cast()
    {
        playermana = GameManager.Instance.PlayerMana;
        if (playermana >= fireBallCardData.manaCost)
        {
            // ���� �Һ�
            playermana -= fireBallCardData.manaCost;

            // Ư�� ī�� ȿ�� ����
            ApplyCardEffect();
        }
        else
        {
            Debug.Log("Not enough mana to cast FireBall.");
        }
    }

    private void ApplyCardEffect()
    {
        
        //fireBallCardData.damage;
    }
    

}
