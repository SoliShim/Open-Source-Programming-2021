using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode KeyToPress;

    //private SpriteRenderer noteRenderer= self;

    void Start()
    {
        //renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            if(canBePressed)  //노트 맞췄을 때 
            {
                GameManager.instance.NoteHit();
                gameObject.SetActive(false);
                //sprite.enabled = false;
                //Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Activator")
        {
            canBePressed = true;

        }
    }
}
