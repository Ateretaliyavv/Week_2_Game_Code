using UnityEngine;

public class MiniMap : MonoBehaviour
{
    public Transform player;       // Character
    public RectTransform mapUI;    // Mini-map UI element
    public RectTransform icon;     // Icon

    void Update()
    {
        Vector3 viewPos = Camera.main.WorldToViewportPoint(player.position);

        // Transform to mini-map coordinates
        float x = (viewPos.x - 0.5f) * mapUI.rect.width;
        float y = (viewPos.y - 0.5f) * mapUI.rect.height;

        icon.anchoredPosition = new Vector2(x, y);
    }
}