using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDoor : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
   
    //Starts the animation Imediatly if the monster has been seen. -Simon
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();

        if (GameObject.Find("Bools").GetComponent<SavedBools>().monsterHasClosedDoor)
        {
            animator.SetTrigger("Closing");
        }
    }

   

    //Om den tagagar med player de kommer animations trigger starta -Deni
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            animator.SetTrigger("Closing");
            GameObject.Find("Bools").GetComponent<SavedBools>().monsterHasClosedDoor = true;


        }


    }
}
