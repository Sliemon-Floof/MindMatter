using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Miguel skrev allt code i den här scripten
    public Animator animator;
    
    [SerializeField]
    private KeyCode right; // key for move player right
    [SerializeField]
    private KeyCode left; // key for move player left

    private float speed = 7.5f; //movement speed
    Rigidbody2D rb; //rigidbody

    private float currentScale;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // gets rigidbody
        currentScale = transform.localScale.x;

    }

    // Update is called once per frame
    void Update()
    {

      
        
        {
            if (Input.GetKey(right))
            {
                rb.velocity = new Vector3(speed, 0, 0); // move right speed
                transform.localScale = new Vector3(currentScale, transform.localScale.y, transform.localScale.z);

                
            }
            else if (Input.GetKeyUp(right))
            {
                rb.velocity = new Vector3(0, 0, 0);
            }


            if (Input.GetKey(left))
            {
                rb.velocity = new Vector3(-speed, 0, 0); // move left speed
                transform.localScale = new Vector3(-currentScale, transform.localScale.y, transform.localScale.z);

            }
            else if (Input.GetKeyUp(left))
            {
                rb.velocity = new Vector3(0, 0, 0);
            }
            

        }

    }
}
