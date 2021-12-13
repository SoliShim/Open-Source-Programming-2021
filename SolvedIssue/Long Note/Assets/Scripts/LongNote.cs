using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongNote : MonoBehaviour
{

    float starttime;

    public KeyCode KeyToPress;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyToPress))
        {
            starttime = Time.time;
        }

        if (Input.GetKeyUp(KeyToPress))
        {
            Debug.Log(Time.time - starttime);
            if(Time.time - starttime>2.0)
            {
                gameObject.SetActive(false);
            }
        }

    }
}
