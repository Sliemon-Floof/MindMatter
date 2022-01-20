using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflection : MonoBehaviour
{
    private GameObject goblin;
    [SerializeField]
    private bool isCreepy;
    private SpriteRenderer currentSprite;
    // Start is called before the first frame update
    void Start()
    {
        goblin = FindObjectOfType<GameObject>(tag == "Player");
        currentSprite = gameObject.GetComponent<SpriteRenderer>();
        transform.position = new Vector3(goblin.transform.position.x, goblin.transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCreepy)
        {
            currentSprite.enabled = false;
        }
        else
        {
            currentSprite.enabled = true;
        }
    }
}
