using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//점수 계산



public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    
    //게임실행중?
    public bool startPlaying;
    
    //인스턴스 변수
    public static GameManager instance;

    //점수
    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;
    public int scorePerPerfectNote = 150;

    //멀티플라이어
    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThersholds;

    public float totalNotes;
    public float badHits;
    public float goodHits;
    public float perfectHits;
    public float missedHits;

    //점수표시, 멀티표시
    public Text scoreText;
    public Text multiText;

    public GameObject resultsScreen;
    public Text badsText, goodsText, perfectsText, missesText, rankText, finalScoreText;

    void Start()
    {
        instance = this; // 자기 호출
        scoreText.text = "Score : 0";
        
        currentMultiplier = 1;

        totalNotes = FindObjectsOfType<NoteObject>().Length;
    }


    void Update()
    {
        if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theMusic.Play();
            }
        }
        else
        {
            if(!theMusic.isPlaying && !resultsScreen.activeInHierarchy)
            {
                resultsScreen.SetActive(true);

                badsText.text = "" + badHits;
                goodsText.text = goodHits.ToString();
                perfectsText.text = perfectHits.ToString();
                missesText.text = "" + missedHits;

                string rankVal = "F";
                
                if(perfectHits > 10)
                {
                    rankVal = "D";
                    if(perfectHits>20)
                    {
                        rankVal = "C";
                        if (perfectHits > 30)
                        {
                            rankVal = "B";
                            if (perfectHits > 40)
                            {
                                rankVal = "A";
                            }
                                
                        }      
                    }
                }

                rankText.text = rankVal;

                finalScoreText.text = currentScore.ToString();    
            }

        }


    }
    public void NoteHit()
    {
        //Debug.Log("Hit On Time");
        
        /*
        multiplierTracker++;
        if(multiplierThersholds[currentMultiplier-1]<=multiplierTracker)
        {
            multiplierTracker = 0;
            currentMultiplier++;
        }
        */

        currentScore += scorePerNote;
        scoreText.text = "Score : " + currentScore;
    }

    public void PerfectHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();
        perfectHits++;
    }

    public void GoodHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();
        goodHits++;
    }

    public void BadHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
        badHits++;
    }

    public void NoteMissed()
    {
        //Debug.Log("Missed Note");

        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Multiplier: x" + currentMultiplier;

        missedHits++;
    }
}
