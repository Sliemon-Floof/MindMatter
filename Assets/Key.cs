using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]
    private KeyCode activateKey;
    private bool isInBox;
    private SpriteRenderer sprite;
    [SerializeField]
    private GameObject DialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(activateKey) && isInBox)
        {
            print("yaas");
            sprite.enabled = false;
            DialogueBox.GetComponent<DialogueTrigger>().StartDialogue();
           
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isInBox = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInBox = false;
    }
}

