using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void LevelGame()
    {
        SceneManager.LoadScene("LevelsMenu");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is Exiting");
    }


    //Membuat fungsi agar dapat berpindah scene dengan nama MainGame
    public void MainGame()
    {
        SceneManager.LoadScene("Level1");
    }
}