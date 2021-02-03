using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject m;
    public GameObject m2;
    
    public GameObject B2;
    public GameObject B3;
    public GameObject B4;
    public GameObject B5;

    private void Awake()
    {
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (MapUnlock.Stage1 == true)
            B2.SetActive(true);
        else if (MapUnlock.Stage2 == true)
            B3.SetActive(true);
        else if (MapUnlock.Stage3 == true)
            B4.SetActive(true);
        else if (MapUnlock.Stage4 == true)
            B5.SetActive(true);
    }
    public void Onpause()
    {
        Time.timeScale = 0;
        m.SetActive(false);
        m2.SetActive(true);
    }

    public void OnResume()
    {
        Time.timeScale = 1;
        m.SetActive(true);
        m2.SetActive(false);
    }

    public void LoadLevel1()
    {
        GameManager.newGame = true;
        FollowBullet.shooting = false;
        Timer.stopTimer = false;
        ScoreManager.total_score = 0;
        SceneManager.LoadScene(6);
        //Application.LoadLevel("Onelevel");
    }
    public void LoadMap()
    {
        SceneManager.LoadScene(3);

    }
    public void LoadLevel2()
    {
        GameManager.newGame = true;
        FollowBullet.shooting = false;
        Timer.stopTimer = false;
        ScoreManager.total_score = 0;
        SceneManager.LoadScene(8);
        //Application.LoadLevel("level_2");
    }
    public void LoadLevel4()
    {
        GameManager.newGame = true;
        FollowBullet.shooting = false;
        Timer.stopTimer = false;
        ScoreManager.total_score = 0;
        SceneManager.LoadScene(9);
        //Application.LoadLevel("level_2");
    }
}
