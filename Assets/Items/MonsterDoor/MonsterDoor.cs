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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!GameObject.Find("Bools").GetComponent<SavedBools>().monsterHasClosedDoor)
        {
            animator.SetTrigger("Closing");
            print("jag glum");
            GameObject.Find("Bools").GetComponent<SavedBools>().monsterHasClosedDoor = true;
        }


    }
}
