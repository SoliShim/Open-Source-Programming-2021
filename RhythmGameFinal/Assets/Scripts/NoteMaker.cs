using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using System.Diagnostics; //스타워치에 사용


public class NoteMaker : MonoBehaviour
{
    public GameObject[] note1;  //노트1 의 여러 오브젝트들 연결(유니티 인스펙터에서)
    public GameObject[] note2;  //노트1 의 여러 오브젝트들 연결(유니티 인스펙터에서)
    public GameObject[] note3;  //노트1 의 여러 오브젝트들 연결(유니티 인스펙터에서)
    public GameObject[] note4;  //노트1 의 여러 오브젝트들 연결(유니티 인스펙터에서)



    //노래 편집********************************************************************
    //인티저 값으로 활성 비활성 값 넣기
    private int[] noteAry1 ={ 1,1,1,1,1,1,1,1
    };          
    private int[] noteAry2 ={ 1,1,1,1,1,1,1,1

    };          
    private int[] noteAry3 ={ 1,1,1,1,1,1,1,1
    };          
    private int[] noteAry4 ={ 1,1,1,1,1,1,1,1
    };

    //***************************************************************************


    public int noteLenght;//노트 개수-인스펙터에서 수동으로 입력

    private int tmp1;//임시저장
    private int tmp2;
    private int tmp3;
    private int tmp4;
    
    //public bool[] used;




    void Start()
    {


        //noteLenght = 0;

        // 1사분면
        for (int i = 0; i < noteLenght; i++)
        {
            tmp1 = noteAry1[i];
            note1[i].SetActive(Convert.ToBoolean(tmp1));
        }

        // 2사분면
        for (int i = 0; i < noteLenght; i++)
        {
            tmp2 = noteAry2[i];
            note2[i].SetActive(Convert.ToBoolean(tmp2));
        }
        
        
        // 3사분면
        for (int i = 0; i < noteLenght; i++)
        {
            tmp3 = noteAry3[i];
            note3[i].SetActive(Convert.ToBoolean(tmp3));
        }
        
        // 4사분면
        for (int i = 0; i < noteLenght; i++)
        {
            tmp4 = noteAry4[i];
            note4[i].SetActive(Convert.ToBoolean(tmp4));
        }
        
        
    }

    void Update()
    {
        
        
        
    }
    
    
}
