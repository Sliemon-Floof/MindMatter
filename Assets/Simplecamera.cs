using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simplecamera : MonoBehaviour
{
    private GameObject goblin;
    // Start is called before the first frame update
    void Start()
    {
        //Finds the player
        goblin = goblin = GameObject.Find("green_hair_girl_spritesheet_0");
    }

    // Update is called once per frame
    void Update()
    {
    //Moves the camera along the x axis depending on it's distance to the player
        gameObject.transform.position -= new Vector3(0.05f*(transform.position.x - goblin.transform.position.x),0,0);
    }
}
