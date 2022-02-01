using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoRoomSwitch : MonoBehaviour
{
    [SerializeField]
    private string sceneToSwitchTo;
    private string currentScene;
    private GameObject goblin;
    [SerializeField]
    private Vector3 playerPos;

    private bool isInBox;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = gameObject.scene.name;
    }


    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.UnloadSceneAsync(currentScene);
        SceneManager.LoadScene(sceneToSwitchTo, LoadSceneMode.Additive);
        goblin = GameObject.Find("green_hair_girl_spritesheet_0");
        goblin.transform.position = playerPos;

    }

    /*

                print("yaas");
                SceneManager.LoadScene("TransitionRoom", LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync(currentScene);
                SceneManager.LoadScene(sceneToSwitchTo, LoadSceneMode.Additive);
                SceneManager.UnloadSceneAsync("TransitionRoom");
    */
}