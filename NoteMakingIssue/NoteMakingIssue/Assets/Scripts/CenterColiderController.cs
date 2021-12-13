using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterColiderController : MonoBehaviour
{

    public bool isCrashed;
    void Start()
    {
        isCrashed = false;
    }


    void Update()   //Miss ½Ã
    {
        if(isCrashed == true)
        {   
            gameObject.SetActive(false);
            GameManager.instance.NoteMissed();
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
