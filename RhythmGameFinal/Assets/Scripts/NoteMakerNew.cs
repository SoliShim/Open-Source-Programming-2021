using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteMakerNew : MonoBehaviour
{
    public GameObject Note1, Note2, Note3, Note4;
    public float frequency=1f; // 빈도 수 

    private int hasStarted;
    private float cnt;//현재시간

    //노래 편집********************************************************************
    //                                         10                     20                      30                      40                    50                       60                    
    private int[] noteAry1 ={ 0,1,0,0,0,0,0,0,0,0   ,1,0,0,0,0,0,0,0,0,0    ,0,0,0,1,0,0,0,0,0,0    ,1,0,0,0,0,0,1,1,1,1   ,1,1,1,1,1,1,1,1,1,1    ,1,1,1,1,1,1,1,1,1,1
    };                                                                                                                                                                 
    private int[] noteAry2 ={ 0,0,0,1,0,0,0,0,0,0   ,0,0,0,0,1,1,0,0,0,0    ,0,1,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0
                                                                                                                                                                       
    };                                                                                                                                                                 
    private int[] noteAry3 ={ 0,0,0,0,0,0,1,0,0,0   ,1,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,1,0,0    ,0,0,0,1,1,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0
    };                                                                                                                                                                 
    private int[] noteAry4 ={ 0,0,0,0,0,0,0,0,1,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,1,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0
    };

    //1,1,1,1,1,1,1,1,1,1   ,1,1,1,1,1,1,1,1,1,1    ,1,1,1,1,1,1,1,1,1,1    ,1,1,1,1,1,1,1,1,1,1   ,1,1,1,1,1,1,1,1,1,1    ,1,1,1,1,1,1,1,1,1,1


    //*****************************************************************************

    void Start()
    {
        cnt = 0;
        hasStarted = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.anyKeyDown) 
        {
            hasStarted++;
        }
        if (hasStarted == 1)
        {
            StartCoroutine(NoteMaker());
            hasStarted++;
        }
            

    }
    private IEnumerator NoteMaker()
    {
        while (true)
        {
            yield return new WaitForSeconds(frequency); //몇 초 기다리기

            if (noteAry1[Convert.ToInt32(cnt)] == 1)
                Instantiate(Note1, Note1.transform.position, Note1.transform.rotation);
            if (noteAry2[Convert.ToInt32(cnt)] == 1)
                Instantiate(Note2, Note2.transform.position, Note2.transform.rotation);
            if (noteAry3[Convert.ToInt32(cnt)] == 1)
                Instantiate(Note3, Note3.transform.position, Note3.transform.rotation);
            if (noteAry4[Convert.ToInt32(cnt)] == 1)
                Instantiate(Note4, Note4.transform.position, Note4.transform.rotation);

            cnt++;
        }
    }
}
