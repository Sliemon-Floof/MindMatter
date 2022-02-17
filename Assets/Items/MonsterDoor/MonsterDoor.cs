using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDoor : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        if (GameObject.Find("Bools").GetComponent<SavedBools>().monsterHasClosedDoor)
        {
            animator.SetTrigger("Closing");
            print("jag glum");
        }
    }

   

    //Om den tagagar med player de kommer animations trigger starta
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator.SetTrigger("Closing");
            print("jag glum");
            
        }


    }
}
