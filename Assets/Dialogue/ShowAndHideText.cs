using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAndHideText : MonoBehaviour
{
    private Text box;

    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        box.enabled = gameObject.GetComponentInParent<DialogueManager>().boxIsVisible;

    }
}
