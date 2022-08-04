using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene(2);
        WaveSpawner.oleada = 1;
    }


    public void Menu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        Debug.Log("Menu");
    }

}
