using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    [SerializeField]
    private GameObject reflection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!GameObject.Find("Bools").GetComponent<SavedBools>().hasSeenMirrorMonster && GameObject.Find("Bools").GetComponent<SavedBools>().hasLibraryKey)
        {
            reflection.GetComponent<ReflectionScript>().isCreepy = true;

            print("I saw it");
           
        }
    }

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (GameObject.Find("Bools").GetComponent<SavedBools>().hasLibraryKey)
        {
            GameObject.Find("Bools").GetComponent<SavedBools>().hasSeenMirrorMonster = true;
            reflection.GetComponent<ReflectionScript>().isCreepy = false;

            print("It's gone!");
        }
        
    }
}
