using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode KeyToPress;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            if(canBePressed)  //노트 맞췄을 때 
            {
                GameManager.instance.NoteHit();
                gameObject.SetActive(false);
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
