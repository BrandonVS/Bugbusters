using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void Retry()
    {
        SceneManager.LoadScene(0);
        WaveSpawner.oleada = 1;
    }


    public void Menu()
    {
        Debug.Log("Menu");
    }


}
