using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class winScript : MonoBehaviour
{
    [SerializeField] Text scoreText;
    //[SerializeField] int scoreCount;

    void Awake()
    {
        scoreText = GetComponent<Text>();
        //scoreText.text = scoreCount.ToString();
    }

    public void Lanjutkan()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    internal void setActive(bool v)
    {
        throw new NotImplementedException();
    }
}