using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriBash : MonoBehaviour
{
    public float reachRadius = 1.35f;
    RaycastHit2D[] objectsNear;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            objectsNear = Physics2D.CircleCastAll(transform.position, reachRadius, Vector3.forward);
            {
                foreach(RaycastHit2D obj in objectsNear)
                {
                    if(obj.collider.gameObject.GetComponent<BashAble>() != null)
                    {
                        Time.timeScale = 0;
                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            Time.timeScale = 1;
        }
    }
}
