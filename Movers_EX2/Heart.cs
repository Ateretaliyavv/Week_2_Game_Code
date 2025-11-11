using UnityEngine;

public class Heart : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 3f; // 3 times per second
    [SerializeField] private float scaleAmount = 0.1f; // growth 10%

    private Vector3 startScale;

    void Start()
    {
        startScale = transform.localScale; // keep the original scale
    }

    void Update()
    {
        float scale = 1 + Mathf.Sin(Time.time * scaleSpeed) * scaleAmount; // calculate scale factor
        transform.localScale = startScale * scale;  // reset to original scale and apply scaling

    }
}