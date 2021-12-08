using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System.Diagnostics; //스타워치에 사용


public class NoteMaker : MonoBehaviour
{
    public GameObject[] note1;  //노트1 의 여러 오브젝트들 연결
    //public bool[] ary={ true, false, true, false, true  
    // };          //불린 값으로 활성 비활성 값 넣기
    //public bool[] used;

    void Start()
    {
        note1[1].SetActive(true);
        note1[2].SetActive(true);
        note1[3].SetActive(true);
        note1[4].SetActive(true);
    }

    void Update()
    {
        
        
        
    }
    public int Done()
    {
        return 0;
    }

    
}
