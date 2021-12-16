using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriBash : MonoBehaviour
{
   
   Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Vector3 mousePos = Input.mousePosition;
            {
                Debug.Log(mousePos.x);
                Debug.Log(mousePos.y);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0f;
           
                

        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            Time.timeScale = 1.0f;
            
        }
    }
}