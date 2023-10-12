using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableImage : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private CanvasGroup canvasGroup;
    
    

    private Vector2 originalPosition; // ī���� ���� ��ġ ����
    private readonly float maxDistanceToCenter = 200f;

    private bool isDragging = false;

    //private int playermana;
    //public MagicCardSO cardData;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        canvasGroup = GetComponent<CanvasGroup>();
        originalPosition = rectTransform.anchoredPosition;

        //playermana = GameManager.Instance.PlayerMana;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isDragging = true;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            // �̵� ���͸� ����Ͽ� �̹��� ��ġ ������Ʈ
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
        canvasGroup.blocksRaycasts = true;

        if (Vector2.Distance(rectTransform.anchoredPosition, originalPosition) <= maxDistanceToCenter)
        {
            // �߾����� �������� �ʾ��� ��, ���� ��ġ�� �̵�
            rectTransform.anchoredPosition = originalPosition;
        }
        else
        {
            // �߾����� �������� ��, ī�带 �����ϰų� ȿ�� ����
            // �� �κп� �߾ӿ� �������� ���� ������ �߰��ϼ���.
            // ��: ī�� ���� �Ǵ� ȿ�� ���� �Լ� ȣ��
            Destroy(gameObject);
            Cast();
        }
    }

        protected virtual void Cast()
    {
        // �⺻���� ȿ���� ����
        // ���� ȿ���� ���� Ŭ�������� ����
    }

}

    

