using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    // Miguel skrev allt code i den här scripten
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
       
        anim.SetBool("walk", Horizontalinput != 0);// set animator parameters
    }
}
