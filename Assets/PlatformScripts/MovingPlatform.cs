using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed = 2.0f;
    float origY;
    public float distance = 2.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        origY = transform.position.y;
        useSpeed = -directionSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(origY - transform.position.y > distance)
        {
            useSpeed = directionSpeed;
        }
        else if(origY - transform.position.y < -distance)
        {
            useSpeed = -directionSpeed;
        }
        transform.Translate(0, useSpeed * Time.deltaTime, 0);
    }
}
