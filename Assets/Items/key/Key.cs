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
    [SerializeField]
    private SpriteRenderer indicator;
    private SavedBools bools;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();

        // Hides the key if it has been picked up
        if (GameObject.Find("Bools").GetComponent<SavedBools>().hasLibraryKey)
        {
            sprite.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(activateKey) && isInBox)
        {
            print("yaas");
            sprite.enabled = false;
            indicator.enabled = false;
            GameObject.Find("Bools").GetComponent<SavedBools>().hasLibraryKey = true;
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

