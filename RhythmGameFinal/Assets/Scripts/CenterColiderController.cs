using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//MISS 시 중앙 콜라이더 


public class CenterColiderController : MonoBehaviour
{
    //public GameObject MissEffect;
    public bool isCrashed;
    void Start()
    {
        isCrashed = false;
    }


    void Update()   //Miss 시
    {
        if(isCrashed == true)
        {   
            gameObject.SetActive(false);
            GameManager.instance.NoteMissed();
            //Instantiate(MissEffect, MissEffect.transform.position, MissEffect.transform.rotation);

        }

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Colider")
        {
            isCrashed = true;
            
        }
        
    }

}
