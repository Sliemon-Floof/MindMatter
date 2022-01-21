using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpKey : MonoBehaviour
{
    
    [SerializeField]
    private KeyCode activateKey;
    [SerializeField]
    private GameObject reflection;

    private bool isInBox;
    // Start is called before the first frame update
    void Start()
    {
        reflection = GameObject.Find("refection");
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(activateKey) && isInBox)
        {
            reflection.GetComponent<SpriteRenderer>().enabled = false;
            reflection.GetComponentInChildren<SpriteRenderer>().enabled = true;
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

/*

            print("yaas");
            SceneManager.LoadScene("TransitionRoom", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene(sceneToSwitchTo, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("TransitionRoom");
*/
