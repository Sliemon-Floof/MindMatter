using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomSwitch : MonoBehaviour
{
    [SerializeField]
    private string sceneToSwitchTo;
    private string currentScene;
    [SerializeField]
    private KeyCode activateKey;
    [SerializeField]
    private GameObject goblin;
    [SerializeField]
    private Vector3 playerPos;
    private float cooldown;

    private bool isInBox;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = gameObject.scene.name;
    }
    private void FixedUpdate()
    {
        cooldown -= 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(activateKey) && isInBox && cooldown < 0)
        {
            print("yaas");
            SceneManager.UnloadSceneAsync(currentScene);
            SceneManager.LoadScene(sceneToSwitchTo, LoadSceneMode.Additive);
            goblin = GameObject.Find("green_hair_girl_spritesheet_0");
            goblin.transform.position = playerPos;
            cooldown = 50;
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
