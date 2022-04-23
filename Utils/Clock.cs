using UnityEngine;

public class Clock : MonoBehaviour
{    
    private float nextActionTime = 0.0f;
    private const float Period = 2f;

    void Start()
    {
        nextActionTime = Time.time;
    }

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += Period;
            
            //DO YOUR ACTION
        }
    }
}
