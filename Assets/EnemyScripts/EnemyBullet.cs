using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int damage = 3;
    public Rigidbody rb;
    public GameObject Bullet;
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            //collision.gameObject.GetComponent<>();
            Debug.Log("Taken damage");
           
        }
    }
    
}
