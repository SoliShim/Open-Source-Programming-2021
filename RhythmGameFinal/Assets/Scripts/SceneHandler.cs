using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public Image Panel;
    float time = 0f;
    float F_time = 1f;
    
    public void Fade()
    {
        StartCoroutine(FadeFlow());

    }

    IEnumerator FadeFlow()
    {
        Panel.gameObject.SetActive(true);
        time = 0f;
        Color alpha = Panel.color;
        while (alpha.a < 1f) //ÆäÀÌµå¾Æ¿ô
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }
        time = 0f;
        SceneManager.LoadScene("Game");

        yield return null;
    }
}
