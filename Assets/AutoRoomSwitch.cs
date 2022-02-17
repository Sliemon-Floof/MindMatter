using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Av Simon Löwenhielm
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

    //Gets the current scene so that it can be un loaded
    {
        currentScene = gameObject.scene.name;
    }


    // Update is called once per frame

    //If the player enters the trigger: unloades the current scene, switches to the chosen scene, moves the player to the assigned position
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene(sceneToSwitchTo, LoadSceneMode.Additive);
            goblin = GameObject.Find("green_hair_girl_spritesheet_0");
            goblin.transform.position = playerPos;
        }
    }
}