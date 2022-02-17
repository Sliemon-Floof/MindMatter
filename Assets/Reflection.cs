using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectionScript : MonoBehaviour
{
    private GameObject goblin;
    public bool isCreepy;
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
    //Hides and shows the normal and monster sprite.
    {
        
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
