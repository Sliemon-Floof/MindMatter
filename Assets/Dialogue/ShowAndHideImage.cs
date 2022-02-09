using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAndHideImage : MonoBehaviour
{
    private Image box;

    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
       box.enabled = gameObject.GetComponentInParent<DialogueManager>().boxIsVisible;
    }
}
