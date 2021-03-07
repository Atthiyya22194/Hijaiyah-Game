using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour
{
    public static bool isGamePaused = false;
    [SerializeField] GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        isGamePaused = false;
        //Time.timeScale = 1f; // untuk melanjutkan game (platformer = flappu bird, etc.)
    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        isGamePaused = true;
        //Time.timeScale = 0f;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is Exiting");
    }
    
}