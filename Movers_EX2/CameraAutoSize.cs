using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraAutoSize : MonoBehaviour
{
    [Header("Size")]
    public float portraitSize = 5f;    // גודל המצלמה במצב אנכי
    public float landscapeSize = 8f;   // גודל המצלמה במצב אופקי

    private Camera cam;
    private bool lastPortrait;         // לזכור מה היה המצב הקודם

    void Awake()
    {
        cam = GetComponent<Camera>();
        lastPortrait = IsPortrait();
        UpdateCameraSize();
    }

    void Update()
    {
        // אם כיוון המסך השתנה – נעדכן את גודל המצלמה
        bool nowPortrait = IsPortrait();
        if (nowPortrait != lastPortrait)
        {
            lastPortrait = nowPortrait;
            UpdateCameraSize();
        }
    }

    bool IsPortrait()
    {
        return Screen.height >= Screen.width;   // גובה גדול מרוחב = אנכי
    }

    void UpdateCameraSize()
    {
        if (IsPortrait())
        {
            cam.orthographicSize = portraitSize;
        }
        else
        {
            cam.orthographicSize = landscapeSize;
        }
    }
}
