using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjectLong : MonoBehaviour
{

    public bool canBePressed;
    public KeyCode KeyToPress; //키 선택
    //public Collider col1, col2;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyToPress)&& canBePressed==true) //꾹 누르고 있기! GetKey
        {

            //GameManager.instance.LongHit();

            if (gameObject.transform.localScale.y > 0.1f) //y축 길이가 양수일 때(음수이면 반대로까지 이미지가 나옴)
                gameObject.transform.localScale += new Vector3(0, -0.6f * Time.deltaTime, 0f);
            else
                gameObject.SetActive(false); ;
            //}
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }



}
