using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public static bool newGame;
    public GameObject Win;
    public GameObject lose;
    public GameObject[] Dao;
    Timer timee = new Timer();
    float time;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        newGame = false;
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(newGame==true)
        { Time.timeScale = 1; }
        if(Timer.stopTimer==true)
        {
            Time.timeScale = 0;
            if (ScoreManager.total_score>=3000)
            {

                Win.SetActive(true);
                //if(time==2f)
          
                Dao[0].SetActive(true);
                if(ScoreManager.total_score>=3000)
                {
                    Dao[1].SetActive(true);
                    if (SceneManager.GetActiveScene().name=="Onelevel")
                    {
                        MapUnlock.Stage1 = true;
                    }
                    else if (SceneManager.GetActiveScene().name == "Level_2")
                    {
                        MapUnlock.Stage2 = true;
                    }
                    else if (SceneManager.GetActiveScene().name == "Level_3")
                    {
                        MapUnlock.Stage3 = true;
                    }
                    else if (SceneManager.GetActiveScene().name == "Level_4")
                    {
                        MapUnlock.Stage4 = true;
                    }

                }
               
                if(ScoreManager.total_score>=4000)
                Dao[2].SetActive(true);

            }
            else if (ScoreManager.total_score < 3000)
            { lose.SetActive(true); }
        }
    }

    private void FixedUpdate()
    {
        if (Timer.stopTimer == true)
            time = Time.time - timee.gameTime;
    }

}
