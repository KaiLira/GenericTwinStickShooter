using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(RectTransform))]
public class RandomPosInRect : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<Vector2> posSelected;
    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void SelectPos()
    {
        Rect rect = rectTransform.rect;
        rect.center = transform.position;
        Vector2 position = new Vector2(
            Random.Range(rect.min.x, rect.max.x),
            Random.Range(rect.min.y, rect.max.y)
            );

        posSelected?.Invoke(position);
    }
}
