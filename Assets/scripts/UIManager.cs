using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject nextLevelPanel;

    public static bool gameOver;
    public static bool nextScene;

    private static UIManager instance;

    public void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    void Start()
    {
        nextScene = false;
        gameOverPanel.SetActive(false);
        nextLevelPanel.SetActive(false);
        gameOver = false;
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        gameOverPanel.SetActive(false);
    }

    public void NextLevel()
    {
        LoadNextScene();
    }

    private void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        if (nextScene)
        {
            nextLevelPanel.SetActive(true);
        }
    }

}