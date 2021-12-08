using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    
    // De DataTypes die er gebruikt worden zijn de Booleans en de floats dit geeft ook aan welke datatypes er worden gebruikt etc...

    bool isGrounded = true;
    private float speed = 5.0f;
    public GameObject character;
    public Vector3 jump;
    public float jumpForce = 3.0f;
    public int _doubleJump;
    public int countJump = 2;
   // private float vertical;
    //private float horizontal;

    Rigidbody rb;
   
    // De void start geeft aan over de jump variabelen met hoe hoog die kan springen in de y-as en hoe ver dat is.
   // De jump is nog wat houterig moet nog wat aan gedaan worden.
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 3.0f, 0.0f);
    }

    // OnCollisionStay is een Functie die aangeeft met de argument en constructor wat het doet als de character de grond aanraakt geeft ie dat met true aan.
    // Waardoor die weer kan springen het moment dat die springt wordt grounded False;.
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    //Update Functie geeft aan over de input voor de movement en het jumpen van de character. is grounded is een if statement die aangeeft of die op de grond staat.
    // voor het springen zodat die niet oneindig kan springen.
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

           
            if (isGrounded)
            {



                if (Input.GetKey(KeyCode.Space))
                {
                    rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                    isGrounded = false;
                   

                }
            }
          
        }
        Vector3 characterFlip = transform.localScale;
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            characterFlip.z = 1;
            transform.localScale = characterFlip;
           // vertical = Input.GetAxis("Vertical");
           // horizontal = Input.GetAxis("Horizontal");
           //rb.velocity = (transform.forward * vertical) * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            characterFlip.z = -1;
            transform.localScale = characterFlip;

        }
        //Debug.Log(isGrounded);
        //Debug.Log("Do Something");
        Debug.Log(characterFlip);
    }
   


}
