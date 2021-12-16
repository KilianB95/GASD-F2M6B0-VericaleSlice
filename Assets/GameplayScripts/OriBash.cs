using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OriBash : MonoBehaviour
{
    public GameObject player;
    private GameObject arrow;
    public float radius = 1.35f;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0f;
            Collider[] objectsnear = Physics.OverlapSphere(player.transform.position,radius);
            foreach(var objectnear in objectsnear)
            {
                Debug.Log(objectnear.name);
            }
           
            Vector3 mouse = Input.mousePosition;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, player.transform.position.y));
            Vector3 forward = mouseWorld - player.transform.position;
           
            //player.transform.rotation = Quaternion.LookRotation(forward, Vector3.up);



        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Time.timeScale = 1.0f;
            Vector3 mouse = Input.mousePosition;
            Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(mouse.x, mouse.y, player.transform.position.y));
            Vector3 forward = mouseWorld - player.transform.position;
            
        }

       
    }

}