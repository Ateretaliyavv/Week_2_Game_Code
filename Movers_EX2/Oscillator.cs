using UnityEngine;


public class Oscillator : MonoBehaviour
{
    public float upSpeed = 1f;
    public float forwordSpeed = 1f;

    public void update()
    { 
        float sinSpeed = Math.Sin(Time.time * upSpeed);
        Vector3 cosDir = Math.Cos(Time.time * upSpeed) * Vector3.up;
        //Vector3 direction = Vector3.up * upSpeed + Vector3.forward * forwordSpeed;
        transform.Translate(cosDir * Time.deltaTime * sinSpeed , Space.World);
        // Implementation for updating the oscillator state

    }
}