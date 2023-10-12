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
    
    

    private Vector2 originalPosition; // 카드의 원래 위치 저장
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
            // 이동 벡터를 계산하여 이미지 위치 업데이트
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isDragging = false;
        canvasGroup.blocksRaycasts = true;

        if (Vector2.Distance(rectTransform.anchoredPosition, originalPosition) <= maxDistanceToCenter)
        {
            // 중앙으로 도달하지 않았을 때, 원래 위치로 이동
            rectTransform.anchoredPosition = originalPosition;
        }
        else
        {
            // 중앙으로 도달했을 때, 카드를 삭제하거나 효과 적용
            // 이 부분에 중앙에 도달했을 때의 동작을 추가하세요.
            // 예: 카드 삭제 또는 효과 적용 함수 호출
            Destroy(gameObject);
            Cast();
        }
    }

        protected virtual void Cast()
    {
        // 기본적인 효과를 구현
        // 실제 효과는 하위 클래스에서 구현
    }

}

    

