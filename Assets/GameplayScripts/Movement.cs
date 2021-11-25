using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    bool isGrounded = true;
    private float speed = 5.0f;
    public GameObject character;

    private void Update()
    {
        if (isGrounded == true)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}
