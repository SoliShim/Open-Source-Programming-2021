using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterColliderLongController : MonoBehaviour
{
    public GameObject MissEffect;
    public bool isCrashed;

    void Start()
    {
        isCrashed = false;
    }


    void Update()   //Miss 시
    {
        if (isCrashed == true)
        {
            gameObject.SetActive(false);
        }

    }

    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ColliderLong")
        {
            //gameObject.transform.localScale += new Vector3(0, -0.5f * Time.deltaTime, 0f);
        }

    }
    */

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag=="ColliderLong")
        {
            //길이 줄어드는 애니매이션
            if(gameObject.transform.localScale.y > 0.1f) //y축 길이가 양수일 때(음수이면 반대로까지 이미지가 나옴)
                gameObject.transform.localScale += new Vector3(0, -0.6f *Time.deltaTime, 0f);
            else
                isCrashed = true; //비활성화 시켜버림
            //Debug.Log(gameObject.transform.localScale.y);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ColliderLong")
        {
            isCrashed = true;
            //isCrashed = false;
            GameManager.instance.NoteMissed();
            Instantiate(MissEffect, MissEffect.transform.position, MissEffect.transform.rotation);
        }
    }
}
