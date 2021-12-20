using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//카메라 움직임 구현


public class CameraController : MonoBehaviour
{

    public float followSpeed = 15;
    Vector3 camPos;

   

    private float hitDistance=0;
    private float zoomDistance = -1.25f;
    

    public CameraController cam;

    void Start()
    {
        camPos = cam.gameObject.transform.position;
        Debug.Log(camPos);
    }


    void Update()
    {


        
        //Vector3 targetPos = camPos + (transform.forward * hitDistance);
        //transform.position = Vector3.Lerp(camPos, targetPos, Time.deltaTime);
        
        if (Input.anyKeyDown)
        {
            //ZoomCam();
            Invoke("moveCam", 2);
        }
    }
    public IEnumerator ZoomCam()
    {
        yield return new WaitForSeconds(0.15f);
        transform.position += new Vector3(-1f * 2f * Time.deltaTime, -1f * 2f * Time.deltaTime, 0f);
        
        //hitDistance = 0;
        
    }
    public void moveCam()
    {
        transform.position += new Vector3(-1f * 50f * Time.deltaTime, -1f * 50f * Time.deltaTime, 0f);
        Debug.Log("MOVED!");
    }
}

