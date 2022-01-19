using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowAndHideText : MonoBehaviour
{
    private Text box;

    [SerializeField]
    private KeyCode hide = KeyCode.H;
    [SerializeField]
    private KeyCode show = KeyCode.J;

    // Start is called before the first frame update
    void Start()
    {
        box = gameObject.GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        ShowAndHide();
    }

    private void ShowAndHide()
    {

        if (Input.GetKeyDown(hide))
        {
            box.enabled = false;
        }

        if (Input.GetKeyDown(show))
        {
            box.enabled = true;
        }
    }
}
