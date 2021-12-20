using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteMakerNew : MonoBehaviour
{
    public GameObject Note1, Note2, Note3, Note4, LongNote1, LongNote2, LongNote3, LongNote4;
    public GameObject DisalbeImg;
    public float frequency=1f; // 빈도 수 

    private int hasStarted;
    private float cnt;//현재시간

    //노래 편집********************************************************************
    //                                         10                     20                      30                      40                    50                       60                    


    //                                         10                     20                      30                      40                    50                       60                       70                      80                        90                   100                      110                     120                    

    /*
    private int[] noteAry1 ={ 1,0,0,0,0,0,0,0,0,0   ,0,1,0,0,0,0,0,0,0,1    ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,1,0,0,0    ,0,0,0,0,1,0,0,1,1,0     ,1,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,1,0,0,1     ,0,0,1,0,0,0,0,0,0,0   ,1,0,0,1,1,0,0,0,0,1     ,0,0,0,0,0,0,0,0,1,1    ,1,0,0,0,0,0,0,0,0,1   ,0,0
    };
    private int[] noteAry2 ={ 1,0,0,0,0,0,0,0,0,0   ,0,0,1,0,0,0,0,0,0,1    ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,1,0,0,0,1,0,0,0,0,0    ,0,1,0,0,0,0,0,1,1,0     ,0,0,0,0,0,1,0,0,0,1    ,0,0,0,0,1,0,0,0,0,1     ,0,1,0,0,0,1,1,1,0,0   ,0,0,0,1,1,0,1,0,0,1     ,0,0,0,0,0,0,1,0,0,0    ,0,1,0,1,0,0,0,1,0,1   ,0,0

    };
    private int[] noteAry3 ={ 0,0,0,0,0,0,0,0,0,0   ,0,1,0,0,1,1,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,1,1,0,0,0,1,1,0    ,1,0,0,0,0,1,0,0,0,0     ,0,0,1,1,0,0,0,1,1,0    ,0,1,1,0,0,1,0,0,0,1     ,0,0,0,1,0,0,0,0,1,1   ,0,0,0,0,0,0,0,1,0,0     ,0,0,0,1,1,1,0,0,0,0    ,0,0,0,0,0,1,0,0,0,1   ,0,0
    };
    private int[] noteAry4 ={ 0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,1,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,1,1,0,0,0,1,1,0    ,0,0,1,1,0,0,0,0,0,0     ,0,0,1,1,0,0,0,1,1,0    ,0,1,1,0,0,0,0,0,0,1     ,0,0,0,1,0,0,0,0,0,0   ,0,1,0,0,0,0,0,0,0,0     ,0,1,0,0,0,0,0,1,0,0    ,0,0,0,0,0,0,0,0,0,1   ,0,0
    };
    */
                                                                                                               //is this    not                     I'm know i'm                                                               not alone!//
    private int[] noteAry1 ={ 0,1,0,0,0,0,0,0,0,0   ,0,0,0,0,1,0,0,0,0,0    ,0,0,0,0,0,1,0,0,0,0    ,1,0,0,0,0,0,0,0,0,0   ,0,0,0,1,0,4,0,0,0,1    ,1,0,0,0,1,0,0,1,1,0         ,1,0,0,0,0,0,0,1,1,0    ,1,0,0,0,0,0,1,0,0,0     ,0,0,1,0,0,0,1,0,1,1   ,1,0,0,0,0,0,0,0,0,1     ,1,0,0,1,1,0,0,0,1,1    ,1,0,0,0,0,0,0,0,0,0  ,1,0,0,0,0,0,0,0,0,0
    };
    private int[] noteAry2 ={ 0,0,0,1,0,0,0,0,0,0   ,1,0,0,0,1,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0    ,1,0,0,1,1,0,0,0,1,0   ,0,0,0,0,1,0,1,0,0,1    ,1,0,0,1,0,1,0,1,1,0         ,0,1,1,0,0,1,0,0,0,1    ,0,1,1,0,1,0,0,0,0,0     ,0,0,1,0,1,0,0,0,0,0   ,0,0,1,1,0,0,1,0,0,1     ,1,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0  ,1,0,0,0,0,0,0,0,0,0

    };
    private int[] noteAry3 ={ 0,0,0,0,0,1,0,0,0,0   ,1,0,0,0,0,1,0,0,0,0    ,0,0,0,0,0,0,0,1,0,0    ,1,0,0,0,0,0,0,1,0,0   ,0,1,1,0,0,0,0,1,1,0    ,0,1,1,0,0,1,0,1,1,0         ,0,0,0,0,0,0,0,1,1,0    ,0,0,0,0,0,1,0,0,0,0     ,0,0,1,0,0,1,0,0,1,1   ,0,0,0,0,0,0,0,1,0,0     ,0,0,0,1,1,0,0,0,0,0    ,1,0,0,0,0,0,0,0,0,0   ,1,0,0,0,0,0,0,0,0,0
    };
    private int[] noteAry4 ={ 0,0,0,0,0,0,0,1,0,0   ,0,0,0,0,0,1,0,0,0,0    ,1,0,0,0,0,0,0,0,0,0    ,1,0,0,1,1,0,0,0,0,0   ,0,1,1,0,0,0,0,1,1,0    ,0,0,0,0,0,0,0,1,1,0         ,0,1,1,0,0,0,0,0,0,0    ,0,1,1,0,0,0,0,0,0,0     ,0,0,1,0,0,0,0,0,0,0   ,0,0,1,1,0,0,0,0,1,0     ,0,0,1,0,0,0,0,0,0,1    ,0,1,0,0,0,0,0,0,0,0   ,1,0,0,0,0,0,0,0,0,0
    };

    private int[] longNoteAry1 ={0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,1,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0      ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0
    };
    private int[] longNoteAry2 ={0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,1,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0      ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0
    };
    
    private int[] longNoteAry3 ={0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0      ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0
    };
    private int[] longNoteAry4 ={0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0      ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0     ,0,0,0,0,0,0,0,0,0    ,0,0,0,0,0,0,0,0,0,0   ,0,0,0,0,0,0,0,0,0,0    ,0,0,1,0,0,0,0,0,0,0
    };
  



    /*
    private int[] noteAry1 ={ 0,0,0,1,0,0,0,0,0,0,0,0   ,0,0,0,1,0,0,1,0,0,1    ,0,0,1,0,0,1,0,0,0,0    ,1,0,0,0,0,0,1,0,0,1   ,0,1,0,1,0,0,0,1,0,0    ,0,0,1,0,1,0,0,1,0,1     ,0,0,1,0,1,0,0,1,1,0    ,0,1,0,0,1,0,0,1,0,0     ,1,1,0,0,0,0,1,0,1,0   ,0,0,1,0,0,0,1,0,0,1     ,1,1,1,1,0,0,0,1,0,1    ,1,0,0,0,1,0,1,0,0,1
    };
    private int[] noteAry2 ={ 0,0,0,0,0,1,0,0,0,0,0,0   ,0,1,0,0,1,0,1,0,0,0    ,0,0,0,0,0,1,0,0,1,0    ,0,0,1,0,1,0,0,0,0,0   ,1,0,0,1,1,0,0,1,0,1    ,0,1,1,1,0,0,1,0,0,1     ,0,1,1,0,1,0,0,1,0,1    ,1,1,0,1,1,1,0,0,0,1     ,1,0,0,0,1,0,0,1,0,1   ,0,1,0,1,0,1,1,1,0,0     ,1,0,1,0,1,0,0,0,1,0    ,0,1,1,0,0,1,1,0,0,1

    };
    private int[] noteAry3 ={ 0,0,0,0,0,0,0,1,1,0,0,0   ,0,1,0,0,0,0,1,0,1,1    ,0,0,0,1,0,1,0,0,0,0    ,0,0,1,0,0,0,0,1,0,1   ,1,0,0,0,0,0,1,1,0,0    ,1,0,1,0,0,1,1,0,0,0     ,0,1,1,0,0,1,1,0,1,0    ,0,0,1,0,1,1,0,1,1,1     ,1,0,1,1,1,0,0,0,1,0   ,1,0,0,0,1,0,0,0,0,1     ,0,0,0,1,1,1,1,0,1,1    ,0,1,0,1,0,1,0,1,0,1
    };
    private int[] noteAry4 ={ 0,0,0,0,0,0,0,0,0,1,1,1   ,0,0,0,0,0,0,1,0,0,0    ,0,1,0,0,0,0,1,0,1,0    ,0,1,1,1,0,0,1,0,1,0   ,0,0,1,0,0,1,0,1,0,1    ,0,1,0,0,1,0,1,1,1,1     ,0,0,0,1,0,0,1,1,0,0    ,0,0,1,0,1,0,1,0,0,0     ,1,0,0,1,0,1,0,0,0,1   ,0,0,1,1,0,0,1,1,0,0     ,0,1,0,0,1,0,0,1,0,1    ,1,0,1,0,0,0,0,1,0,1
    };
    */
    // 
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

            if (longNoteAry1[Convert.ToInt32(cnt)] == 1)
                Instantiate(LongNote1, LongNote1.transform.position, LongNote1.transform.rotation);

            if (longNoteAry2[Convert.ToInt32(cnt)] == 1)
                Instantiate(LongNote1, LongNote2.transform.position, LongNote2.transform.rotation);

            if (longNoteAry3[Convert.ToInt32(cnt)] == 1)
                Instantiate(LongNote3, LongNote3.transform.position, LongNote3.transform.rotation);

            if (longNoteAry4[Convert.ToInt32(cnt)] == 1)
                Instantiate(LongNote4, LongNote4.transform.position, LongNote4.transform.rotation);

            /*
            if (longNoteAry3[Convert.ToInt32(cnt)] == 1)
                Instantiate(LongNote3, LongNote3.transform.position, LongNote3.transform.rotation);
            if (longNoteAry4[Convert.ToInt32(cnt)] == 1)
                Instantiate(LongNote4, LongNote4.transform.position, LongNote4.transform.rotation);
            */

            cnt++;
            
            Debug.Log(cnt);

            if (cnt == 125) // 키보드 가이드 이미지 숨기기
            {
                DisalbeImg.SetActive(false);
            }
            if (cnt == 129)
            {   
                Debug.Log("BREAK!");
                break;
            }


        }
    }
}
