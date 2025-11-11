using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float speed = 90f; // rates per second

    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.Self); // rotate around local Y axis
    }
}