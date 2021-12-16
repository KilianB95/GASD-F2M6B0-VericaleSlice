using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    
    // De DataTypes die er gebruikt worden zijn de Booleans en de floats dit geeft ook aan welke datatypes er worden gebruikt etc...
    private float speed = 5.0f;
    public GameObject character;
    public Vector3 jump;
    public float jumpForce = 3.0f;
    public float doubleJumpCount = 0;
    private bool jumpp;
    private Animator anim;

    Rigidbody rb;
   
    // De void start geeft aan over de jump variabelen met hoe hoog die kan springen in de y-as en hoe ver dat is.
   // De jump is nog wat houterig moet nog wat aan gedaan worden.
    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
        
    }

    // OnCollisionStay is een Functie die aangeeft met de argument en constructor wat het doet als de character de grond aanraakt geeft ie dat met true aan.
    // Waardoor die weer kan springen het moment dat die springt wordt grounded False;.
    private void OnCollisionEnter(Collision other)
    {
        doubleJumpCount = 0;
    }

    private void FixedUpdate()
    {
        if (jumpp)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }
    }

    // Hier zit de input van het jumpen tot de movement
    // Movement wordt gedaan doormiddel van AddForce wat vloeiender aanvoelt en waardoor je werkt met physics van unity engine zelf.
    public void Update()
    {
       
        jumpp = Input.GetKeyDown(KeyCode.Space);

        if (jumpp)
        {
            doubleJumpCount++;

            if (doubleJumpCount > 2)
            {
                jumpp = false;
            }
        }

        Vector3 characterFlip = transform.localScale;
        if (Input.GetKey(KeyCode.D))
        {
            
            rb.AddForce (Vector3.right, ForceMode.Impulse);
            transform.eulerAngles = new Vector3(0, -90, 0);
            anim.SetFloat("speed", 1);
           
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce (Vector3.left, ForceMode.Impulse);
            transform.eulerAngles = new Vector3(0, 90, 0);
            anim.SetFloat("speed", 1);
           
        }
        if (anim)
        {

        }
    }
    
   


}
