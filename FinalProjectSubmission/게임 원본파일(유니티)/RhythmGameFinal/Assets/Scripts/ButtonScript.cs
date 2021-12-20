using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//버튼 눌렀을 떄 이미지 바뀜


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
