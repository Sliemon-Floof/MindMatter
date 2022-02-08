using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//Av Simon Löwenhielm
public class Indicator : MonoBehaviour
{
    private SpriteRenderer sprite;
    private GameObject goblin;
    [SerializeField]
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
       sprite =  gameObject.GetComponent<SpriteRenderer>();
       goblin = GameObject.Find("green_hair_girl_spritesheet_0");
    }

    // Update is called once per frame
    void Update()
    {
     sprite.color = new Color(sprite.color.r,sprite.color.g,sprite.color.b, distance*(goblin.transform.position.x/transform.position.x));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
