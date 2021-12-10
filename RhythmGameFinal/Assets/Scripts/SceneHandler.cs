using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{

    public void SceneChange()
    {
        
        SceneManager.LoadScene("Game");
    }

}
