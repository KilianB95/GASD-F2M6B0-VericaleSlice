using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform target;
    public Transform weaponMuzzle;
    public GameObject bullet;
    public float fireRate = 3000f;
    public float shootingPower = 20f;

    private float shootingTime;

    




    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        if (Time.time > shootingTime)
        {
            shootingTime = Time.time + fireRate / 1000;
            Vector3 myPos = new Vector3(weaponMuzzle.position.x, weaponMuzzle.position.y, weaponMuzzle.position.z);
            GameObject projectile = Instantiate(bullet, myPos, Quaternion.identity);
            Vector3 direction = (Vector3)target.position - myPos;
            projectile.GetComponent<Rigidbody>().velocity = direction * shootingPower;
        }
    }
}
