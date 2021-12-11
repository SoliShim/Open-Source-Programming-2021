using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;


    public KeyCode KeyToPress;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyToPress))
        {
            theSR.sprite = pressedImage;
        }
        if (Input.GetKeyUp(KeyToPress))
        {
            theSR.sprite = defaultImage;
        }

    }
}
