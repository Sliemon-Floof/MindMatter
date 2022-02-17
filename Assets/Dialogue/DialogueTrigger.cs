using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Av Simon Löwenhielm
public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    //Starts the Dialogue when called and sends all of the information bellow
    public void StartDialogue()
    {
        FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    }
}

//Recordes the messages and their id
[System.Serializable]
public class Message
{
    public int actorId;
    public string message;
}


//The Id information is stored here, each id has a name and image atached to it
[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}
