using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {       // grab refrences for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontalinput = (Input.GetAxis("Horizontal"));
        //body.velocity = new Vector2(Horizontalinput * speed, body.velocity.y);

       // if (Horizontalinput > 0.01f)
          //  transform.localScale - new Vector3.(1, 1, 1);
      // else if (Horizontalinput < -0.01f)
         //  Transform.localScale - new Vector3,(-1, 1, 1);

        //set animator parameters
        anim.SetBool("walk", Horizontalinput != 0);
    }
}
