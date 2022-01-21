using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoRoomSwitch : MonoBehaviour
{
    [SerializeField]
    private string sceneToSwitchTo;
    private string currentScene;
    [SerializeField]
    private KeyCode activateKey;
    private GameObject goblin;
    [SerializeField]
    private Vector2 playerPos;
    private float cooldown;

    private bool isInBox;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = gameObject.scene.name;
        goblin = FindObjectOfType<GameObject>(tag == "Player");
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("yaas");
        SceneManager.UnloadSceneAsync(currentScene);
        SceneManager.LoadScene(sceneToSwitchTo, LoadSceneMode.Additive);
        goblin.transform.position = playerPos;

    }

}

/*

            print("yaas");
            SceneManager.LoadScene("TransitionRoom", LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene(sceneToSwitchTo, LoadSceneMode.Additive);
            SceneManager.UnloadSceneAsync("TransitionRoom");
*/
