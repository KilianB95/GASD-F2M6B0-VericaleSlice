using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriBash : MonoBehaviour
{
    public float reachRadius = 1.35f;
    RaycastHit2D[] objectsNear;
    Vector3 direction;
    public float speed = 3;
    public bool canBash;
    public GameObject BashableObj;
    public float maxTime = 1f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

   IEnumerator Counter()
    {
        //yield return new WaitForSeconds()
        float pauseTime = Time.realtimeSinceStartup + maxTime;

        while (Time.realtimeSinceStartup<pauseTime)
        {
            yield return null;
        }
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1f;
            canBash = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            objectsNear = Physics2D.CircleCastAll(transform.position, reachRadius, Vector3.up);
            {
                foreach(RaycastHit2D obj in objectsNear)
                {
                    if (obj.collider.gameObject.GetComponent<BashAble>() != null)
                    {
                        BashableObj = gameObject;
                        StartCoroutine("Counter");
                        Time.timeScale = 0;

                        canBash = true;
                        
                        break;
                    }
                }
            }
        }
        else if (Input.GetKeyUp(KeyCode.C) && canBash)
        {
            Time.timeScale = 1;
            direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - BashableObj.transform.position);
            direction.z = 0;
            direction = direction.normalized;

            transform.position = rb.transform.position + direction;

            
            GetComponent<Rigidbody>();
            rb.AddForce(0, 3, 0);

            canBash = false;
        }

        void onDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, reachRadius);
        }
    }
}
