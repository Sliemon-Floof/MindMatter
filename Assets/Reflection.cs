using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private GameObject goblin;
    [SerializeField]
    private bool isCreepy;
    private SpriteRenderer currentSprite;
    [SerializeField]
    private SpriteRenderer creepySprite;
    // Start is called before the first frame update
    void Start()
    {
        goblin = GameObject.Find("green_hair_girl_spritesheet_0");
        currentSprite = gameObject.GetComponent<SpriteRenderer>();
        transform.position = new Vector3(goblin.transform.position.x,goblin.transform.position.y,2.1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -10)
        {
            isCreepy = true;
        }
        if (isCreepy)
        {
            currentSprite.enabled = false;
            creepySprite.enabled = true;
        }
        else
        {
            currentSprite.enabled = true;
            creepySprite.enabled = false;
        }
    }
}
