using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool gameOver;

    public GameObject gameOverUI;
    public GameObject WinUI;

    GameObject[] bugs;

    void Start()
    {
        gameOver = false;
    }

    void Update()
    {
        bugs = GameObject.FindGameObjectsWithTag("Bug");

        if (gameOver == true)
        {
            return;
        }   

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }

        if (WaveSpawner.oleada >= 20)
        {
            if(bugs.Length == 0)
            {
                WinGame();
            }
        }
    }

    void EndGame()
    {
        gameOver = true;

        gameOverUI.SetActive(true);

        Time.timeScale = 0;
    }

    void WinGame()
    {
        gameOver = true;

        WinUI.SetActive(true);
    }
}
