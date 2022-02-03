using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;
    private Image box;

    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessage = 0;
    public static bool isactive = false;
    public bool boxIsVisible;


    [SerializeField]
    private KeyCode nextMessage;
    [SerializeField]
    public KeyCode hide;
    [SerializeField]
    public KeyCode show;

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isactive = true;
        print("started conversation" + messages.Length);
        DisplayMessage();
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;
       // StartCoroutine("TypeText");

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite; 
    }
    IEnumerator TypeText()
    {
        Message messageToDisplay = currentMessages[activeMessage];

        foreach (char c in messageToDisplay.message)
        {
            messageText.text += c;
            yield return new WaitForSeconds(0);
        }
    }

   

    public void NextMessage()
    {
        activeMessage++;
        if(isactive == true && activeMessage < currentMessages.Length)
        {
            DisplayMessage();
            box.enabled = true;

        }
        else
        {
            isactive = false;
            box.enabled = false;

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(nextMessage))
        {
            NextMessage();
        }

        ShowAndHide();

    }

    private void ShowAndHide()
    {

        if (isactive)
        {
            box.enabled = true;
            boxIsVisible = true;
        }
        else
        {
            box.enabled = false;
            boxIsVisible = false;
        }

        
    }
}
