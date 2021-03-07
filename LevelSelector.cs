using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public string nextLevel;
    
    // Start is called before the first frame update
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
