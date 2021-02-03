using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartScene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void BackGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //public void GoLevel()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    //}

    public void GoLevel1()
    {
        SceneManager.LoadScene(6,LoadSceneMode.Additive);
    }
    public void GoAnima1()
    {
        SceneManager.LoadScene(4);
    }
    public void Anima()
    {
        SceneManager.LoadScene(2);
    }
    public void Anima2()
    {
        SceneManager.LoadScene(7);
    }
}
