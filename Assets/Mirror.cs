using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Av Simon L�wenhielm
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
    //When the player enters the mirror for the first time WITH THE KEY the reflection becomes "creepy"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!GameObject.Find("Bools").GetComponent<SavedBools>().hasSeenMirrorMonster && GameObject.Find("Bools").GetComponent<SavedBools>().hasLibraryKey)
        {
            reflection.GetComponent<ReflectionScript>().isCreepy = true;

           
        }
    }

    
    // When the player leaves the mirror after seing the creepy reflection, the reflection becomes normal and the creepy version can't be seen again.
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
